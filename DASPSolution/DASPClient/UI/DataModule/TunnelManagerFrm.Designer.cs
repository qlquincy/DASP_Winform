namespace DASPClient.UI.DataModule
{
    partial class TunnelManagerFrm
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
            this.dgvDataSource = new ZControls.ZDataGridView();
            this.ucToolBar = new DASPClient.UI.CommonModule.UCToolBar();
            this.pagerControl = new DASPClient.UI.CommonModule.PagerControl();
            this.txtColumnTunnelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnTunnelLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnTunnelEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tableLayPanel.Controls.Add(this.pagerControl, 0, 2);
            this.tableLayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayPanel.Name = "tableLayPanel";
            this.tableLayPanel.RowCount = 3;
            this.tableLayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayPanel.Size = new System.Drawing.Size(796, 443);
            this.tableLayPanel.TabIndex = 0;
            // 
            // dgvDataSource
            // 
            this.dgvDataSource.AllowUserToAddRows = false;
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
            this.txtColumnTunnelName,
            this.txtColumnTunnelLeader,
            this.txtColumnStartDate,
            this.txtColumnTunnelEndDate,
            this.txtColumnProjectName,
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
            this.dgvDataSource.Size = new System.Drawing.Size(790, 352);
            this.dgvDataSource.TabIndex = 1;
            this.dgvDataSource.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDataSource_CellFormatting);
            this.dgvDataSource.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDataSource_CellMouseClick);
            // 
            // ucToolBar
            // 
            this.ucToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolBar.Location = new System.Drawing.Point(3, 3);
            this.ucToolBar.Name = "ucToolBar";
            this.ucToolBar.Size = new System.Drawing.Size(790, 44);
            this.ucToolBar.TabIndex = 0;
            // 
            // pagerControl
            // 
            this.pagerControl.AutoSize = true;
            this.pagerControl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pagerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagerControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.pagerControl.JumpText = "Go";
            this.pagerControl.Location = new System.Drawing.Point(3, 411);
            this.pagerControl.Name = "pagerControl";
            this.pagerControl.PageIndex = 1;
            this.pagerControl.PageSize = 5;
            this.pagerControl.RecordCount = 0;
            this.pagerControl.Size = new System.Drawing.Size(790, 29);
            this.pagerControl.TabIndex = 2;
            this.pagerControl.OnPageChanged += new System.EventHandler(this.pagerControl_OnPageChanged);
            // 
            // txtColumnTunnelName
            // 
            this.txtColumnTunnelName.DataPropertyName = "TunnelName";
            this.txtColumnTunnelName.HeaderText = "隧道名称";
            this.txtColumnTunnelName.Name = "txtColumnTunnelName";
            // 
            // txtColumnTunnelLeader
            // 
            this.txtColumnTunnelLeader.DataPropertyName = "TunnelLeader";
            this.txtColumnTunnelLeader.HeaderText = "隧道责任人";
            this.txtColumnTunnelLeader.Name = "txtColumnTunnelLeader";
            // 
            // txtColumnStartDate
            // 
            this.txtColumnStartDate.DataPropertyName = "TunnelStartDate";
            this.txtColumnStartDate.HeaderText = "隧道开始检查日期";
            this.txtColumnStartDate.Name = "txtColumnStartDate";
            // 
            // txtColumnTunnelEndDate
            // 
            this.txtColumnTunnelEndDate.DataPropertyName = "TunnelEndDate";
            this.txtColumnTunnelEndDate.HeaderText = "隧道结束检查日期";
            this.txtColumnTunnelEndDate.Name = "txtColumnTunnelEndDate";
            // 
            // txtColumnProjectName
            // 
            this.txtColumnProjectName.DataPropertyName = "Project.ProjectName";
            this.txtColumnProjectName.HeaderText = "所属合同";
            this.txtColumnProjectName.Name = "txtColumnProjectName";
            // 
            // txtColumnRemark
            // 
            this.txtColumnRemark.DataPropertyName = "Remark";
            this.txtColumnRemark.HeaderText = "备注";
            this.txtColumnRemark.Name = "txtColumnRemark";
            // 
            // TunnelManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 443);
            this.Controls.Add(this.tableLayPanel);
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "TunnelManagerFrm";
            this.Text = "隧道管理";
            this.tableLayPanel.ResumeLayout(false);
            this.tableLayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayPanel;
        private CommonModule.UCToolBar ucToolBar;
        private ZControls.ZDataGridView dgvDataSource;
        private CommonModule.PagerControl pagerControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnTunnelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnTunnelLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnTunnelEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnRemark;
    }
}