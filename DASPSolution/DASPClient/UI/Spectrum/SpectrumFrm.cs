using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Dasp;
using WeifenLuo.WinFormsUI.Docking;
using DASP.Business.IManager;
using DASPClient.Utility;
using DASP_UI;
using DASPClient.Global;

namespace Dasp_UI
{
    public partial class SpecTrum : DockContent
    {
       
        private SpectrumParas spepara = null;
        private int nWavePtNum = 1024;
        private float fCalCv;
        private float fWaveSf;
        /// <summary>
        /// 试验数据系列号
        /// </summary>
        private string fileName = null;
        private string fileName2 = null;
        ITBTestDataManager testDataManager = null;
        ITBTestParameterManager testParameterManager = null;
        private static object lockObject = new object();
        #region 自谱分析参数
        int nWaveOffset;

        int nFftPtNum = 1024;
        int nWindowType;

        float fCalOffset;
        int nExpPara;
        int nClearDc = 1;
        int nSpectrumType;
        int nAverageType;
        int nCascadePercent;
        #endregion 
        /// <summary>
        /// 图形数据列表
        /// </summary>
        private IList<IList<float>[]> datalsts = new List<IList<float>[]>();
        public SpecTrum()
        {
            InitializeComponent();
            this.Load += new EventHandler(Spectrum_Load);
        }
        public SpecTrum(string fname)
        {
            fileName = fname;
            InitializeComponent();
            this.Load += new EventHandler(Spectrum_Load);
        }
        public SpecTrum(string fname,SpectrumParas para)
        {
            fileName = fname;
            spepara = para;
            InitializeComponent();
            this.Load += new EventHandler(Spectrum_Load);
        }
        public SpecTrum(string fname, string fname2)
        {
            fileName = fname;
            fileName2 = fname2;
            InitializeComponent();
            this.Load += new EventHandler(Spectrum_Load);
        }
        /// <summary>  
        /// 初始化ComboBoxTree  
        /// </summary>  
        private void InitTree()
        {
            NodeData rootNode = DASPClient.Global.Common.BuildCommonData();
            if (null != rootNode)
            {
                TreeNode root = new TreeNode();
                root.Text = rootNode.NodeName;
                root.Name = rootNode.NodeId.ToString();
                root.Tag = rootNode.Children;

                //增加树的根节点  
                treeView.Nodes.Add(root);
                AddNode(root, root.Name);
                root.ExpandAll();
            }
        }
        /// <summary>  
        /// 递规添加TreeView节点  
        /// </summary>  
        /// <param name="node"></param>  
        /// <param name="parentID"></param>  
        public void AddNode(TreeNode node, string parentID)
        {
            lock (lockObject)
            {
                List<NodeData> child = node.Tag as List<NodeData>;
                if (null != child)
                    foreach (NodeData c in child)
                    {
                        TreeNode subNode = new TreeNode();
                        subNode.Text = c.NodeName;
                        subNode.Name = c.NodeId.ToString();
                        subNode.Tag = c.Children;

                        node.Nodes.Add(subNode);
                        AddNode(subNode, subNode.Name);
                    }
            }
        }
        void Spectrum_Load(object sender, EventArgs e)
        {
            this.tableLayoutPanel.Dock = DockStyle.Fill;
            InitTree();
            //this.mcadLine1.BgColor = Color.Black;
           
            //if (fileName != null)
            //{
            //   GetWavData(fileName);
            //}
           
            
        }
       
     
        /// <summary>
        /// 根据参数设置界面得到的输入数据绘制自谱图像
        /// </summary>
        /// <param name="Fname"></param>
        private void GetSpectData(List<float> indata,string serialid)
        {
            IList<int> scape = new List<int>();
            IList<DataBase> dbex = new List<DataBase>(); 
            List<float>[] waveData = new List<float>[1];//波形图只有一组绘制数据
            List<float>[] SprectData = new List<float>[1];//自谱分析结果数据
            waveData[0] = indata;
            SprectData[0] = null;
            float gain = 1f;
            try
            {
                testDataManager = SpringUtils.Context.GetObject("TestDataManager") as ITBTestDataManager;
                testParameterManager = SpringUtils.Context.GetObject("TestParameterManager") as ITBTestParameterManager;
              //  DASP.Domain.Entitys.TBTestDataEntity entity = testDataManager.Get(Guid.Parse(serialid));//"f2d72bcb-88b2-4f93-af7a-0b10834848d9"));
                DASP.Domain.Entitys.TBTestParameterEntity paraentity = testParameterManager.Get(Guid.Parse(serialid));
                gain = paraentity.Gain;
                float sf = Convert.ToSingle(paraentity.SF);
                float cv = Convert.ToSingle(paraentity.CV);
                
                //for (int i = 0; i < waveData[0].Count; i++)
                //{
                //    waveData[0][i] = waveData[0][i] ;
                //}
                datalsts.Add(waveData);
                //datalsts.Add(waveData);
                SprectData[0] = GetSprectData(waveData[0]);
                datalsts.Add(SprectData);

                scape.Add(30);
                scape.Add(70);

                DataBase db = new DataBase(1 / sf, "s", 1f, "N");
                dbex.Add(db);
                db = new DataBase(sf / spepara.nFftPtNum, "Hz", 1f, "N");
                dbex.Add(db);

                this.mcadLine1.drawall = true;
                this.mcadLine1.SetDrawDataAll(datalsts, scape, dbex);
                //this.mcadLine1.SetDrawDataAll(datalsts);
                this.mcadLine1.Focus();
            }
            catch { }
           
            //datalsts.Add(waveData);
            //datalsts.Add(waveData);
            //this.mcadLine1.drawall = true;
            //this.mcadLine1.SetDrawDataAll( datalsts);
        }
        
