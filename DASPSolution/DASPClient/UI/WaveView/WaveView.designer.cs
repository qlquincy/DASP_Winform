using Dasp;
namespace Dasp_WaveView
{
    partial class WaveView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenData = new System.Windows.Forms.Button();
            this.pointsperpage = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mcadLine1 = new Dasp.MCADLine();
            this.txtSerialID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnview);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSerialID);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnOpenData);
            this.panel2.Controls.Add(this.pointsperpage);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 147);
            this.panel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(392, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 24);
            this.button5.TabIndex = 33;
            this.button5.Text = "读光标";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(230, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 26);
            this.button4.TabIndex = 32;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 26);
            this.button3.TabIndex = 31;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 26);
            this.button2.TabIndex = 30;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 26);
            this.button1.TabIndex = 29;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "预览点数";
            // 
            // btnOpenData
            // 
            this.btnOpenData.Location = new System.Drawing.Point(503, 49);
            this.btnOpenData.Name = "btnOpenData";
            this.btnOpenData.Size = new System.Drawing.Size(87, 33);
            this.btnOpenData.TabIndex = 25;
            this.btnOpenData.Text = "打开数据文件";
            this.btnOpenData.UseVisualStyleBackColor = true;
            this.btnOpenData.Click += new System.EventHandler(this.btnOpenData_Click);
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
            this.pointsperpage.Location = new System.Drawing.Point(90, 51);
            this.pointsperpage.Name = "pointsperpage";
            this.pointsperpage.Size = new System.Drawing.Size(70, 20);
            this.pointsperpage.TabIndex = 28;
            this.pointsperpage.SelectedIndexChanged += new System.EventHandler(this.pointsperpage_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 43);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mcadLine1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 109);
            this.panel1.TabIndex = 2;
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
            this.mcadLine1.Location = new System.Drawing.Point(0, 0);
            this.mcadLine1.Name = "mcadLine1";
            this.mcadLine1.Remainder = 0;
            this.mcadLine1.sindex = 0;
            this.mcadLine1.Size = new System.Drawing.Size(808, 109);
            this.mcadLine1.SliceColor = System.Drawing.Color.Black;
            this.mcadLine1.SliceTextColor = System.Drawing.Color.Black;
            this.mcadLine1.StartPindex = 0;
            this.mcadLine1.TabIndex = 1;
            this.mcadLine1.TextColor = System.Drawing.Color.White;
            this.mcadLine1.Title = "";
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
            // txtSerialID
            // 
            this.txtSerialID.Location = new System.Drawing.Point(81, 15);
            this.txtSerialID.Name = "txtSerialID";
            this.txtSerialID.Size = new System.Drawing.Size(233, 21);
            this.txtSerialID.TabIndex = 34;
            this.txtSerialID.Text = "f2d72bcb-88b2-4f93-af7a-0b10834848d9";
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
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(341, 8);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(76, 32);
            this.btnview.TabIndex = 36;
            this.btnview.Text = "波形预览";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // WaveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 256);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KeyPreview = true;
            this.Name = "WaveView";
            this.Text = "波形浏览";
            this.Load += new System.EventHandler(this.WaveView_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MCADLine mcadLine1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOpenData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pointsperpage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerialID;
    }
}