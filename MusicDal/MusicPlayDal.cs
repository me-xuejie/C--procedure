using Model;
using Shell32;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace MusicDal
{
    public class MusicPlayDal
    {
        //获取连接字符串
        private static string connStr;
        public MusicPlayDal(string conn)
        {
            connStr =" data source="+ conn + ";version=3;";
        }
        /// <summary>
        /// 获取歌曲信息
        /// </summary>
        /// <param name="path">歌曲路径</param>
        /// <returns></returns>
        public MusicInfo GetInfo(string path,string s)
        {
            ShellClass sh = new ShellClass();            
            Folder dir = sh.NameSpace(path);//路径
            FolderItem item = dir.ParseName(s);//文件名称加扩展名

            MusicInfo music = new MusicInfo
            {
                Mname = dir.GetDetailsOf(item, 0).Split('.')[0],
                Msize = dir.GetDetailsOf(item, 1),
                Album = dir.GetDetailsOf(item, 14),
                Author = dir.GetDetailsOf(item, 20),
                Mtime = dir.GetDetailsOf(item, 27),
                //完整路径加扩展名
                Path = Path.Combine(path, s)
            };

            GetMusicBitmap(music);
            return music;
        }

        /// <summary>
        /// 查找歌词
        /// </summary>
        /// <param name="music">音乐信息类</param>
        /// <param name="path">新词路径</param>
        /// <returns></returns>
        public bool GetLyric(MusicInfo music)
        {
            string lrcpath = music.Path.Split('.')[0] + ".lrc";
            bool isok = false;
            if (File.Exists(lrcpath))
            {
                //歌词加载
                music.Lyric = LoadLrc(lrcpath);
                isok = true;
            }
            return isok;
        }

        /// <summary>
        /// 数据删除
        /// </summary>
        /// <param name="music"></param>
        /// <returns></returns>
        public bool Delete(MusicInfo music)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("delete from UserInfo ");
            sb.Append(" where  mid=@mid");
            SQLiteParameter parameter = new SQLiteParameter("@mid", System.Data.DbType.Int32) { Value =( music.Id  )};
            using (SQLiteConnection con = new SQLiteConnection(connStr))
            {
                SQLiteCommand cmd = new SQLiteCommand(sb.ToString(), con);
                cmd.Parameters.Add(parameter);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Remove(MusicInfo music)
        {
            try
            {
                //文件删除成功
                File.Delete(music.Path);
                //移除数据库中的数据
                Delete(music);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public string OPenDirectory(string path)
        {
            return Path.GetDirectoryName(path);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="music"></param>
        /// <returns></returns>
        public bool Update(MusicInfo music)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("update UserInfo set ");
            sb.Append(" set mpath=@mpath ");
            sb.Append(" mname=@mname ");
            sb.Append(" where mid=@mid ");
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@mpath",System.Data.DbType.String,128),
                new SQLiteParameter("@mname",System.Data.DbType.Int32),
            };
            parameters[0].Value = music.Path;
            parameters[1].Value = music.Mname;

            using (SQLiteConnection con = new SQLiteConnection(connStr))
            {
                SQLiteCommand cmd = new SQLiteCommand(sb.ToString(), con);
                cmd.Parameters.AddRange(parameters);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// 向数据库中写入
        /// </summary>
        /// <param name="music"></param>
        /// <returns></returns>
        public bool Insert(MusicInfo music)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("insert into UserInfo (Mname,Mpath,Mid) values(@Mname,@Mpath,@mid)");
            SQLiteParameter[] parameter = {
                new SQLiteParameter("@Mname",System.Data.DbType.String,32),
                new SQLiteParameter("@Mpath",System.Data.DbType.String,128),
                new SQLiteParameter("@mid",System.Data.SqlDbType.Int),
            };
            parameter[0].Value = music.Mname;
            parameter[1].Value = music.Path;
            parameter[2].Value = music.Id;

            using (SQLiteConnection con=new SQLiteConnection(connStr))
            {
                SQLiteCommand cmd = new SQLiteCommand(sb.ToString(),con);
                cmd.Parameters.AddRange(parameter);
                con.Open();
                return cmd.ExecuteNonQuery()>0;
            }
        }

        /// <summary>
        /// 获取地址
        /// </summary>
        /// <returns></returns>
        public string Select()
        {
            StringBuilder s = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from ");
            sb.Append(" UserInfo ");
            using (SQLiteConnection con = new SQLiteConnection(connStr))
            {
                SQLiteCommand cmd = new SQLiteCommand(sb.ToString(),con);
                con.Open();
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        s.Append(reader.GetString(2));
                        s.Append("[]");
                    }
                }  
            }
            return s.ToString();
        }

        /// <summary>
        /// 加载歌词
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private List<lyrics> LoadLrc(string item)
        {
            StreamReader reader = new StreamReader(item, Encoding.UTF8);
            List<lyrics> lys = new List<lyrics>();
            string read;
            while ((read =reader.ReadLine())!=null)
            {
                if (read=="")
                {
                    continue;
                }
                lyrics ly = new lyrics
                {
                    //[00:00:00] xxxxx
                    Minute = Convert.ToInt32(read.Substring(1, 2)),//从第二个开始
                    Second = Convert.ToSingle(read.Substring(4, 5))//从第四个开始
                };
                ly.Totsecond = (float)(ly.Minute * 60 + ly.Second);

                ly.StrLyric = read.Substring(10);

                lys.Add(ly);
            }
            reader.Close();
            reader.Dispose();
            return lys;
        }

        /// <summary>
        /// 获取封面专辑图片
        /// </summary>
        /// <param name="music"></param>
        /// <returns></returns>
        public bool GetMusicBitmap(MusicInfo music)
        {
            bool isok = false;
            string path =music.Path;// Path.Combine(music.Path,music.Mname)+ ".mp3";
            TagLib.File file = TagLib.File.Create(path);//一个获取音频，视频的类
            if (file.Tag.Pictures.Length > 0)
            {
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                music.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(100, 100, null, IntPtr.Zero);
                music.Bigimage = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(400, 400, null, IntPtr.Zero);
                isok = true;
            }
            else
            {
                //没有图片
            }
            return isok;
        }

        /// <summary>
        /// 判断文件是否存在
        /// </summary>
        /// <param name="infos"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool Myexists(List<MusicInfo> infos, string path)
        {
            bool isok = false;
            foreach (var item in infos)
            {
                if (item.Path.Equals(path))
                {
                    isok = true;
                    break;
                } 
            }
            return isok;
        }
        
        /// <summary>
        /// 返回单个对象
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Model.MusicInfo SingleAdd(string path)
        {
            string p = Path.GetDirectoryName(path);
            string s = Path.GetFileName(path);
            return GetInfo(p, s);
        }
    }
}
