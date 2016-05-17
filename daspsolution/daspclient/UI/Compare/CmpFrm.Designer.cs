namespace Dasp_UI
{
    partial class CmpFrm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcmpa = new System.Windows.Forms.TextBox();
            this.txtcmpb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pointsperpage = new System.Windows.Forms.ComboBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.MenuStrp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripObj = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripRef = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOK = new System.Windows.Forms.Button();
            this.mcadLine1 = new Dasp.MCADLine();
            this.tableLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MenuStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.mcadLine1, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.treeView, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(996, 451);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtcmpa);
            this.panel2.Controls.Add(this.txtcmpb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pointsperpage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(153, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 75);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "比对参考对象";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = "比对对象";
            // 
            // txtcmpa
            // 
            this.txtcmpa.Enabled = false;
            this.txtcmpa.Location = new System.Drawing.Point(85, 6);
            this.txtcmpa.Name = "txtcmpa";
            this.txtcmpa.Size = new System.Drawing.Size(239, 21);
            this.txtcmpa.TabIndex = 37;
            this.txtcmpa.Text = "84930f04-cd56-4cb7-a609-95ac668746fe";
            // 
            // txtcmpb
            // 
            this.txtcmpb.Enabled = false;
            this.txtcmpb.Location = new System.Drawing.Point(413, 6);
            this.txtcmpb.Name = "txtcmpb";
            this.txtcmpb.Size = new System.Drawing.Size(233, 21);
            this.txtcmpb.TabIndex = 34;
            this.txtcmpb.Text = "f2d72bcb-88b2-4f93-af7a-0b10834848d9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "比对属性";
            // 
            // pointsperpage
            // 
            this.pointsperpage.FormattingEnabled = true;
            this.pointsperpage.Items.AddRange(new object[] {
            "波形图",
            "自谱分析",
            "传递分析"});
            this.pointsperpage.Location = new System.Drawing.Point(720, 6);
            this.pointsperpage.Name = "pointsperpage";
            this.pointsperpage.Size = new System.Drawing.Size(70, 20);
            this.pointsperpage.TabIndex = 28;
            // 
            // treeView
            // 
            this.treeView.ContextMenuStrip = this.MenuStrp;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            this.tableLayoutPanel.SetRowSpan(this.treeView, 2);
            this.treeView.Size = new System.Drawing.Size(144, 445);
            this.treeView.TabIndex = 2;
            this.treeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseClick);
            // 
            // MenuStrp
            // 
            this.MenuStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripObj,
            this.ToolStripRef});
            this.MenuStrp.Name = "MenuStrp";
            this.MenuStrp.Size = new System.Drawing.Size(149, 48);
            // 
            // ToolStripObj
            // 
            this.ToolStripObj.Name = "ToolStripObj";
            this.ToolStripObj.Size = new System.Drawing.Size(148, 22);
            this.ToolStripObj.Text = "设置比对目标";
            this.ToolStripObj.Click += new System.EventHandler(this.ToolStripObj_Click);
            // 
            // ToolStripRef
            // 
            this.ToolStripRef.Name = "ToolStripRef";
            this.ToolStripRef.Size = new System.Drawing.Size(148, 22);
            this.ToolStripRef.Text = "设置参考目标";
            this.ToolStripRef.Click += new System.EventHandler(this.ToolStripObj_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(460, 36);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 28);
            this.btnOK.TabIndex = 41;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // mcadLine1
            // 
            this.mcadLine1.AxisColor = System.Drawing.Color.Gray;
            this.mcadLine1.BackColor = System.Drawing.Color.White;
            this.mcadLine1.barDiffWidth = 4;
            this.mcadLine1.barWidth = 2;
            this.mcadLine1.BgColor = System.Drawing.Color.Black;
            this.mcadLine1.BmSpan = 4;
            this.mcadLine1.BorderColor = System.Drawing.Color.White;
            this.mcadLine1.ClrsCurveColors = System.Drawing.Color.Red;
            this.mcadLine1.ClrsCurveColorsb = System.Drawing.Color.Green;
            this.mcadLine1.CurveSize = 1;
            this.mcadLine1.Decima = 1;
            this.mcadLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcadLine1.drawall = false;
            this.mcadLine1.drawlen = 1024;
            this.mcadLine1.DrawPageIndex = 0;
            this.mcadLine1.DrawParts = 1;
            this.mcadLine1.DrwaPageTotalPages = 0;
            this.mcadLine1.EndPindex = 0;
            this.mcadLine1.FontSize = 9;
            this.mcadLine1.Khz = 25600;
            this.mcadLine1.Location = new System.Drawing.Point(153, 84);
            this.mcadLine1.Lspan = 30;
            this.mcadLine1.Name = "mcadLine1";
            this.mcadLine1.Remainder = 0;
            this.mcadLine1.RightText = null;
            this.mcadLine1.Rspan = 70;
            this.mcadLine1.sindex = 0;
            this.mcadLine1.Size = new System.Drawing.Size(840, 364);
            this.mcadLine1.SliceColor = System.Drawing.Color.Black;
            this.mcadLine1.SliceTextColor = System.Drawing.Color.Black;
            this.mcadLine1.StartPindex = 0;
            this.mcadLine1.TabIndex = 1;
            this.mcadLine1.TextColor = System.Drawing.Color.White;
            this.mcadLine1.Title = "";
            this.mcadLine1.TopRemarkSpan = 35;
            this.mcadLine1.xGridSpan = 64;
            this.mcadLine1.xInterval = 1;
            this.mcadLine1.XSlice = 50F;
            this.mcadLine1.XSpace = 4;
            this.mcadLine1.xUnitPointNum = 64;
            this.mcadLine1.yGridspan = 100;
            this.mcadLine1.YRotateAngle = 0F;
            this.mcadLine1.YSlice = 50F;
            this.mcadLine1.YSliceBegin = -2000F;
            this.mcadLine1.YSliceEnd = 2000F;
            this.mcadLine1.YSliceValue = 20F;
            this.mcadLine1.YSpace = 0F;
            this.mcadLine1.ZeroL = 400;
            // 
            // CmpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 451);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "CmpFrm";
            this.Text = "对比分析";
            this.Load += new System.EventHandler(this.CmpFrm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MenuStrp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Dasp.MCADLine mcadLine1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtcmpa;
        private System.Windows.Forms.TextBox txtcmpb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pointsperpage;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip MenuStrp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripObj;
        private System.Windows.Forms.ToolStripMenuItem ToolStripRef;
        private System.Windows.Forms.Button btnOK;
    }
}