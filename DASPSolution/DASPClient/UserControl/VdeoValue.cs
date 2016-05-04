using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dasp
{
    /// <summary>
    /// 记录屏幕上点所代表的值
    /// </summary>
    public class VideoValue
    {
       
        public int xTime
        {
            set;
            get;
        }
        public float yN_Mss
        {
            set;
            get;
        }
        public VideoValue(int _time, float _nmss)
        {
            xTime = _time;
            yN_Mss = _nmss;
        }
    }
}
