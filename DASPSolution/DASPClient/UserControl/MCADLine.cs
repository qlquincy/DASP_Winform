using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

using System.Collections.Generic;

namespace Dasp
{



    public delegate void UpdateMouseValue(int x,int y,float tim,float yvalue);
	/// <summary>
	/// 
	/// </summary>
	public class MCADLine : System.Windows.Forms.UserControl
    {
        #region 2016
        /// <summary>
        /// 设置左边预留的标注空间
        /// </summary>
        public int Lspan
        {
            set { lspan = value; }
            get { return lspan; }
        }
        /// <summary>
        /// 设置分部绘制区域
        /// </summary>
        /// <param name="indextstart"></param>
        /// <param name="len"></param>
        /// <param name="indexpart"></param>
        public void SetDrawAera(int indexpart,int indextstart,int len )
        {
            if ((LVP != null) && (indexpart < this.LVP.Count))
            {
                if (indextstart < LVP[indexpart].DrawDatalstPara[0].Count)
                LVP[indexpart].Sindex = indextstart;

                if (indextstart + len < LVP[indexpart].DrawDatalstPara[0].Count)
                {
                    LVP[indexpart].Eindex = indextstart + len - 1;
                }
                else
                    LVP[indexpart].Eindex = -1;

                this.Refresh();
            }
             
        }
        public string[] RightText
        {
            set;
            get;
        }
        public int Rspan
        {
            set { rspan = value; }
            get { return rspan; }
        }
        #region 不再使用
        public int sindex
        {
            set;
            get;
        }
        public int drawlen
        {
            set;
            get;
        }
        public void SetDrawPara(int index,int dcount)
        {
            sindex = index;
            drawlen = dcount;
            this.Refresh();
        }
        #endregion 不再使用
        /// <summary>
        /// 当前控件分区绘制信息
        /// </summary>
        private List<ViewPartInfo> LVP = new List<ViewPartInfo>();
        /// <summary>
        /// 垂直图形分区数量
        /// </summary>
        private int drawparts = 1;
        public int DrawParts
        {
            set { drawparts = value; }
            get { return drawparts; }
        }
        private List<int> Heights = new List<int>();
        /// <summary>
        /// 计算各分区的绘制高度,注意取整问题
        /// </summary>
        private void CalculatePartDrawHeight()
        {
            // this.Heights.Clear();
            if (LVP.Count != this.drawparts) //绘制区域数量发生改变
            {
                LVP.Clear();
                ViewPartInfo viewPartInfo = null;
                for (int i = 0; i < drawparts; i++)
                {
                    viewPartInfo = new ViewPartInfo();
                    LVP.Add(viewPartInfo);
                }
            }
            //int unith = this.Height / drawparts;
            //int remand = this.Height % drawparts;

            //for (int i = 0; i < remand; i++)
            //{
            ////    Heights.Add(unith + 1);
            //    LVP[i].dHeight = unith + 1;
            //   // Heights[i] = unith + 1;
            //}
            //for (int i = remand; i < drawparts; i++)
            //{
            //    LVP[i].dHeight = unith ;
            // //   Heights.Add(unith);
            //}
            int m = 0;
            for (int i = 0; i < drawparts; i++)
            {
                m = m + LVP[i].percent;
            }
            float unith = 1f * this.Height / m;

            for (int i = 0; i < drawparts; i++)
            {
                LVP[i].dHeight = Convert.ToInt32(unith * LVP[i].percent);
                // Heights.Add(unith);
            }
        }
        /// <summary>
        /// 计算各分区的绘制高度,注意取整问题
        /// </summary>
        private void CalculatePartDrawHeight(IList<int> scape)
        {
            this.Heights.Clear();
            if (LVP.Count != this.drawparts) //绘制区域数量发生改变
            {
                LVP.Clear();
                ViewPartInfo viewPartInfo = null;
                for (int i = 0; i < drawparts; i++)
                {
                    viewPartInfo = new ViewPartInfo();
                    LVP.Add(viewPartInfo);
                }
            }
            int m = 0;
            for (int i = 0; i < drawparts; i++)
            {
                m = m + LVP[i].percent;
            }
            float unith = 1f * this.Height / m;

            for (int i = 0; i < drawparts; i++)
            {
                LVP[i].dHeight = Convert.ToInt32(unith * LVP[i].percent);
                // Heights.Add(unith);
            }
        }
        /// <summary>
        /// 设置所有的绘制数据,及占用绘制区域的空间比例
        /// </summary>
        /// <param name="datalsts"></param>
        public void SetDrawDataAll(IList<IList<float>[]> datalsts, IList<int> scape)
        {
            int tmpparts = datalsts.Count;//获取绘制区域总数
            DrawParts = tmpparts;//设置绘制区域数量
            ViewPartInfo viewPartInfo = null;
            LVP.Clear();
            for (int i = 0; i < drawparts; i++)
            {
                viewPartInfo = new ViewPartInfo();
                viewPartInfo.DrawDatalstPara = datalsts[i];//设置每部分区域的绘制数据
                viewPartInfo.percent = scape[i];
                LVP.Add(viewPartInfo);
            }
            CalculatePartDrawHeight();
            exd = true;
            this.Refresh();
        }

        /// <summary>
        /// 设置所有的绘制数据,及占用绘制区域的空间比例
        /// </summary>
        /// <param name="datalsts"></param>
        public void SetDrawDataAll(IList<IList<float>[]> datalsts, IList<int> scape, IList<DataBase> dbex)
        {
            int tmpparts = datalsts.Count;//获取绘制区域总数
            DrawParts = tmpparts;//设置绘制区域数量
            ViewPartInfo viewPartInfo = null;
            LVP.Clear();
            for (int i = 0; i < drawparts; i++)
            {
                viewPartInfo = new ViewPartInfo();
                viewPartInfo.DrawDatalstPara = datalsts[i];//设置每部分区域的绘制数据
                viewPartInfo.percent = scape[i];
                viewPartInfo.dbase = dbex[i];
                LVP.Add(viewPartInfo);
            }
            CalculatePartDrawHeight();
            exd = true;
            this.Refresh();
        }

        /// <summary>
        /// 设置制定区域的绘制参数
        /// </summary>
        /// <param name="indexpart">绘制区域序号</param>
        /// <param name="datalst">绘图数据数组</param>
        public void SetDrawDataofPart(int indexpart, IList<float>[] datalst)
        {
            if ((LVP != null) && (indexpart < LVP.Count))
            {
                LVP[indexpart].DrawDatalstPara = datalst;
            }

        }
        /// <summary>
        /// 设置所有的绘制数据
        /// </summary>
        /// <param name="datalsts"></param>
        public void SetDrawDataAll(IList<IList<float>[]> datalsts)
        {
            int tmpparts = datalsts.Count;//获取绘制区域总数
            DrawParts = tmpparts;//设置绘制区域数量
            ViewPartInfo viewPartInfo = null;
            LVP.Clear();
            for (int i = 0; i < drawparts; i++)
            {
                viewPartInfo = new ViewPartInfo();
                viewPartInfo.DrawDatalstPara = datalsts[i];//设置每部分区域的绘制数据
                LVP.Add(viewPartInfo);
            }
            CalculatePartDrawHeight();
            exd = true;
            this.Refresh();
        }
        /// <summary>
        /// 使用扩展算法绘制图形
        /// </summary>
        private bool exd = false;
     
        public UpdateMouseValue updateMouseValue = null;
        #endregion 2016
        #region 2011
        private string strTitle = "实时线"; //标题
        private Color clrBgColor = Color.Snow; //背景色
        private Color clrTextColor = Color.White; //文字颜色
        private Color clrBorderColor = Color.Black; //整体边框颜色
        private Color clrAxisColor = Color.Gray; //轴线颜色
        private Color clrSliceTextColor = Color.Black; //刻度文字颜色
        private float fltYRotateAngle = 0f; //Y轴文字旋转角度
        /// <summary>
        /// 基本图形曲线的颜色
        /// </summary>
        private Color clrsCurveColors = Color.Red;

