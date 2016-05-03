namespace DASPClient.UI.UserModule
{
    partial class ChangePasswordFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordFrm));
            this.lblProtoPwd = new ZControls.ZLabelControl();
            this.txtProtoPwd = new DASP.ZControls.ZTextBox();
            this.lblNewPwd = new ZControls.ZLabelControl();
            this.txtNewPwd = new DASP.ZControls.ZTextBox();
            this.lblAgainPwd = new ZControls.ZLabelControl();
            this.txtAgainPwd = new DASP.ZControls.ZTextBox();
            this.btnSave = new DASP.ZControls.ZButton();
            this.reqValidOldPwd = new CommonUtil.Validators.RequiredFieldValidator();
            this.reqValidNewPwd = new CommonUtil.Validators.RequiredFieldValidator();
            this.reqValidConPwd = new CommonUtil.Validators.RequiredFieldValidator();
            this.formValid = new CommonUtil.Validators.FormValidator();
            this.compareValid = new CommonUtil.Validators.CompareValidator();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidOldPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidNewPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidConPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compareValid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProtoPwd
            // 
            this.lblProtoPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblProtoPwd.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblProtoPwd.Location = new System.Drawing.Point(91, 80);
            this.lblProtoPwd.Name = "lblProtoPwd";
            this.lblProtoPwd.Size = new System.Drawing.Size(60, 20);
            this.lblProtoPwd.TabIndex = 5;
            this.lblProtoPwd.Text = "旧密码：";
            // 
            // txtProtoPwd
            // 
            this.txtProtoPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProtoPwd.EmptyTextTip = null;
            this.txtProtoPwd.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtProtoPwd.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtProtoPwd.Location = new System.Drawing.Point(182, 76);
            this.txtProtoPwd.Name = "txtProtoPwd";
            this.txtProtoPwd.Size = new System.Drawing.Size(273, 23);
            this.txtProtoPwd.TabIndex = 1;
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPwd.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblNewPwd.Location = new System.Drawing.Point(91, 120);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(60, 20);
            this.lblNewPwd.TabIndex = 6;
            this.lblNewPwd.Text = "新密码：";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPwd.EmptyTextTip = null;
            this.txtNewPwd.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtNewPwd.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtNewPwd.Location = new System.Drawing.Point(182, 116);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(273, 23);
            this.txtNewPwd.TabIndex = 2;
            // 
            // lblAgainPwd
            // 
            this.lblAgainPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblAgainPwd.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblAgainPwd.Location = new System.Drawing.Point(64, 162);
            this.lblAgainPwd.Name = "lblAgainPwd";
            this.lblAgainPwd.Size = new System.Drawing.Size(87, 20);
            this.lblAgainPwd.TabIndex = 7;
            this.lblAgainPwd.Text = "确认新密码：";
            // 
            // txtAgainPwd
            // 
            this.txtAgainPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgainPwd.EmptyTextTip = null;
            this.txtAgainPwd.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtAgainPwd.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtAgainPwd.Location = new System.Drawing.Point(182, 162);
            this.txtAgainPwd.Name = "txtAgainPwd";
            this.txtAgainPwd.Size = new System.Drawing.Size(273, 23);
            this.txtAgainPwd.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.btnSave.Location = new System.Drawing.Point(182, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // reqValidOldPwd
            // 
            this.reqValidOldPwd.ControlToValidate = this.txtProtoPwd;
            this.reqValidOldPwd.ErrorMessage = "旧密码不能为空！";
            this.reqValidOldPwd.Icon = ((System.Drawing.Icon)(resources.GetObject("reqValidOldPwd.Icon")));
            // 
            // reqValidNewPwd
            // 
            this.reqValidNewPwd.ControlToValidate = this.txtNewPwd;
            this.reqValidNewPwd.ErrorMessage = "新密码不能为空！";
            this.reqValidNewPwd.Icon = ((System.Drawing.Icon)(resources.GetObject("reqValidNewPwd.Icon")));
            // 
            // reqValidConPwd
            // 
            this.reqValidConPwd.ControlToValidate = this.txtAgainPwd;
            this.reqValidConPwd.ErrorMessage = "确认新密码不能为空！";
            this.reqValidConPwd.Icon = ((System.Drawing.Icon)(resources.GetObject("reqValidConPwd.Icon")));
            // 
            // formValid
            // 
            this.formValid.HostingForm = this;
            // 
            // compareValid
            // 
            this.compareValid.ControlToCompare = this.txtNewPwd;
            this.compareValid.ControlToValidate = this.txtAgainPwd;
            this.compareValid.ErrorMessage = "两次输入的密码不一致！";
            this.compareValid.Icon = ((System.Drawing.Icon)(resources.GetObject("compareValid.Icon")));
            this.compareValid.Operator = CommonUtil.Validators.ValidationCompareOperator.Equal;
            // 
            // ChangePasswordFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 273);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAgainPwd);
            this.Controls.Add(this.lblAgainPwd);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.txtProtoPwd);
            this.Controls.Add(this.lblProtoPwd);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordFrm";
            this.Text = "修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.reqValidOldPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidNewPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidConPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compareValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZControls.ZLabelControl lblProtoPwd;
        private DASP.ZControls.ZTextBox txtProtoPwd;
        private ZControls.ZLabelControl lblNewPwd;
        private DASP.ZControls.ZTextBox txtNewPwd;
        private ZControls.ZLabelControl lblAgainPwd;
        private DASP.ZControls.ZTextBox txtAgainPwd;
        private DASP.ZControls.ZButton btnSave;
        private CommonUtil.Validators.RequiredFieldValidator reqValidOldPwd;
        private CommonUtil.Validators.RequiredFieldValidator reqValidNewPwd;
        private CommonUtil.Validators.RequiredFieldValidator reqValidConPwd;
        private CommonUtil.Validators.FormValidator formValid;
        private CommonUtil.Validators.CompareValidator compareValid;
    }
}