using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DASP.ZControls
{

    /// <summary>
    /// 透明的加载等待层
    /// </summary>
    [ToolboxBitmap(typeof(ZLoadingPanel))]
    public class ZLoadingPanel : System.Windows.Forms.Control
    {
        /// <summary>
        /// 是否背景透明
        /// </summary>
        private bool _transparentBG = true;

        /// <summary>
        /// 透明度
        /// </summary>
        private int _alpha = 125;

        /// <summary>
        /// 字体画刷
        /// </summary>
        private SolidBrush fontBrush = new SolidBrush(Color.FromArgb(206, 94, 94, 94));

        /// <summary>
        /// 容器组件
        /// </summary>
        private System.ComponentModel.Container components = new System.ComponentModel.Container();

        /// <summary>
        /// 构造函数
        /// </summary>
        public ZLoadingPanel() : this(true) { }


        /// <summary>
        /// 标准构造函数
        /// </summary>
        /// <param name="Alpha"></param>
        /// <param name="showLoadingImage"></param>
        public ZLoadingPanel(bool showLoadingImage)
        {
            // | ControlStyles.OptimizedDoubleBuffer AllPaintingInWmPaint
            SetStyle(ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

            base.CreateControl();

            // 显示等待的图像
            if (showLoadingImage)
            {
                PictureBox pictureBox_Loading = new PictureBox();
                pictureBox_Loading.BackColor = System.Drawing.Color.White;
                pictureBox_Loading.Image = RenderControlUtils.GetImageFormResourceStream("Resources.loading.gif");
                pictureBox_Loading.Name = "pictureBox_Loading";
                pictureBox_Loading.Size = new System.Drawing.Size(48, 48);
                pictureBox_Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                Point Location = new Point(this.Location.X + (this.Width - pictureBox_Loading.Width) / 2,
                    this.Location.Y + (this.Height - pictureBox_Loading.Height) / 2);//居中
                pictureBox_Loading.Location = Location;
                pictureBox_Loading.Anchor = AnchorStyles.None;
                this.Controls.Add(pictureBox_Loading);

                Invalidate();
            }
        }

        /// <summary>
        /// 析构处理
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!((components == null)))
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// 自定义绘制窗体
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            float vlblControlWidth;
            float vlblControlHeight;

            Pen labelBorderPen;
            SolidBrush labelBackColorBrush;

            if (_transparentBG)
            {
                Color drawColor = Color.FromArgb(this._alpha, this.BackColor);
                labelBorderPen = new Pen(drawColor, 0);
                labelBackColorBrush = new SolidBrush(drawColor);
            }
            else
            {
                labelBorderPen = new Pen(this.BackColor, 0);
                labelBackColorBrush = new SolidBrush(this.BackColor);
            }
            vlblControlWidth = this.Size.Width;
            vlblControlHeight = this.Size.Height;
            e.Graphics.DrawRectangle(labelBorderPen, 0, 0, vlblControlWidth, vlblControlHeight);
            e.Graphics.FillRectangle(labelBackColorBrush, 0, 0, vlblControlWidth, vlblControlHeight);
            string loadContent = this.Text.Trim();
            if (string.IsNullOrEmpty(loadContent))
            {
                e.Graphics.DrawString("正在加载...", new Font("Microsoft YaHei", 10, FontStyle.Bold), fontBrush, vlblControlWidth / 2 + 25, vlblControlHeight / 2 - 10);
            }
            else
            {
                e.Graphics.DrawString(loadContent, new Font("Microsoft YaHei", 10, FontStyle.Bold), fontBrush, vlblControlWidth / 2 + 25, vlblControlHeight / 2 - 10);
            }

            base.OnPaint(e);
        }

        ///// <summary>
        ///// 控件透明特性
        ///// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_TRANSPARENT = 0x00000020;
                CreateParams cp = base.CreateParams;
                // 开启 WS_EX_TRANSPARENT,使控件支持透明
                cp.ExStyle |= WS_EX_TRANSPARENT;
                return cp;
            }
        }

        /// <summary>
        /// 是否使用透明
        /// </summary>
        [Category("AlphaOpaque"), Description("是否使用透明,默认为True")]
        public bool TransparentBG
        {
            get { return _transparentBG; }
            set
            {
                _transparentBG = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// 设置透明度
        /// </summary>
        [Category("AlphaOpaque"), Description("设置透明度")]
        public int Alpha
        {
            get { return _alpha; }
            set
            {
                _alpha = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// 隐藏处理
        /// </summary>
        public void CloseWaitingPanel()
        {
            this.BeginInvoke(new Action(() =>
            {
                SendToBack();
                Hide();

            }));
        }

        /// <summary>
        /// 显示处理
        /// </summary>
        public void ShowWaitingPanel()
        {
            this.BeginInvoke(new Action(() =>
            {
                BringToFront();
                this.Dock = DockStyle.Fill;
                Show();

                Refresh();
                Invalidate();
            }));
        }
    }
}
