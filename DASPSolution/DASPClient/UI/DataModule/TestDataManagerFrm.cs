using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using DASP.Tools;
using DASP.Business.IManager;
using DASPClient.UI.CommonModule;

namespace DASPClient.UI.DataModule
{
    public partial class TestDataManagerFrm : DockContent
    {

        ITBTestDataManager testDataManager = null;

        public TestDataManagerFrm()
        {
            InitializeComponent();
            ucToolBar.IconImage = ResourceDynamicReaderUtils.DynamicLoadResourceByResourceName("add.png");
            this.Load += new EventHandler(TestDataManagerFrm_Load);
        }

        void TestDataManagerFrm_Load(object sender, EventArgs e)
        {
            UI.CommonModule.DataGridViewActionButtonColumn actionColumn =
            new UI.CommonModule.DataGridViewActionButtonColumn();
            actionColumn.Name = "ColAction";
            actionColumn.DataPropertyName = "DataId";
            actionColumn.MinimumWidth = 120;
            dgvDataSource.Columns.Add(actionColumn);

            this.ucToolBar.OnAddClick += new EventHandler(ucToolBar_OnAddClick);
            testDataManager = Utility.SpringUtils.Context.GetObject("TestDataManager") as ITBTestDataManager;

            LoadData();
        }

        void LoadData()
        {
            DASP.Domain.Common.Pager pager = new DASP.Domain.Common.Pager();
            pager.PageIndex = pagerControl.PageIndex;
            pager.PageSize = pagerControl.PageSize;

            IList<DASP.Domain.Entitys.TBTestDataEntity> result = testDataManager.FindForPager(pager);
            dgvDataSource.AutoGenerateColumns = false;
            dgvDataSource.DataSource = result;

            pagerControl.DrawControl(pager.TotalCount);
        }

        void ucToolBar_OnAddClick(object sender, EventArgs e)
        {
            EditTestFrm editFrm = new EditTestFrm();
            editFrm.FormClosed += new FormClosedEventHandler(editFrm_FormClosed);
            editFrm.ShowDialog();
        }

        void editFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void dgvDataSource_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvDataSource.Rows[e.RowIndex].DataBoundItem != null) &&
                 (dgvDataSource.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                string[] nameAndProp = dgvDataSource.Columns[e.ColumnIndex].DataPropertyName.Split(new char[] { '.' });
                object pObj = dgvDataSource.Rows[e.RowIndex].DataBoundItem;
                System.Reflection.PropertyInfo objProp = pObj.GetType().GetProperty(nameAndProp[0]);
                object unboundValue = objProp.GetValue(pObj, null);
                if (null == unboundValue) return;
                System.Reflection.PropertyInfo objectProperty = unboundValue.GetType().GetProperty(nameAndProp[1]);
                e.Value = objectProperty.GetValue(unboundValue, null).ToString();
            }
        }

        private void dgvDataSource_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DataGridViewActionButtonCell.IsModifyButtonClick(sender, e))
            {
                string objectId = dgvDataSource["ColAction", e.RowIndex].Value.ToString(); // 获取所要修改关联对象的主键
                DASP.Domain.Entitys.TBTestDataEntity entity = testDataManager.Get(Guid.Parse(objectId));
                EditTestFrm editFrm = new EditTestFrm(entity);
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
