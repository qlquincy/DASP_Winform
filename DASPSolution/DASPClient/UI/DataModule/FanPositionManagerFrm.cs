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
using DASPClient.Common;

namespace DASPClient.UI.DataModule
{
    public partial class FanPositionManagerFrm : DockContent
    {
        ITBFanPositionManager posManager = null;

        List<ListItem> honeWayList = new List<ListItem>()
            {
                new ListItem("--请选择--","-1"),
                new ListItem("左","1"),
                new ListItem("右","2")
            };


        List<ListItem> laneWayList = new List<ListItem>()
            {
                new ListItem("--请选择--","-1"),
                new ListItem("1号","1"),
                new ListItem("2号","2"),
                new ListItem("3号","1"),
                new ListItem("4号","2")
            };

        public FanPositionManagerFrm()
        {
            InitializeComponent();
            ucToolBar.IconImage = ResourceDynamicReaderUtils.DynamicLoadResourceByResourceName("add.png");
            this.Load += new EventHandler(FanPositionManagerFrm_Load);
        }

        void FanPositionManagerFrm_Load(object sender, EventArgs e)
        {

            UI.CommonModule.DataGridViewActionButtonColumn actionColumn =
             new UI.CommonModule.DataGridViewActionButtonColumn();
            actionColumn.Name = "ColAction";
            actionColumn.DataPropertyName = "PositionId";
            actionColumn.MinimumWidth = 120;
            dgvDataSource.Columns.Add(actionColumn);

            ucToolBar.OnAddClick += new EventHandler(ucToolBar_OnAddClick);

            posManager = Utility.SpringUtils.Context.GetObject("FanPositionManager") as ITBFanPositionManager;

            LoadData();
        }

        void LoadData()
        {
            DASP.Domain.Common.Pager pager = new DASP.Domain.Common.Pager();
            pager.PageIndex = pagerControl.PageIndex;
            pager.PageSize = pagerControl.PageSize;

            IList<DASP.Domain.Entitys.TBFanPositionEntity> result = posManager.FindForPager(pager);
            dgvDataSource.AutoGenerateColumns = false;
            dgvDataSource.DataSource = result;

            pagerControl.DrawControl(pager.TotalCount);
        }

        void ucToolBar_OnAddClick(object sender, EventArgs e)
        {
            EditFanPosFrm editFrm = new EditFanPosFrm();
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

            if ((dgvDataSource.Rows[e.RowIndex].DataBoundItem != null) &&
                (dgvDataSource.Columns[e.ColumnIndex].DataPropertyName.Equals("HoleWay")))
            {

                ListItem listItem = honeWayList.Where(p => p.Value.Equals(e.Value.ToString())).FirstOrDefault();
                e.Value = listItem.Key;
            }

            if ((dgvDataSource.Rows[e.RowIndex].DataBoundItem != null) &&
               (dgvDataSource.Columns[e.ColumnIndex].DataPropertyName.Equals("LaneWay")))
            {

                ListItem listItem = laneWayList.Where(p => p.Value.Equals(e.Value.ToString())).FirstOrDefault();
                e.Value = listItem.Key;
            }
        }

        private void pagerControl_OnPageChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvDataSource_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DataGridViewActionButtonCell.IsModifyButtonClick(sender, e))
            {
                string objectId = dgvDataSource["ColAction", e.RowIndex].Value.ToString(); // 获取所要修改关联对象的主键
                DASP.Domain.Entitys.TBFanPositionEntity entity = posManager.Get(Guid.Parse(objectId));
                EditFanPosFrm editFrm = new EditFanPosFrm(entity);
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
