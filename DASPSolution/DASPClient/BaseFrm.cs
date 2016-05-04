using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DASP.ZControls;
using DASP.Tools;

namespace DASPClient
{
    public partial class BaseFrm : FormEx
    {
        public BaseFrm()
            :base()
        {
            InitializeComponent();
            //this.Icon = Icon.FromHandle(((Bitmap)ResourceDynamicReaderUtils.DynamicLoadResourceByResourceName("logo.png")).GetHicon());
        }
    }
}
