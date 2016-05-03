namespace DASPClient.UI.DataModule
{
    partial class EditFanPosFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFanPosFrm));
            this.lblFanPosName = new ZControls.ZLabelControl();
            this.txtFanPosName = new DASP.ZControls.ZTextBox();
            this.lblLaneWay = new ZControls.ZLabelControl();
            this.cboBoxLaneWay = new System.Windows.Forms.ComboBox();
            this.lblHoleWay = new ZControls.ZLabelControl();
            this.cboBoxHoleWay = new System.Windows.Forms.ComboBox();
            this.lblSelectTunnel = new ZControls.ZLabelControl();
            this.cboBoxTunnel = new System.Windows.Forms.ComboBox();
            this.lblRemark = new ZControls.ZLabelControl();
            this.txtRemark = new DASP.ZControls.ControlEx.TextBox.ZMultiTextBox();
            this.btnSave = new DASP.ZControls.ZButton();
            this.reqValid = new CommonUtil.Validators.RequiredFieldValidator();
            this.formValid = new CommonUtil.Validators.FormValidator();
            this.cusValidLaneWay = new CommonUtil.Validators.CustomValidator();
            this.cusValidHoleWay = new CommonUtil.Validators.CustomValidator();
            this.cusValidTunnel = new CommonUtil.Validators.CustomValidator();
            ((System.ComponentModel.ISupportInitialize)(this.reqValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValidLaneWay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValidHoleWay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValidTunnel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFanPosName
            // 
            this.lblFanPosName.BackColor = System.Drawing.Color.Transparent;
            this.lblFanPosName.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblFanPosName.Location = new System.Drawing.Point(113, 55);
            this.lblFanPosName.Name = "lblFanPosName";
            this.lblFanPosName.Size = new System.Drawing.Size(101, 20);
            this.lblFanPosName.TabIndex = 0;
            this.lblFanPosName.Text = "风机位置名称：";
            // 
            // txtFanPosName
            // 
            this.txtFanPosName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFanPosName.EmptyTextTip = null;
            this.txtFanPosName.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtFanPosName.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtFanPosName.Location = new System.Drawing.Point(234, 51);
            this.txtFanPosName.Name = "txtFanPosName";
            this.txtFanPosName.Size = new System.Drawing.Size(230, 23);
            this.txtFanPosName.TabIndex = 1;
            // 
            // lblLaneWay
            // 
            this.lblLaneWay.BackColor = System.Drawing.Color.Transparent;
            this.lblLaneWay.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblLaneWay.Location = new System.Drawing.Point(113, 96);
            this.lblLaneWay.Name = "lblLaneWay";
            this.lblLaneWay.Size = new System.Drawing.Size(74, 20);
            this.lblLaneWay.TabIndex = 2;
            this.lblLaneWay.Text = "所属车道：";
            // 
            // cboBoxLaneWay
            // 
            this.cboBoxLaneWay.FormattingEnabled = true;
            this.cboBoxLaneWay.Location = new System.Drawing.Point(234, 95);
            this.cboBoxLaneWay.Name = "cboBoxLaneWay";
            this.cboBoxLaneWay.Size = new System.Drawing.Size(230, 20);
            this.cboBoxLaneWay.TabIndex = 3;
            // 
            // lblHoleWay
            // 
            this.lblHoleWay.BackColor = System.Drawing.Color.Transparent;
            this.lblHoleWay.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblHoleWay.Location = new System.Drawing.Point(113, 150);
            this.lblHoleWay.Name = "lblHoleWay";
            this.lblHoleWay.Size = new System.Drawing.Size(74, 20);
            this.lblHoleWay.TabIndex = 4;
            this.lblHoleWay.Text = "隧道左右：";
            // 
            // cboBoxHoleWay
            // 
            this.cboBoxHoleWay.FormattingEnabled = true;
            this.cboBoxHoleWay.Location = new System.Drawing.Point(234, 149);
            this.cboBoxHoleWay.Name = "cboBoxHoleWay";
            this.cboBoxHoleWay.Size = new System.Drawing.Size(230, 20);
            this.cboBoxHoleWay.TabIndex = 5;
            // 
            // lblSelectTunnel
            // 
            this.lblSelectTunnel.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectTunnel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectTunnel.Location = new System.Drawing.Point(113, 200);
            this.lblSelectTunnel.Name = "lblSelectTunnel";
            this.lblSelectTunnel.Size = new System.Drawing.Size(74, 20);
            this.lblSelectTunnel.TabIndex = 6;
            this.lblSelectTunnel.Text = "选择隧道：";
            // 
            // cboBoxTunnel
            // 
            this.cboBoxTunnel.FormattingEnabled = true;
            this.cboBoxTunnel.Location = new System.Drawing.Point(234, 199);
            this.cboBoxTunnel.Name = "cboBoxTunnel";
            this.cboBoxTunnel.Size = new System.Drawing.Size(230, 20);
            this.cboBoxTunnel.TabIndex = 7;
            // 
            // lblRemark
            // 
            this.lblRemark.BackColor = System.Drawing.Color.Transparent;
            this.lblRemark.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemark.Location = new System.Drawing.Point(113, 253);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(46, 20);
            this.lblRemark.TabIndex = 8;
            this.lblRemark.Text = "备注：";
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.EmptyTextTip = null;
            this.txtRemark.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtRemark.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtRemark.Location = new System.Drawing.Point(234, 253);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(230, 89);
            this.txtRemark.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.btnSave.Location = new System.Drawing.Point(234, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // reqValid
            // 
            this.reqValid.ControlToValidate = this.txtFanPosName;
            this.reqValid.ErrorMessage = "风机位置名称不能为空！";
            this.reqValid.Icon = ((System.Drawing.Icon)(resources.GetObject("reqValid.Icon")));
            // 
            // formValid
            // 
            this.formValid.HostingForm = this;
            // 
            // cusValidLaneWay
            // 
            this.cusValidLaneWay.ControlToValidate = this.cboBoxLaneWay;
            this.cusValidLaneWay.ErrorMessage = "请选择车道！";
            this.cusValidLaneWay.Icon = ((System.Drawing.Icon)(resources.GetObject("cusValidLaneWay.Icon")));
            this.cusValidLaneWay.Validating += new CommonUtil.Validators.CustomValidator.ValidatingEventHandler(this.cusValid_Validating);
            // 
            // cusValidHoleWay
            // 
            this.cusValidHoleWay.ControlToValidate = this.cboBoxHoleWay;
            this.cusValidHoleWay.ErrorMessage = "请选择隧道左右！";
            this.cusValidHoleWay.Icon = ((System.Drawing.Icon)(resources.GetObject("cusValidHoleWay.Icon")));
            this.cusValidHoleWay.Validating += new CommonUtil.Validators.CustomValidator.ValidatingEventHandler(this.cusValid_Validating);
            // 
            // cusValidTunnel
            // 
            this.cusValidTunnel.ControlToValidate = this.cboBoxTunnel;
            this.cusValidTunnel.ErrorMessage = "请选择隧道！";
            this.cusValidTunnel.Icon = ((System.Drawing.Icon)(resources.GetObject("cusValidTunnel.Icon")));
            this.cusValidTunnel.Validating += new CommonUtil.Validators.CustomValidator.ValidatingEventHandler(this.cusValid_Validating);
            // 
            // EditFanPosFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 440);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.cboBoxTunnel);
            this.Controls.Add(this.lblSelectTunnel);
            this.Controls.Add(this.cboBoxHoleWay);
            this.Controls.Add(this.lblHoleWay);
            this.Controls.Add(this.cboBoxLaneWay);
            this.Controls.Add(this.lblLaneWay);
            this.Controls.Add(this.txtFanPosName);
            this.Controls.Add(this.lblFanPosName);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFanPosFrm";
            this.Text = "新增风机位置";
            ((System.ComponentModel.ISupportInitialize)(this.reqValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValidLaneWay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValidHoleWay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValidTunnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZControls.ZLabelControl lblFanPosName;
        private DASP.ZControls.ZTextBox txtFanPosName;
        private ZControls.ZLabelControl lblLaneWay;
        private System.Windows.Forms.ComboBox cboBoxLaneWay;
        private ZControls.ZLabelControl lblHoleWay;
        private System.Windows.Forms.ComboBox cboBoxHoleWay;
        private ZControls.ZLabelControl lblSelectTunnel;
        private System.Windows.Forms.ComboBox cboBoxTunnel;
        private ZControls.ZLabelControl lblRemark;
        private DASP.ZControls.ControlEx.TextBox.ZMultiTextBox txtRemark;
        private DASP.ZControls.ZButton btnSave;
        private CommonUtil.Validators.RequiredFieldValidator reqValid;
        private CommonUtil.Validators.FormValidator formValid;
        private CommonUtil.Validators.CustomValidator cusValidLaneWay;
        private CommonUtil.Validators.CustomValidator cusValidHoleWay;
        private CommonUtil.Validators.CustomValidator cusValidTunnel;
    }
}