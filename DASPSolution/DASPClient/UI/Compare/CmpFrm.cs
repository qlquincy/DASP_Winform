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
using DASPClient.Global;
using DASPClient.Utility;
using Dasp;

namespace Dasp_UI
{
    public partial class CmpFrm : DockContent
    {
        ITBTestDataManager testDataManager = null;
        ITBTestParameterManager testParameterManager = null;
        private static object lockObject = new object();
        public CmpFrm()
        {
            InitializeComponent();
            this.treeView.AfterSelect +=new TreeViewEventHandler(treeView_AfterSelect);
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
        private string cmpobj = null;
        private string cmpref = null;
        private string selobj = null;
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode _SelectNode = this.treeView.SelectedNode;
            if (null != _SelectNode)
            {
                selobj = _SelectNode.Name;
                //MessageBox.Show("aaaaa");
              //  DrawWaveFromDB(dataid);
            }
        }
        private void CmpFrm_Load(object sender, EventArgs e)
        {
            InitTree();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            DrawWaveFromDB(this.txtcmpb.Text);
        }
        /// <summary>
        /// 从数据库中读取观测记录
        /// </summary>
        /// <param name="serialid"></param>
        private void DrawWaveFromDB(string serialid)
        {
            try
            {
                testDataManager = SpringUtils.Context.GetObject("TestDataManager") as ITBTestDataManager;
                testParameterManager = SpringUtils.Context.GetObject("TestParameterManager") as ITBTestParameterManager;
                DASP.Domain.Entitys.TBTestDataEntity entity = testDataManager.Get(Guid.Parse(serialid));//"f2d72bcb-88b2-4f93-af7a-0b10834848d9"));
                DASP.Domain.Entitys.TBTestParameterEntity paraentity = testParameterManager.Get(Guid.Parse(serialid));
                // byte[] bufferData = DASP.Tools.SerializerUtils.SerializeFromObject(entity.Data) as byte[];
                List<float> list = DASP.Tools.SerializerUtils.SerializeToObject(entity.Data) as List<float>;
                float gain = paraentity.Gain;
                float cv = Convert.ToSingle(paraentity.CV);
                float sf = Convert.ToSingle(paraentity.SF);
                //  nWavePtNum = paraentity.
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] = list[i] * gain / cv;
                }
              //  IList<int> scape = new List<int>();
              //  IList<DataBase> dbex = new List<DataBase>();
              //  IList<IList<float>[]> datalsts = new List<IList<float>[]>();
              //  IList<float>[] waveData = new IList<float>[2];//波形图只有一组绘制数据
              //  waveData[0] = list;// new List<float>();  //初始化第一组数据
              //  // this.mcadLine1.DrawParts = 2;
              //  waveData[1] = list;
              //  this.mcadLine1.BmSpan = 30;
              //  datalsts.Add(waveData);
              // // datalsts.Add(waveData);

              //  scape.Add(40);
              // // scape.Add(60);

              //  DataBase db = new DataBase(1 / sf, "s", 1f, "N");
              //  dbex.Add(db);
              ////  dbex.Add(db);
              //  //this.mcadLine1.drawall = true;
              //  this.mcadLine1.SetDrawDataAll(datalsts, scape, dbex);
              //  this.mcadLine1.Focus();
            }
            catch (Exception ex)
            {

            }
            //this.pointsperpage.SelectedIndex = 5;
            //this.mcadLine1.Focus();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripObj_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem c = sender as System.Windows.Forms.ToolStripDropDownItem;
            if (c.Name == this.ToolStripObj.Name)
            {
                if (!string.IsNullOrEmpty(this.selobj))
                {
                    this.cmpobj = this.selobj;
                    this.txtcmpa.Text = this.selobj;
                }
                //MessageBox.Show("设置比较源");
            }
            else if (c.Name == this.ToolStripRef.Name)
            {
                if (!string.IsNullOrEmpty(this.selobj))
                {
                    this.cmpref = this.selobj;
                    this.txtcmpb.Text = this.selobj;
                }
                //MessageBox.Show("设置参考");
            }
            this.selobj = null;
        }

        private void treeView_Click(object sender, EventArgs e)
        {

        }

        private void treeView_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("bbbbb");
            this.MenuStrp.Show(sender as Control, e.Location);
        }
        private List<float> GetWaveDataFromDB(string serialid,out float sf)
        {
            List<float> list = null;
            sf = 1f;
            try
            {
                testDataManager = SpringUtils.Context.GetObject("TestDataManager") as ITBTestDataManager;
                testParameterManager = SpringUtils.Context.GetObject("TestParameterManager") as ITBTestParameterManager;
                DASP.Domain.Entitys.TBTestDataEntity entity = testDataManager.Get(Guid.Parse(serialid));//"f2d72bcb-88b2-4f93-af7a-0b10834848d9"));
                DASP.Domain.Entitys.TBTestParameterEntity paraentity = testParameterManager.Get(Guid.Parse(serialid));
                // byte[] bufferData = DASP.Tools.SerializerUtils.SerializeFromObject(entity.Data) as byte[];
                list = DASP.Tools.SerializerUtils.SerializeToObject(entity.Data) as List<float>;
                float gain = paraentity.Gain;
                float cv = Convert.ToSingle(paraentity.CV);
                sf = Convert.ToSingle(paraentity.SF);
                //  nWavePtNum = paraentity.
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] = list[i] * gain / cv;
                }
                //  IList<int> scape = new List<int>();
                //  IList<DataBase> dbex = new List<DataBase>();
                //  IList<IList<float>[]> datalsts = new List<IList<float>[]>();
                //  IList<float>[] waveData = new IList<float>[2];//波形图只有一组绘制数据
                //  waveData[0] = list;// new List<float>();  //初始化第一组数据
                //  // this.mcadLine1.DrawParts = 2;
                //  waveData[1] = list;
                //  this.mcadLine1.BmSpan = 30;
                //  datalsts.Add(waveData);
                // // datalsts.Add(waveData);

                //  scape.Add(40);
                // // scape.Add(60);

                //  DataBase db = new DataBase(1 / sf, "s", 1f, "N");
                //  dbex.Add(db);
                ////  dbex.Add(db);
                //  //this.mcadLine1.drawall = true;
                //  this.mcadLine1.SetDrawDataAll(datalsts, scape, dbex);
                //  this.mcadLine1.Focus();
            }
            catch (Exception ex)
            {

            }
            return list;

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.cmpobj) && !string.IsNullOrEmpty(this.cmpref))
            {

                IList<int> scape = new List<int>();
                IList<DataBase> dbex = new List<DataBase>();
                IList<IList<float>[]> datalsts = new List<IList<float>[]>();
                IList<float>[] waveData = new IList<float>[2];//波形图只有一组绘制数据
                float sf1 = 1f;
                float sf2 = 1f;
                waveData[0] = GetWaveDataFromDB(cmpobj,out sf1);
                // this.mcadLine1.DrawParts = 2;
                waveData[1] = GetWaveDataFromDB(cmpref,out sf2);
                this.mcadLine1.BmSpan = 30;
                datalsts.Add(waveData);
                // datalsts.Add(waveData);

                scape.Add(40);
                // scape.Add(60);

                DataBase db = new DataBase(1 / sf1, "s", 1f, "N");
                dbex.Add(db);
                //  dbex.Add(db);
                //this.mcadLine1.drawall = true;
                this.mcadLine1.SetDrawDataAll(datalsts, scape, dbex);
                this.mcadLine1.Focus();
            }
        }
    }
}
