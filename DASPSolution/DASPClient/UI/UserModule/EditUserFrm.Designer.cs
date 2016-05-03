namespace DASPClient.UI.UserModule
{
    partial class EditUserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserFrm));
            this.lblControl = new ZControls.ZLabelControl();
            this.txtLoginName = new DASP.ZControls.ZTextBox();
            this.lblUserName = new ZControls.ZLabelControl();
            this.txtUserName = new DASP.ZControls.ZTextBox();
            this.lblLoginPwd = new ZControls.ZLabelControl();
            this.txtLoginPwd = new DASP.ZControls.ZTextBox();
            this.lblTel = new ZControls.ZLabelControl();
            this.txtTel = new DASP.ZControls.ZTextBox();
            this.lblEmail = new ZControls.ZLabelControl();
            this.txtEmail = new DASP.ZControls.ZTextBox();
            this.lblAddress = new ZControls.ZLabelControl();
            this.txtAddress = new DASP.ZControls.ZTextBox();
            this.lblRemark = new ZControls.ZLabelControl();
            this.txtAreaRemark = new DASP.ZControls.ControlEx.TextBox.ZMultiTextBox();
            this.btnSave = new DASP.ZControls.ZButton();
            this.lblReqUserName = new ZControls.ZLabelControl();
            this.lblLoginName = new ZControls.ZLabelControl();
            this.lblPwd = new ZControls.ZLabelControl();
            this.reqValidName = new CommonUtil.Validators.RequiredFieldValidator();
            this.reqValidLoginName = new CommonUtil.Validators.RequiredFieldValidator();
            this.reqValidPwd = new CommonUtil.Validators.RequiredFieldValidator();
            this.zLabelControl1 = new ZControls.ZLabelControl();
            this.rdBtnAdmin = new DASP.ZControls.ZRadioButton();
            this.rdBtnNormal = new DASP.ZControls.ZRadioButton();
            this.formValid = new CommonUtil.Validators.FormValidator();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidLoginName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblControl
            // 
            this.lblControl.BackColor = System.Drawing.Color.Transparent;
            this.lblControl.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblControl.Location = new System.Drawing.Point(105, 109);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(60, 20);
            this.lblControl.TabIndex = 10;
            this.lblControl.Text = "登录名：";
            // 
            // txtLoginName
            // 
            this.txtLoginName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginName.EmptyTextTip = null;
            this.txtLoginName.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtLoginName.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtLoginName.Location = new System.Drawing.Point(187, 108);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(292, 23);
            this.txtLoginName.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserName.Location = new System.Drawing.Point(105, 57);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 20);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "姓   名：";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.EmptyTextTip = null;
            this.txtUserName.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtUserName.Location = new System.Drawing.Point(187, 53);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(292, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // lblLoginPwd
            // 
            this.lblLoginPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginPwd.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblLoginPwd.Location = new System.Drawing.Point(105, 161);
            this.lblLoginPwd.Name = "lblLoginPwd";
            this.lblLoginPwd.Size = new System.Drawing.Size(58, 20);
            this.lblLoginPwd.TabIndex = 11;
            this.lblLoginPwd.Text = "密   码：";
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPwd.EmptyTextTip = null;
            this.txtLoginPwd.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtLoginPwd.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtLoginPwd.Location = new System.Drawing.Point(187, 158);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.Size = new System.Drawing.Size(292, 23);
            this.txtLoginPwd.TabIndex = 3;
            // 
            // lblTel
            // 
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblTel.Location = new System.Drawing.Point(105, 218);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(54, 20);
            this.lblTel.TabIndex = 12;
            this.lblTel.Text = "电  话：";
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.EmptyTextTip = null;
            this.txtTel.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtTel.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtTel.Location = new System.Drawing.Point(187, 218);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(292, 23);
            this.txtTel.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(105, 271);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 20);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "邮  箱：";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.EmptyTextTip = null;
            this.txtEmail.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtEmail.Location = new System.Drawing.Point(187, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(105, 325);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 20);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "地  址：";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.EmptyTextTip = null;
            this.txtAddress.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtAddress.Location = new System.Drawing.Point(187, 325);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(292, 23);
            this.txtAddress.TabIndex = 6;
            // 
            // lblRemark
            // 
            this.lblRemark.BackColor = System.Drawing.Color.Transparent;
            this.lblRemark.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemark.Location = new System.Drawing.Point(105, 383);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(54, 20);
            this.lblRemark.TabIndex = 15;
            this.lblRemark.Text = "备  注：";
            // 
            // txtAreaRemark
            // 
            this.txtAreaRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAreaRemark.EmptyTextTip = null;
            this.txtAreaRemark.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtAreaRemark.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtAreaRemark.Location = new System.Drawing.Point(187, 381);
            this.txtAreaRemark.Multiline = true;
            this.txtAreaRemark.Name = "txtAreaRemark";
            this.txtAreaRemark.Size = new System.Drawing.Size(292, 62);
            this.txtAreaRemark.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.btnSave.Location = new System.Drawing.Point(187, 524);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblReqUserName
            // 
            this.lblReqUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblReqUserName.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblReqUserName.ForeColor = System.Drawing.Color.Red;
            this.lblReqUserName.Location = new System.Drawing.Point(504, 57);
            this.lblReqUserName.Name = "lblReqUserName";
            this.lblReqUserName.Size = new System.Drawing.Size(68, 20);
            this.lblReqUserName.TabIndex = 16;
            this.lblReqUserName.Text = "(*) 必填项";
            // 
            // lblLoginName
            // 
            this.lblLoginName.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginName.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblLoginName.ForeColor = System.Drawing.Color.Red;
            this.lblLoginName.Location = new System.Drawing.Point(504, 108);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(68, 20);
            this.lblLoginName.TabIndex = 17;
            this.lblLoginName.Text = "(*) 必填项";
            // 
            // lblPwd
            // 
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblPwd.ForeColor = System.Drawing.Color.Red;
            this.lblPwd.Location = new System.Drawing.Point(504, 158);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(68, 20);
            this.lblPwd.TabIndex = 18;
            this.lblPwd.Text = "(*) 必填项";
            // 
            // reqValidName
            // 
            this.reqValidName.ControlToValidate = this.txtUserName;
            this.reqValidName.ErrorMessage = "姓名不能为空！";
            this.reqValidName.Icon = ((System.Drawing.Icon)(resources.GetObject("reqValidName.Icon")));
            // 
            // reqValidLoginName
            // 
            this.reqValidLoginName.ControlToValidate = this.txtLoginName;
            this.reqValidLoginName.ErrorMessage = "登录名不能为空！";
            this.reqValidLoginName.Icon = ((System.Drawing.Icon)(resources.GetObject("reqValidLoginName.Icon")));
            // 
            // reqValidPwd
            // 
            this.reqValidPwd.ControlToValidate = this.txtLoginPwd;
            this.reqValidPwd.ErrorMessage = "密码不能为空！";
            this.reqValidPwd.Icon = ((System.Drawing.Icon)(resources.GetObject("reqValidPwd.Icon")));
            // 
            // zLabelControl1
            // 
            this.zLabelControl1.BackColor = System.Drawing.Color.Transparent;
            this.zLabelControl1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.zLabelControl1.Location = new System.Drawing.Point(105, 463);
            this.zLabelControl1.Name = "zLabelControl1";
            this.zLabelControl1.Size = new System.Drawing.Size(45, 20);
            this.zLabelControl1.TabIndex = 19;
            this.zLabelControl1.Text = "角  色:";
            // 
            // rdBtnAdmin
            // 
            this.rdBtnAdmin.AutoSize = true;
            this.rdBtnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rdBtnAdmin.Checked = true;
            this.rdBtnAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.rdBtnAdmin.Location = new System.Drawing.Point(187, 461);
            this.rdBtnAdmin.Name = "rdBtnAdmin";
            this.rdBtnAdmin.Size = new System.Drawing.Size(62, 21);
            this.rdBtnAdmin.TabIndex = 20;
            this.rdBtnAdmin.TabStop = true;
            this.rdBtnAdmin.Text = "管理员";
            this.rdBtnAdmin.UseVisualStyleBackColor = false;
            // 
            // rdBtnNormal
            // 
            this.rdBtnNormal.AutoSize = true;
            this.rdBtnNormal.BackColor = System.Drawing.Color.Transparent;
            this.rdBtnNormal.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.rdBtnNormal.Location = new System.Drawing.Point(265, 463);
            this.rdBtnNormal.Name = "rdBtnNormal";
            this.rdBtnNormal.Size = new System.Drawing.Size(74, 21);
            this.rdBtnNormal.TabIndex = 21;
            this.rdBtnNormal.TabStop = true;
            this.rdBtnNormal.Text = "普通用户";
            this.rdBtnNormal.UseVisualStyleBackColor = false;
            // 
            // formValid
            // 
            this.formValid.HostingForm = this;
            // 
            // EditUserFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(684, 559);
            this.Controls.Add(this.rdBtnNormal);
            this.Controls.Add(this.rdBtnAdmin);
            this.Controls.Add(this.zLabelControl1);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.lblReqUserName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAreaRemark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.lblLoginPwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.lblControl);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增用户";
            ((System.ComponentModel.ISupportInitialize)(this.reqValidName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidLoginName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZControls.ZLabelControl lblControl;
        private DASP.ZControls.ZTextBox txtLoginName;
        private ZControls.ZLabelControl lblUserName;
        private DASP.ZControls.ZTextBox txtUserName;
        private ZControls.ZLabelControl lblLoginPwd;
        private DASP.ZControls.ZTextBox txtLoginPwd;
        private ZControls.ZLabelControl lblTel;
        private DASP.ZControls.ZTextBox txtTel;
        private ZControls.ZLabelControl lblEmail;
        private DASP.ZControls.ZTextBox txtEmail;
        private ZControls.ZLabelControl lblAddress;
        private DASP.ZControls.ZTextBox txtAddress;
        private ZControls.ZLabelControl lblRemark;
        private DASP.ZControls.ControlEx.TextBox.ZMultiTextBox txtAreaRemark;
        private DASP.ZControls.ZButton btnSave;
        private ZControls.ZLabelControl lblReqUserName;
        private ZControls.ZLabelControl lblLoginName;
        private ZControls.ZLabelControl lblPwd;
        private CommonUtil.Validators.RequiredFieldValidator reqValidName;
        private CommonUtil.Validators.RequiredFieldValidator reqValidLoginName;
        private CommonUtil.Validators.RequiredFieldValidator reqValidPwd;
        private ZControls.ZLabelControl zLabelControl1;
        private DASP.ZControls.ZRadioButton rdBtnAdmin;
        private DASP.ZControls.ZRadioButton rdBtnNormal;
        private CommonUtil.Validators.FormValidator formValid;
    }
}