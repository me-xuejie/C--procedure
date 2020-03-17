using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  enum Playorder
    {
        /// <summary>
        /// 顺序播放
        /// </summary>
        orderplay = 0,

        /// <summary>
        /// 列表循环
        /// </summary>
        listplay = 1,

        /// <summary>
        /// 单曲
        /// </summary>
        singleplay = 2,

        /// <summary>
        /// 随机
        /// </summary>
        randomplay = 3,

    }
}
