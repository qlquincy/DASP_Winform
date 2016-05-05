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
            this.panel2 = new System.Windows.Forms.Panel();
            this.mcadLine1 = new Dasp.MCADLine();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mcadLine1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 462);
            this.panel2.TabIndex = 47;
            // 
            // mcadLine1
            // 
            this.mcadLine1.AxisColor = System.Drawing.Color.Gray;
            this.mcadLine1.barDiffWidth = 4;
            this.mcadLine1.barWidth = 2;
            this.mcadLine1.BgColor = System.Drawing.Color.Snow;
            this.mcadLine1.BmSpan = 4;
            this.mcadLine1.BorderColor = System.Drawing.Color.Black;
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
            this.mcadLine1.Size = new System.Drawing.Size(871, 462);
            this.mcadLine1.SliceColor = System.Drawing.Color.Black;
            this.mcadLine1.SliceTextColor = System.Drawing.Color.Black;
            this.mcadLine1.StartPindex = 0;
            this.mcadLine1.TabIndex = 0;
            this.mcadLine1.TextColor = System.Drawing.Color.White;
            this.mcadLine1.Title = "实时线";
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
            // REF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 462);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "REF";
            this.Text = "传递函数分析";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MCADLine mcadLine1;
    }
}