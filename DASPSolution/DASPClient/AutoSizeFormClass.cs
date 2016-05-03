using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DASPClient
{
    /// <summary>
    /// 自适应窗体
    /// </summary>
    internal class AutoSizeFormClass
    {
        /// <summary>
        /// 声明结构,只记录窗体和其控件的初始位置和大小
        /// </summary>
        public struct controlRect
        {
            public int Left;
            public int Top;
            public int Width;
            public int Height;
        }

        /// <summary>
        /// 注意这里不能使用控件列表记录 List nCtrl;，因为控件的关联性，记录的始终是当前的大小
        /// </summary>
        public List<controlRect> oldCtrl = new List<controlRect>();
        int ctrlNo = 0;


        /// <summary>
        /// 记录窗体和其控件的初始位置和大小
        /// </summary>
        /// <param name="mForm"></param>
        public void controllInitializeSize(Control mForm)
        {
            controlRect cR;
            cR.Left = mForm.Left; cR.Top = mForm.Top; cR.Width = mForm.Width; cR.Height = mForm.Height;
            oldCtrl.Add(cR);//第一个为"窗体本身",只加入一次即可

            AddControl(mForm);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
        }

        private void AddControl(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {  
                controlRect objCtrl;
                objCtrl.Left = c.Left; objCtrl.Top = c.Top; objCtrl.Width = c.Width; objCtrl.Height = c.Height;
                oldCtrl.Add(objCtrl);

                if (c.Controls.Count > 0)
                {
                    AddControl(c);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
                }
            }
        }

        //(3.2)控件自适应大小,
        public void controlAutoSize(Control mForm)
        {
            if (ctrlNo == 0)
            { 
                controlRect cR;
                //  cR.Left = mForm.Left; cR.Top = mForm.Top; cR.Width = mForm.Width; cR.Height = mForm.Height;
                cR.Left = 0; cR.Top = 0; cR.Width = mForm.PreferredSize.Width; cR.Height = mForm.PreferredSize.Height;

                oldCtrl.Add(cR);//第一个为"窗体本身",只加入一次即可

                AddControl(mForm);//窗体内其余控件可能嵌套其它控件(比如panel),故单独抽出以便递归调用
            }
            float wScale = (float)mForm.Width / (float)oldCtrl[0].Width;//新旧窗体之间的比例，与最早的旧窗体
            float hScale = (float)mForm.Height / (float)oldCtrl[0].Height;//.Height;
            ctrlNo = 1;//进入=1，第0个为窗体本身,窗体内的控件,从序号1开始

            AutoScaleControl(mForm, wScale, hScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
        }

        private void AutoScaleControl(Control ctl, float wScale, float hScale)
        {
            int ctrLeft0, ctrTop0, ctrWidth0, ctrHeight0;
            foreach (Control c in ctl.Controls)
            {
              
                ctrLeft0 = oldCtrl[ctrlNo].Left;
                ctrTop0 = oldCtrl[ctrlNo].Top;
                ctrWidth0 = oldCtrl[ctrlNo].Width;
                ctrHeight0 = oldCtrl[ctrlNo].Height;
                c.Left = (int)((ctrLeft0) * wScale);//新旧控件之间的线性比例。控件位置只相对于窗体，所以不能加 + wLeft1
                c.Top = (int)((ctrTop0) * hScale);//
                c.Width = (int)(ctrWidth0 * wScale);//只与最初的大小相关，所以不能与现在的宽度相乘 (int)(c.Width * w);
                c.Height = (int)(ctrHeight0 * hScale);//
                ctrlNo++;//累加序号
                
                if (c.Controls.Count > 0)
                {
                    AutoScaleControl(c, wScale, hScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
                }

            }
        }

    }
}