        /// <summary>
        ///比较图形曲线的颜色
        /// </summary>
        private Color clrsCurveColorsb = Color.Green;
        private Color clrSliceColor = Color.Black; //刻度颜色
        private int intFontSize = 9; //字体大小号数
        private int intCurveSize = 1; //曲线线条大小
        /// <summary>
        /// 曲线线条宽度
        /// </summary>
        public int CurveSize
        {
            get
            {
                return intCurveSize;
            }
            set
            {
                intCurveSize = value;
            }
        }
        /// <summary>
        /// 字体大小号数
        /// </summary>
        public int FontSize
        {
            get
            {
                return intFontSize;
            }
            set
            {
                intFontSize = value;
            }
        }
        private System.ComponentModel.Container components = null;
        private Panel ChartPanel;
        /// <summary>
        /// 绘制的花布所在
        /// </summary>
        private Graphics g;
        /// <summary>
        /// 判断是否可以绘制，没有数据或只有一个数据点就不需要绘制
        /// </summary>
        private bool CanDraw
        {
            get
            {
                return canDraw();
            }
        }
      

        /// <summary>
        /// 标题，已经使用
        /// </summary>
        public string Title
        {
            set
            {
                strTitle = value;
            }
            get
            {
                return strTitle;
            }
        }
        /// <summary>
        /// 背景色，已经使用
        /// </summary>
        public Color BgColor
        {
            set
            {
                clrBgColor = value;
            }
            get
            {
                return clrBgColor;
            }
        }
        /// <summary>
        /// 绘制刻度文字颜色
        /// </summary>
        public Color TextColor
        {
            set
            {
                clrTextColor = value;
            }
            get
            {
                return clrTextColor;
            }
        }
        /// <summary>
        /// 设置绘制基本图形线的颜色
        /// </summary>
        public Color ClrsCurveColors
        {
            set { clrsCurveColors = value; }
            get {return clrsCurveColors;}
        }
        /// <summary>
        /// 设置比较图形曲线的颜色
        /// </summary>
        public Color ClrsCurveColorsb
        {
            set { clrsCurveColorsb = value; }
            get { return clrsCurveColorsb; }
        }
        /// 轴线颜色
        /// </summary>
        public Color AxisColor
        {
            set
            {
                clrAxisColor = value;
            }
            get
            {
                return clrAxisColor;
            }
        }
        /// <summary>
        /// 整体边框颜色，已经使用
        /// </summary>
        public Color BorderColor
        {
            set
            {
                clrBorderColor = value;
            }
            get
            {
                return clrBorderColor;
            }
        }
        /// <summary>
        /// 刻度颜色
        /// </summary>
        public Color SliceColor
        {
            set
            {
                clrSliceColor = value;
            }
            get
            {
                return clrSliceColor;
            }
        }
        /// <summary>
        /// 刻度文字颜色
        /// </summary>
        public Color SliceTextColor
        {
            set
            {
                clrSliceTextColor = value;
            }
            get
            {
                return clrSliceTextColor;
            }
        }
        /// <summary>
        /// 坐标刻度需要表示的小数位数
        /// </summary>
        private int decima = 1;
        public int Decima
        {
            set
            {
                decima = value;
            }
            get
            {
                return decima;
            }
        }
        /// <summary>
        /// 获取或设置绘制对象之间的间距
        /// </summary>
        public int barDiffWidth
        {
            set
            {
                BarDiff = value;
                Calculatea();
            }
            get
            {
                return BarDiff;
            }
        }
        /// <summary>
        /// 绘制对象之间的间距以像素为单位
        /// </summary>
        private int BarDiff = 4;//
        /// <summary>
        /// 获取或设置绘制对象之间的空隙宽度 空隙宽度+绘制宽度等于单位绘制对象占用的宽度
        /// </summary>
        public int barWidth
        {
            set
            {
                PerBarWith = value;
                Calculatea();
            }
            get
            {
                return PerBarWith;
            }
        }
        /// <summary>
        /// 绘制对象的宽度  如柱子的柱宽度，用像素表示
        /// </summary>
        private int PerBarWith = 2;
        /// <summary>
        /// 增加一个绘制点
        /// </summary>
        /// <param name="barp"></param>
        public void AddNewDate(double barp)
        {

            this.Refresh();
        }
        /// <summary>
        /// 绘图区域
        /// </summary>
        private Size CurrentSize = new Size(0, 0);
        private float fltYSpace = 0f; //图像上下距离边缘距离
        float[] dashValues = { 3, 3 };
        /// <summary>
        /// 获取图像左距离边缘距离
        /// </summary>
        public int XSpace
        { get { return this.innerbar; } set { this.innerbar = value; } }
        /// <summary>
        /// 图像上下距离边缘距离
        /// </summary>
        public float YSpace
        {
            get
            {
                return fltYSpace;
            }
            set
            {
                fltYSpace = value;
            }
        }
      
       
        /// <summary>
        /// 可显示的柱子数量
        /// </summary>
        private int DisPlayBars = 0;
        /// <summary>
        /// 计算当前画布可显示的绘制数量
        /// 可用的花布范围除以单位绘制点的宽度（绘制对象宽度+绘制对象之间的空隙）
        /// 得出可表示绘制点数
        /// </summary>
        private void Calculatea()
        {
            DisPlayBars = (Width - rspan - innerbar) / (this.PerBarWith + BarDiff);
        }
        /// <summary>
        /// 计算目前单位格所绘制的对象数
        /// </summary>
        /// <returns></returns>
        public int SCA()
        {
            int sc = 1;
            switch (BarDiff)
            {
                case 22://每单位格显示1个k柱，间隔 22柱宽 10
                    sc = 1;
                    break;
                case 8:  //每单位格显示2个柱，柱间隔 8柱宽
                    sc = 2;
                    break;
                case 4:  //每单位格显示4个柱，柱间隔 4柱宽
                    sc = 4;
                    break;
                case 2: //每单位格显示8个柱，柱间隔 2柱宽2
                    sc = 8;
                    break;
                case 1:
                    sc = 16;//每单位格显示8个柱，柱间隔 1柱宽1
                    break;
                case 0:
                    sc = 32;//每单位格显示32个柱，柱间隔 0柱宽1
                    break;
                default:
                    break;
            }
            return sc;

        }
        
        /// <summary>
        /// 当前绘制区域可分辨的柱子数
        /// </summary>
        /// <returns></returns>
        private int MaxBar()
        {
            int ti;
            ti = this.Width - this.rspan - this.innerbar; //宽度区域的象素个数，没有间隔
            //
            ti = ti * scale / this.Gridspan;
            return ti;
        }
        /// <summary>
        /// Y轴文字旋转角度
        /// </summary>
        public float YRotateAngle
        {
            get
            {
                return fltYRotateAngle;
            }
            set
            {
                fltYRotateAngle = value;
            }
        }
       
        /// <summary>
        /// 零刻度线在画布中的高度
        /// </summary>
        private int ZeroLeve = 400;      
        /// <summary>
        /// X轴点间距（象素个数）
        /// </summary>
        private float fltXSlice = 50; 
        #endregion
        #region 绘图数据
       
       
        #endregion 
        /// <summary>
		/// 画布距左边及上边的空隙 
		/// </summary>
		private int innerbar = 4;
		/// <summary>
		/// 底边留给注时间坐标的空间
		/// </summary>
		private int bmspan = 4;

        public int BmSpan
        {
            set { bmspan = value; }
            get { return bmspan; }
        }
        /// <summary>
        /// 绘制区上端预留标注区高度
        /// </summary>
        private int topremark = 50;
        public int TopRemarkSpan
        {
            set { topremark = value; }
            get { return topremark; }
        }
        /// <summary>
		/// Y轴向网格尺寸间距，以像素为单位
		/// </summary>
		private int Gridspan = 20;
        /// <summary>
        /// 纵向格高度（Y轴向网格尺寸间距）
        /// </summary>
        public int yGridspan
        {
            set {Gridspan = value;}
            get { return Gridspan; }
        }       
   		
      
		/// <summary>
		/// 右边留给注坐标的空间
		/// </summary>
		private int rspan = 50;
        

