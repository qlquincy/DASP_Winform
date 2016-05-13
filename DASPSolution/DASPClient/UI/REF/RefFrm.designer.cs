using Dasp;
namespace Dasp_UI
{
    partial class REF
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
            this.mcadLine1 = new Dasp.MCADLine();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbout = new System.Windows.Forms.ComboBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtin = new System.Windows.Forms.TextBox();
            this.btnGetpara = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pointsperpage = new System.Windows.Forms.ComboBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.MenuStrp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripObj = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripRef = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcadLine1
            // 
            this.mcadLine1.AxisColor = System.Drawing.Color.Gray;
            this.mcadLine1.barDiffWidth = 4;
            this.mcadLine1.barWidth = 2;
            this.mcadLine1.BgColor = System.Drawing.Color.Black;
            this.mcadLine1.BmSpan = 30;
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
            this.mcadLine1.Location = new System.Drawing.Point(153, 86);
            this.mcadLine1.Lspan = 35;
            this.mcadLine1.Name = "mcadLine1";
            this.mcadLine1.Remainder = 0;
            this.mcadLine1.RightText = null;
            this.mcadLine1.Rspan = 70;
            this.mcadLine1.sindex = 0;
            this.mcadLine1.Size = new System.Drawing.Size(849, 373);
            this.mcadLine1.SliceColor = System.Drawing.Color.Black;
            this.mcadLine1.SliceTextColor = System.Drawing.Color.Black;
            this.mcadLine1.StartPindex = 0;
            this.mcadLine1.TabIndex = 0;
            this.mcadLine1.TextColor = System.Drawing.Color.White;
            this.mcadLine1.Title = "实时线";
            this.mcadLine1.TopRemarkSpan = 35;
            this.mcadLine1.xGridSpan = 64;
            this.mcadLine1.xInterval = 0;
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
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.treeView, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.mcadLine1, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1005, 462);
            this.tableLayoutPanel.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbout);
            this.panel1.Controls.Add(this.txtOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtin);
            this.panel1.Controls.Add(this.btnGetpara);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pointsperpage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(153, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 77);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = "输出设置";
            // 
            // cmbout
            // 
            this.cmbout.FormattingEnabled = true;
            this.cmbout.Items.AddRange(new object[] {
            "幅频 、相频",
            "幅频 、相干",
            "实部 、虚部",
            "输入自谱 、输出自谱",
            "幅频 相频  相干"});
            this.cmbout.Location = new System.Drawing.Point(455, 44);
            this.cmbout.Name = "cmbout";
            this.cmbout.Size = new System.Drawing.Size(101, 20);
            this.cmbout.TabIndex = 38;
            this.cmbout.SelectedIndexChanged += new System.EventHandler(this.cmbout_SelectedIndexChanged);
            // 
            // txtOut
            // 
            this.txtOut.Enabled = false;
            this.txtOut.Location = new System.Drawing.Point(351, 13);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(239, 21);
            this.txtOut.TabIndex = 37;
            this.txtOut.Text = "84930f04-cd56-4cb7-a609-95ac668746fe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "试验序列号";
            // 
            // txtin
            // 
            this.txtin.Enabled = false;
            this.txtin.Location = new System.Drawing.Point(81, 15);
            this.txtin.Name = "txtin";
            this.txtin.Size = new System.Drawing.Size(233, 21);
            this.txtin.TabIndex = 34;
            this.txtin.Text = "f2d72bcb-88b2-4f93-af7a-0b10834848d9";
            // 
            // btnGetpara
            // 
            this.btnGetpara.Location = new System.Drawing.Point(647, 10);
            this.btnGetpara.Name = "btnGetpara";
            this.btnGetpara.Size = new System.Drawing.Size(86, 24);
            this.btnGetpara.TabIndex = 33;
            this.btnGetpara.Text = "参数设定";
            this.btnGetpara.UseVisualStyleBackColor = true;
            this.btnGetpara.Click += new System.EventHandler(this.btnGetpara_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 26);
            this.button4.TabIndex = 32;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 26);
            this.button3.TabIndex = 31;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 26);
            this.button2.TabIndex = 30;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 26);
            this.button1.TabIndex = 29;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "预览点数";
            // 
            // pointsperpage
            // 
            this.pointsperpage.FormattingEnabled = true;
            this.pointsperpage.Items.AddRange(new object[] {
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            "全部"});
            this.pointsperpage.Location = new System.Drawing.Point(81, 42);
            this.pointsperpage.Name = "pointsperpage";
            this.pointsperpage.Size = new System.Drawing.Size(70, 20);
            this.pointsperpage.TabIndex = 28;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            this.tableLayoutPanel.SetRowSpan(this.treeView, 2);
            this.treeView.Size = new System.Drawing.Size(144, 456);
            this.treeView.TabIndex = 2;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
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
            this.ToolStripObj.Text = "设置输入信号";
            this.ToolStripObj.Click += new System.EventHandler(this.ToolStripObj_Click);
            // 
            // ToolStripRef
            // 
            this.ToolStripRef.Name = "ToolStripRef";
            this.ToolStripRef.Size = new System.Drawing.Size(148, 22);
            this.ToolStripRef.Text = "设置输出信号";
            this.ToolStripRef.Click += new System.EventHandler(this.ToolStripObj_Click);
            // 
            // REF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 462);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "REF";
            this.Text = "传递函数分析";
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuStrp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MCADLine mcadLine1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtin;
        private System.Windows.Forms.Button btnGetpara;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pointsperpage;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbout;
        private System.Windows.Forms.ContextMenuStrip MenuStrp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripObj;
        private System.Windows.Forms.ToolStripMenuItem ToolStripRef;
    }
}