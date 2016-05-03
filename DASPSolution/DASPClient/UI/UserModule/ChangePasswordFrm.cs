using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DASP.ZControls;
using DASP.Tools;
using DASP.Business.IManager;

namespace DASPClient.UI.UserModule
{
    public partial class ChangePasswordFrm : BaseFrm
    {

        ITBUserManager userManager;

        public ChangePasswordFrm()
            :base()
        {
            InitializeComponent();
            this.Load += new EventHandler(ChangePasswordFrm_Load);
        }

        void ChangePasswordFrm_Load(object sender, EventArgs e)
        {
            //居中显示
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2;

            userManager  = DASPClient.Utility.SpringUtils.Context.GetObject("UserManager") as ITBUserManager;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (formValid.IsValid)
            {
                DASP.Domain.Entitys.TBUserEntity curUser = Global.UserInfoInstance.CurrentLoginUser;
                string oldPwd = EncryptUtils.EncryptFromInputString(txtProtoPwd.Text.Trim());
                if (!curUser.UserPassword.Equals(oldPwd))
                {
                    ZMessageBox.Show(this, "旧密码输入错误！", "提示", ZMessageBoxIcon.Information,
                        ZMessageBoxButtons.OK);
                    this.DialogResult = DialogResult.None;
                    return;
                }

                curUser.UserPassword = EncryptUtils.EncryptFromInputString(txtNewPwd.Text.Trim());

                try
                {
                    userManager.Update(curUser);
                    ZMessageBox.Show(this, "修改密码成功！", "提示", ZMessageBoxIcon.Information,
                        ZMessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
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
