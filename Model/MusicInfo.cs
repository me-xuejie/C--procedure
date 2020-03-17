using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MusicInfo
    {
        private int id;
        private string mname;
        private string author;
        private string album;        
        private string mtime;
        private string msize;
        private List< lyrics> lyric;
        private string path;
        private Image image;
        private Image bigimage;
        /// <summary>
        /// 音乐路径不包名称扩展名
        /// </summary>
        public string Path { get { return path; } set { path = value; } }
        /// <summary>
        /// 音乐标题
        /// </summary>
        public string Mname { get { return mname; } set { mname = value; } }
        /// <summary>
        /// 歌手      
        /// </summary>
        public string Author { get { return author; } set { author = value; } }
        /// <summary>
        /// 专辑
        /// </summary>
        public string Album { get { return album; } set { album = value; } }
        /// <summary>
        ///  时长
        /// </summary>
        public string Mtime { get { return mtime; } set { mtime = value; } }
        /// <summary>
        /// 大小
        /// </summary>
        public string Msize { get { return msize; } set { msize = value; } }
        /// <summary>
        /// 歌词
        /// </summary>
        public List<lyrics> Lyric { get { return lyric; } set { lyric = value; } }
        /// <summary>
        /// 专辑图片
        /// </summary>
        public Image Image { get { return image; } set { image = value; } }
        /// <summary>
        /// 封面图片
        /// </summary>
        public Image Bigimage { get { return bigimage; } set { bigimage = value; } }
        /// <summary>
        /// 音乐索引
        /// </summary>
        public int Id { get { return id; } set { id = value; } }
    }
}
