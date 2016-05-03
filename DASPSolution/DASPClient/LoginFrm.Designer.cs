namespace DASPClient
{
    partial class LoginFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.zLabelControl1 = new ZControls.ZLabelControl();
            this.zLabelControl2 = new ZControls.ZLabelControl();
            this.txtLoginName = new DASP.ZControls.ZTextBox();
            this.txtLoginPwd = new DASP.ZControls.ZTextBox();
            this.btnSubmit = new DASP.ZControls.ZButton();
            this.reqFieldValidName = new CommonUtil.Validators.RequiredFieldValidator();
            this.reqFieldValidPwd = new CommonUtil.Validators.RequiredFieldValidator();
            this.formValid = new CommonUtil.Validators.FormValidator();
            this.btnSettingDB = new DASP.ZControls.ZButton();
            ((System.ComponentModel.ISupportInitialize)(this.reqFieldValidName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqFieldValidPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).BeginInit();
            this.SuspendLayout();
            // 
            // zLabelControl1
            // 
            this.zLabelControl1.BackColor = System.Drawing.Color.Transparent;
            this.zLabelControl1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.zLabelControl1.Location = new System.Drawing.Point(93, 92);
            this.zLabelControl1.Name = "zLabelControl1";
            this.zLabelControl1.Size = new System.Drawing.Size(60, 20);
            this.zLabelControl1.TabIndex = 4;
            this.zLabelControl1.Text = "用户名：";
            // 
            // zLabelControl2
            // 
            this.zLabelControl2.BackColor = System.Drawing.Color.Transparent;
            this.zLabelControl2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.zLabelControl2.Location = new System.Drawing.Point(93, 194);
            this.zLabelControl2.Name = "zLabelControl2";
            this.zLabelControl2.Size = new System.Drawing.Size(58, 20);
            this.zLabelControl2.TabIndex = 5;
            this.zLabelControl2.Text = "密   码：";
            // 
            // txtLoginName
            // 
            this.txtLoginName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginName.EmptyTextTip = null;
            this.txtLoginName.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtLoginName.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtLoginName.Location = new System.Drawing.Point(177, 88);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(270, 23);
            this.txtLoginName.TabIndex = 0;
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPwd.EmptyTextTip = null;
            this.txtLoginPwd.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtLoginPwd.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtLoginPwd.Location = new System.Drawing.Point(177, 194);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(270, 23);
            this.txtLoginPwd.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.btnSubmit.Location = new System.Drawing.Point(177, 276);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(182, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "登录";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // reqFieldValidName
            // 
            this.reqFieldValidName.ControlToValidate = this.txtLoginName;
            this.reqFieldValidName.ErrorMessage = "用户名不能为空";
            this.reqFieldValidName.Icon = ((System.Drawing.Icon)(resources.GetObject("reqFieldValidName.Icon")));
            // 
            // reqFieldValidPwd
            // 
            this.reqFieldValidPwd.ControlToValidate = this.txtLoginPwd;
            this.reqFieldValidPwd.ErrorMessage = "密码不能为空";
            this.reqFieldValidPwd.Icon = ((System.Drawing.Icon)(resources.GetObject("reqFieldValidPwd.Icon")));
            // 
            // formValid
            // 
            this.formValid.HostingForm = this;
            // 
            // btnSettingDB
            // 
            this.btnSettingDB.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.btnSettingDB.Location = new System.Drawing.Point(28, 357);
            this.btnSettingDB.Name = "btnSettingDB";
            this.btnSettingDB.Size = new System.Drawing.Size(68, 23);
            this.btnSettingDB.TabIndex = 3;
            this.btnSettingDB.Text = "设置数据库";
            this.btnSettingDB.UseVisualStyleBackColor = true;
            this.btnSettingDB.Click += new System.EventHandler(this.btnSettingDB_Click);
            // 
            // LoginFrm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(562, 392);
            this.Controls.Add(this.btnSettingDB);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.zLabelControl2);
            this.Controls.Add(this.zLabelControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reqFieldValidName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqFieldValidPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZControls.ZLabelControl zLabelControl1;
        private ZControls.ZLabelControl zLabelControl2;
        private DASP.ZControls.ZTextBox txtLoginName;
        private DASP.ZControls.ZTextBox txtLoginPwd;
        private DASP.ZControls.ZButton btnSubmit;
        private CommonUtil.Validators.RequiredFieldValidator reqFieldValidName;
        private CommonUtil.Validators.RequiredFieldValidator reqFieldValidPwd;
        private CommonUtil.Validators.FormValidator formValid;
        private DASP.ZControls.ZButton btnSettingDB;
    }
}