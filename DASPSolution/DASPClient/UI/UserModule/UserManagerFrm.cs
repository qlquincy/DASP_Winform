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

namespace DASPClient.UI.UserModule
{
    public partial class UserManagerFrm : DockContent
    {
        ITBUserManager userManager;

        public UserManagerFrm()
        {
            InitializeComponent();
            ucToolBar.IconImage = ResourceDynamicReaderUtils.DynamicLoadResourceByResourceName("add.png");
            this.Load += new EventHandler(UserManagerFrm_Load);
        }

        void UserManagerFrm_Load(object sender, EventArgs e)
        {
            UI.CommonModule.DataGridViewActionButtonColumn actionColumn =
                new UI.CommonModule.DataGridViewActionButtonColumn();
            actionColumn.Name = "ColAction";
            actionColumn.DataPropertyName = "UserId";
            dgvUserDataSource.Columns.Add(actionColumn);

          
            ucToolBar.OnAddClick += new EventHandler(ucToolBar_OnAddClick);

            userManager = DASPClient.Utility.SpringUtils.Context.GetObject("UserManager") as ITBUserManager;
            LoadData(userManager);
        }

        void LoadData(ITBUserManager userManager)
        {
            dgvUserDataSource.AutoGenerateColumns = false;
            dgvUserDataSource.DataSource = userManager.GetAll();
        }

        void ucToolBar_OnAddClick(object sender, EventArgs e)
        {
            EditUserFrm editFrm = new EditUserFrm();
            editFrm.FormClosed += new FormClosedEventHandler(editFrm_FormClosed);
            editFrm.ShowDialog();
        }

        void editFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData(userManager);
        }

           /// <summary>
        /// 用户单击DataGridView时的事件处理方法。
        /// </summary>
        private void dgvUserDataSource_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {       
            //用户单击DataGridView“操作”列中的“修改”按钮。
            if (DataGridViewActionButtonCell.IsModifyButtonClick(sender, e))
            {
                string objectId = dgvUserDataSource["ColAction", e.RowIndex].Value.ToString(); // 获取所要修改关联对象的主键。
                DASP.Domain.Entitys.TBUserEntity entity = userManager.Get(Guid.Parse(objectId));
                EditUserFrm editFrm = new EditUserFrm(entity);
                editFrm.FormClosed += new FormClosedEventHandler(editFrm_FormClosed);
                editFrm.ShowDialog();
            }

            //用户单击DataGridView“操作”列中的“删除”按钮。
            if (DataGridViewActionButtonCell.IsDeleteButtonClick(sender, e))
            {
                string objectId = dgvUserDataSource["ColAction", e.RowIndex].Value.ToString(); // 获取所要删除关联对象的主键。
                
            }
        }

        private void dgvUserDataSource_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
