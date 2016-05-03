namespace DASPClient.UI.UserModule
{
    partial class UserManagerFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUserDataSource = new ZControls.ZDataGridView();
            this.txtColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnLoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucToolBar = new DASPClient.UI.CommonModule.UCToolBar();
            this.tableLayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayPanel
            // 
            this.tableLayPanel.ColumnCount = 1;
            this.tableLayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayPanel.Controls.Add(this.dgvUserDataSource, 5, 1);
            this.tableLayPanel.Controls.Add(this.ucToolBar, 0, 0);
            this.tableLayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayPanel.Name = "tableLayPanel";
            this.tableLayPanel.RowCount = 2;
            this.tableLayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayPanel.Size = new System.Drawing.Size(653, 449);
            this.tableLayPanel.TabIndex = 0;
            // 
            // dgvUserDataSource
            // 
            this.dgvUserDataSource.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.dgvUserDataSource.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserDataSource.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUserDataSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserDataSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserDataSource.ColumnHeadersHeight = 26;
            this.dgvUserDataSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserDataSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtColumnName,
            this.txtColumnLoginName,
            this.txtColumnTel,
            this.txtColumnEmail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserDataSource.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserDataSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserDataSource.EnableHeadersVisualStyles = false;
            this.dgvUserDataSource.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvUserDataSource.Location = new System.Drawing.Point(3, 53);
            this.dgvUserDataSource.Name = "dgvUserDataSource";
            this.dgvUserDataSource.ReadOnly = true;
            this.dgvUserDataSource.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserDataSource.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUserDataSource.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUserDataSource.RowTemplate.Height = 23;
            this.dgvUserDataSource.Size = new System.Drawing.Size(647, 393);
            this.dgvUserDataSource.TabIndex = 0;
            this.dgvUserDataSource.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserDataSource_CellMouseClick);
            this.dgvUserDataSource.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserDataSource_CellMouseDoubleClick);
            // 
            // txtColumnName
            // 
            this.txtColumnName.DataPropertyName = "UserName";
            this.txtColumnName.HeaderText = "姓名";
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.ReadOnly = true;
            // 
            // txtColumnLoginName
            // 
            this.txtColumnLoginName.DataPropertyName = "LoginName";
            this.txtColumnLoginName.HeaderText = "登录名";
            this.txtColumnLoginName.Name = "txtColumnLoginName";
            this.txtColumnLoginName.ReadOnly = true;
            // 
            // txtColumnTel
            // 
            this.txtColumnTel.DataPropertyName = "UserTel";
            this.txtColumnTel.HeaderText = "电话";
            this.txtColumnTel.Name = "txtColumnTel";
            this.txtColumnTel.ReadOnly = true;
            // 
            // txtColumnEmail
            // 
            this.txtColumnEmail.DataPropertyName = "UserEmail";
            this.txtColumnEmail.HeaderText = "邮箱";
            this.txtColumnEmail.Name = "txtColumnEmail";
            this.txtColumnEmail.ReadOnly = true;
            // 
            // ucToolBar
            // 
            this.ucToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolBar.Location = new System.Drawing.Point(3, 3);
            this.ucToolBar.Name = "ucToolBar";
            this.ucToolBar.Size = new System.Drawing.Size(647, 44);
            this.ucToolBar.TabIndex = 1;
            // 
            // UserManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 449);
            this.Controls.Add(this.tableLayPanel);
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UserManagerFrm";
            this.Text = "用户管理";
            this.tableLayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDataSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayPanel;
        private ZControls.ZDataGridView dgvUserDataSource;
        private CommonModule.UCToolBar ucToolBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnLoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnEmail;
    }
}