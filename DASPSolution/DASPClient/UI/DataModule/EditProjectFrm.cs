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
    public partial class EditProjectFrm : FormEx
    {
        ITBProjectManager projectManager = null;
        DASP.Domain.Entitys.TBProjectEntity projectEntity = null;

        public EditProjectFrm()
        {
            InitializeComponent();
            this.Load += new EventHandler(EditProjectFrm_Load);
        }

        public EditProjectFrm(DASP.Domain.Entitys.TBProjectEntity entity)
            :this()
        {
            this.Text = "修改合同";
            this.projectEntity = entity;
        }

        void EditProjectFrm_Load(object sender, EventArgs e)
        {
            //居中显示
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2;

            projectManager = Utility.SpringUtils.Context.GetObject("ProjectManager") as ITBProjectManager;

            LoadData();
        }

        void LoadData()
        {
            if (this.projectEntity != null)
            {
                txtProjectName.Text = this.projectEntity.ProjectName;
                txtProjectDate.Text = this.projectEntity.ProjectDate;
                txtProjectLeader.Text = this.projectEntity.ProjectLeader;
                txtProjectRemark.Text = this.projectEntity.Remark;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (formValid.IsValid)
            {
                string projectName = txtProjectName.Text.Trim();
                string projectDate = txtProjectDate.Text.Trim();
                DateTime result;
                if (!DateTime.TryParse(projectDate, out result))
                {
                    ZMessageBox.Show(this, string.Format("合同日期不是时间格式！"), "提示", ZMessageBoxIcon.Information, ZMessageBoxButtons.OK);
                    return;
                }
         
                string projectLeader = txtProjectLeader.Text.Trim();
                string projectRemark = txtProjectRemark.Text.Trim();

                DASP.Domain.Entitys.TBProjectEntity entity = null;
                bool isUpdate = false;
                if (this.projectEntity != null)
                {
                    entity = this.projectEntity;
                    isUpdate = true;
                }
                else
                {
                    entity = new DASP.Domain.Entitys.TBProjectEntity();
                    entity.ProjectId = Guid.NewGuid();
                    entity.CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    isUpdate = false;
                }

                entity.ProjectName = projectName;
                entity.ProjectDate = projectDate;
                entity.ProjectLeader = projectLeader;
                entity.Remark = projectRemark;
                entity.UpdateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                entity.Creator = Global.UserInfoInstance.CurrentLoginUser;

                try
                {
                    if (isUpdate)
                    {
                        projectManager.Update(entity);
                    }
                    else
                    {
                        projectManager.Save(entity);
                    }

                    ZMessageBox.Show(this,"保存成功！","提示",ZMessageBoxIcon.Information,ZMessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception ex)
                {
                    ZMessageBox.Show(this, string.Format("保存失败:{0}！",ex.Message), "提示", ZMessageBoxIcon.Information, ZMessageBoxButtons.OK);
                }
            }
        }

    }
}
