namespace DASPClient.UI.DataModule
{
    partial class EditProjectFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProjectFrm));
            this.lblProjectName = new ZControls.ZLabelControl();
            this.txtProjectName = new DASP.ZControls.ZTextBox();
            this.lblProjectDate = new ZControls.ZLabelControl();
            this.txtProjectDate = new DASP.ZControls.ZTextBox();
            this.lblProjectLeader = new ZControls.ZLabelControl();
            this.txtProjectLeader = new DASP.ZControls.ZTextBox();
            this.lblProjectRemark = new ZControls.ZLabelControl();
            this.txtProjectRemark = new DASP.ZControls.ControlEx.TextBox.ZMultiTextBox();
            this.btnSave = new DASP.ZControls.ZButton();
            this.reqValidProjectName = new CommonUtil.Validators.RequiredFieldValidator();
            this.reqValidProjectDate = new CommonUtil.Validators.RequiredFieldValidator();
            this.formValid = new CommonUtil.Validators.FormValidator();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidProjectName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidProjectDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblProjectName.Location = new System.Drawing.Point(124, 63);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(74, 20);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "合同名称：";
            // 
            // txtProjectName
            // 
            this.txtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProjectName.EmptyTextTip = null;
            this.txtProjectName.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtProjectName.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtProjectName.Location = new System.Drawing.Point(206, 59);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(267, 23);
            this.txtProjectName.TabIndex = 1;
            // 
            // lblProjectDate
            // 
            this.lblProjectDate.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectDate.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblProjectDate.Location = new System.Drawing.Point(124, 115);
            this.lblProjectDate.Name = "lblProjectDate";
            this.lblProjectDate.Size = new System.Drawing.Size(74, 20);
            this.lblProjectDate.TabIndex = 2;
            this.lblProjectDate.Text = "合同时间：";
            // 
            // txtProjectDate
            // 
            this.txtProjectDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProjectDate.EmptyTextTip = null;
            this.txtProjectDate.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtProjectDate.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtProjectDate.Location = new System.Drawing.Point(206, 115);
            this.txtProjectDate.Name = "txtProjectDate";
            this.txtProjectDate.Size = new System.Drawing.Size(267, 23);
            this.txtProjectDate.TabIndex = 3;
            // 
            // lblProjectLeader
            // 
            this.lblProjectLeader.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectLeader.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblProjectLeader.Location = new System.Drawing.Point(124, 168);
            this.lblProjectLeader.Name = "lblProjectLeader";
            this.lblProjectLeader.Size = new System.Drawing.Size(76, 20);
            this.lblProjectLeader.TabIndex = 4;
            this.lblProjectLeader.Text = "责  任  人：";
            // 
            // txtProjectLeader
            // 
            this.txtProjectLeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProjectLeader.EmptyTextTip = null;
            this.txtProjectLeader.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtProjectLeader.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtProjectLeader.Location = new System.Drawing.Point(206, 164);
            this.txtProjectLeader.Name = "txtProjectLeader";
            this.txtProjectLeader.Size = new System.Drawing.Size(267, 23);
            this.txtProjectLeader.TabIndex = 5;
            // 
            // lblProjectRemark
            // 
            this.lblProjectRemark.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectRemark.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblProjectRemark.Location = new System.Drawing.Point(124, 216);
            this.lblProjectRemark.Name = "lblProjectRemark";
            this.lblProjectRemark.Size = new System.Drawing.Size(71, 20);
            this.lblProjectRemark.TabIndex = 6;
            this.lblProjectRemark.Text = "备      注：";
            // 
            // txtProjectRemark
            // 
            this.txtProjectRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProjectRemark.EmptyTextTip = null;
            this.txtProjectRemark.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtProjectRemark.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtProjectRemark.Location = new System.Drawing.Point(206, 216);
            this.txtProjectRemark.Multiline = true;
            this.txtProjectRemark.Name = "txtProjectRemark";
            this.txtProjectRemark.Size = new System.Drawing.Size(267, 98);
            this.txtProjectRemark.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.btnSave.Location = new System.Drawing.Point(206, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // reqValidProjectName
            // 
            this.reqValidProjectName.ControlToValidate = this.txtProjectName;
            this.reqValidProjectName.ErrorMessage = "合同名称不能为空！";
            this.reqValidProjectName.Icon = ((System.Drawing.Icon)(resources.GetObject("reqValidProjectName.Icon")));
            // 
            // reqValidProjectDate
            // 
            this.reqValidProjectDate.ControlToValidate = this.txtProjectDate;
            this.reqValidProjectDate.ErrorMessage = "合同时间不能为空！";
            this.reqValidProjectDate.Icon = ((System.Drawing.Icon)(resources.GetObject("reqValidProjectDate.Icon")));
            // 
            // formValid
            // 
            this.formValid.HostingForm = this;
            // 
            // EditProjectFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 402);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProjectRemark);
            this.Controls.Add(this.lblProjectRemark);
            this.Controls.Add(this.txtProjectLeader);
            this.Controls.Add(this.lblProjectLeader);
            this.Controls.Add(this.txtProjectDate);
            this.Controls.Add(this.lblProjectDate);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblProjectName);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProjectFrm";
            this.Text = "新增合同";
            ((System.ComponentModel.ISupportInitialize)(this.reqValidProjectName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidProjectDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZControls.ZLabelControl lblProjectName;
        private DASP.ZControls.ZTextBox txtProjectName;
        private ZControls.ZLabelControl lblProjectDate;
        private DASP.ZControls.ZTextBox txtProjectDate;
        private ZControls.ZLabelControl lblProjectLeader;
        private DASP.ZControls.ZTextBox txtProjectLeader;
        private ZControls.ZLabelControl lblProjectRemark;
        private DASP.ZControls.ControlEx.TextBox.ZMultiTextBox txtProjectRemark;
        private DASP.ZControls.ZButton btnSave;
        private CommonUtil.Validators.RequiredFieldValidator reqValidProjectName;
        private CommonUtil.Validators.RequiredFieldValidator reqValidProjectDate;
        private CommonUtil.Validators.FormValidator formValid;
    }
}