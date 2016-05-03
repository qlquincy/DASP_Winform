namespace DASPClient.UI.DataModule
{
    partial class ProjectManagerFrm
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
            this.ucToolBar = new DASPClient.UI.CommonModule.UCToolBar();
            this.dgvDataSource = new ZControls.ZDataGridView();
            this.txtColumnProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnProjectTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayPanel
            // 
            this.tableLayPanel.ColumnCount = 1;
            this.tableLayPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayPanel.Controls.Add(this.ucToolBar, 0, 0);
            this.tableLayPanel.Controls.Add(this.dgvDataSource, 0, 1);
            this.tableLayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayPanel.Name = "tableLayPanel";
            this.tableLayPanel.RowCount = 2;
            this.tableLayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayPanel.Size = new System.Drawing.Size(702, 407);
            this.tableLayPanel.TabIndex = 0;
            // 
            // ucToolBar
            // 
            this.ucToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolBar.Location = new System.Drawing.Point(3, 3);
            this.ucToolBar.Name = "ucToolBar";
            this.ucToolBar.Size = new System.Drawing.Size(696, 44);
            this.ucToolBar.TabIndex = 0;
            // 
            // dgvDataSource
            // 
            this.dgvDataSource.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.dgvDataSource.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataSource.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDataSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataSource.ColumnHeadersHeight = 26;
            this.dgvDataSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtColumnProjectName,
            this.txtColumnProjectTime,
            this.txtColumnLeader,
            this.txtColumnRemark});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataSource.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataSource.EnableHeadersVisualStyles = false;
            this.dgvDataSource.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDataSource.Location = new System.Drawing.Point(3, 53);
            this.dgvDataSource.Name = "dgvDataSource";
            this.dgvDataSource.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataSource.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataSource.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDataSource.RowTemplate.Height = 23;
            this.dgvDataSource.Size = new System.Drawing.Size(696, 351);
            this.dgvDataSource.TabIndex = 1;
            this.dgvDataSource.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDataSource_CellMouseClick);
            // 
            // txtColumnProjectName
            // 
            this.txtColumnProjectName.DataPropertyName = "ProjectName";
            this.txtColumnProjectName.HeaderText = "合同名称";
            this.txtColumnProjectName.Name = "txtColumnProjectName";
            // 
            // txtColumnProjectTime
            // 
            this.txtColumnProjectTime.DataPropertyName = "ProjectDate";
            this.txtColumnProjectTime.HeaderText = "合同时间";
            this.txtColumnProjectTime.Name = "txtColumnProjectTime";
            // 
            // txtColumnLeader
            // 
            this.txtColumnLeader.DataPropertyName = "ProjectLeader";
            this.txtColumnLeader.HeaderText = "责任人";
            this.txtColumnLeader.Name = "txtColumnLeader";
            // 
            // txtColumnRemark
            // 
            this.txtColumnRemark.DataPropertyName = "Remark";
            this.txtColumnRemark.HeaderText = "备注";
            this.txtColumnRemark.Name = "txtColumnRemark";
            // 
            // ProjectManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 407);
            this.Controls.Add(this.tableLayPanel);
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ProjectManagerFrm";
            this.Text = "合同管理";
            this.tableLayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayPanel;
        private CommonModule.UCToolBar ucToolBar;
        private ZControls.ZDataGridView dgvDataSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnProjectTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnRemark;
    }
}