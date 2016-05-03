namespace DASPClient.UI.DataModule
{
    partial class EditTestFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTestFrm));
            this.btnReadData = new DASP.ZControls.ZButton();
            this.btnReadConfig = new DASP.ZControls.ZButton();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.dgvDataSource = new ZControls.ZDataGridView();
            this.txtColumnSF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnADVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnISC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTestName = new ZControls.ZLabelControl();
            this.txtTestName = new DASP.ZControls.ZTextBox();
            this.lblTestCode = new ZControls.ZLabelControl();
            this.txtTestCode = new DASP.ZControls.ZTextBox();
            this.lblCh = new ZControls.ZLabelControl();
            this.cboBoxChannel = new System.Windows.Forms.ComboBox();
            this.lblDataType = new ZControls.ZLabelControl();
            this.cboBoxDataType = new System.Windows.Forms.ComboBox();
            this.lblTestTime = new ZControls.ZLabelControl();
            this.dtpTestTime = new System.Windows.Forms.DateTimePicker();
            this.lblSortCode = new ZControls.ZLabelControl();
            this.txtSort = new DASP.ZControls.ZTextBox();
            this.lblRemark = new ZControls.ZLabelControl();
            this.mTxtRemark = new DASP.ZControls.ControlEx.TextBox.ZMultiTextBox();
            this.btnSave = new DASP.ZControls.ZButton();
            this.reqValidTestName = new CommonUtil.Validators.RequiredFieldValidator();
            this.reqValidTestCode = new CommonUtil.Validators.RequiredFieldValidator();
            this.cusValidChannel = new CommonUtil.Validators.CustomValidator();
            this.cusValidDataType = new CommonUtil.Validators.CustomValidator();
            this.groupBoxReadData = new System.Windows.Forms.GroupBox();
            this.formValid = new CommonUtil.Validators.FormValidator();
            this.lblFanPosition = new ZControls.ZLabelControl();
            this.cboBoxFanPos = new System.Windows.Forms.ComboBox();
            this.cusValidFanPos = new CommonUtil.Validators.CustomValidator();
            this.groupBoxConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidTestName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidTestCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValidChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValidDataType)).BeginInit();
            this.groupBoxReadData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValidFanPos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadData
            // 
            this.btnReadData.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.btnReadData.Location = new System.Drawing.Point(47, 179);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(68, 23);
            this.btnReadData.TabIndex = 0;
            this.btnReadData.Text = "导入数据";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // btnReadConfig
            // 
            this.btnReadConfig.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.btnReadConfig.Location = new System.Drawing.Point(44, 42);
            this.btnReadConfig.Name = "btnReadConfig";
            this.btnReadConfig.Size = new System.Drawing.Size(68, 23);
            this.btnReadConfig.TabIndex = 1;
            this.btnReadConfig.Text = "导入配置";
            this.btnReadConfig.UseVisualStyleBackColor = true;
            this.btnReadConfig.Click += new System.EventHandler(this.btnReadConfig_Click);
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.dgvDataSource);
            this.groupBoxConfig.Location = new System.Drawing.Point(44, 80);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(678, 84);
            this.groupBoxConfig.TabIndex = 2;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "预览配置数据";
            // 
            // dgvDataSource
            // 
            this.dgvDataSource.AllowUserToAddRows = false;
            this.dgvDataSource.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.dgvDataSource.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDataSource.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDataSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDataSource.ColumnHeadersHeight = 26;
            this.dgvDataSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtColumnSF,
            this.txtColumnADVer,
            this.txtColumnPages,
            this.txtColumnISC,
            this.txtColumnCh,
            this.txtColumnEU});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataSource.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDataSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataSource.EnableHeadersVisualStyles = false;
            this.dgvDataSource.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDataSource.Location = new System.Drawing.Point(3, 17);
            this.dgvDataSource.Name = "dgvDataSource";
            this.dgvDataSource.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataSource.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDataSource.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDataSource.RowTemplate.Height = 23;
            this.dgvDataSource.Size = new System.Drawing.Size(672, 64);
            this.dgvDataSource.TabIndex = 0;
            // 
            // txtColumnSF
            // 
            this.txtColumnSF.DataPropertyName = "SF";
            this.txtColumnSF.HeaderText = "频率";
            this.txtColumnSF.Name = "txtColumnSF";
            // 
            // txtColumnADVer
            // 
            this.txtColumnADVer.DataPropertyName = "ADVer";
            this.txtColumnADVer.HeaderText = "卡版本";
            this.txtColumnADVer.Name = "txtColumnADVer";
            // 
            // txtColumnPages
            // 
            this.txtColumnPages.DataPropertyName = "Pages";
            this.txtColumnPages.HeaderText = "页数";
            this.txtColumnPages.Name = "txtColumnPages";
            // 
            // txtColumnISC
            // 
            this.txtColumnISC.DataPropertyName = "ISC";
            this.txtColumnISC.HeaderText = "零点数";
            this.txtColumnISC.Name = "txtColumnISC";
            // 
            // txtColumnCh
            // 
            this.txtColumnCh.DataPropertyName = "Ch";
            this.txtColumnCh.HeaderText = "通道";
            this.txtColumnCh.Name = "txtColumnCh";
            // 
            // txtColumnEU
            // 
            this.txtColumnEU.DataPropertyName = "EU";
            this.txtColumnEU.HeaderText = "工程单位";
            this.txtColumnEU.Name = "txtColumnEU";
            // 
            // lblTestName
            // 
            this.lblTestName.BackColor = System.Drawing.Color.Transparent;
            this.lblTestName.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblTestName.Location = new System.Drawing.Point(44, 20);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(74, 20);
            this.lblTestName.TabIndex = 0;
            this.lblTestName.Text = "试点名称：";
            // 
            // txtTestName
            // 
            this.txtTestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTestName.EmptyTextTip = null;
            this.txtTestName.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtTestName.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtTestName.Location = new System.Drawing.Point(124, 20);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(180, 23);
            this.txtTestName.TabIndex = 1;
            // 
            // lblTestCode
            // 
            this.lblTestCode.BackColor = System.Drawing.Color.Transparent;
            this.lblTestCode.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblTestCode.Location = new System.Drawing.Point(325, 20);
            this.lblTestCode.Name = "lblTestCode";
            this.lblTestCode.Size = new System.Drawing.Size(60, 20);
            this.lblTestCode.TabIndex = 2;
            this.lblTestCode.Text = "试点号：";
            // 
            // txtTestCode
            // 
            this.txtTestCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTestCode.EmptyTextTip = null;
            this.txtTestCode.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtTestCode.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtTestCode.Location = new System.Drawing.Point(405, 17);
            this.txtTestCode.Name = "txtTestCode";
            this.txtTestCode.Size = new System.Drawing.Size(180, 23);
            this.txtTestCode.TabIndex = 3;
            // 
            // lblCh
            // 
            this.lblCh.BackColor = System.Drawing.Color.Transparent;
            this.lblCh.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblCh.Location = new System.Drawing.Point(44, 75);
            this.lblCh.Name = "lblCh";
            this.lblCh.Size = new System.Drawing.Size(60, 20);
            this.lblCh.TabIndex = 4;
            this.lblCh.Text = "通道号：";
            // 
            // cboBoxChannel
            // 
            this.cboBoxChannel.FormattingEnabled = true;
            this.cboBoxChannel.Location = new System.Drawing.Point(124, 74);
            this.cboBoxChannel.Name = "cboBoxChannel";
            this.cboBoxChannel.Size = new System.Drawing.Size(180, 20);
            this.cboBoxChannel.TabIndex = 5;
            // 
            // lblDataType
            // 
            this.lblDataType.BackColor = System.Drawing.Color.Transparent;
            this.lblDataType.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblDataType.Location = new System.Drawing.Point(325, 74);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(74, 20);
            this.lblDataType.TabIndex = 6;
            this.lblDataType.Text = "数据类型：";
            // 
            // cboBoxDataType
            // 
            this.cboBoxDataType.FormattingEnabled = true;
            this.cboBoxDataType.Location = new System.Drawing.Point(405, 74);
            this.cboBoxDataType.Name = "cboBoxDataType";
            this.cboBoxDataType.Size = new System.Drawing.Size(180, 20);
            this.cboBoxDataType.TabIndex = 7;
            // 
            // lblTestTime
            // 
            this.lblTestTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTestTime.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblTestTime.Location = new System.Drawing.Point(44, 122);
            this.lblTestTime.Name = "lblTestTime";
            this.lblTestTime.Size = new System.Drawing.Size(74, 20);
            this.lblTestTime.TabIndex = 8;
            this.lblTestTime.Text = "采样时间：";
            // 
            // dtpTestTime
            // 
            this.dtpTestTime.Location = new System.Drawing.Point(124, 122);
            this.dtpTestTime.Name = "dtpTestTime";
            this.dtpTestTime.Size = new System.Drawing.Size(180, 21);
            this.dtpTestTime.TabIndex = 9;
            // 
            // lblSortCode
            // 
            this.lblSortCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSortCode.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblSortCode.Location = new System.Drawing.Point(325, 118);
            this.lblSortCode.Name = "lblSortCode";
            this.lblSortCode.Size = new System.Drawing.Size(60, 20);
            this.lblSortCode.TabIndex = 10;
            this.lblSortCode.Text = "排序号：";
            // 
            // txtSort
            // 
            this.txtSort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSort.EmptyTextTip = null;
            this.txtSort.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtSort.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtSort.Location = new System.Drawing.Point(405, 114);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(180, 23);
            this.txtSort.TabIndex = 11;
            // 
            // lblRemark
            // 
            this.lblRemark.BackColor = System.Drawing.Color.Transparent;
            this.lblRemark.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemark.Location = new System.Drawing.Point(44, 197);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(46, 20);
            this.lblRemark.TabIndex = 12;
            this.lblRemark.Text = "备注：";
            // 
            // mTxtRemark
            // 
            this.mTxtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTxtRemark.EmptyTextTip = null;
            this.mTxtRemark.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.mTxtRemark.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.mTxtRemark.Location = new System.Drawing.Point(124, 197);
            this.mTxtRemark.Multiline = true;
            this.mTxtRemark.Name = "mTxtRemark";
            this.mTxtRemark.Size = new System.Drawing.Size(461, 50);
            this.mTxtRemark.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.btnSave.Location = new System.Drawing.Point(361, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // reqValidTestName
            // 
            this.reqValidTestName.ControlToValidate = this.txtTestName;
            this.reqValidTestName.ErrorMessage = "试点名称不能为空！";
            this.reqValidTestName.Icon = ((System.Drawing.Icon)(resources.GetObject("reqValidTestName.Icon")));
            // 
            // reqValidTestCode
            // 
            this.reqValidTestCode.ControlToValidate = this.txtTestCode;
            this.reqValidTestCode.ErrorMessage = "试点号不能为空！";
            this.reqValidTestCode.Icon = ((System.Drawing.Icon)(resources.GetObject("reqValidTestCode.Icon")));
            // 
            // cusValidChannel
            // 
            this.cusValidChannel.ControlToValidate = this.cboBoxChannel;
            this.cusValidChannel.ErrorMessage = "请选择通道号！";
            this.cusValidChannel.Icon = ((System.Drawing.Icon)(resources.GetObject("cusValidChannel.Icon")));
            this.cusValidChannel.Validating += new CommonUtil.Validators.CustomValidator.ValidatingEventHandler(this.cusValid_Validating);
            // 
            // cusValidDataType
            // 
            this.cusValidDataType.ControlToValidate = this.cboBoxDataType;
            this.cusValidDataType.ErrorMessage = "请选择数据类型！";
            this.cusValidDataType.Icon = ((System.Drawing.Icon)(resources.GetObject("cusValidDataType.Icon")));
            this.cusValidDataType.Validating += new CommonUtil.Validators.CustomValidator.ValidatingEventHandler(this.cusValid_Validating);
            // 
            // groupBoxReadData
            // 
            this.groupBoxReadData.Controls.Add(this.cboBoxFanPos);
            this.groupBoxReadData.Controls.Add(this.lblFanPosition);
            this.groupBoxReadData.Controls.Add(this.mTxtRemark);
            this.groupBoxReadData.Controls.Add(this.lblRemark);
            this.groupBoxReadData.Controls.Add(this.txtSort);
            this.groupBoxReadData.Controls.Add(this.lblSortCode);
            this.groupBoxReadData.Controls.Add(this.dtpTestTime);
            this.groupBoxReadData.Controls.Add(this.lblTestTime);
            this.groupBoxReadData.Controls.Add(this.cboBoxDataType);
            this.groupBoxReadData.Controls.Add(this.lblDataType);
            this.groupBoxReadData.Controls.Add(this.cboBoxChannel);
            this.groupBoxReadData.Controls.Add(this.lblCh);
            this.groupBoxReadData.Controls.Add(this.txtTestCode);
            this.groupBoxReadData.Controls.Add(this.lblTestCode);
            this.groupBoxReadData.Controls.Add(this.txtTestName);
            this.groupBoxReadData.Controls.Add(this.lblTestName);
            this.groupBoxReadData.Location = new System.Drawing.Point(44, 221);
            this.groupBoxReadData.Name = "groupBoxReadData";
            this.groupBoxReadData.Size = new System.Drawing.Size(675, 262);
            this.groupBoxReadData.TabIndex = 3;
            this.groupBoxReadData.TabStop = false;
            this.groupBoxReadData.Text = "预览数据";
            // 
            // formValid
            // 
            this.formValid.HostingForm = this;
            // 
            // lblFanPosition
            // 
            this.lblFanPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblFanPosition.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblFanPosition.Location = new System.Drawing.Point(44, 164);
            this.lblFanPosition.Name = "lblFanPosition";
            this.lblFanPosition.Size = new System.Drawing.Size(74, 20);
            this.lblFanPosition.TabIndex = 14;
            this.lblFanPosition.Text = "风机位置：";
            // 
            // cboBoxFanPos
            // 
            this.cboBoxFanPos.FormattingEnabled = true;
            this.cboBoxFanPos.Location = new System.Drawing.Point(125, 164);
            this.cboBoxFanPos.Name = "cboBoxFanPos";
            this.cboBoxFanPos.Size = new System.Drawing.Size(179, 20);
            this.cboBoxFanPos.TabIndex = 15;
            // 
            // cusValidFanPos
            // 
            this.cusValidFanPos.ControlToValidate = this.cboBoxFanPos;
            this.cusValidFanPos.ErrorMessage = "请选择风机位置！";
            this.cusValidFanPos.Icon = ((System.Drawing.Icon)(resources.GetObject("cusValidFanPos.Icon")));
            this.cusValidFanPos.Validating += new CommonUtil.Validators.CustomValidator.ValidatingEventHandler(this.cusValid_Validating);
            // 
            // EditTestFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 529);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBoxReadData);
            this.Controls.Add(this.groupBoxConfig);
            this.Controls.Add(this.btnReadConfig);
            this.Controls.Add(this.btnReadData);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTestFrm";
            this.Text = "新增采样数据";
            this.groupBoxConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidTestName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqValidTestCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValidChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValidDataType)).EndInit();
            this.groupBoxReadData.ResumeLayout(false);
            this.groupBoxReadData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusValidFanPos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DASP.ZControls.ZButton btnReadData;
        private DASP.ZControls.ZButton btnReadConfig;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private ZControls.ZDataGridView dgvDataSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnSF;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnADVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnISC;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnEU;
        private ZControls.ZLabelControl lblTestName;
        private DASP.ZControls.ZTextBox txtTestName;
        private ZControls.ZLabelControl lblTestCode;
        private DASP.ZControls.ZTextBox txtTestCode;
        private ZControls.ZLabelControl lblCh;
        private System.Windows.Forms.ComboBox cboBoxChannel;
        private ZControls.ZLabelControl lblDataType;
        private System.Windows.Forms.ComboBox cboBoxDataType;
        private ZControls.ZLabelControl lblTestTime;
        private System.Windows.Forms.DateTimePicker dtpTestTime;
        private ZControls.ZLabelControl lblRemark;
        private DASP.ZControls.ZTextBox txtSort;
        private ZControls.ZLabelControl lblSortCode;
        private DASP.ZControls.ControlEx.TextBox.ZMultiTextBox mTxtRemark;
        private DASP.ZControls.ZButton btnSave;
        private CommonUtil.Validators.RequiredFieldValidator reqValidTestName;
        private CommonUtil.Validators.RequiredFieldValidator reqValidTestCode;
        private CommonUtil.Validators.CustomValidator cusValidChannel;
        private CommonUtil.Validators.CustomValidator cusValidDataType;
        private System.Windows.Forms.GroupBox groupBoxReadData;
        private CommonUtil.Validators.FormValidator formValid;
        private ZControls.ZLabelControl lblFanPosition;
        private System.Windows.Forms.ComboBox cboBoxFanPos;
        private CommonUtil.Validators.CustomValidator cusValidFanPos;
    }
}