using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MusicDal;
using Model;
using System.Xml.Linq;

namespace MusicBll
{
    public class BasicPlay
    {
        MusicPlayDal dal;
        public BasicPlay(string name)
        {
            dal = new MusicPlayDal(name);
        }
         
        /// <summary>
        /// 根据传输过来的音乐文件路径获取其中信息
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<MusicInfo> GetMusicInfo(string path,string fite="*.mp3")
        {
            List<MusicInfo> musics = new List<MusicInfo>();
            string[] strfiles = Directory.GetFiles(path,fite);
            //把获取的音乐文件挨个遍历
            foreach (string s in strfiles)
            {
                musics.Add(dal.GetInfo(path, Path.GetFileName(s)));
            }
            //获取音乐文件的信息
           return  musics;
        }

        /// <summary>
        /// 获取歌词
        /// </summary>s
        /// <param name="music"></param>
        /// <returns></returns>
        public bool GetLrc(Model.MusicInfo  music)
        {
            //查找是否有歌词
            return dal.GetLyric(music);
        }

        /// <summary>
        /// 是否有专辑图片
        /// </summary>
        /// <param name="music"></param>
        /// <returns></returns>
        public bool GetMusicBitmap(Model.MusicInfo music)
        {
            return dal.GetMusicBitmap(music);
        }

        /// <summary>
        /// 保存一条新的路径
        /// </summary>
        /// <param name="music"></param>
        /// <returns></returns>
        public bool Add(Model.MusicInfo music)
        {
            return dal.Insert(music);
        }

        public string select()
        {
            return dal.Select();
        }

        /// <summary>
        /// 判断文件是否存在
        /// </summary>
        /// <param name="infos"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool Myexists(List<MusicInfo> infos, string path)
        {
            return dal.Myexists(infos,path);
        }

        /// <summary>
        /// 返回单个对象
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Model.MusicInfo SingleAdd(string path)
        {
            return dal.SingleAdd(path);
        }

        public string OPenDirectory(string path)
        {
            return dal.OPenDirectory(path);
        }

        public bool Delete(Model.MusicInfo music)
        {
            return dal.Delete(music);
        }

        public bool Remove(Model.MusicInfo music)
        {
            return dal.Remove(music);
        }
    }
}
