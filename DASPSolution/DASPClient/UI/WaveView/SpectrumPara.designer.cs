namespace ChartTrialProgram
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
            this.btnCal = new System.Windows.Forms.Button();
            this.CascadePercent = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.ClearDc = new System.Windows.Forms.CheckBox();
            this.ExpPara = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.WindowType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WaveSf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FftPtNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenData = new System.Windows.Forms.Button();
            this.WavePtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AverageType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SpectrumType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WaveOffset = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CalCv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncmp = new System.Windows.Forms.Button();
            this.CalOffset = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CascadePercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpPara)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(12, 49);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(98, 29);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "计算参数";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // CascadePercent
            // 
            this.CascadePercent.Location = new System.Drawing.Point(743, 93);
            this.CascadePercent.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.CascadePercent.Name = "CascadePercent";
            this.CascadePercent.Size = new System.Drawing.Size(70, 21);
            this.CascadePercent.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(651, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 36;
            this.label9.Text = "重叠比例";
            // 
            // ClearDc
            // 
            this.ClearDc.AutoSize = true;
            this.ClearDc.Location = new System.Drawing.Point(508, 87);
            this.ClearDc.Name = "ClearDc";
            this.ClearDc.Size = new System.Drawing.Size(60, 16);
            this.ClearDc.TabIndex = 33;
            this.ClearDc.Text = "去直流";
            this.ClearDc.UseVisualStyleBackColor = true;
            // 
            // ExpPara
            // 
            this.ExpPara.Location = new System.Drawing.Point(555, 26);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "指数窗系数";
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
            this.WindowType.Location = new System.Drawing.Point(373, 88);
            this.WindowType.Name = "WindowType";
            this.WindowType.Size = new System.Drawing.Size(70, 20);
            this.WindowType.TabIndex = 30;
            this.WindowType.SelectedIndexChanged += new System.EventHandler(this.cmb3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "窗函数类型";
            // 
            // WaveSf
            // 
            this.WaveSf.Location = new System.Drawing.Point(408, 22);
            this.WaveSf.Name = "WaveSf";
            this.WaveSf.Size = new System.Drawing.Size(70, 21);
            this.WaveSf.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "时域波形采样频率";
            // 
            // FftPtNum
            // 
            this.FftPtNum.FormattingEnabled = true;
            this.FftPtNum.Items.AddRange(new object[] {
            "256",
            "512",
            "1024"});
            this.FftPtNum.Location = new System.Drawing.Point(207, 85);
            this.FftPtNum.Name = "FftPtNum";
            this.FftPtNum.Size = new System.Drawing.Size(70, 20);
            this.FftPtNum.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "计算点数";
            // 
            // btnOpenData
            // 
            this.btnOpenData.Location = new System.Drawing.Point(14, 7);
            this.btnOpenData.Name = "btnOpenData";
            this.btnOpenData.Size = new System.Drawing.Size(87, 33);
            this.btnOpenData.TabIndex = 24;
            this.btnOpenData.Text = "打开数据文件";
            this.btnOpenData.UseVisualStyleBackColor = true;
            this.btnOpenData.Click += new System.EventHandler(this.btnOpenData_Click);
            // 
            // WavePtNum
            // 
            this.WavePtNum.Location = new System.Drawing.Point(229, 55);
            this.WavePtNum.Name = "WavePtNum";
            this.WavePtNum.Size = new System.Drawing.Size(70, 21);
            this.WavePtNum.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "时域波形的点数";
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
            this.AverageType.Location = new System.Drawing.Point(743, 54);
            this.AverageType.Name = "AverageType";
            this.AverageType.Size = new System.Drawing.Size(70, 20);
            this.AverageType.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 38;
            this.label7.Text = "平均方式";
            // 
            // SpectrumType
            // 
            this.SpectrumType.FormattingEnabled = true;
            this.SpectrumType.Items.AddRange(new object[] {
            "0 单峰值 ",
            "1 有效值 ",
            "2 功率谱 ",
            "3PSD"});
            this.SpectrumType.Location = new System.Drawing.Point(727, 19);
            this.SpectrumType.Name = "SpectrumType";
            this.SpectrumType.Size = new System.Drawing.Size(70, 20);
            this.SpectrumType.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "频谱类型";
            // 
            // WaveOffset
            // 
            this.WaveOffset.Location = new System.Drawing.Point(229, 28);
            this.WaveOffset.Name = "WaveOffset";
            this.WaveOffset.Size = new System.Drawing.Size(70, 21);
            this.WaveOffset.TabIndex = 43;
            this.WaveOffset.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 42;
            this.label10.Text = "计算起始点序号";
            // 
            // CalCv
            // 
            this.CalCv.Location = new System.Drawing.Point(390, 54);
            this.CalCv.Name = "CalCv";
            this.CalCv.Size = new System.Drawing.Size(70, 21);
            this.CalCv.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 44;
            this.label11.Text = "fCalCv";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncmp);
            this.panel1.Controls.Add(this.CalOffset);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnOpenData);
            this.panel1.Controls.Add(this.CascadePercent);
            this.panel1.Controls.Add(this.AverageType);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.SpectrumType);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CalCv);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.WaveOffset);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ClearDc);
            this.panel1.Controls.Add(this.WavePtNum);
            this.panel1.Controls.Add(this.ExpPara);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.FftPtNum);
            this.panel1.Controls.Add(this.WindowType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.WaveSf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 120);
            this.panel1.TabIndex = 46;
            // 
            // btncmp
            // 
            this.btncmp.Location = new System.Drawing.Point(14, 85);
            this.btncmp.Name = "btncmp";
            this.btncmp.Size = new System.Drawing.Size(91, 31);
            this.btncmp.TabIndex = 48;
            this.btncmp.Text = "打开比较文件";
            this.btncmp.UseVisualStyleBackColor = true;
            this.btncmp.Click += new System.EventHandler(this.btncmp_Click);
            // 
            // CalOffset
            // 
            this.CalOffset.Location = new System.Drawing.Point(574, 60);
            this.CalOffset.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.CalOffset.Name = "CalOffset";
            this.CalOffset.Size = new System.Drawing.Size(70, 21);
            this.CalOffset.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 46;
            this.label8.Text = "fCalOffset";
            // 
            // Spectrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 462);
            this.Controls.Add(this.panel1);
            this.Name = "Spectrum";
            this.Text = "Spectrum";
            ((System.ComponentModel.ISupportInitialize)(this.CascadePercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpPara)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalOffset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.NumericUpDown CascadePercent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ClearDc;
        private System.Windows.Forms.NumericUpDown ExpPara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox WindowType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WaveSf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FftPtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenData;
        private System.Windows.Forms.TextBox WavePtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AverageType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SpectrumType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WaveOffset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CalCv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown CalOffset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncmp;
    }
}