        /// <summary>
        /// 左边留给注坐标的空间
        /// </summary>
        private int lspan = 50;
	
       
        /// <summary>
        /// 保证Y轴的刻度是100的整数
        /// </summary>
        /// <param name="_dv"></param>
        /// <param name="wdth"></param>
        /// <returns></returns>
        private double GetInt(double _dv, int wdth)
        {
            double dvalue = 0f;
          
           dvalue =  Convert.ToInt32(_dv / wdth );
            return dvalue;
        }
		
        /// <summary>
        /// 指示当前是否可以进行图形绘制
        /// </summary>
        /// <returns></returns>
        private bool canDraw()
        {
            bool cdraw = true;
            if (exd)
            {
                cdraw = false;
                if (LVP != null)
                {
                    cdraw = true;
                }
            }
          
            return cdraw;
        }
		
      
		/// <summary>
		/// X轴的画制对象之间的间距像素值（不含画制对象自身的宽度）最小为1
        ///一个格子的宽度除以一个格子标识的点数  =   每个点横向间隔值  ，最小是点与点之间为一个像素
        ///可以直接指定，也可以按单位格子放置的点数确定
		/// </summary>
		public float XSlice
		{	
            set 
            { 
                fltXSlice = value; 
            }	
            get 
            { 
                return fltXSlice; 
            }	
        } 		
		/// <summary>
		/// 获取或设置零刻度线在画布中的高度，以像素为单位
		/// </summary>
		public int  ZeroL
		{
			get 
            {
                return ZeroLeve;
            } 
            set 
            {
                ZeroLeve = value;
            }
		}		
        /// <summary>
        ///Y轴单位刻度的所表示的数值 
        /// </summary>
		private float fltYSliceValue = 20;
        /// <summary>
        /// Y轴起始刻度所表示的值
        /// </summary>
		private float fltYSliceBegin = 30; 

        /// <summary>
        /// Y轴顶部所表示的值
        /// </summary>
        private float fltYSliceEnd = 30;
		/// <summary>
		/// 设置或获取Y轴大单位刻度的所表示的数值,不应该确定了?
		/// </summary>
		public float YSliceValue
		{	
            set 
            { 
                fltYSliceValue = value; 
            }		
            get 
            { 
                return fltYSliceValue;
            }		
        }
		/// <summary>
		/// Y轴刻度宽度
		/// </summary>
		public float YSlice
		{	
            set 
            { 
                fltYSlice = value;
            }		
            get
            { 
                return fltYSlice;
            }	
        }
		private float fltYSlice = 50; //Y轴刻度宽度
		/// <summary>
		/// Y轴底部所表示的值（在图像上表示的最小值）
		/// </summary>
		public float YSliceBegin
		{	
            set 
            { 
                fltYSliceBegin = value;
            }		
            get 
            {
                return fltYSliceBegin;
            }		
        }
        /// <summary>
        /// Y轴顶部部所表示的值（在图像上表示的最大值）
        /// </summary>
        public float YSliceEnd
        {
            set
            {
                fltYSliceEnd = value;
            }
            get
            {
                return fltYSliceEnd;
            }
        }
		/// <summary>
		/// 每个格表示的点数
		/// </summary>
		private int scale = 10; //
        #region 放大缩小问题先不管


      
		
        /// <summary>
        /// 横轴点之间的间隔，以像素为单位
        /// </summary>
        public int xInterval
        {
            set;
            get;
        }
     
     
        #endregion 
       
       
      
        ///// <summary>
        ///// 每页可绘制的点数
        ///// </summary>
        //private int pageNumberOfValue = 1024;
        ///// <summary>
        ///// 设置绘制点数
        ///// </summary>
        //public int PageNumberOfValue
        //{
        //    set 
        //    {
        //        if (value == -1)
        //        {
        //            drawall = true;
        //        }
        //        else
        //        {
        //            drawall = false;
        //            pageNumberOfValue = value;
        //        }
        //        this.Refresh();
        //    }
        //    get 
        //    {
        //        return pageNumberOfValue;
        //    }
        //}

        /// <summary>
        /// 比较分析指示
        /// </summary>
        private bool cmp = false;
       
       
        /// <summary>
        /// 计算在当前绘制每屏绘制点数情况下，计算出总共可绘制的屏数
        /// 以便于进行分页绘制
        /// </summary>
        /// <returns></returns>
        //private int GetPagePoint()
        //{
        //    //int xnum = (this.Width - this.rspan - innerbar) / (this.xGridSpan);//可绘制网格刻度数量
        //    //pageNumberOfValue = xnum * xUnitPointNum;//每页可绘制的点数 
        //    if ((pageNumberOfValue > 0) && (this.CurrentNumberOfValues < pageNumberOfValue))
        //        pageNumberOfValue = CurrentNumberOfValues;//当单页绘制的点数大于总点数时  每页绘制点数等于总点数
        //    int drwaPageTotalPages = this.CurrentNumberOfValues / pageNumberOfValue;
        //    if ((Remainder = this.CurrentNumberOfValues % pageNumberOfValue) > 0)
        //   {
        //       DrwaPageTotalPages = drwaPageTotalPages + 1;
        //   }
        //   else
        //   {
        //       DrwaPageTotalPages = drwaPageTotalPages;
        //   }
        //   return DrwaPageTotalPages;
        //}
        /// <summary>
        /// 余数
        /// </summary>
        public int Remainder
        {
            set;
            get;
        }
        public MCADLine()
        {
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            YSliceBegin = -2000;
            this.YSliceEnd = 2000;
            xGridSpan = 64;
            xUnitPointNum = 64;
            yGridspan = 100;
            Khz = 25600;
            sindex = 0;
            drawlen = 1024;
            //pageNumberOfValue = 1024;
          // this.PreProcessControlMessage
           
            imgTemp = new Bitmap(this.ChartPanel.Width, this.ChartPanel.Height);
            //imgTemp = new Bitmap(200, 200, ChartPanel.CreateGraphics());
            //g = Graphics.FromImage(imgTemp);
            g = ChartPanel.CreateGraphics();
            DrawChart();
        }
      
       
        private Bitmap imgTemp = null;//new BitMap(200, 200, g);//创建Image对象，大小为200 * 200
      
        /// <summary>
        /// 绘制起点序号
        /// </summary>
        public int StartPindex
        {
            set;
            get;
        }
        /// <summary>
        /// 绘制终点序号
        /// </summary>
        public int EndPindex
        {
            set;
            get;
        }
        /// <summary>
        /// 绘制图像页号
        /// </summary>
        public int DrawPageIndex
        {
            set;
            get;
        }
        /// <summary>
        /// 当前绘制的总页数 =  绘制总点数  /当前屏幕所能绘制的点数
        /// 当前屏幕所能绘制的点数 = 屏幕的绘制宽度 / 每个点占用的横坐标像素数量
        /// </summary>
        public int DrwaPageTotalPages
        {
            set;
            get;
        }
        /// <summary>
        /// Y轴单位格（像素）所表示的值
        /// </summary>
        private int unitgridyvalue
        {
            set;
            get;
        }
        /// <summary>
        /// 设置横向网格的宽度 ,以像素为单位 
        /// </summary>
        public int xGridSpan
        {
            set;
            get;
        }
        /// <summary>
        ///单位横向单元格所绘制的点数
        /// 点数越小图像越大相当于横向放大，但展示的点数越少
        /// 当前绘制区域的宽度由多少个单位单元格？
        /// </summary>
        public int xUnitPointNum
        {
            set;
            get;
        }
        private int khz;
        /// <summary>
        /// 采样频率
        /// </summary>
        public int Khz
        {
            set { khz = value; this.Refresh(); }
            get { return khz; }
        }
		
