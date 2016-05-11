using Dasp;
namespace Dasp_UI
{
    partial class SpectrumPara
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
            this.btnOK = new System.Windows.Forms.Button();
            this.CascadePercent = new System.Windows.Forms.NumericUpDown();
            this.CalOffset = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.AverageType = new System.Windows.Forms.ComboBox();
            this.btnview = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerialID = new System.Windows.Forms.TextBox();
            this.ClearDc = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WindowType = new System.Windows.Forms.ComboBox();
            this.pointsperpage = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SpectrumType = new System.Windows.Forms.ComboBox();
            this.CalCv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ExpPara = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WavePtNum = new System.Windows.Forms.TextBox();
            this.FftPtNum = new System.Windows.Forms.ComboBox();
            this.WaveOffset = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.WaveSf = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mcadLine1 = new Dasp.MCADLine();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CascadePercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpPara)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.CascadePercent);
            this.panel2.Controls.Add(this.CalOffset);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.AverageType);
            this.panel2.Controls.Add(this.btnview);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSerialID);
            this.panel2.Controls.Add(this.ClearDc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.WindowType);
            this.panel2.Controls.Add(this.pointsperpage);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.SpectrumType);
            this.panel2.Controls.Add(this.CalCv);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.ExpPara);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.WavePtNum);
            this.panel2.Controls.Add(this.FftPtNum);
            this.panel2.Controls.Add(this.WaveOffset);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.WaveSf);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 149);
            this.panel2.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(602, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 32);
            this.btnOK.TabIndex = 48;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CascadePercent
            // 
            this.CascadePercent.Location = new System.Drawing.Point(685, 118);
            this.CascadePercent.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.CascadePercent.Name = "CascadePercent";
            this.CascadePercent.Size = new System.Drawing.Size(70, 21);
            this.CascadePercent.TabIndex = 37;
            // 
            // CalOffset
            // 
            this.CalOffset.Location = new System.Drawing.Point(529, 85);
            this.CalOffset.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.CalOffset.Name = "CalOffset";
            this.CalOffset.Size = new System.Drawing.Size(70, 21);
            this.CalOffset.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(619, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 36;
            this.label9.Text = "重叠比例";
            // 
            // AverageType
            // 
            this.AverageType.FormattingEnabled = true;
            this.AverageType.Items.AddRange(new object[] {
            "0 线性平均",
            "1 峰值保持+平滑 ",
            "2 最大值保持 ",
            "3 指数平均 ",
            "4 峰值保持"});
            this.AverageType.Location = new System.Drawing.Point(684, 84);
            this.AverageType.Name = "AverageType";
            this.AverageType.Size = new System.Drawing.Size(70, 20);
            this.AverageType.TabIndex = 39;
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(463, 8);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(76, 32);
            this.btnview.TabIndex = 36;
            this.btnview.Text = "波形预览";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 46;
            this.label8.Text = "fCalOffset";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 38;
            this.label7.Text = "平均方式";
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
            // txtSerialID
            // 
            this.txtSerialID.Location = new System.Drawing.Point(81, 15);
            this.txtSerialID.Name = "txtSerialID";
            this.txtSerialID.Size = new System.Drawing.Size(233, 21);
            this.txtSerialID.TabIndex = 34;
            this.txtSerialID.Text = "f2d72bcb-88b2-4f93-af7a-0b10834848d9";
            // 
            // ClearDc
            // 
            this.ClearDc.AutoSize = true;
            this.ClearDc.Location = new System.Drawing.Point(621, 53);
            this.ClearDc.Name = "ClearDc";
            this.ClearDc.Size = new System.Drawing.Size(60, 16);
            this.ClearDc.TabIndex = 33;
            this.ClearDc.Text = "去直流";
            this.ClearDc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "预览点数";
            // 
            // WindowType
            // 
            this.WindowType.FormattingEnabled = true;
            this.WindowType.Items.AddRange(new object[] {
            "矩形窗",
            "指数窗",
            "Hanning窗",
            "hamming",
            "平顶窗",
            "Kaiser 窗",
            "CosRectangle",
            "Y1",
            "Y2",
            "Triangle",
            "HalfCos"});
            this.WindowType.Location = new System.Drawing.Point(529, 117);
            this.WindowType.Name = "WindowType";
            this.WindowType.Size = new System.Drawing.Size(70, 20);
            this.WindowType.TabIndex = 30;
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
            this.pointsperpage.Location = new System.Drawing.Point(378, 12);
            this.pointsperpage.Name = "pointsperpage";
            this.pointsperpage.Size = new System.Drawing.Size(70, 20);
            this.pointsperpage.TabIndex = 28;
            this.pointsperpage.SelectedIndexChanged += new System.EventHandler(this.pointsperpage_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(424, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 29;
            this.label13.Text = "窗函数类型";
            // 
            // SpectrumType
            // 
            this.SpectrumType.FormattingEnabled = true;
            this.SpectrumType.Items.AddRange(new object[] {
            "0 单峰值 ",
            "1 有效值 ",
            "2 功率谱 ",
            "3PSD"});
            this.SpectrumType.Location = new System.Drawing.Point(529, 57);
            this.SpectrumType.Name = "SpectrumType";
            this.SpectrumType.Size = new System.Drawing.Size(70, 20);
            this.SpectrumType.TabIndex = 41;
            // 
            // CalCv
            // 
            this.CalCv.Location = new System.Drawing.Point(317, 87);
            this.CalCv.Name = "CalCv";
            this.CalCv.Size = new System.Drawing.Size(70, 21);
            this.CalCv.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "指数窗系数";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 44;
            this.label11.Text = "fCalCv";
            // 
            // ExpPara
            // 
            this.ExpPara.Location = new System.Drawing.Point(320, 56);
            this.ExpPara.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ExpPara.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExpPara.Name = "ExpPara";
            this.ExpPara.Size = new System.Drawing.Size(70, 21);
            this.ExpPara.TabIndex = 32;
            this.ExpPara.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "时域波形的点数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "计算点数";
            // 
            // WavePtNum
            // 
            this.WavePtNum.Location = new System.Drawing.Point(144, 118);
            this.WavePtNum.Name = "WavePtNum";
            this.WavePtNum.Size = new System.Drawing.Size(70, 21);
            this.WavePtNum.TabIndex = 23;
            // 
            // FftPtNum
            // 
            this.FftPtNum.FormattingEnabled = true;
            this.FftPtNum.Items.AddRange(new object[] {
            "256",
            "512",
            "1024"});
            this.FftPtNum.Location = new System.Drawing.Point(318, 118);
            this.FftPtNum.Name = "FftPtNum";
            this.FftPtNum.Size = new System.Drawing.Size(70, 20);
            this.FftPtNum.TabIndex = 26;
            // 
            // WaveOffset
            // 
            this.WaveOffset.Location = new System.Drawing.Point(144, 57);
            this.WaveOffset.Name = "WaveOffset";
            this.WaveOffset.Size = new System.Drawing.Size(70, 21);
            this.WaveOffset.TabIndex = 43;
            this.WaveOffset.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 42;
            this.label10.Text = "计算起始点序号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "频谱类型";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "时域波形采样频率";
            // 
            // WaveSf
            // 
            this.WaveSf.Location = new System.Drawing.Point(144, 87);
            this.WaveSf.Name = "WaveSf";
            this.WaveSf.Size = new System.Drawing.Size(70, 21);
            this.WaveSf.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mcadLine1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 227);
            this.panel1.TabIndex = 2;
            // 
            // mcadLine1
            // 
            this.mcadLine1.AxisColor = System.Drawing.Color.Gray;
            this.mcadLine1.BackColor = System.Drawing.Color.White;
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
            this.mcadLine1.Location = new System.Drawing.Point(0, 0);
            this.mcadLine1.Lspan = 35;
            this.mcadLine1.Name = "mcadLine1";
            this.mcadLine1.Remainder = 0;
            this.mcadLine1.RightText = null;
            this.mcadLine1.Rspan = 70;
            this.mcadLine1.sindex = 0;
            this.mcadLine1.Size = new System.Drawing.Size(808, 227);
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
            // SpectrumPara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KeyPreview = true;
            this.Name = "SpectrumPara";
            this.Text = "自谱分析参数选择";
            this.Load += new System.EventHandler(this.WaveView_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CascadePercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpPara)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MCADLine mcadLine1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pointsperpage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerialID;
        private System.Windows.Forms.NumericUpDown CalOffset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CascadePercent;
        private System.Windows.Forms.ComboBox AverageType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SpectrumType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CalCv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox WaveOffset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ClearDc;
        private System.Windows.Forms.TextBox WavePtNum;
        private System.Windows.Forms.NumericUpDown ExpPara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FftPtNum;
        private System.Windows.Forms.ComboBox WindowType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox WaveSf;
        private System.Windows.Forms.Button btnOK;
    }
}