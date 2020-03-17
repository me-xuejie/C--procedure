using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBll
{
    public class MusicInfo
    {        
        private string mname;        
        private string author;
        private string album;        
        private string mtime;        
        private double msize;
        private string lyric;

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
        public double Msize { get { return msize; } set { msize = value; } }
        /// <summary>
        /// 歌词
        /// </summary>
        public string Lyric { get { return lyric; } set { lyric = value; } }
    }
}
