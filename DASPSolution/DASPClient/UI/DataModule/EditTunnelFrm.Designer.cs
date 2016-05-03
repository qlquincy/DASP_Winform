namespace DASPClient.UI.DataModule
{
    partial class EditTunnelFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTunnelFrm));
            this.lblTunnelName = new ZControls.ZLabelControl();
            this.txtTunnelName = new DASP.ZControls.ZTextBox();
            this.lblStartDate = new ZControls.ZLabelControl();
            this.txtStartDate = new DASP.ZControls.ZTextBox();
            this.lblEndDate = new ZControls.ZLabelControl();
            this.txtEndDate = new DASP.ZControls.ZTextBox();
            this.lblLeader = new ZControls.ZLabelControl();
            this.txtLeader = new DASP.ZControls.ZTextBox();
            this.lblSelectProject = new ZControls.ZLabelControl();
            this.cboBoxProject = new System.Windows.Forms.ComboBox();
            this.lblRemark = new ZControls.ZLabelControl();
            this.txtRemark = new DASP.ZControls.ControlEx.TextBox.ZMultiTextBox();
            this.btnSave = new DASP.ZControls.ZButton();
            this.reqValid = new CommonUtil.Validators.RequiredFieldValidator();
            this.formValid = new CommonUtil.Validators.FormValidator();
            this.cusValid = new CommonUtil.Validators.CustomValidator();
            ((System.ComponentModel.ISupportInitialize)(this.reqValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTunnelName
            // 
            this.lblTunnelName.BackColor = System.Drawing.Color.Transparent;
            this.lblTunnelName.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblTunnelName.Location = new System.Drawing.Point(141, 53);
            this.lblTunnelName.Name = "lblTunnelName";
            this.lblTunnelName.Size = new System.Drawing.Size(74, 20);
            this.lblTunnelName.TabIndex = 7;
            this.lblTunnelName.Text = "隧道名称：";
            // 
            // txtTunnelName
            // 
            this.txtTunnelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTunnelName.EmptyTextTip = null;
            this.txtTunnelName.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtTunnelName.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtTunnelName.Location = new System.Drawing.Point(239, 50);
            this.txtTunnelName.Name = "txtTunnelName";
            this.txtTunnelName.Size = new System.Drawing.Size(213, 23);
            this.txtTunnelName.TabIndex = 0;
            // 
            // lblStartDate
            // 
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.Location = new System.Drawing.Point(141, 98);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(74, 20);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "开始时间：";
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartDate.EmptyTextTip = null;
            this.txtStartDate.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtStartDate.Location = new System.Drawing.Point(239, 98);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(213, 23);
            this.txtStartDate.TabIndex = 1;
            // 
            // lblEndDate
            // 
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.Location = new System.Drawing.Point(141, 152);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(74, 20);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "结束时间：";
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndDate.EmptyTextTip = null;
            this.txtEndDate.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtEndDate.Location = new System.Drawing.Point(239, 149);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(213, 23);
            this.txtEndDate.TabIndex = 2;
            // 
            // lblLeader
            // 
            this.lblLeader.BackColor = System.Drawing.Color.Transparent;
            this.lblLeader.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblLeader.Location = new System.Drawing.Point(141, 198);
            this.lblLeader.Name = "lblLeader";
            this.lblLeader.Size = new System.Drawing.Size(60, 20);
            this.lblLeader.TabIndex = 10;
            this.lblLeader.Text = "责任人：";
            // 
            // txtLeader
            // 
            this.txtLeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLeader.EmptyTextTip = null;
            this.txtLeader.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtLeader.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtLeader.Location = new System.Drawing.Point(239, 194);
            this.txtLeader.Name = "txtLeader";
            this.txtLeader.Size = new System.Drawing.Size(213, 23);
            this.txtLeader.TabIndex = 3;
            // 
            // lblSelectProject
            // 
            this.lblSelectProject.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectProject.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectProject.Location = new System.Drawing.Point(141, 259);
            this.lblSelectProject.Name = "lblSelectProject";
            this.lblSelectProject.Size = new System.Drawing.Size(74, 20);
            this.lblSelectProject.TabIndex = 11;
            this.lblSelectProject.Text = "选择合同：";
            // 
            // cboBoxProject
            // 
            this.cboBoxProject.FormattingEnabled = true;
            this.cboBoxProject.Location = new System.Drawing.Point(239, 258);
            this.cboBoxProject.Name = "cboBoxProject";
            this.cboBoxProject.Size = new System.Drawing.Size(213, 20);
            this.cboBoxProject.TabIndex = 4;
            // 
            // lblRemark
            // 
            this.lblRemark.BackColor = System.Drawing.Color.Transparent;
            this.lblRemark.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemark.Location = new System.Drawing.Point(141, 314);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(75, 20);
            this.lblRemark.TabIndex = 12;
            this.lblRemark.Text = "备       注：";
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.EmptyTextTip = null;
            this.txtRemark.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtRemark.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtRemark.Location = new System.Drawing.Point(239, 312);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(213, 90);
            this.txtRemark.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.btnSave.Location = new System.Drawing.Point(239, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // reqValid
            // 
            this.reqValid.ControlToValidate = this.txtTunnelName;
            this.reqValid.ErrorMessage = "隧道名称不能为空！";
            this.reqValid.Icon = ((System.Drawing.Icon)(resources.GetObject("reqValid.Icon")));
            // 
            // formValid
            // 
            this.formValid.HostingForm = this;
            // 
            // cusValid
            // 
            this.cusValid.ControlToValidate = this.cboBoxProject;
            this.cusValid.ErrorMessage = "请选择合同！";
            this.cusValid.Icon = ((System.Drawing.Icon)(resources.GetObject("cusValid.Icon")));
            this.cusValid.Validating += new CommonUtil.Validators.CustomValidator.ValidatingEventHandler(this.cusValid_Validating);
            // 
            // EditTunnelFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(684, 470);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.cboBoxProject);
            this.Controls.Add(this.lblSelectProject);
            this.Controls.Add(this.txtLeader);
            this.Controls.Add(this.lblLeader);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtTunnelName);
            this.Controls.Add(this.lblTunnelName);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTunnelFrm";
            this.Text = "新增隧道";
            ((System.ComponentModel.ISupportInitialize)(this.reqValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZControls.ZLabelControl lblTunnelName;
        private DASP.ZControls.ZTextBox txtTunnelName;
        private ZControls.ZLabelControl lblStartDate;
        private DASP.ZControls.ZTextBox txtStartDate;
        private ZControls.ZLabelControl lblEndDate;
        private DASP.ZControls.ZTextBox txtEndDate;
        private ZControls.ZLabelControl lblLeader;
        private DASP.ZControls.ZTextBox txtLeader;
        private ZControls.ZLabelControl lblSelectProject;
        private System.Windows.Forms.ComboBox cboBoxProject;
        private ZControls.ZLabelControl lblRemark;
        private DASP.ZControls.ControlEx.TextBox.ZMultiTextBox txtRemark;
        private DASP.ZControls.ZButton btnSave;
        private CommonUtil.Validators.RequiredFieldValidator reqValid;
        private CommonUtil.Validators.FormValidator formValid;
        private CommonUtil.Validators.CustomValidator cusValid;
    }
}