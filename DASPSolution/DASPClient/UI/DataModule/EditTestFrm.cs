using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DASP.ZControls;
using System.IO;
using DASP.Core;
using DASP.Tools;
using DASPClient.Common;
using DASP.Business.IManager;

namespace DASPClient.UI.DataModule
{
    public partial class EditTestFrm : FormEx
    {
        List<TspConfig> tspConfigList;
        List<StsData> stsDataList;
        ITBTestDataManager testDataManager = null;
        ITBTestParameterManager testParamManager = null;
        ITBFanPositionManager fanPositionManager = null;
        DASP.Domain.Entitys.TBTestDataEntity testDataEntity;

        public EditTestFrm()
            : base()
        {
            InitializeComponent();
            this.Load += new EventHandler(EditTestFrm_Load);
        }

        public EditTestFrm(DASP.Domain.Entitys.TBTestDataEntity entity)
            : this()
        {
            this.Text = "修改数据采集";
            this.testDataEntity = entity;
        }

        void EditTestFrm_Load(object sender, EventArgs e)
        {
            //居中显示
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2;

            testDataManager = Utility.SpringUtils.Context.GetObject("TestDataManager") as ITBTestDataManager;
            testParamManager = Utility.SpringUtils.Context.GetObject("TestParameterManager") as ITBTestParameterManager;
            fanPositionManager = Utility.SpringUtils.Context.GetObject("FanPositionManager") as ITBFanPositionManager;

            BindData();
        }


        void BindData()
        {
            List<ListItem> channelList = new List<ListItem>()
            {
                new ListItem("请选择","-1"),
                new ListItem("1通道","1"),
                new ListItem("2通道","2")
            };


            List<ListItem> dataTypeList = new List<ListItem>()
            {
                new ListItem("请选择","-1"),
                new ListItem("N","1"),
                new ListItem("m/ss","2")
            };

            cboBoxChannel.DataSource = channelList;
            cboBoxChannel.DisplayMember = "Key";
            cboBoxChannel.ValueMember = "Value";

            cboBoxDataType.DataSource = dataTypeList;
            cboBoxDataType.DisplayMember = "Key";
            cboBoxDataType.ValueMember = "Value";

            IList<DASP.Domain.Entitys.TBFanPositionEntity> fanPosList = fanPositionManager.GetAll();
            if (null == fanPosList)
            {
                fanPosList = new List<DASP.Domain.Entitys.TBFanPositionEntity>();
            }
            fanPosList.Insert(0, new DASP.Domain.Entitys.TBFanPositionEntity() { PositionId = Guid.Empty, PositionName = "--请选择--" });
            cboBoxFanPos.DataSource = fanPosList;
            cboBoxFanPos.DisplayMember = "PositionName";
            cboBoxFanPos.ValueMember = "PositionId";
            if (null != testDataEntity)
            {
                DASP.Domain.Entitys.TBTestParameterEntity entity = testParamManager.Get(testDataEntity.DataId);
                TspConfig tspConfig = new TspConfig();
                tspConfig.ADVer = entity.ADVer;
                tspConfig.Ch = entity.Ch;
                tspConfig.CV = entity.CV;
                tspConfig.EU = entity.EU;
                tspConfig.Gain = entity.Gain;
                tspConfig.ISC = entity.ISC;
                tspConfig.Pages = entity.Pages;
                tspConfig.SF = entity.SF;
                tspConfig.TotalCh = entity.TotalCh;
                tspConfig.FileHash = entity.FileHash;

                tspConfigList = new List<TspConfig>();
                tspConfigList.Add(tspConfig);
                dgvDataSource.AutoGenerateColumns = false;
                dgvDataSource.DataSource = tspConfigList;

                txtTestName.Text = testDataEntity.TestName;
                txtTestCode.Text = testDataEntity.TestCode.ToString();
                txtSort.Text = testDataEntity.SortCode.ToString();
                mTxtRemark.Text = testDataEntity.Remark;

                cboBoxFanPos.SelectedValue = testDataEntity.Position.PositionId;
                cboBoxDataType.SelectedValue = testDataEntity.DataType.ToString();
                cboBoxChannel.SelectedValue = testDataEntity.ChannelCode.ToString();

            }
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            if (stsDataList != null)
            {
                stsDataList.Clear();
            }
            else
            {
                stsDataList = new List<StsData>();
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "所有Dasp测试文件|*.sts";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string hashCode = FileOperationUtils.MD5File(openFileDialog.FileName);
                StsData stsData = ResolveStsFileAlgorithm.ReadDataFromStsFile(openFileDialog.FileName);
                stsData.FileHash = hashCode;

                stsDataList.Add(stsData);
            }
        }