        private List<float>[] cmplst = new List<float>[2];
        private  List<float> GetSprectData(List<float> indata)
        {  
            List<float> SpecData = null;
            bool rc  = false;
            rc = DaspSDK.DaspAutoSpectrum(indata, spepara.nWaveOffset, spepara.nWavePtNum, spepara.nFftPtNum, spepara.nWindowType, spepara.fCalCv, spepara.fWaveSf, spepara.fCalOffset, spepara.nExpPara, spepara.nClearDc, spepara.nSpectrumType, spepara.nAverageType, spepara.nCascadePercent, out SpecData);
            if (rc)
            {              
            }
            else
            {
                SpecData = null;
            }
            return SpecData;

        }

        public float fWaveSfIn { get; set; }

        private void cmb3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        public bool iscalculating { get; set; }

        private void btnGetpara_Click(object sender, EventArgs e)
        {
            List<float> indata = null;
            SpectrumPara spectrumPara = new SpectrumPara("f2d72bcb-88b2-4f93-af7a-0b10834848d9");
            spectrumPara.FormClosed += (s, ea) =>
            {
                spepara = spectrumPara.spe;
                indata = spectrumPara.indata;
            };
            if (spectrumPara.ShowDialog() == DialogResult.OK)
            {
                GetSpectData(indata, "f2d72bcb-88b2-4f93-af7a-0b10834848d9");
                //SpecTrum specttum = new SpecTrum("f2d72bcb-88b2-4f93-af7a-0b10834848d9", spectrump);
                //specttum.Show(this.dockPanelContent);
            }
        }

        /// 根据试验标识读试验波形数据
        /// </summary>
        /// <param name="Fname"></param>
        private void GetWavData(string serialid)
        {
            IList<int> scape = new List<int>();
            IList<DataBase> dbex = new List<DataBase>();
            List<float>[] waveData = new List<float>[1];//波形图只有一组绘制数据
            List<float>[] SprectData = new List<float>[1];//自谱分析结果数据
            waveData[0] = null;// new List<float>();  //初始化第一组数据
            SprectData[0] = null;
            float gain = 1f;
            try
            {
                testDataManager = SpringUtils.Context.GetObject("TestDataManager") as ITBTestDataManager;
                testParameterManager = SpringUtils.Context.GetObject("TestParameterManager") as ITBTestParameterManager;
                DASP.Domain.Entitys.TBTestDataEntity entity = testDataManager.Get(Guid.Parse(serialid));//"f2d72bcb-88b2-4f93-af7a-0b10834848d9"));
                DASP.Domain.Entitys.TBTestParameterEntity paraentity = testParameterManager.Get(Guid.Parse(serialid));
                // byte[] bufferData = DASP.Tools.SerializerUtils.SerializeFromObject(entity.Data) as byte[];
                waveData[0] = DASP.Tools.SerializerUtils.SerializeToObject(entity.Data) as List<float>;
                gain = paraentity.Gain;
                float sf = Convert.ToSingle(paraentity.SF);
                float cv = Convert.ToSingle(paraentity.CV);
                //  nWavePtNum = paraentity.
                //for (int i = 0; i < waveData[0].Count; i++)
                //{
                //    waveData[0][i] = waveData[0][i] ;
                //}
                datalsts.Add(waveData);
                //datalsts.Add(waveData);
                SprectData[0] = GetSprectData(waveData[0]);
                datalsts.Add(SprectData);

                scape.Add(30);
                scape.Add(70);

                DataBase db = new DataBase(1 / sf, "s", 1f, "N");
                dbex.Add(db);
                db = new DataBase(sf / spepara.nFftPtNum, "Hz", 1f, "N");
                dbex.Add(db);

                this.mcadLine1.drawall = true;
                this.mcadLine1.SetDrawDataAll(datalsts, scape, dbex);
                //this.mcadLine1.SetDrawDataAll(datalsts);
                this.mcadLine1.Focus();
            }
            catch { }

            //datalsts.Add(waveData);
            //datalsts.Add(waveData);
            //this.mcadLine1.drawall = true;
            //this.mcadLine1.SetDrawDataAll( datalsts);
        }

       
    }
}
