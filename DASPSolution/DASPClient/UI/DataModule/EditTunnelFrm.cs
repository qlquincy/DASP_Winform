using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DASP.ZControls;
using DASP.Business.IManager;

namespace DASPClient.UI.DataModule
{
    public partial class EditTunnelFrm : FormEx
    {
        DASP.Domain.Entitys.TBTunnelEntity tunnelEntity = null;
        ITBProjectManager projectManager = null;
        ITBTunnelManager tunnelManager = null;


        public EditTunnelFrm()
            : base()
        {
            InitializeComponent();
            this.Load += new EventHandler(EditTunnelFrm_Load);
        }

        public EditTunnelFrm(DASP.Domain.Entitys.TBTunnelEntity entity)
            : this()
        {
            this.Text = "修改隧道";
            this.tunnelEntity = entity;
        }

        void EditTunnelFrm_Load(object sender, EventArgs e)
        {
            //居中显示
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2;

            projectManager = Utility.SpringUtils.Context.GetObject("ProjectManager") as ITBProjectManager;
            tunnelManager = Utility.SpringUtils.Context.GetObject("TunnelManager") as ITBTunnelManager;
            BuildComBoxDataSource(); 
        }

        private void BuildComBoxDataSource()
        {
            IList<DASP.Domain.Entitys.TBProjectEntity> result = projectManager.FindAllProjects();
            if (null == result)
            {
                result = new List<DASP.Domain.Entitys.TBProjectEntity>();
            }
            DASP.Domain.Entitys.TBProjectEntity defaultItem = new DASP.Domain.Entitys.TBProjectEntity();
            defaultItem.ProjectId = Guid.Empty;
            defaultItem.ProjectName = "-- 请选择 --";
            result.Insert(0, defaultItem);

            cboBoxProject.DataSource = result;
            cboBoxProject.ValueMember = "ProjectId";
            cboBoxProject.DisplayMember = "ProjectName";
           
            LoadData();
        }

        private void LoadData()
        {
            if (this.tunnelEntity != null)
            {
                txtTunnelName.Text = this.tunnelEntity.TunnelName;
                txtStartDate.Text = this.tunnelEntity.TunnelStartDate;
                txtEndDate.Text = this.tunnelEntity.TunnelEndDate;
                txtRemark.Text = this.tunnelEntity.Remark;
                txtLeader.Text = this.tunnelEntity.TunnelLeader;
               
                cboBoxProject.SelectedValue = this.tunnelEntity.Project.ProjectId;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (formValid.IsValid)
            {
                bool isUpdate = false;
                if (this.tunnelEntity == null)
                {
                    this.tunnelEntity = new DASP.Domain.Entitys.TBTunnelEntity();
                    this.tunnelEntity.TunnelId = Guid.NewGuid();
                    this.tunnelEntity.TunnelName = txtTunnelName.Text.Trim();
                    this.tunnelEntity.TunnelStartDate = txtStartDate.Text.Trim();
                    this.tunnelEntity.TunnelEndDate = txtEndDate.Text.Trim();
                    this.tunnelEntity.TunnelLeader = txtLeader.Text.Trim();
                    this.tunnelEntity.Remark = txtRemark.Text.Trim();


                    this.tunnelEntity.CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    this.tunnelEntity.Creator = Global.UserInfoInstance.CurrentLoginUser;
                    this.tunnelEntity.Project = (DASP.Domain.Entitys.TBProjectEntity)cboBoxProject.SelectedItem;

                    isUpdate = false;
                }
                else
                {
                    this.tunnelEntity.TunnelName = txtTunnelName.Text.Trim();
                    this.tunnelEntity.TunnelStartDate = txtStartDate.Text.Trim();
                    this.tunnelEntity.TunnelEndDate = txtEndDate.Text.Trim();
                    this.tunnelEntity.TunnelLeader = txtLeader.Text.Trim();
                    this.tunnelEntity.Remark = txtRemark.Text.Trim();

                    this.tunnelEntity.Creator = Global.UserInfoInstance.CurrentLoginUser;
                    this.tunnelEntity.Project = (DASP.Domain.Entitys.TBProjectEntity)cboBoxProject.SelectedItem;
                    isUpdate = true;
                }

                this.tunnelEntity.UpdateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                try
                {
                    if (isUpdate)
                    {
                        tunnelManager.Update(this.tunnelEntity);
                    }
                    else
                    {
                        tunnelManager.Save(this.tunnelEntity);
                    }

                    ZMessageBox.Show(this, "保存成功！", "提示", ZMessageBoxIcon.Information, ZMessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception ex)
                {
                    ZMessageBox.Show(this, string.Format("保存失败:{0}！", ex.Message), "提示", ZMessageBoxIcon.Information, ZMessageBoxButtons.OK);
                }
            }
        }

        private void cusValid_Validating(object sender, CommonUtil.Validators.CustomValidator.ValidatingCancelEventArgs e)
        {
           ComboBox cboBoxProject = e.ControlToValidate as ComboBox;
           DASP.Domain.Entitys.TBProjectEntity selectItem = cboBoxProject.SelectedItem as DASP.Domain.Entitys.TBProjectEntity;
           if (selectItem.ProjectId == Guid.Empty)
           {
               e.Valid = false;
           }
           else
           {
               e.Valid = true;
           }
        }
    }
}