        private void btnReadConfig_Click(object sender, EventArgs e)
        {
            if (tspConfigList != null)
            {
                tspConfigList.Clear();
            }
            else
            {
                tspConfigList = new List<TspConfig>();
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "所有Dasp测试文件|*.tsp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string hashCode = FileOperationUtils.MD5File(openFileDialog.FileName);
                TspConfig tspConfig = ResolveTspFileAlgorithm.ReadDataFromTspFile(openFileDialog.FileName);
                tspConfig.FileHash = hashCode;
                tspConfigList.Add(tspConfig);
                dgvDataSource.AutoGenerateColumns = false;
                dgvDataSource.DataSource = tspConfigList;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (formValid.IsValid)
            {
                if (tspConfigList == null || (tspConfigList != null && tspConfigList.Count <= 0))
                {
                    ZMessageBox.Show(this, "请选导入配置数据！", "提示", ZMessageBoxIcon.Information,
                      ZMessageBoxButtons.OK);
                    return;
                }

                if (stsDataList == null || (stsDataList != null && stsDataList.Count <= 0))
                {
                    ZMessageBox.Show(this, "请选导入数据！", "提示", ZMessageBoxIcon.Information,
                      ZMessageBoxButtons.OK);
                    return;
                }
                bool isUpdate = false;

                if (testDataEntity == null)
                {
                    testDataEntity = new DASP.Domain.Entitys.TBTestDataEntity();
                    testDataEntity.DataId = Guid.NewGuid();
                    testDataEntity.CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    isUpdate = false;
                }
                else
                {
                    isUpdate = true;
                }


                string data = DASP.Tools.SerializerUtils.SerializeFromString(stsDataList[0].Data);
                List<float> v = DASP.Tools.SerializerUtils.SerializeToObject(data) as List<float>;
                testDataEntity.Data = data;
                testDataEntity.TestName = txtTestName.Text.Trim();
                testDataEntity.FileHash = stsDataList[0].FileHash;
                testDataEntity.TestCode = int.Parse(txtTestCode.Text.Trim());
                testDataEntity.ChannelCode = int.Parse(cboBoxChannel.SelectedValue.ToString());
                testDataEntity.DataType = byte.Parse(cboBoxDataType.SelectedValue.ToString());

                testDataEntity.SortCode = int.Parse(txtSort.Text.Trim());
                testDataEntity.Remark = mTxtRemark.Text.Trim();
                testDataEntity.Creator = Global.UserInfoInstance.CurrentLoginUser;
                testDataEntity.TestTime = dtpTestTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                testDataEntity.UpdateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                DASP.Domain.Entitys.TBFanPositionEntity position = cboBoxFanPos.SelectedItem as DASP.Domain.Entitys.TBFanPositionEntity;
                testDataEntity.Position = position;

                DASP.Domain.Entitys.TBTestParameterEntity testParamEntity = new DASP.Domain.Entitys.TBTestParameterEntity();
                testParamEntity.ParamId = testDataEntity.DataId;
                testParamEntity.FileHash = tspConfigList[0].FileHash;
                testParamEntity.SF = tspConfigList[0].SF;
                testParamEntity.TotalCh = tspConfigList[0].TotalCh;
                testParamEntity.UpdateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                testParamEntity.CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                testParamEntity.ADVer = tspConfigList[0].ADVer;
                testParamEntity.Ch = tspConfigList[0].Ch;
                testParamEntity.CV = tspConfigList[0].CV;
                testParamEntity.Data = testDataEntity;
                testParamEntity.EU = tspConfigList[0].EU;
                testParamEntity.Gain = tspConfigList[0].Gain;
                testParamEntity.ISC = tspConfigList[0].ISC;
                testParamEntity.Pages = tspConfigList[0].Pages;


                try
                {
                    if (isUpdate)
                    {
                        testDataManager.Update(testDataEntity);
                        testParamManager.Update(testParamEntity);
                    }
                    else
                    {
                        testDataManager.Save(testDataEntity);
                        testParamManager.Save(testParamEntity);
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
            if (e.ControlToValidate == cboBoxChannel)
            {
                ListItem listItem = cboBoxChannel.SelectedItem as ListItem;
                if (null == listItem || (null != listItem && listItem.Value.Equals("-1")))
                {
                    e.Valid = false;
                }
                else
                {
                    e.Valid = true;
                }
            }

            if (e.ControlToValidate == cboBoxDataType)
            {
                ListItem listItem = cboBoxDataType.SelectedItem as ListItem;
                if (null == listItem || (null != listItem && listItem.Value.Equals("-1")))
                {
                    e.Valid = false;
                }
                else
                {
                    e.Valid = true;
                }
            }

            if (e.ControlToValidate == cboBoxFanPos)
            {
                DASP.Domain.Entitys.TBFanPositionEntity listItem = cboBoxFanPos.SelectedItem as DASP.Domain.Entitys.TBFanPositionEntity;
                if (listItem.PositionId == Guid.Empty)
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
