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
using DASP.Tools;
using DASP.Business.IManager;
using DASP.Domain.Entitys;

namespace DASPClient
{
    public partial class LoginFrm : BaseFrm
    {
        ITBUserManager userManager = null;

        public DASP.Domain.Entitys.TBUserEntity CurrentLoginUser
        {
            get;
            private set;
        }

        public LoginFrm() :
            base()
        {
            InitializeComponent();
           
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            //居中显示
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2;

            userManager = DASPClient.Utility.SpringUtils.Context.GetObject("UserManager") as ITBUserManager;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (formValid.IsValid)
            {
                string loginName = txtLoginName.Text.Trim();
                string loginPwd = EncryptUtils.EncryptFromInputString(txtLoginPwd.Text.Trim());
                TBUserEntity entity = userManager.GetUserByLoginName(loginName);
                if (null == entity)
                {
                    ZMessageBox.Show(this, "用户不存在,请联系管理员！", "提示", ZMessageBoxIcon.Information,
                        ZMessageBoxButtons.OK);
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    if (entity.UserPassword.Equals(loginPwd))
                    {
                        ZMessageBox.Show(this, "登录成功！", "提示", ZMessageBoxIcon.Information,
                            ZMessageBoxButtons.OK);
                        this.CurrentLoginUser = entity;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        ZMessageBox.Show(this, "密码错误,请重新输入！", "提示", ZMessageBoxIcon.Information, 
                            ZMessageBoxButtons.OK);
                        this.DialogResult = DialogResult.None;
                    }
                }
            }
        }

        private void btnSettingDB_Click(object sender, EventArgs e)
        {
            SettingFrm settingFrm = new SettingFrm();
            settingFrm.ShowDialog();
        }
    }
}
