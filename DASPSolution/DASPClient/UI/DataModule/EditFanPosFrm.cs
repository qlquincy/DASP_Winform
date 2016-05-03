using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DASP.ZControls;
using DASPClient.Common;
using DASP.Business.IManager;

namespace DASPClient.UI.DataModule
{
    public partial class EditFanPosFrm : FormEx
    {
        ITBTunnelManager tunnelManager = null;
        ITBFanPositionManager posManager = null;
        DASP.Domain.Entitys.TBFanPositionEntity fanPosEntity = null;

        public EditFanPosFrm():
            base()
        {
            InitializeComponent();
            this.Load += new EventHandler(EditFanPosFrm_Load);
        }

        public EditFanPosFrm(DASP.Domain.Entitys.TBFanPositionEntity entity)
            :this()
        {
            this.Text = "修改风机位置";
            this.fanPosEntity = entity;
        }

        void EditFanPosFrm_Load(object sender, EventArgs e)
        {
            //居中显示
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2;

            tunnelManager = Utility.SpringUtils.Context.GetObject("TunnelManager") as ITBTunnelManager;
            posManager = Utility.SpringUtils.Context.GetObject("FanPositionManager") as ITBFanPositionManager;

            BindData();
        }

        private void BindData()
        {
            List<ListItem> honeWayList = new List<ListItem>()
            {
                new ListItem("--请选择--","-1"),
                new ListItem("左","1"),
                new ListItem("右","2")
            };

            cboBoxHoleWay.DataSource = honeWayList;
            cboBoxHoleWay.DisplayMember = "Key";
            cboBoxHoleWay.ValueMember = "Value";

            List<ListItem> laneWayList = new List<ListItem>()
            {
                new ListItem("--请选择--","-1"),
                new ListItem("1号","1"),
                new ListItem("2号","2"),
                new ListItem("3号","1"),
                new ListItem("4号","2")
            };

            cboBoxLaneWay.DataSource = laneWayList;
            cboBoxLaneWay.DisplayMember = "Key";
            cboBoxLaneWay.ValueMember = "Value";


            IList<DASP.Domain.Entitys.TBTunnelEntity> tunnelList  = tunnelManager.GetAll();
            if (null == tunnelList)
            {
                tunnelList = new List<DASP.Domain.Entitys.TBTunnelEntity>();
            }

            tunnelList.Insert(0, new DASP.Domain.Entitys.TBTunnelEntity() { TunnelId = Guid.Empty,TunnelName = "--请选择--"});
            cboBoxTunnel.DataSource = tunnelList;
            cboBoxTunnel.DisplayMember = "TunnelName";
            cboBoxTunnel.ValueMember = "TunnelId";

            if (this.fanPosEntity != null)
            {
                txtFanPosName.Text = this.fanPosEntity.PositionName;
                txtRemark.Text = this.fanPosEntity.Ramark;

                ListItem laneWaySelectItem =
                    laneWayList.Where(p => p.Value.Equals(fanPosEntity.LaneWay.ToString())).FirstOrDefault();

                cboBoxLaneWay.SelectedValue = laneWaySelectItem.Value;

                ListItem holeWaySelectItem =
                   honeWayList.Where(p => p.Value.Equals(fanPosEntity.HoleWay.ToString())).FirstOrDefault();

                cboBoxHoleWay.SelectedValue = holeWaySelectItem.Value;


                DASP.Domain.Entitys.TBTunnelEntity tunnelSelectItem=
                    tunnelList.Where(p => p.TunnelId.Equals(fanPosEntity.Tunnel.TunnelId)).FirstOrDefault();

                cboBoxTunnel.SelectedValue = tunnelSelectItem.TunnelId;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (formValid.IsValid)
            {
                bool isUpdate;

                if (null != fanPosEntity)
                {
                    isUpdate = true;
                }
                else
                {
                    fanPosEntity = new DASP.Domain.Entitys.TBFanPositionEntity();
                    fanPosEntity.PositionId = Guid.NewGuid();
                    fanPosEntity.CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    isUpdate = false;
                }

                DASP.Domain.Entitys.TBTunnelEntity tunnel = cboBoxTunnel.SelectedItem as DASP.Domain.Entitys.TBTunnelEntity;
                fanPosEntity.Tunnel = tunnel;
                fanPosEntity.LaneWay = byte.Parse(cboBoxLaneWay.SelectedValue.ToString());
                fanPosEntity.HoleWay = byte.Parse(cboBoxHoleWay.SelectedValue.ToString());
                fanPosEntity.Creator = Global.UserInfoInstance.CurrentLoginUser;
                fanPosEntity.PositionName = txtFanPosName.Text.Trim();
                fanPosEntity.Ramark = txtRemark.Text.Trim();

                fanPosEntity.UpdateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                try
                {
                    if (isUpdate)
                    {
                        posManager.Update(fanPosEntity);
                    }
                    else
                    {
                        posManager.Save(fanPosEntity);
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
            if (e.ControlToValidate == cboBoxHoleWay)
            {
                ListItem listItem = cboBoxHoleWay.SelectedItem as ListItem;
                if (listItem.Value.Equals("-1"))
                {
                    e.Valid = false;
                }
                else
                {
                    e.Valid = true;
                }
            }

            if (e.ControlToValidate == cboBoxLaneWay)
            {
                ListItem listItem = cboBoxLaneWay.SelectedItem as ListItem;
                if (listItem.Value.Equals("-1"))
                {
                    e.Valid = false;
                }
                else
                {
                    e.Valid = true;
                }
            }

            if (e.ControlToValidate == cboBoxTunnel)
            {
                DASP.Domain.Entitys.TBTunnelEntity listItem = cboBoxTunnel.SelectedItem as DASP.Domain.Entitys.TBTunnelEntity;
                if (listItem.TunnelId == Guid.Empty)
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
}