       /// <summary>
       /// 预算分区绘制中y向网格的大小以及单位像素所表示的值
       /// </summary>
       /// <param name="indexpart">绘制的分区序号</param>
        public void Fit(int indexpart)
        {
            if ((LVP != null) && (indexpart < this.LVP.Count))
            {

                float fltMaxValue = LVP[indexpart].maxValue;
                int tmph = innerbar + topremark;//只有负数情况
                if (LVP[indexpart].dataStyle == DataStyle.nplusp)
                {
                    tmph = (int)((this.LVP[indexpart].dHeight - bmspan - innerbar - topremark) * fltMaxValue / (fltMaxValue - this.LVP[indexpart].minValue)) + innerbar + topremark;//计算该区域绘制零轴线高度
                }
                else if (LVP[indexpart].dataStyle == DataStyle.onlypos)
                {
                    tmph = this.LVP[indexpart].dHeight - bmspan;//只有正值出现，零刻度线在底部预留空隙之上
                }
                LVP[indexpart].y_zeroHeght = tmph;
                if (LVP[indexpart].dataStyle == DataStyle.nplusp)  //在绘制空间中有正有负值情况下，确定网格的合理大小值
                {

                    int  ynlentop = (LVP[indexpart].y_zeroHeght - 1 * this.innerbar - topremark) / this.Gridspan;//先计算系统默认网格高度情况下为y轴向上方向的网格个数
                    int  ynlenbottom = (LVP[indexpart].dHeight - bmspan - LVP[indexpart].y_zeroHeght) / this.Gridspan;//负值区域可能的网格数量
                    int ynlen = Math.Min(ynlentop, ynlenbottom);
                    if (ynlen < 1)  //不足一个网格需要调整系统设定的网格大小
                    {
                        if (ynlen == ynlentop)  //以上部区域为准调整网格大小
                        {
                            LVP[indexpart].yGridSnap = LVP[indexpart].y_zeroHeght - 1 * this.innerbar - topremark;
                        }
                        else
                        {
                            LVP[indexpart].yGridSnap = LVP[indexpart].dHeight - bmspan - LVP[indexpart].y_zeroHeght;
                        }
                        ynlen = 1;
                    }
                    else
                    {
                        LVP[indexpart].yGridSnap = this.Gridspan;
                    }

                    float f100 = GetSacle(Math.Max(Math.Abs(LVP[indexpart].maxValue), Math.Abs(LVP[indexpart].minValue)));

                    unitgridyvalue = Convert.ToInt32((Math.Max(Math.Abs(LVP[indexpart].maxValue), Math.Abs(LVP[indexpart].minValue)) / (f100 * ynlen)) * f100);//unitgridyvalue 表示y轴上单位标刻度线的值，此处表示归化为10的倍数
                  
                    LVP[indexpart].y_ValuePerPixel = 1f * unitgridyvalue / LVP[indexpart].yGridSnap;  //计算出每个像素高所代表的值
                }
            }
        }
        private  float GetSacle(float fValue)
        {
            float scale = 1f;

            string b = fValue.ToString("E8");
            int b1 = b.IndexOf('E');
            string c = b.Substring(b1 + 1, 1);
            string d = b.Substring(b1 + 2, 3);
            int d1 = Convert.ToInt32(d);
            int c1 = 1;
            if (c.Equals("-"))
            {
                c1 = -1;
                scale = Convert.ToSingle(Math.Pow(10, c1 * (d1 + 1)));
            }
            else
            {
                scale = Convert.ToSingle(Math.Pow(10, c1 * (d1 - 1)));
            }
            return scale;
        }
       
     
     
	
		/// <summary>
		/// 画绘制对象的标题，在左上角绘制
		/// </summary>
		/// <param name="objGraphics"></param>
		private void DrawTitle()
		{
			g.DrawString(Title, new Font("宋体", FontSize), new SolidBrush(TextColor), new Point((int)this.innerbar  , (int)(YSpace + FontSize)));
		}
     
       
        public int GetValidDrawWith
        {
            get { return this.rspan + innerbar; }
        }
        /// <summary>
        /// 单位像素绘制的点数,全部显示时,可能几个点在一起
        /// </summary>
        private float unitPoints
        {
            set;
            get;
        }
       
