using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Dasp
{
    /// <summary>
    /// 单个绘制区域的参数信息
    /// </summary>
    public class ViewPartInfo
    {
        /// <summary>
        /// 绘制附加参数
        /// </summary>
        public DataBase dbase
        {
            set;
            get;
        }
        /// <summary>
        /// 占用区域比例
        /// </summary>
        public int percent
        {
            set;
            get;
        }
        public int Sindex = 0;
        /// <summary>
        /// -1表示全程计算
        /// </summary>
        public int Eindex = -1;

        /// <summary>
        /// 绘制点数
        /// </summary>
        public int DisplayLen()
        {
            int einde = Eindex;
            if (einde == -1) einde = DrawDatalstPara[0].Count;
            return (einde - Sindex);
        }
        /// <summary>
        /// 改变绘制起点
        /// </summary>
        /// <param name="step"></param>
        public void ChangeStartNum(int step)
        {
            if (Sindex + step < DrawDatalstPara[0].Count)
                Sindex = Sindex + step;
            if (Eindex + step < DrawDatalstPara[0].Count)
                Eindex = Eindex + step;
            else
                Eindex = DrawDatalstPara[0].Count;

            CalculateMMValue();
        }
        /// <summary>
        /// 改变绘制起点及绘制点数
        /// </summary>
        /// <param name="step"></param>
        public void ChangeStartNum_Len(int istart,int len)
        {
            if (istart < DrawDatalstPara[0].Count)
                Sindex = istart;
            if (Sindex + len < DrawDatalstPara[0].Count)
                Eindex = Sindex + len;
            else
                Eindex = DrawDatalstPara[0].Count;
        }
        /// <summary>
        /// 设置绘制起点及绘制区域
        /// </summary>
        /// <param name="sInext"></param>
        /// <param name="eIndex"></param>
        public void SetDisPlayRang(int sInext, int eIndex)
        {
            Sindex = sInext;
            Eindex = eIndex;
        }
        /// <summary>
        /// 记录屏幕绘制点处的坐标值
        /// </summary>
        public SortedList<int, VideoValue> videoValue = null;
        /// <summary>
        /// 另外一条曲线的坐标值记录
        /// </summary>
        public SortedList<int, VideoValue> videoValueb = null;
        /// <summary>
        /// 动态标注内容
        /// </summary>
        public string topremark
        {
            set;
            get;
        }
        /// <summary>
        /// 图形正负空间对称
        /// </summary>
        public bool usesym
        {
            set;
            get;
        }
        /// <summary>
        /// 采样频率
        /// </summary>
        public int khz
        {
            set;
            get;
        }
        /// <summary>
        /// X轴值系数，值系数乘点序号的得出横坐标的实际值
        /// </summary>
        public float xValueScale
        {
            set;
            get;
        }
        /// <summary>
        /// Y轴值单位
        /// </summary>
        public string yEU
        {
            set;
            get;
        }
        public ViewPartInfo(int group, int _percent,DataBase Db)
        {
            DrawGroup = group;
            xValueScale = Db.xScael;
            usesym = true;
            videoValue = new SortedList<int, VideoValue>();
            if (group == 2)
            {
                videoValueb = new SortedList<int, VideoValue>();
            }
            percent = _percent;
            dbase = Db;
        }
        public ViewPartInfo(int group,  DataBase Db):this(group,10,Db)
        {
           
        }
       
        public ViewPartInfo(int group, int _percent)
        {
            DrawGroup = group;
            xValueScale = 1f;
            usesym = true;
            videoValue = new SortedList<int, VideoValue>();
            if (group == 2)
            {
                videoValueb = new SortedList<int, VideoValue>();
            }
            percent = _percent;
            dbase = new DataBase();
        }
        public ViewPartInfo()
            : this(1, 10)
        {


        }
        /// <summary>
        /// 数据分配情况
        /// </summary>
        public  DataStyle dataStyle
        {
            set;
            get;
        }
        /// <summary>
        /// 该区域y轴0线在当前绘制区域的高度，相对自己的区域原点的高度值
        /// </summary>
        public int y_zeroHeght
        {
            set;
            get;
        }
        /// <summary>
        /// 绘制区域的最大值
        /// </summary>
        public float maxValue
        {
            set;
            get;
        }
        /// <summary>
        /// 绘制区域的最小值
        /// </summary>
        public float minValue
        {
            set;
            get;
        }
        /// <summary>
        /// 绘制区域的值空间大小
        /// </summary>
        public float rgValue
        {
            set;
            get;
        }
        /// <summary>
        /// 绘制空间的高度
        /// </summary>
        public int dHeight
        {
            set;
            get;
        }
        /// <summary>
        /// 绘制空间的横向（X轴）网格大小,以像素为单位
        /// </summary>
        public int xGridSnap
        {
            set;
            get;
        }
        /// <summary>
        /// 绘制空间的Y向网格大小,以像素为单位
        /// </summary>
        public int yGridSnap
        {
            set;
            get;
        }
        /// <summary>
        /// 单位像素所表示的值
        /// </summary>
        public float y_ValuePerPixel
        {
            set;
            get;
        }
       
        private IList<float>[]  drawDatalst = null;
        /// <summary>
        /// 绘图数据系列
        /// </summary>
        public IList<float>[] DrawDatalstPara
        {
            set
            {
                if (null != value)
                {
                    drawDatalst = value;
                    DrawGroup = drawDatalst.Length;
                    if (DrawGroup == 2)
                    {
                        if (videoValueb == null)
                            videoValueb = new SortedList<int, VideoValue>();
                    }
                    CalculateMMValue();
                }
            }
            get
            {
                return drawDatalst;
            }
        }
        /// <summary>
        /// 绘图数据组数，当有比较操作时，将有DrawGroup = 2
        /// 否则只是绘制第一组数据
        /// </summary>
        public int DrawGroup
        {
            set;
            get;
        }
        /// <summary>
        /// 计算绘制数据的值域
        /// </summary>
        private void CalculateMMValue()
        {
            float _max = float.MinValue;
            float _min = float.MaxValue;
            float _max2 = float.MinValue;
            float _min2 = float.MaxValue;
            CalculatingValue(DrawDatalstPara[0], out _max, out _min);
            if (DrawGroup != 1)
            {
                CalculatingValue(DrawDatalstPara[1], out _max2, out _min2);
                maxValue = Math.Max(_max,_max2);
                minValue = Math.Min(_min, _min2);
            }
            else
            {
                maxValue = _max;
                minValue = _min;
            }
            if (usesym)
            {
                maxValue = Math.Max(maxValue, Math.Abs(minValue));
                minValue = -maxValue;
            }
            dataStyle = DataStyle.nplusp;//认为数据有正有负
            if ((minValue * 100 > 0) || (Math.Abs( minValue) <  0.000001f))
            {
                dataStyle = DataStyle.onlypos;  //只有正数
            }
            if ((maxValue  < 0) || (Math.Abs(maxValue) < 0.000001f))
            {
                dataStyle = DataStyle.onlyneg;  //只有负数
            }
        }
        /// <summary>
        /// 计算一个列表的的最大值及最小值
        /// </summary>
        /// <param name="vlst"></param>
        /// <param name="maxValue"></param>
        /// <param name="minValue"></param>
        /// <returns></returns>
        private bool CalculatingValue(IList<float> vlst, out float axValue, out float inValue)
        {
            if (null != vlst)
                return CalculatingValue(vlst, Sindex, Eindex, out  axValue, out  inValue);
            else
            {
                axValue = 0f;
                inValue = -0f;
                return false;
            }
        }
        /// <summary>
        /// 横轴上单位像素所表示的点数
        /// </summary>
        public float x_unitPoints
        {
            set;
            get;
        }
        /// <summary>
        /// 横轴上单位网格所表示的点数量
        /// </summary>
        public float x_grids
        {
            set;
            get;
        }
        /// <summary>
        /// 计算一个列表区域的最大值和最小值
        /// </summary>
        /// <param name="vlst"></param>
        /// <param name="sIndex"></param>
        /// <param name="eIndex"></param>
        /// <param name="maxValue"></param>
        /// <param name="minValue"></param>
        /// <returns></returns>
        private bool CalculatingValue(IList<float> vlst, int sIndex, int eIndex, out float axValue, out float inValue)
        {
            bool br = false;
            axValue = float.MinValue;
            inValue = float.MaxValue;
            if (eIndex == -1) eIndex = vlst.Count;
            if (vlst != null)
            {
                for (int i = sIndex; i < eIndex; i++)
                {
                    if (vlst[i] > axValue) axValue = vlst[i];
                    if (vlst[i] < inValue) inValue = vlst[i];
                }
                br = true;
            }
            return br;
        }
    }

    public enum DataStyle
    {
        onlyneg = 0,
        onlypos = 1,
        nplusp = 2 

    }
}
