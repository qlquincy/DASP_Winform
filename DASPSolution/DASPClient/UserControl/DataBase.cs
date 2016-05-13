using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dasp
{
    public class DataBase
    {
       /// <summary>
       /// 图形说明
       /// </summary>
        public string Title
        {
            set;
            get;
        }
       /// <summary>
       /// 横轴单位比例
       /// 
       /// </summary>
        public float xScael
        {
            set;
            get;
        }
        /// <summary>
        /// 纵轴单位比例
        /// </summary>
        public float yScael
        {
            set;
            get;
        }
        /// <summary>
        /// 横轴单位名称
        /// </summary>
        public string xName
        {
            set;
            get;
        }
        /// <summary>
        /// 纵轴单位名称
        /// </summary>
        public string yName
        {
            set;
            get;
        }
        public  DataBase(float x,string xn,float y,string yn)
        {
            xScael = x;
            xName = xn;
            yScael = y;
            yName = yn;
            Title = "波形图";
        }
        public DataBase(float x, string xn, float y, string yn,string title)
        {
            xScael = x;
            xName = xn;
            yScael = y;
            yName = yn;
            Title = title;
        }
        public  DataBase():this(1f,"None",1f,"None","波形图")
        {
        }
    }
}
