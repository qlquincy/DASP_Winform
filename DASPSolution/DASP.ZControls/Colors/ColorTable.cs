using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DASP.ZControls
{
   
    /// <summary>
    /// 实现效果控件内部使用颜色表
    /// </summary>
    internal class ColorTable
    {
        public static Color BorderColor = Color.LightBlue;  //LightBlue = Color.FromArgb(173, 216, 230)
        public static Color HighLightColor =RenderHelper.GetColor(BorderColor,255,-63,-11,23);   //Color.FromArgb(110, 205, 253)
        public static Color HighLightInnerColor = RenderHelper.GetColor(BorderColor, 255, -100, -44, 1);   //Color.FromArgb(73, 172, 231);
    }
}
