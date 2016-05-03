using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DASP.ZControls;
using System.Drawing.Drawing2D;

namespace DASPTool
{
    public partial class InitToolFrm : FormEx
    {
        public InitToolFrm()
            : base()
        {
            InitializeComponent();
        }

        private void InitToolFrm_Load(object sender, EventArgs e)
        {
            //居中显示
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2;

            this.txtDBName.Focus();
        }


        #region Override

        /// <summary>
        /// 修改样式
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (!DesignMode)
                {
                    cp.ExStyle |= (int)WindowStyle.WS_CLIPCHILDREN;
                }
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawFromAlphaMainPart(this, e.Graphics);
        }

        #endregion

        #region Private

        /// <summary>
        /// 绘制窗体主体部分白色透明层
        /// </summary>
        /// <param name="form"></param>
        /// <param name="g"></param>
        public static void DrawFromAlphaMainPart(Form form, Graphics g)
        {
            Color[] colors = 
            {
                Color.FromArgb(5, Color.White),
                Color.FromArgb(30, Color.White),
                Color.FromArgb(145, Color.White),
                Color.FromArgb(150, Color.White),
                Color.FromArgb(30, Color.White),
                Color.FromArgb(5, Color.White)
            };

            float[] pos = 
            {
                0.0f,
                0.04f,
                0.10f,
                0.90f,
                0.97f,
                1.0f      
            };

            ColorBlend colorBlend = new ColorBlend(6);
            colorBlend.Colors = colors;
            colorBlend.Positions = pos;

            RectangleF destRect = new RectangleF(0, 0, form.Width, form.Height);
            using (LinearGradientBrush lBrush = new LinearGradientBrush(destRect, colors[0], colors[5], LinearGradientMode.Vertical))
            {
                lBrush.InterpolationColors = colorBlend;
                g.FillRectangle(lBrush, destRect);
            }
        }

        /// <summary>
        /// 更新布局样式
        /// </summary>
        private void SetStyles()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();
        }

        #endregion

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            if (formValid.IsValid)
            {
                bool canSuccess = false;
                try
                {
                    string dbName = txtDBName.Text.Trim();
                    MSSqlUtils.CreateDB(dbName);
                    canSuccess = true;
                }
                catch (Exception ex)
                {
                    ZMessageBox.Show(this,ex.Message,"提示",ZMessageBoxIcon.Error,ZMessageBoxButtons.OK);                    
                }

                if (canSuccess)
                {
                    ZMessageBox.Show(this, "数据库创建成功！", "提示", ZMessageBoxIcon.Information, ZMessageBoxButtons.OK);
                }
            }
        }

        private void btnCreateInit_Click(object sender, EventArgs e)
        {
            /**
             * 
             * 初始化系统角色
             * 
             */ 


        }
    }
}
