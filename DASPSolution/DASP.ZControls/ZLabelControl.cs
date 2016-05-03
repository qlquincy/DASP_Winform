using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.Design;
using System.ComponentModel;

namespace ZControls
{
    [Designer(typeof(ZLabelControlDesigner))]
    public class ZLabelControl : Control
    {

        public ZLabelControl():
            base()
        {
            SetStyles();
            this.BackColor = Color.Transparent;
            this.Font = new Font("微软雅黑", 10.0f, FontStyle.Bold);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; //WS_EX_TRANSPARENT 
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //计算文字的高度宽度
            SizeF size = e.Graphics.MeasureString(this.Text,this.Font);
            this.Height = (int)size.Height + 1;
            this.Width = (int)size.Width + 1;

            e.Graphics.DrawString(this.Text,this.Font,new SolidBrush(this.ForeColor),this.ClientRectangle);
            base.OnPaint(e);
        }

        private void SetStyles()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();
        }
    }

    class ZLabelControlDesigner : ControlDesigner
    {
        public override SelectionRules SelectionRules
        {
            get
            {
                return System.Windows.Forms.Design.SelectionRules.Moveable;
            }
        }
    }
}
