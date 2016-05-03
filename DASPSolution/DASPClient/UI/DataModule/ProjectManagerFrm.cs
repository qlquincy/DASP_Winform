using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using DASP.Business.IManager;
using DASPClient.UI.CommonModule;
using DASP.Tools;

namespace DASPClient.UI.DataModule
{
    public partial class ProjectManagerFrm : DockContent
    {
        ITBProjectManager projectManager;

        public ProjectManagerFrm()
        { 
            InitializeComponent();

            ucToolBar.IconImage = ResourceDynamicReaderUtils.DynamicLoadResourceByResourceName("add.png");
            this.Load += new EventHandler(ProjectManagerFrm_Load);
        }

        void ProjectManagerFrm_Load(object sender, EventArgs e)
        {
            UI.CommonModule.DataGridViewActionButtonColumn actionColumn =
                new UI.CommonModule.DataGridViewActionButtonColumn();
            actionColumn.Name = "ColAction";
            actionColumn.DataPropertyName = "ProjectId";
            actionColumn.MinimumWidth = 120;
            dgvDataSource.Columns.Add(actionColumn);

          
            ucToolBar.OnAddClick += new EventHandler(ucToolBar_OnAddClick);

            projectManager = Utility.SpringUtils.Context.GetObject("ProjectManager") as ITBProjectManager;
            LoadData();

        }

        void ucToolBar_OnAddClick(object sender, EventArgs e)
        {
            EditProjectFrm editFrm = new EditProjectFrm();
            editFrm.FormClosed += new FormClosedEventHandler(editFrm_FormClosed);
            editFrm.ShowDialog();
        }

        void editFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
           var dataSource = projectManager.GetAll();
           dgvDataSource.AutoGenerateColumns = false;
           dgvDataSource.DataSource = dataSource;
        }

        private void dgvDataSource_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DataGridViewActionButtonCell.IsModifyButtonClick(sender, e))
            {
                string objectId = dgvDataSource["ColAction", e.RowIndex].Value.ToString(); // 获取所要修改关联对象的主键。
                DASP.Domain.Entitys.TBProjectEntity entity = projectManager.Get(Guid.Parse(objectId));
                EditProjectFrm editFrm = new EditProjectFrm(entity);
                editFrm.FormClosed += new FormClosedEventHandler(editFrm_FormClosed);
                editFrm.ShowDialog();
            }

            if (DataGridViewActionButtonCell.IsDeleteButtonClick(sender, e))
            {
                string objectId = dgvDataSource["ColAction", e.RowIndex].Value.ToString(); // 获取所要删除关联对象的主键

            }
        }
    }
}
