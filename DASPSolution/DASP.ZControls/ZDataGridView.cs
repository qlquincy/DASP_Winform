using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ZControls
{
    /// <summary>
    /// 类说明：ZDataGridView控件的实现用来代替系统的DataGridView控件
    /// </summary>
    public class ZDataGridView : System.Windows.Forms.DataGridView
    {
        public ZDataGridView()
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnCreateControl()
        {
            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(247, 246, 239);
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            this.ColumnHeadersHeight = 26;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.RowHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.RowHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.RowHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DefaultCellStyle.SelectionBackColor = Color.Wheat;
            this.DefaultCellStyle.SelectionForeColor = Color.DarkSlateBlue;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AllowUserToOrderColumns = true;
            this.AutoGenerateColumns = true;

            //奇数行的颜色
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(216, 229, 248);
            base.OnCreateControl();
        }

        #region 鼠标颜色
        Color defaultcolor;

        //移到单元格时的颜色
        protected override void OnCellMouseMove(DataGridViewCellMouseEventArgs e)
        {
            base.OnCellMouseMove(e);
            try
            {
                Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.YellowGreen;
            }
            catch { }
        }

        //进入单元格时保存当前的颜色

        protected override void OnCellMouseEnter(DataGridViewCellEventArgs e)
        {
            base.OnCellMouseEnter(e);
            try
            {
                defaultcolor = Rows[e.RowIndex].DefaultCellStyle.BackColor;
            }
            catch { }
        }

        //离开时还原颜色
        protected override void OnCellMouseLeave(DataGridViewCellEventArgs e)
        {
            base.OnCellMouseLeave(e);
            try
            {
                Rows[e.RowIndex].DefaultCellStyle.BackColor = defaultcolor;
            }
            catch { }
        }

        //在生成列表时添加一个行号，颜色默认为红色
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            base.OnRowPostPaint(e);
            //自动编号与数据库无关
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), RowHeadersDefaultCellStyle.Font, rectangle,
             Color.Red, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        #endregion

    }
}
