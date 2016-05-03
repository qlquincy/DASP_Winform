using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DASP.Tools;

namespace DASPClient.UI.CommonModule
{
    public partial class UCToolBar : UserControl
    {

        public event EventHandler OnAddClick;

        public Image IconImage
        {
            set;
            private get;
        }
        
        public UCToolBar()
        {
            InitializeComponent();
            this.Load += new EventHandler(UCToolBar_Load);
        }

        void UCToolBar_Load(object sender, EventArgs e)
        {
           
            btnAdd.BackColor = Color.Transparent;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Image = this.IconImage;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Click += new EventHandler(btnAdd_Click);
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            if (null != OnAddClick)
            {
                OnAddClick(sender,e);
            }
        }
    }
}
