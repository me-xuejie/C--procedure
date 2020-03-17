using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class lyrics
    {
        private int minute;//分钟
        private float second;//秒
        private String strLyric;//具体歌词
        private float totsecond;//总秒数

        /// <summary>
        /// 分钟
        /// </summary>
        public int Minute { get { return minute; } set { minute = value; } }
        /// <summary>
        /// 秒钟
        /// </summary>
        public float Second { get { return second; } set { second = value; } }
        /// <summary>
        /// 歌词
        /// </summary>
        public string StrLyric { get { return strLyric; } set { strLyric = value; } }
        /// <summary>
        /// 总时长 秒
        /// </summary>
        public float Totsecond { get { return totsecond; } set { totsecond = value; } }
    }
}