        /// <summary>
        /// 在分区中一屏上绘制所有点时X轴的绘制
        /// </summary>
        /// <param name="objGraphics"></param>
        private void DrawAllXAxis(int indexparts)
        {
            Pen penDashed = new Pen(new SolidBrush(AxisColor));
            penDashed.DashStyle = DashStyle.Custom;
            penDashed.DashPattern = dashValues;
            int xnum = (this.Width - this.rspan - this.lspan - innerbar) / LVP[indexparts].xGridSnap;// x轴向上可画的网格个数
            string strSliceText = string.Empty;
            g.DrawLine(penDashed, this.Width - this.rspan, SumHeght(indexparts) + innerbar + topremark, this.Width - this.rspan, SumHeght(indexparts) + LVP[indexparts].dHeight - bmspan);
            float unittime = LVP[indexparts].x_grids* LVP[indexparts].xValueScale; //横轴单位网格表示的值
            for (int i = 0; i <= xnum; i++)
            {
                g.DrawLine(penDashed, innerbar + i * LVP[indexparts].xGridSnap + this.lspan, SumHeght(indexparts) + innerbar + topremark, innerbar + i * LVP[indexparts].xGridSnap + this.lspan, SumHeght(indexparts) + LVP[indexparts].dHeight - bmspan);
                strSliceText = (i * unittime).ToString("f2");//当前轴线所表示的Y值：刻度数
                //g.TranslateTransform(this.XSpace + i * this.xGridSpan, /*this.YSliceBegin*/ this.ZeroL); //平移图像(原点)
                //g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                //g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(Color.Red /*SliceTextColor*/), 0, 0);
                //g.ResetTransform(); //重置图像 

                g.TranslateTransform(this.XSpace + this.lspan + i * LVP[indexparts].xGridSnap, /*this.YSliceBegin*/SumHeght(indexparts) + LVP[indexparts].dHeight - 1* bmspan); //平移图像(原点)
                g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(clrTextColor /*SliceTextColor*/), 0, 0);
                g.ResetTransform(); //重置图像 
            }
            if (this.Mousex != -1)
            {
                g.DrawLine(penDashed, this.Mousex, SumHeght(indexparts) +innerbar + this.topremark, this.Mousex, SumHeght(indexparts) + LVP[indexparts].dHeight - bmspan);
                this.DrawTopRemark(indexparts);
            }
            penDashed.Dispose();
        }
        private void DrawTopRemark(int indexparts)
        {
            string txtcontext = "";
            int i =Convert.ToInt32( MouseLocation * LVP[indexparts].DisplayLen());//.DrawDatalstPara[0].Count);
            if (i < LVP[indexparts].DisplayLen()) //.DrawDatalstPara[0].Count)
            {
                txtcontext = Convert.ToString(LVP[indexparts].videoValue[i].xTime) + " V:" + Convert.ToString(LVP[indexparts].videoValue[i].yN_Mss);
                g.TranslateTransform(this.XSpace + this.lspan, SumHeght(indexparts) + 12); //平移图像(原点)
                g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                g.DrawString(txtcontext, new Font("宋体", FontSize), new SolidBrush(clrTextColor /*SliceTextColor*/), 0, 0);
                g.ResetTransform();
            }
        }
	    /// <summary>
	    /// 在分区中全屏绘制曲线
	    /// </summary>
	    /// <param name="indexparts"></param>
        public void DrawAllContent(int indexparts)
        {
            Pen CurvePen = new Pen(clrsCurveColors, CurveSize);
            Pen CurvePen2 = new Pen(clrsCurveColorsb, CurveSize);
            GraphicsPath m_gp = new GraphicsPath();
            Brush mbrush = new LinearGradientBrush(new Rectangle(0, 0, this.barWidth, this.barWidth), Color.Green, Color.Green, LinearGradientMode.Horizontal);
            PointF[] CurvePointF = new PointF[LVP[indexparts].DrawDatalstPara[0].Count];//一系列连线坐标
            PointF[] CurvePointF2 = new PointF[LVP[indexparts].DrawDatalstPara[0].Count];//一系列连线坐标
            float keys = 0;
            float values = 0;
            m_gp.Reset();
            float unitv = Convert.ToSingle(this.Width - this.rspan - innerbar - this.lspan) / Convert.ToSingle(LVP[indexparts].DrawDatalstPara[0].Count);//每个点占用X轴的宽度 
            if (LVP[indexparts].DrawGroup != 1) //cmp)
            {
                LVP[indexparts].videoValue.Clear();
                LVP[indexparts].videoValueb.Clear();
                for (int i = 0; i < LVP[indexparts].DrawDatalstPara[0].Count; i++)
                {
                    keys = unitv * i + XSpace + this.lspan;
                   // if (LVP[indexparts].DrawDatalstPara[0][i] > 0)
                    {
                        values = SumHeght(indexparts) +  (LVP[indexparts].y_zeroHeght) - (float)(LVP[indexparts].DrawDatalstPara[0][i] / LVP[indexparts].y_ValuePerPixel);//此处是转换成像素坐标值,
                        CurvePointF[i] = new PointF(keys, values);

                        values = SumHeght(indexparts) + (LVP[indexparts].y_zeroHeght) - (float)(LVP[indexparts].DrawDatalstPara[1][i] / LVP[indexparts].y_ValuePerPixel);//此处是转换成像素坐标值,
                        CurvePointF2[i] = new PointF(keys, values);

                        VideoValue _VideoValue = new VideoValue(i, (float)(LVP[indexparts].DrawDatalstPara[0][i]));
                        LVP[indexparts].videoValue[i] = _VideoValue;
                        _VideoValue = new VideoValue(i, (float)(LVP[indexparts].DrawDatalstPara[1][i]));
                        LVP[indexparts].videoValueb[i] = _VideoValue;
                    }
                   

                }
               
              
                g.FillRegion(mbrush /*UnderBrush*/, new Region(m_gp));
                g.DrawLines(CurvePen, CurvePointF);
                g.DrawLines(CurvePen2, CurvePointF2);
            }
            else
            {
                LVP[indexparts].videoValue.Clear();
                for (int i = 0; i < LVP[indexparts].DrawDatalstPara[0].Count; i++)  //只有一组数据，只画第一组
                {
                    keys = unitv * i + XSpace + this.lspan;
                    // if (LVP[indexparts].DrawDatalstPara[0][i] > 0)
                    {
                        values = SumHeght(indexparts)+(LVP[indexparts].y_zeroHeght) - (float)(LVP[indexparts].DrawDatalstPara[0][i] / LVP[indexparts].y_ValuePerPixel);//此处是转换成像素坐标值,
                        CurvePointF[i] = new PointF(keys, values);
                    }
                    VideoValue _VideoValue = new VideoValue(i, (float)(LVP[indexparts].DrawDatalstPara[0][i]));
                    LVP[indexparts].videoValue[i] = _VideoValue;
                }
                g.FillRegion(mbrush /*UnderBrush*/, new Region(m_gp));
                g.DrawLines(CurvePen, CurvePointF);
            }
            mbrush.Dispose();
            CurvePen.Dispose();
            CurvePen2.Dispose();
        }
        /// <summary>
        /// 累计当前绘制区参考基点高度
        /// </summary>
        /// <param name="indexparts"></param>
        /// <returns></returns>
        private int SumHeght(int indexparts)
        {
            int sumh = 0;
            if (indexparts > 0)
            {
                for (int i = 0; i < indexparts ; i++)
                {
                    sumh += LVP[i].dHeight;
                }
            }
            return sumh;
        }
        /// <summary>
        /// 分区全绘是绘制Y向轴线及轴线上的刻度和文字,与分页绘制无关
        /// </summary>
        /// <param name="objGraphics"></param>
        private void DrawAllYAxis(int indexparts)
        {
            string strSliceText = string.Empty;
            Pen penDashed = new Pen(new SolidBrush(AxisColor));
            //g.DrawLine(penDashed, this.lspan + innerbar, SumHeght(indexparts) + LVP[indexparts].y_zeroHeght, this.Width - innerbar - this.rspan, SumHeght(indexparts)+ LVP[indexparts].y_zeroHeght);//画0轴横线
            //g.DrawLine(penDashed, this.lspan + innerbar, SumHeght(indexparts) + LVP[indexparts].dHeight - bmspan, this.Width - innerbar - this.rspan, SumHeght(indexparts) + LVP[indexparts].dHeight - bmspan);//绘制当前绘制区的底部横线
            penDashed.DashStyle = DashStyle.Custom;
            penDashed.DashPattern = dashValues;
            int ynlen = (LVP[indexparts].y_zeroHeght - 1 * this.innerbar - topremark) / LVP[indexparts].yGridSnap;//y轴向上方网格个数
            // int  unitgridyvalue = Convert.ToInt32(this.YSliceEnd /(10* ynlen ))*10;//表示y轴上单位格表示的值
            for (int i = 0; i <= ynlen; i++)
            {	//画网格虚线，从0轴线往上绘制				
                g.DrawLine(penDashed, this.lspan + innerbar, SumHeght(indexparts) + LVP[indexparts].y_zeroHeght - i * LVP[indexparts].yGridSnap, this.Width - this.rspan, SumHeght(indexparts) + LVP[indexparts].y_zeroHeght - i * LVP[indexparts].yGridSnap);  //从中心线向上画网格线

                strSliceText = Convert.ToString(LVP[indexparts].yGridSnap * LVP[indexparts].y_ValuePerPixel * i);//标示网格线的刻度值
                //strSliceText = Convert.ToString(unitgridyvalue * i);
                g.TranslateTransform(this.Width - this.rspan, LVP[indexparts].y_zeroHeght + SumHeght(indexparts) - i * LVP[indexparts].yGridSnap - FontSize / 2); //标注右侧刻度线
                g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(Color.Gold /*SliceTextColor*/), 0, 0);
                g.ResetTransform();
                g.TranslateTransform(this.XSpace, LVP[indexparts].y_zeroHeght + SumHeght(indexparts) - i * LVP[indexparts].yGridSnap - FontSize / 2); //标注左侧刻度线
                g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(Color.Gold /*SliceTextColor*/), 0, 0);

