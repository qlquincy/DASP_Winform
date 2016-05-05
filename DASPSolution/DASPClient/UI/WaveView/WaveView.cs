using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dasp;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;
using DASP.Business.IManager;
using DASPClient.Utility;

namespace Dasp_WaveView
{
    public partial class WaveView :  DockContent
    {
        private List<float> indata;
        private int nWavePtNum = 1024;
        private float fCalCv;
        private float fWaveSf;
        ITBTestDataManager testDataManager = null;
        ITBTestParameterManager testParameterManager = null;
        public WaveView()
        {
            InitializeComponent();
        }

        private void btnOpenData_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "所有Dasp测试文件|*.sts";
            indata = new List<float>();
            string Fname = null;
            float gain = 1f;

            openFileDialog.Title = "选择输入文件";
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                Fname = openFileDialog.FileName;
                try
                {
                    long dataLength = 0;
                    //this.txtFilename.Text = Fname;
                    string fn = Fname.Replace(".sts", ".tsp");
                    string[] paras = DaspSDK.Read(fn);
                    if ((paras != null) && (paras.Length == 9))
                    {

                        gain = Convert.ToSingle(paras[5]);
                        this.fCalCv = DaspSDK.ChangeDataToD(paras[7]);
                       
                       
                    }
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        dataLength = fs.Length;
                        BinaryReader r = new BinaryReader(fs);
                        for (int i = 0; i < dataLength / 4; i++)
                        {
                            indata.Add(r.ReadSingle() * gain / fCalCv);
                        }

                        nWavePtNum = Convert.ToInt32(dataLength / 4);
                     
                    }
                    if (indata != null)
                    {
                        switch (this.pointsperpage.SelectedIndex)
                        {
                            case 0:
                                this.mcadLine1.SetDrawPara(0,  128);
                                break;
                            case 1:
                                this.mcadLine1.SetDrawPara(0, 256);
                                break;
                            case 2:
                                this.mcadLine1.SetDrawPara(0,512);
                                break;
                            case 3:
                                this.mcadLine1.SetDrawPara(0,1024);
                                break;
                            case 4:
                                this.mcadLine1.SetDrawPara(0,2048);
                                break;
                            case 5:
                                this.mcadLine1.SetDrawPara(0,4096);
                                break;
                            case 6:
                                this.mcadLine1.SetDrawPara(0,8192);
                                break;
                            default:
                                //this.mcadLine1.PageNumberOfValue = -1;
                                break;

                        }
                        IList<IList<float>[]> datalsts = new List<IList<float>[]>();
                        IList<float>[] waveData = new IList<float>[1];//波形图只有一组绘制数据
                        waveData[0] = indata;// new List<float>();  //初始化第一组数据
                        this.mcadLine1.DrawParts = 2;
                        this.mcadLine1.BmSpan = 30;
                        datalsts.Add(waveData);
                        this.mcadLine1.drawall = true;
                        this.mcadLine1.SetDrawDataAll(datalsts);
                        this.mcadLine1.Focus();
                    }
                }
                catch { }
            }
        }
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
               //  nWavePtNum = paraentity.
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] = list[i] * gain / cv;
                }
                 IList<IList<float>[]> datalsts = new List<IList<float>[]>();
                        IList<float>[] waveData = new IList<float>[1];//波形图只有一组绘制数据
                        waveData[0] = list;// new List<float>();  //初始化第一组数据
                        this.mcadLine1.DrawParts = 2;
                        this.mcadLine1.BmSpan = 30;
                        datalsts.Add(waveData);
                        this.mcadLine1.drawall = true;
                        this.mcadLine1.SetDrawDataAll(datalsts);
                        this.mcadLine1.Focus();
            }
            catch (Exception ex)
            {

            }
            //this.pointsperpage.SelectedIndex = 5;
            //this.mcadLine1.Focus();

        }
        private void WaveView_Load(object sender, EventArgs e)
        {

           
        }

        private void pointsperpage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.pointsperpage.SelectedIndex)
            {
                case 0:
                    this.mcadLine1.SetDrawPara(0, 128);
                    break;
                case 1:
                    this.mcadLine1.SetDrawPara(0, 256);
                    break;
                case 2:
                    this.mcadLine1.SetDrawPara(0, 512);
                    break;
                case 3:
                    this.mcadLine1.SetDrawPara(0, 1024);
                    break;
                case 4:
                    this.mcadLine1.SetDrawPara(0, 2048);
                    break;
                case 5:
                    this.mcadLine1.SetDrawPara(0, 4096);
                    break;
                case 6:
                    this.mcadLine1.SetDrawPara(0, 8192);
                    break;
                default:
                    //this.mcadLine1.PageNumberOfValue = -1;
                    break;

            }
            this.mcadLine1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.mcadLine1.Focus();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            DrawWaveFromDB(this.txtSerialID.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DrawWaveFromDB(this.txtOut.Text);
        }
    }
}
