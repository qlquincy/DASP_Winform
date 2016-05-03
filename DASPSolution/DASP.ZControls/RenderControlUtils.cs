using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace DASP.ZControls
{
    public class RenderControlUtils
    {
        /// <summary>
        /// 获取当前命名空间下嵌入的资源图片
        /// </summary>
        /// <param name="imagePath">嵌入的图片资源的路径</param>
        public static Image GetImageFormResourceStream(string imagePath)
        {
            return Image.FromStream(
                Assembly.GetExecutingAssembly().
                GetManifestResourceStream(
                MethodBase.GetCurrentMethod().DeclaringType.Namespace + "." + imagePath));
        }
    }
}
