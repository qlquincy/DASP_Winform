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
using DASP.Business.IManager;
using DASP.Tools;

namespace DASPClient.UI.UserModule
{
    public partial class EditUserFrm : BaseFrm
    {
        ITBUserManager userManager;
        ITBRoleManager roleManager;
        DASP.Domain.Entitys.TBUserEntity userEntity;

        public EditUserFrm()
            :base()
        {
            InitializeComponent();
            this.Load += new EventHandler(EditUserFrm_Load);
        }

        public EditUserFrm(DASP.Domain.Entitys.TBUserEntity userEntity)
            :this()
        {
            this.userEntity = userEntity;
        }

        void EditUserFrm_Load(object sender, EventArgs e)
        {
            //居中显示
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2;

            userManager = DASPClient.Utility.SpringUtils.Context.GetObject("UserManager") as ITBUserManager;

            roleManager = DASPClient.Utility.SpringUtils.Context.GetObject("RoleManager") as ITBRoleManager;

            LoadData(this.userEntity);
        }

        void LoadData(DASP.Domain.Entitys.TBUserEntity userEntity)
        {
            if (null != userEntity)
            {
                txtUserName.Text = userEntity.UserName;
                txtLoginName.Text = userEntity.LoginName;
                txtLoginName.Enabled = false;
                txtLoginPwd.Text = userEntity.UserPassword;
                txtLoginPwd.Enabled = false;

                txtTel.Text = userEntity.UserTel;
                txtEmail.Text = userEntity.UserEmail;
                txtAddress.Text = userEntity.UserAddress;
                txtAreaRemark.Text = userEntity.UserRemark;

                if (userEntity.Role != null)
                {
                    if (userEntity.Role.RoleCode.Equals("0001"))
                    {
                        rdBtnAdmin.Checked = true;
                    }

                    if (userEntity.Role.RoleCode.Equals("0002"))
                    {
                        rdBtnNormal.Checked = true;
                    }
                }
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (formValid.IsValid)
            {
                try
                {
                    DASP.Domain.Entitys.TBUserEntity entity = null;
                    bool isUpdate = false;
                    if (this.userEntity != null)
                    {
                        entity = this.userEntity;
                        isUpdate = true;
                    }
                    else
                    { 
                        entity = new DASP.Domain.Entitys.TBUserEntity();
                        entity.UserId = Guid.NewGuid();
                        entity.CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        isUpdate = false;
                    }

                    string userName = txtUserName.Text.Trim();
                    string loginName = txtLoginName.Text.Trim();
                    string loginPwd = EncryptUtils.EncryptFromInputString(txtLoginPwd.Text.Trim());
                    string userRemark = txtAreaRemark.Text.Trim();
                    
                   
                    entity.UserName = userName;
                    entity.LoginName = loginName;
                    entity.UserPassword = loginPwd;
                    entity.UserRemark = userRemark;
                    entity.UserEmail = txtEmail.Text.Trim();
                    entity.UserAddress = txtAddress.Text.Trim();
                    entity.UserTel = txtTel.Text.Trim();
                    entity.UpdateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    IList<DASP.Domain.Entitys.TBRoleEntity> roleList = roleManager.GetAll();

                    if (rdBtnAdmin.Checked)
                    {
                        var role = roleList.Where(it => it.RoleCode.Equals("0001")).FirstOrDefault();
                        entity.Role = role;
                    }
                    else
                    {
                        var role = roleList.Where(it => it.RoleCode.Equals("0002")).FirstOrDefault();
                        entity.Role = role;
                    }
                    if (isUpdate)
                    {
                        userManager.Update(entity);
                    }
                    else
                    {
                        userManager.Save(entity);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