                g.ResetTransform(); //重置图像 
            }
            ynlen = (LVP[indexparts].dHeight - bmspan - LVP[indexparts].y_zeroHeght/*this.ZeroL*/ ) / LVP[indexparts].yGridSnap;// this.Gridspan;//y轴向下方网格个数。
            for (int i = 0; i <= ynlen; i++)
            {	//画网格虚线，从0轴线往下绘制						
                g.DrawLine(penDashed, this.lspan + innerbar, SumHeght(indexparts) + LVP[indexparts].y_zeroHeght + i * LVP[indexparts].yGridSnap, this.Width - this.rspan, SumHeght(indexparts) + LVP[indexparts].y_zeroHeght + i * LVP[indexparts].yGridSnap);
                strSliceText = Convert.ToString(-LVP[indexparts].yGridSnap * LVP[indexparts].y_ValuePerPixel * i + 0);//当前轴线所表示的Y值：刻度数
                // strSliceText = Convert.ToString(-unitgridyvalue * i);
                g.TranslateTransform(this.Width - this.rspan, LVP[indexparts].y_zeroHeght + SumHeght(indexparts) + i * LVP[indexparts].yGridSnap - FontSize / 2); //平移图像(原点)
                g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(Color.Gold /*SliceTextColor*/), 0, 0);
                g.ResetTransform(); //重置图像 

                g.TranslateTransform(this.XSpace, LVP[indexparts].y_zeroHeght + SumHeght(indexparts) + i * LVP[indexparts].yGridSnap - FontSize / 2); //平移图像(原点)
                g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(Color.Gold /*SliceTextColor*/), 0, 0);
                g.ResetTransform(); //重置图像 
            }
            penDashed.Dispose();
        }
      
        private string TopRemark = "";
        /// <summary>
        /// 绘制抬头备注信息
        /// </summary>
        private void DrawTopRemark(string txtcontext)
        {
            g.TranslateTransform(this.XSpace + this.lspan ,  5); //平移图像(原点)
            g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
            g.DrawString(txtcontext, new Font("宋体", FontSize), new SolidBrush(clrTextColor /*SliceTextColor*/), 0, 0);
            g.ResetTransform(); //重置图像 
        }
    

    
		
        public bool drawall
        {
            set;
            get;
        }
        /// <summary>
        /// 在右侧标注有关内容
        /// </summary>
        private void RemarLeftText()
        {
           
           if (RightText != null)
            // int  unitgridyvalue = Convert.ToInt32(this.YSliceEnd /(10* ynlen ))*10;//表示y轴上单位格表示的值
            for (int i = 0; i < RightText.Length; i++)
            {	//画网格虚线，从0轴线往上绘制				
               
                g.TranslateTransform(this.Width - this.rspan +5,  this.topremark + i *FontSize *2 - FontSize / 2); //标注右侧刻度线
                g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                g.DrawString(RightText[i], new Font("宋体", FontSize), new SolidBrush(Color.Gold /*SliceTextColor*/), 0, 0);
                g.ResetTransform();

            }
           

        }
        /// <summary>
        /// 绘制实施 刷新或启动时调用 
        /// </summary>
        public void DrawChart()
        {
            CalculatePartDrawHeight();
            g.FillRectangle(new SolidBrush(BgColor), 1, 1, Width - 2, Height);//- 2); //填充边框区域
            //g.DrawRectangle(new Pen(BorderColor, 1), this.innerbar + this.lspan, this.innerbar + topremark, Width - rspan - this.innerbar - this.lspan, Height -  this.innerbar - topremark - bmspan); //画边框
         //   xInterval = 1;
            if (CanDraw)
            {
              

                if (exd) //采用分区进行图形绘制
                {
                    RemarLeftText();
                    for (int i = 0; i < this.drawparts; i++)  //依次绘制各个分区的图形
                    {
                        bool br = false;
                        if (br)
                        {
                            Fit(i);

                            if (drawall) //绘制所有点
                            {
                                LVP[i].x_unitPoints = 1f * LVP[i].DrawDatalstPara[0].Count / (this.Width - this.rspan - innerbar - this.lspan);  //单位像素表示的点数.
                                LVP[i].x_grids = Convert.ToInt32(LVP[i].x_unitPoints * LVP[i].DrawDatalstPara[0].Count / (this.Width - this.rspan - innerbar - this.lspan));
                                LVP[i].xGridSnap = this.xGridSpan;
                                DrawAllYAxis(i);
                                DrawAllXAxis(i);
                                DrawAllContent(i);
                            }
                        }
                        else
                        {
                            ReCalculateLVP(LVP[i].Sindex,  LVP[i].DisplayLen(), i);
                            //ReCalculateLVP(sindex, drawlen, i);
                            Fit_ext(i);

                            //if (drawall) //绘制所有点
                            //{Convert.ToInt32
                                LVP[i].x_unitPoints = 1f * LVP[i].DisplayLen() / (this.Width - this.rspan - innerbar - this.lspan);  //单位像素表示的点数.
                                LVP[i].x_grids = (LVP[i].x_unitPoints * LVP[i].DisplayLen() / (this.Width - this.rspan - innerbar - this.lspan));
                                LVP[i].xGridSnap = this.xGridSpan;
                                DrawAllYAxis_ext(i);
                                DrawAllXAxis_ext(i);//正在
                                DrawAllContent_ext(i);
                            //}
                        }
                    }
                }

               
               
            }
        }
        #region 制定点数绘制
        /// <summary>
        /// 指定区段绘制图像
        /// </summary>
        /// <param name="indextstart">绘制起点</param>
        /// <param name="len">绘制长度</param>
        /// <param name="indexpart"></param>
        private void ReCalculateLVP(int indextstart,int len,int indexpart)
        {
            if ((LVP != null) && (indexpart < this.LVP.Count))
            {
                LVP[indexpart].ChangeStartNum_Len(indextstart, len);//按区段计算绘制数据的最大最小值
            }

        }
        public void Fit_ext(int indexpart)
        {
            if ((LVP != null) && (indexpart < this.LVP.Count))
            {

                float fltMaxValue = LVP[indexpart].maxValue;
                int tmph = innerbar + topremark;//只有负数情况
                if (LVP[indexpart].dataStyle == DataStyle.nplusp)
                {
                    tmph = (int)((this.LVP[indexpart].dHeight - bmspan - innerbar - topremark) * fltMaxValue / (fltMaxValue - this.LVP[indexpart].minValue)) + innerbar + topremark;//计算该区域绘制零轴线高度
                }
                else if (LVP[indexpart].dataStyle == DataStyle.onlypos)
                {
                    tmph = this.LVP[indexpart].dHeight - bmspan;//只有正值出现，零刻度线在底部预留空隙之上
                }
                LVP[indexpart].y_zeroHeght = tmph;
                if (LVP[indexpart].dataStyle == DataStyle.nplusp)  //在绘制空间中有正有负值情况下，确定网格的合理大小值
                {

                    int ynlentop = (LVP[indexpart].y_zeroHeght - 1 * this.innerbar - topremark) / this.Gridspan;//先计算系统默认网格高度情况下为y轴向上方向的网格个数
                    int ynlenbottom = (LVP[indexpart].dHeight - bmspan - LVP[indexpart].y_zeroHeght) / this.Gridspan;//负值区域可能的网格数量
                    int ynlen = Math.Min(ynlentop, ynlenbottom);
                    if (ynlen < 1)  //不足一个网格需要调整系统设定的网格大小
                    {
                        if (ynlen == ynlentop)  //以上部区域为准调整网格大小
                        {
                            LVP[indexpart].yGridSnap = LVP[indexpart].y_zeroHeght - 1 * this.innerbar - topremark;
                        }
                        else
                        {
                            LVP[indexpart].yGridSnap = LVP[indexpart].dHeight - bmspan - LVP[indexpart].y_zeroHeght;
                        }
                        ynlen = 1;
                    }
                    else
                    {
                        LVP[indexpart].yGridSnap = this.Gridspan;
                    }

                    float f100 = GetSacle(Math.Max(Math.Abs(LVP[indexpart].maxValue), Math.Abs(LVP[indexpart].minValue)));

                    unitgridyvalue = Convert.ToInt32((Math.Max(Math.Abs(LVP[indexpart].maxValue), Math.Abs(LVP[indexpart].minValue)) / (f100 * ynlen)) * f100);//unitgridyvalue 表示y轴上单位标刻度线的值，此处表示归化为10的倍数

                    LVP[indexpart].y_ValuePerPixel = 1f * unitgridyvalue / LVP[indexpart].yGridSnap;  //计算出每个像素高所代表的值
                }
            }
        }
        private void DrawAllYAxis_ext(int indexparts)
        {
            string strSliceText = string.Empty;
            Pen penDashed = new Pen(new SolidBrush(AxisColor));
          
            penDashed.DashStyle = DashStyle.Custom;
            penDashed.DashPattern = dashValues;
            int ynlen = (LVP[indexparts].y_zeroHeght - 1 * this.innerbar - topremark) / LVP[indexparts].yGridSnap;//y轴向上方网格个数
            // int  unitgridyvalue = Convert.ToInt32(this.YSliceEnd /(10* ynlen ))*10;//表示y轴上单位格表示的值
            for (int i = 0; i <= ynlen; i++)
            {	//画网格虚线，从0轴线往上绘制				
                g.DrawLine(penDashed, this.lspan + innerbar, SumHeght(indexparts) + LVP[indexparts].y_zeroHeght - i * LVP[indexparts].yGridSnap, this.Width - this.rspan, SumHeght(indexparts) + LVP[indexparts].y_zeroHeght - i * LVP[indexparts].yGridSnap);  //从中心线向上画网格线

                strSliceText = Convert.ToString(LVP[indexparts].yGridSnap * LVP[indexparts].y_ValuePerPixel * i);//标示网格线的刻度值
                //strSliceText = Convert.ToString(unitgridyvalue * i);
                //g.TranslateTransform(this.Width - this.rspan, LVP[indexparts].y_zeroHeght + SumHeght(indexparts) - i * LVP[indexparts].yGridSnap - FontSize / 2); //标注右侧刻度线
                //g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                //g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(Color.Gold /*SliceTextColor*/), 0, 0);
                //g.ResetTransform();
                g.TranslateTransform(this.XSpace, LVP[indexparts].y_zeroHeght + SumHeght(indexparts) - i * LVP[indexparts].yGridSnap - FontSize / 2); //标注左侧刻度线
                g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(Color.Gold /*SliceTextColor*/), 0, 0);

                g.ResetTransform(); //重置图像 
            }
            ynlen = (LVP[indexparts].dHeight - bmspan - LVP[indexparts].y_zeroHeght/*this.ZeroL*/ ) / LVP[indexparts].yGridSnap;// this.Gridspan;//y轴向下方网格个数。
            for (int i = 0; i <= ynlen; i++)
            {	//画网格虚线，从0轴线往下绘制						
                g.DrawLine(penDashed, this.lspan + innerbar, SumHeght(indexparts) + LVP[indexparts].y_zeroHeght + i * LVP[indexparts].yGridSnap, this.Width - this.rspan, SumHeght(indexparts) + LVP[indexparts].y_zeroHeght + i * LVP[indexparts].yGridSnap);
                strSliceText = Convert.ToString(-LVP[indexparts].yGridSnap * LVP[indexparts].y_ValuePerPixel * i + 0);//当前轴线所表示的Y值：刻度数
                // strSliceText = Convert.ToString(-unitgridyvalue * i);
                //g.TranslateTransform(this.Width - this.rspan, LVP[indexparts].y_zeroHeght + SumHeght(indexparts) + i * LVP[indexparts].yGridSnap - FontSize / 2); //平移图像(原点)
                //g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                //g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(Color.Gold /*SliceTextColor*/), 0, 0);
                //g.ResetTransform(); //重置图像 

                g.TranslateTransform(this.XSpace, LVP[indexparts].y_zeroHeght + SumHeght(indexparts) + i * LVP[indexparts].yGridSnap - FontSize / 2); //平移图像(原点)
                g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(Color.Gold /*SliceTextColor*/), 0, 0);
                g.ResetTransform(); //重置图像 
            }
            #region 标注Y轴单位
            strSliceText = Convert.ToString(LVP[indexparts].dbase.yName);//当前轴线所表示的Y值单位


            g.TranslateTransform(this.XSpace + this.lspan, SumHeght(indexparts) + this.innerbar + topremark - FontSize - 2); //平移图像(原点)
            g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
            g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(Color.Gold /*SliceTextColor*/), 0, 0);
            g.ResetTransform(); 
            #endregion //重置图像 
            g.DrawLine(new Pen(BorderColor, 1), this.lspan + innerbar, SumHeght(indexparts) + this.innerbar + topremark, this.Width - this.rspan, SumHeght(indexparts) + this.innerbar + topremark);//画上部 
            g.DrawLine(new Pen(BorderColor, 1), this.lspan + innerbar, SumHeght(indexparts) + LVP[indexparts].dHeight - bmspan, this.Width - this.rspan, SumHeght(indexparts) + LVP[indexparts].dHeight - bmspan);//绘制底部横线
            penDashed.Dispose();
        }
        /// <summary>
        /// 在分区中一屏上绘制所有点时X轴的绘制
        /// </summary>
        /// <param name="objGraphics"></param>
        private void DrawAllXAxis_ext(int indexparts)
        {
            Pen penDashed = new Pen(new SolidBrush(AxisColor));
            penDashed.DashStyle = DashStyle.Custom;
            penDashed.DashPattern = dashValues;
            int xnum = (this.Width - this.rspan - this.lspan - innerbar) / LVP[indexparts].xGridSnap;// x轴向上可画的网格个数
            string strSliceText = string.Empty;
           
            float unittime = LVP[indexparts].x_grids * LVP[indexparts].xValueScale; //横轴单位网格表示的值
            for (int i = 0; i <= xnum; i++)
            {
                g.DrawLine(penDashed, innerbar + i * LVP[indexparts].xGridSnap + this.lspan, SumHeght(indexparts) + innerbar + topremark, innerbar + i * LVP[indexparts].xGridSnap + this.lspan, SumHeght(indexparts) + LVP[indexparts].dHeight - bmspan);
                strSliceText =( LVP[indexparts].Sindex + (i * unittime)).ToString("f2")  ;//当前轴线所表示的Y值：刻度数
                //g.TranslateTransform(this.XSpace + i * this.xGridSpan, /*this.YSliceBegin*/ this.ZeroL); //平移图像(原点)
                //g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                //g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(Color.Red /*SliceTextColor*/), 0, 0);
                //g.ResetTransform(); //重置图像 

                g.TranslateTransform(this.XSpace + this.lspan + i * LVP[indexparts].xGridSnap, SumHeght(indexparts) + LVP[indexparts].dHeight + FontSize/2  - bmspan); //平移图像(原点)
                g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
                g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(clrTextColor /*SliceTextColor*/), 0, 0);
                g.ResetTransform(); //重置图像 
            }
            if (this.Mousex != -1)
            {
                g.DrawLine(penDashed, this.Mousex, SumHeght(indexparts) + innerbar + this.topremark, this.Mousex, SumHeght(indexparts) + LVP[indexparts].dHeight -  bmspan );
                this.DrawTopRemark(indexparts);
            }
            #region 标注横轴坐标单位
            strSliceText =  LVP[indexparts].dbase.xName;
            g.TranslateTransform(this.Width - this.rspan, SumHeght(indexparts) + LVP[indexparts].dHeight - 1 * bmspan - FontSize); //平移图像(原点)
            g.RotateTransform(YRotateAngle, MatrixOrder.Prepend); //旋转图像
            g.DrawString(strSliceText, new Font("宋体", FontSize), new SolidBrush(clrTextColor /*SliceTextColor*/), 0, 0);
            g.ResetTransform();
            #endregion
            g.DrawLine(new Pen(BorderColor, 1), this.Width - this.rspan, SumHeght(indexparts) + innerbar + topremark, this.Width - this.rspan, SumHeght(indexparts) + LVP[indexparts].dHeight - bmspan);
            g.DrawLine(new Pen(BorderColor, 1), innerbar + this.lspan, SumHeght(indexparts) + innerbar + topremark, innerbar + this.lspan, SumHeght(indexparts) + LVP[indexparts].dHeight - bmspan);
            penDashed.Dispose();
        }
        /// <summary>
        /// 在分区中全屏绘制曲线
        /// </summary>
        /// <param name="indexparts"></param>
        public void DrawAllContent_ext(int indexparts)
        {
            Pen CurvePen = new Pen(clrsCurveColors, CurveSize);
            Pen CurvePen2 = new Pen(clrsCurveColorsb, CurveSize);
            GraphicsPath m_gp = new GraphicsPath();
            Brush mbrush = new LinearGradientBrush(new Rectangle(0, 0, this.barWidth, this.barWidth), Color.Green, Color.Green, LinearGradientMode.Horizontal);
            PointF[] CurvePointF = new PointF[LVP[indexparts].DisplayLen()];//.DrawDatalstPara[0].Count];//一系列连线坐标
            PointF[] CurvePointF2 = new PointF[LVP[indexparts].DisplayLen()];//.DrawDatalstPara[0].Count];//一系列连线坐标
            float keys = 0;
            float values = 0;
            m_gp.Reset();
            float unitv = Convert.ToSingle(this.Width - this.rspan - innerbar - this.lspan) / Convert.ToSingle(LVP[indexparts].DisplayLen());//每个点占用X轴的宽度 
            if (LVP[indexparts].DrawGroup != 1) //有两组数据需要进行比较
            {
                LVP[indexparts].videoValue.Clear();
                LVP[indexparts].videoValueb.Clear();
                for (int i = LVP[indexparts].Sindex; i < LVP[indexparts].DisplayLen(); i++)
                {
                    keys = unitv * i + XSpace + this.lspan;
                    // if (LVP[indexparts].DrawDatalstPara[0][i] > 0)
                    {
                        values = SumHeght(indexparts) + (LVP[indexparts].y_zeroHeght) - (float)(LVP[indexparts].DrawDatalstPara[0][i] / LVP[indexparts].y_ValuePerPixel);//此处是转换成像素坐标值,
                        CurvePointF[i] = new PointF(keys, values);

                        values = SumHeght(indexparts) + (LVP[indexparts].y_zeroHeght) - (float)(LVP[indexparts].DrawDatalstPara[1][i] / LVP[indexparts].y_ValuePerPixel);//此处是转换成像素坐标值,
                        CurvePointF2[i] = new PointF(keys, values);

                        VideoValue _VideoValue = new VideoValue(i, (float)(LVP[indexparts].DrawDatalstPara[0][i ]));
                        LVP[indexparts].videoValue[i] = _VideoValue;
                        _VideoValue = new VideoValue(i, (float)(LVP[indexparts].DrawDatalstPara[1][i]));
                        LVP[indexparts].videoValueb[i] = _VideoValue;
                    }


                }


                g.FillRegion(mbrush /*UnderBrush*/, new Region(m_gp));
                g.DrawLines(CurvePen, CurvePointF);
                g.DrawLines(CurvePen2, CurvePointF2);
            }
            else
            {
                LVP[indexparts].videoValue.Clear();
                for (int i = LVP[indexparts].Sindex; i < LVP[indexparts].DisplayLen(); i++)  //只有一组数据，只画第一组
                {
                    keys = unitv * i + XSpace + this.lspan;
                    // if (LVP[indexparts].DrawDatalstPara[0][i] > 0)
                    {
                        values = SumHeght(indexparts) + (LVP[indexparts].y_zeroHeght) - (float)(LVP[indexparts].DrawDatalstPara[0][i] / LVP[indexparts].y_ValuePerPixel);//此处是转换成像素坐标值,
                        CurvePointF[i] = new PointF(keys, values);
                    }
                    VideoValue _VideoValue = new VideoValue(i, (float)(LVP[indexparts].DrawDatalstPara[0][i]));
                    LVP[indexparts].videoValue[i] = _VideoValue;
                }
                g.FillRegion(mbrush /*UnderBrush*/, new Region(m_gp));
                g.DrawLines(CurvePen, CurvePointF);
            }
            mbrush.Dispose();
            CurvePen.Dispose();
            CurvePen2.Dispose();
        }
        
        #endregion

        #region 系统自己处理
        /// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}
       public void SaveBmp()
       {
         //  Bitmap bmp = new Bitmap(this.ChartPanel.Width, this.ChartPanel.Height);
           this.ChartPanel.DrawToBitmap(imgTemp,new Rectangle(0,0,this.ChartPanel.Width, this.ChartPanel.Height));
         //  bmp.Save("c:\\aa.jpg");
           imgTemp.Save("c:\\aa.jpg");
       }
        /// <summary>
        /// 绘制图形数据
        /// </summary>
		private void RecalculateSize()
		{
			if ((CurrentSize.Height != 0) && (CurrentSize.Width != 0)) //avoid divide by 0
			{
				g.Dispose();
                //imgTemp = new Bitmap(200, 200, ChartPanel.CreateGraphics());
                //g = Graphics.FromImage(imgTemp);
                g = ChartPanel.CreateGraphics();
				DrawChart();
			}
		}
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ChartPanel
            // 
            this.ChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartPanel.Location = new System.Drawing.Point(0, 0);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(289, 93);
            this.ChartPanel.TabIndex = 0;
            this.ChartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChartPanel_Paint);
            this.ChartPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChartPanel_MouseDown);
            this.ChartPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChartPanel_MouseMove);
            this.ChartPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ChartPanel_PreviewKeyDown);
            // 
            // MCADLine
            // 
            this.Controls.Add(this.ChartPanel);
            this.Name = "MCADLine";
            this.Size = new System.Drawing.Size(289, 93);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MCADLine_PreviewKeyDown);
            this.ResumeLayout(false);

		}
		#endregion
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (ChartPanel != null)
			{
				if ((Size.Height == 0) || (Size.Width == 0))	return;
				if ((CurrentSize.Height == 0) && (CurrentSize.Width == 0))
				{
					CurrentSize = Size;
					return;
				}
				RecalculateSize();
				CurrentSize = Size;
			}
		} 
		private void ChartPanel_Paint(object sender, PaintEventArgs e)
		{
			if (ChartPanel != null)
				OnResize(new EventArgs());
        }
        #endregion 
        private int Mousex = -1;
        private int OldMouseX = -1;
       /// <summary>
       /// 
       /// </summary>
        private float MouseLocation = -1f;
        private void ChartPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (exd)
            {
                if ((e.X >= XSpace + this.lspan) && (e.X <= (this.Width - this.rspan)))
                {
                    MouseLocation = 1f * (e.X - XSpace - this.lspan) / (this.Width - this.rspan - innerbar - this.lspan);
                    Mousex = e.X;
                    OldMouseX = e.X;
                    this.Refresh();
                    Mousex = -1;
                }
            }
            else
            {
               
            }
        }

        private void ChartPanel_MouseMove(object sender, MouseEventArgs e)
        {
           
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool br = false;
            // MessageBox.Show( keyData.ToString());
            switch (keyData)
            {//处理方向键
                case Keys.Right:
                    //this.Uk++;
                    br = true;
                    break;
                case Keys.Left:
                    //this.Uk--;
                    br = true;
                    break;

            }
            if (br)
            {
                this.Focus();
                return br;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void ChartPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            bool bm = false; 
            switch (e.KeyData)
            {
                case Keys.Up:
                    //point.Y -= 2;
                    break;
                case Keys.Down:
                    //point.Y += 2;
                    break;
                case Keys.Right:
                    OldMouseX += 1;
                    bm = true;
                    break;
                case Keys.Left:
                    OldMouseX -= 1;
                    bm = true;
                    break;
                case Keys.Escape:
                    //this.Close();
                    break;
                default: break;
            }
            if (bm)
            {


                if (exd)
                {
                    if ((OldMouseX >= XSpace + this.lspan) && (OldMouseX <= (this.Width - this.rspan)))
                    {
                        MouseLocation = 1f * (OldMouseX - XSpace - this.lspan) / (this.Width - this.rspan - innerbar - this.lspan);
                        Mousex = OldMouseX;
                        this.Refresh();
                        Mousex = -1;
                    }
                }
            }
          //  this.Location = point;
        }

        private void MCADLine_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            bool bm = false;
            switch (e.KeyData)
            {
                case Keys.Up:
                    //point.Y -= 2;
                    break;
                case Keys.Down:
                    //point.Y += 2;
                    break;
                case Keys.Right:
                    OldMouseX += 1;
                    bm = true;
                    break;
                case Keys.Left:
                    OldMouseX -= 1;
                    bm = true;
                    break;
                case Keys.Escape:
                    //this.Close();
                    break;
                default: break;
            }
            if (bm)
            {


                if (exd)
                {
                    if ((OldMouseX >= XSpace + this.lspan) && (OldMouseX <= (this.Width - this.rspan)))
                    {
                        MouseLocation = 1f * (OldMouseX - XSpace - this.lspan) / (this.Width - this.rspan - innerbar - this.lspan);
                        Mousex = OldMouseX;
                        this.Refresh();
                        Mousex = -1;
                    }
                }
            }
        }
    }	
	
}