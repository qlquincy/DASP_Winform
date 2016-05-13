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
    public partial class REF : DockContent
    {
        //private List<float> indata;
        private FrfParas frf = null;
        private int nWavePtNum = 1024;
        private float fCalCv;
        private float fWaveSf;
        /// <summary>
        /// 试验数据系列号
        /// </summary>
        public List<float> indata = null;

        public List<float> outdata = null;
        private List<float>[] lstFrf = null;
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
        public REF()
        {
            InitializeComponent();
            this.Load += new EventHandler(Spectrum_Load);
            this.cmbout.SelectedIndex = 0;
        }
        public REF(string fname)
        {
           
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
        private string inobj = null;
        private string outobj = null;
        private string selobj = null;
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            TreeNode _SelectNode = this.treeView.SelectedNode;
            if (null != _SelectNode)
            {
                selobj = _SelectNode.Name;
            }
        }
        public REF(List<float> fname, List<float> fname2, FrfParas frfpara)
        {
            indata = fname;
            outdata = fname2;
            InitializeComponent();
            this.Load += new EventHandler(Spectrum_Load);
            this.mcadLine1.BgColor = Color.Black;
            frf = frfpara;
        }
        void Spectrum_Load(object sender, EventArgs e)
        {
           // GetWavData();
            this.tableLayoutPanel.Dock = DockStyle.Fill;
            InitTree();
        }
        private void ToolStripObj_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem c = sender as System.Windows.Forms.ToolStripDropDownItem;
            if (c.Name == this.ToolStripObj.Name)
            {
                if (!string.IsNullOrEmpty(this.selobj))
                {
                    this.inobj = this.selobj;
                    this.txtin.Text = this.selobj;
                }
                //MessageBox.Show("设置比较源");
            }
            else if (c.Name == this.ToolStripRef.Name)
            {
                if (!string.IsNullOrEmpty(this.selobj))
                {
                    this.outobj = this.selobj;
                    this.txtOut.Text = this.selobj;
                }
                //MessageBox.Show("设置参考");
            }
            this.selobj = null;
        }
        private List<float>[] rfroutdata = null;
        private void GetWavData()
        {
            IList<int> scape = new List<int>();
            IList<DataBase> dbex = new List<DataBase>();
            IList<IList<float>[]> datalsts = new List<IList<float>[]>();
            IList<float>[] waveData =  new IList<float>[1];//波形图只有一组绘制数据
           
            if (DaspSDK.CalFRF(indata, outdata, out lstFrf, frf.nWavePtNum, frf.nFftPtNum, frf.fWaveSfOut, frf.fWaveSfIn, frf.nWindowType, frf.nExpPara, frf.nWindowLL, frf.nWindowLR, frf.nClearDc, frf.nSpectrumType, frf.nCorePar, frf.nCascadePercent))
            {
              
                rfroutdata = lstFrf;
                switch (cmbout.SelectedIndex)
                {
                    case 0://幅频 、相频0 1
                        waveData = new IList<float>[1];
                        waveData[0] = lstFrf[0];
                        datalsts.Add(waveData);
                        waveData = new IList<float>[1];
                        waveData[0] = lstFrf[1];
                        datalsts.Add(waveData);
                        break;
                    case 1://幅频 、相干0 2
                        waveData = new IList<float>[1];
                        waveData[0] = lstFrf[0];
                        datalsts.Add(waveData);
                        waveData = new IList<float>[1];
                        waveData[0] = lstFrf[2];
                        datalsts.Add(waveData);
                        break;
                    case 2://实部 、虚部3 4
                        waveData = new IList<float>[1];
                        waveData[0] = lstFrf[3];
                        datalsts.Add(waveData);
                        waveData = new IList<float>[1];
                        waveData[0] = lstFrf[4];
                        datalsts.Add(waveData);
                        break;
                    case 3: //输入自谱 、输出自谱 5 6
                        waveData = new IList<float>[1];
                        waveData[0] = lstFrf[5];
                        datalsts.Add(waveData);
                        waveData = new IList<float>[1];
                        waveData[0] = lstFrf[6];
                        datalsts.Add(waveData);
                        break;
                    case 4: //幅频 相频  相干0 1 2
                        waveData = new IList<float>[1];
                        waveData[0] = lstFrf[0];
                        datalsts.Add(waveData);
                        waveData = new IList<float>[1];
                        waveData[0] = lstFrf[1];
                        datalsts.Add(waveData);
                        waveData = new IList<float>[1];
                        waveData[0] = lstFrf[2];
                        datalsts.Add(waveData);
                        break;

                }
              

                //waveData = new IList<float>[1];
              

               
                this.mcadLine1.BmSpan = 30;
                this.mcadLine1.drawall = true;
                scape.Add(50);
                scape.Add(50);
                scape.Add(50);
                this.mcadLine1.SetDrawDataAll(datalsts);
                this.mcadLine1.Focus();
            }

           
        }
        /// <summary>
        /// 根据试验标识读试验波形数据
        /// </summary>
        /// <param name="Fname"></param>
        private void GetWavData(string serialid)
        {
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
                float cv = Convert.ToSingle(paraentity.CV);
                //  nWavePtNum = paraentity.
                for (int i = 0; i < waveData[0].Count; i++)
                {
                    waveData[0][i] = waveData[0][i] * gain / cv;
                }
                datalsts.Add(waveData);
                SprectData[0] = GetSprectData(waveData[0] );
                datalsts.Add(SprectData);
                this.mcadLine1.drawall = true;
                this.mcadLine1.SetDrawDataAll(datalsts);
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
            //   List<float> resolveData;

          
            List<float> SpecData = null;

           

            return SpecData;

        }

        public float fWaveSfIn { get; set; }

        private void cmb3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGetpara_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.inobj) && !string.IsNullOrEmpty(this.outobj))
            {

                FRFParaSetFrm frfParaSetFrm = null; //new FRFParaSetFrm("84930f04-cd56-4cb7-a609-95ac668746fe", "f2d72bcb-88b2-4f93-af7a-0b10834848d9");
                frfParaSetFrm = new FRFParaSetFrm(inobj, outobj);
                frfParaSetFrm.FormClosed += (s, ea) =>
                {
                    frf = frfParaSetFrm.frf;
                    indata = frfParaSetFrm.inlist;
                    outdata = frfParaSetFrm.outlist;
                };
                if (frfParaSetFrm.ShowDialog() == DialogResult.OK)
                {
                    GetWavData();

                }
            }
        }

        private void treeView_MouseClick(object sender, MouseEventArgs e)
        {
            this.MenuStrp.Show(sender as Control, e.Location);
        }

        private void cmbout_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFrf != null)
            {
                IList<IList<float>[]> datalsts = new List<IList<float>[]>();
                IList<float>[] waveData = new IList<float>[1];//波形图只有一组绘制数据
                IList<int> scape = new List<int>();
                IList<DataBase> dbex = new List<DataBase>();
                {

                    rfroutdata = lstFrf;
                    DataBase db = null;
                    switch (cmbout.SelectedIndex)
                    {
                        case 0://幅频 、相频0 1
                            waveData = new IList<float>[1];
                            waveData[0] = lstFrf[0];
                            datalsts.Add(waveData);
                            db = new DataBase(frf.fWaveSfOut / frf.nFftPtNum, "Hz", 1f, "m/ss/N", "幅值");
                            dbex.Add(db);
                            waveData = new IList<float>[1];
                            waveData[0] = lstFrf[1];
                            db = new DataBase(frf.fWaveSfOut / frf.nFftPtNum, "Hz", 1f, "。", "相位");
                            dbex.Add(db);
                            datalsts.Add(waveData);
                             scape.Add(50);
                            scape.Add(25);
                            break;
                        case 1://幅频 、相干0 2
                            waveData = new IList<float>[1];
                            waveData[0] = lstFrf[0];
                            datalsts.Add(waveData);
                            db = new DataBase(frf.fWaveSfOut / frf.nFftPtNum, "Hz", 1f, "m/ss/N", "幅值");
                            dbex.Add(db);
                            waveData = new IList<float>[1];
                            waveData[0] = lstFrf[2];
                            datalsts.Add(waveData);
                            db = new DataBase(frf.fWaveSfOut / frf.nFftPtNum, "Hz", 1f, "。", "相干");
                            dbex.Add(db);
                             scape.Add(50);
                            scape.Add(25);
                            break;
                        case 2://实部 、虚部3 4
                            waveData = new IList<float>[1];
                            waveData[0] = lstFrf[3];
                            datalsts.Add(waveData);
                            db = new DataBase(frf.fWaveSfOut / frf.nFftPtNum, "Hz", 1f, "m/ss/N", "实部");
                            dbex.Add(db);
                            waveData = new IList<float>[1];
                            waveData[0] = lstFrf[4];
                            datalsts.Add(waveData);
                            db = new DataBase(frf.fWaveSfOut / frf.nFftPtNum, "Hz", 1f, "m/ss/N", "虚部");
                            dbex.Add(db);
                             scape.Add(50);
                            scape.Add(25);
                            break;
                        case 3: //输入自谱 、输出自谱 5 6
                            waveData = new IList<float>[1];
                            waveData[0] = lstFrf[5];
                            datalsts.Add(waveData);
                            datalsts.Add(waveData);
                            db = new DataBase(frf.fWaveSfOut / frf.nFftPtNum, "Hz", 1f, "（N）", "输入自谱");
                            waveData = new IList<float>[1];
                            waveData[0] = lstFrf[6];
                            datalsts.Add(waveData);
                            datalsts.Add(waveData);
                            db = new DataBase(frf.fWaveSfOut / frf.nFftPtNum, "Hz", 1f, "（N）", "输出自谱");
                             scape.Add(50);
                            scape.Add(50);
                            break;
                        case 4: //幅频 相频  相干0 1 2
                            waveData = new IList<float>[1];
                            waveData[0] = lstFrf[0];
                            datalsts.Add(waveData);
                            db = new DataBase(frf.fWaveSfOut / frf.nFftPtNum, "Hz", 1f, "m/ss/N", "幅值");
                            dbex.Add(db);
                            waveData = new IList<float>[1];
                            waveData[0] = lstFrf[1];
                            datalsts.Add(waveData);
                            db = new DataBase(frf.fWaveSfOut / frf.nFftPtNum, "Hz", 1f, "。", "相位");
                            dbex.Add(db);
                            waveData = new IList<float>[1];
                            waveData[0] = lstFrf[2];
                            datalsts.Add(waveData);
                            db = new DataBase(frf.fWaveSfOut / frf.nFftPtNum, "Hz", 1f, "。", "相干");
                            dbex.Add(db);
                            scape.Add(50);
                            scape.Add(25);
                            scape.Add(25);
                            break;

                    }


                    //waveData = new IList<float>[1];



                    this.mcadLine1.BmSpan = 30;
                    this.mcadLine1.drawall = true;

                    this.mcadLine1.SetDrawDataAll(datalsts, scape, dbex);
                    this.mcadLine1.Focus();
                }
            }
        }







       
    }
}
