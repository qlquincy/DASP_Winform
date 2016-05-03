using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DASP.Tools;

namespace DASPClient
{
    public partial class MainFrm : BaseMainFrm
    {
        private UI.UserModule.UserManagerFrm userFrm;
        private UI.DataModule.ProjectManagerFrm projectFrm;
        private UI.DataModule.TunnelManagerFrm tunnelFrm;
        private UI.DataModule.FanPositionManagerFrm fanPosFrm;
        private UI.DataModule.TestDataManagerFrm testDataFrm;

        private DASP.Domain.Entitys.TBUserEntity currentLoginUser;

        public MainFrm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainFrm_Load);
        }

        public MainFrm(DASP.Domain.Entitys.TBUserEntity entity)
            : this()
        {
            currentLoginUser = entity;
            Global.UserInfoInstance.SetInstance(entity);
        }

        void MainFrm_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;

            userToolStripMenuItem.Image = ResourceDynamicReaderUtils.DynamicLoadResourceByResourceName("user72.png");
            dataToolStripMenuItem.Image = ResourceDynamicReaderUtils.DynamicLoadResourceByResourceName("data72.png");
            dockPanelContent.BackgroundImage = ResourceDynamicReaderUtils.DynamicLoadResourceByResourceName("bkg_blueteacup.jpg");
            dockPanelContent.BackgroundImageLayout = ImageLayout.Stretch;

            tableLayPanelMiddle.BackgroundImage = ResourceDynamicReaderUtils.DynamicLoadResourceByResourceName("bg.png");
            tableLayPanelMiddle.BackgroundImageLayout = ImageLayout.Stretch;
            panelLeftColumn.BackColor = Color.Transparent;
            linkLblChangePwd.BackColor = Color.Transparent;
            linkLblExit.BackColor = Color.Transparent;

            string diplayLoginInfo = lblDisplayLoginInfo.Text;
            lblDisplayLoginInfo.Text = string.Format(diplayLoginInfo, currentLoginUser.UserName);
        }

        private void UserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dockPanelContent.Contents.Contains(userFrm))
            {
                userFrm.Show(this.dockPanelContent);
            }
            else
            {
                userFrm = new UI.UserModule.UserManagerFrm();
                userFrm.Show(this.dockPanelContent);
            }
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dockPanelContent.Contents.Contains(projectFrm))
            {
                projectFrm.Show(this.dockPanelContent);
            }
            else
            {
                projectFrm = new UI.DataModule.ProjectManagerFrm();
                projectFrm.Show(this.dockPanelContent);
            }
        }

        private void linkLblChangePwd_Click(object sender, EventArgs e)
        {
            UI.UserModule.ChangePasswordFrm changeFrm = new UI.UserModule.ChangePasswordFrm();
            changeFrm.ShowDialog();
        }

        private void linkLblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tunnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dockPanelContent.Contents.Contains(tunnelFrm))
            {
                tunnelFrm.Show(this.dockPanelContent);
            }
            else
            {
                tunnelFrm = new UI.DataModule.TunnelManagerFrm();
                tunnelFrm.Show(this.dockPanelContent);
            }
        }

        private void fanPosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dockPanelContent.Contents.Contains(fanPosFrm))
            {
                fanPosFrm.Show(this.dockPanelContent);
            }
            else
            {
                fanPosFrm = new UI.DataModule.FanPositionManagerFrm();
                fanPosFrm.Show(this.dockPanelContent);
            }
        }

        private void dataAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dockPanelContent.Contents.Contains(testDataFrm))
            {
                testDataFrm.Show(this.dockPanelContent);
            }
            else
            {
                testDataFrm = new UI.DataModule.TestDataManagerFrm();
                testDataFrm.Show(this.dockPanelContent);
            }
        } 
    }
}
