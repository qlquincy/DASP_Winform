namespace DASPTool
{
    partial class InitToolFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitToolFrm));
            this.zLabelControl1 = new ZControls.ZLabelControl();
            this.txtDBName = new DASP.ZControls.ZTextBox();
            this.btnCreateDB = new DASP.ZControls.ZButton();
            this.btnCreateInit = new DASP.ZControls.ZButton();
            this.reqFieldValid = new CommonUtil.Validators.RequiredFieldValidator();
            this.formValid = new CommonUtil.Validators.FormValidator();
            ((System.ComponentModel.ISupportInitialize)(this.reqFieldValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).BeginInit();
            this.SuspendLayout();
            // 
            // zLabelControl1
            // 
            this.zLabelControl1.BackColor = System.Drawing.Color.Transparent;
            this.zLabelControl1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.zLabelControl1.Location = new System.Drawing.Point(100, 96);
            this.zLabelControl1.Name = "zLabelControl1";
            this.zLabelControl1.Size = new System.Drawing.Size(87, 20);
            this.zLabelControl1.TabIndex = 0;
            this.zLabelControl1.Text = "数据库名称：";
            // 
            // txtDBName
            // 
            this.txtDBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBName.EmptyTextTip = null;
            this.txtDBName.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtDBName.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtDBName.Location = new System.Drawing.Point(209, 96);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(218, 23);
            this.txtDBName.TabIndex = 1;
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.btnCreateDB.Location = new System.Drawing.Point(119, 186);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(68, 23);
            this.btnCreateDB.TabIndex = 2;
            this.btnCreateDB.Text = "创建数据库";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.btnCreateDB_Click);
            // 
            // btnCreateInit
            // 
            this.btnCreateInit.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.btnCreateInit.Location = new System.Drawing.Point(359, 186);
            this.btnCreateInit.Name = "btnCreateInit";
            this.btnCreateInit.Size = new System.Drawing.Size(68, 23);
            this.btnCreateInit.TabIndex = 3;
            this.btnCreateInit.Text = "初始化数据";
            this.btnCreateInit.UseVisualStyleBackColor = true;
            this.btnCreateInit.Click += new System.EventHandler(this.btnCreateInit_Click);
            // 
            // reqFieldValid
            // 
            this.reqFieldValid.ControlToValidate = this.txtDBName;
            this.reqFieldValid.ErrorMessage = "数据库名称不能为空";
            this.reqFieldValid.Icon = ((System.Drawing.Icon)(resources.GetObject("reqFieldValid.Icon")));
            // 
            // formValid
            // 
            this.formValid.HostingForm = this;
            // 
            // InitToolFrm
            // 
            this.AcceptButton = this.btnCreateDB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(588, 316);
            this.Controls.Add(this.btnCreateInit);
            this.Controls.Add(this.btnCreateDB);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.zLabelControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "InitToolFrm";
            this.Text = "初始化工具";
            this.Load += new System.EventHandler(this.InitToolFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reqFieldValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZControls.ZLabelControl zLabelControl1;
        private DASP.ZControls.ZTextBox txtDBName;
        private DASP.ZControls.ZButton btnCreateDB;
        private DASP.ZControls.ZButton btnCreateInit;
        private CommonUtil.Validators.RequiredFieldValidator reqFieldValid;
        private CommonUtil.Validators.FormValidator formValid;
    }
}

