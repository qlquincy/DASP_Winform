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

namespace Dasp_UI
{
    public partial class SpecTrum : DockContent
    {
        //private List<float> indata;
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
        void Spectrum_Load(object sender, EventArgs e)
        {
            this.mcadLine1.BgColor = Color.Black;
            this.FftPtNum.SelectedIndex = 2;
            this.WindowType.SelectedIndex = 0;
            this.SpectrumType.SelectedIndex = 0;
            this.AverageType.SelectedIndex = 0;
            if (fileName2 != null)
            {
                GetWavData2(fileName,fileName2);
            }
            else
            GetWavData(fileName);
        }
        private void GetWavData2(string Fname,string Fname2)
        {
            IList<float>[] waveData = new IList<float>[2];//波形图只有一组绘制数据
            waveData[0] = new List<float>();  //初始化第一组数据
            waveData[1] = new List<float>();
            float gain = 1f;
            try
            {
                long dataLength = 0;
                //this.txtFilename.Text = Fname;
                string fn = Fname.Replace(".sts", ".tsp");
                string[] paras = DaspSDK.Read(fn);
                if ((paras != null) && (paras.Length == 9))
                {
                    this.fCalCv = DaspSDK.ChangeDataToD(paras[7]);
                    this.CalCv.Text = paras[7];
                    fWaveSfIn = Convert.ToSingle(paras[0]);
                    this.WaveSf.Text = paras[0];
                    gain = Convert.ToSingle(paras[5]);
                }
                using (FileStream fs = new FileStream(Fname, FileMode.Open, FileAccess.Read))
                {
                    dataLength = fs.Length;
                    BinaryReader r = new BinaryReader(fs);
                    for (int i = 0; i < dataLength / 4; i++)
                    {
                        waveData[0].Add(r.ReadSingle() / gain / this.fCalCv);
                    }

                    nWavePtNum = Convert.ToInt32(dataLength / 4);
                    this.WavePtNum.Text = Convert.ToString(nWavePtNum);
                }
            }
            catch { }

            try
            {
                long dataLength = 0;
                //this.txtFilename.Text = Fname;
                string fn = Fname2.Replace(".sts", ".tsp");
                string[] paras = DaspSDK.Read(fn);
                if ((paras != null) && (paras.Length == 9))
                {
                    this.fCalCv = DaspSDK.ChangeDataToD(paras[7]);
                    this.CalCv.Text = paras[7];
                    fWaveSfIn = Convert.ToSingle(paras[0]);
                    this.WaveSf.Text = paras[0];
                    gain = Convert.ToSingle(paras[5]);
                }
                using (FileStream fs = new FileStream(Fname, FileMode.Open, FileAccess.Read))
                {
                    dataLength = fs.Length;
                    BinaryReader r = new BinaryReader(fs);
                    for (int i = 0; i < dataLength / 4; i++)
                    {
                        waveData[1].Add(r.ReadSingle() / gain / this.fCalCv);
                    }

                    nWavePtNum = Convert.ToInt32(dataLength / 4);
                    this.WavePtNum.Text = Convert.ToString(nWavePtNum);
                }
            }
            catch { }

            datalsts.Add(waveData);
            //datalsts.Add(waveData);
            //datalsts.Add(waveData);
            this.mcadLine1.drawall = true;
            this.mcadLine1.SetDrawDataAll(datalsts);
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
                    waveData[0][i] = waveData[0][i] ;
                }
                datalsts.Add(waveData);
                //datalsts.Add(waveData);
                SprectData[0] = GetSprectData(waveData[0]);
                datalsts.Add(SprectData);
                this.mcadLine1.drawall = true;
                this.mcadLine1.SetDrawDataAll(datalsts);
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

        private void btnOpenData_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "所有Dasp测试文件|*.sts";
           List<float>  indata = new List<float>();
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
                        this.CalCv.Text = paras[7];
                        fWaveSfIn = Convert.ToSingle(paras[0]);
                        this.WaveSf.Text = paras[0];
                    }
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        dataLength = fs.Length;
                        BinaryReader r = new BinaryReader(fs);
                        for (int i = 0; i < dataLength / 4; i++)
                        {
                            indata.Add(r.ReadSingle());// / gain / cv);
                        }

                        nWavePtNum = Convert.ToInt32(dataLength / 4);
                        this.WavePtNum.Text = Convert.ToString(nWavePtNum);
                    }
                }
                catch { }
            }
          
        }

        public bool iscalculating { get; set; }

        private void btncmp_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "所有Dasp测试文件|*.sts";
            List<float> indata = new List<float>();
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
                        this.CalCv.Text = paras[7];
                        fWaveSfIn = Convert.ToSingle(paras[0]);
                        this.WaveSf.Text = paras[0];
                    }
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        dataLength = fs.Length;
                        BinaryReader r = new BinaryReader(fs);
                        for (int i = 0; i < dataLength / 4; i++)
                        {
                            indata.Add(r.ReadSingle());// / gain / cv);
                        }

                        nWavePtNum = Convert.ToInt32(dataLength / 4);
                        this.WavePtNum.Text = Convert.ToString(nWavePtNum);
                    }
                    SetSecondlstdata(indata);
                }
                catch { }
            }
        }

        private void SetSecondlstdata(List<float> indata)
        {
            int nWaveOffset;

            int nFftPtNum = 1024;
            int nWindowType;

            float fCalOffset;
            int nExpPara;
            int nClearDc = 1;
            int nSpectrumType;
            int nAverageType;
            int nCascadePercent;
            List<float> SpecData = null;

            iscalculating = false;


            nWaveOffset = Convert.ToInt32(WaveOffset.Text);
            switch (this.FftPtNum.SelectedIndex)
            {
                case 0:
                    nFftPtNum = 256;
                    break;
                case 1:
                    nFftPtNum = 512;
                    break;
                case 2:
                    nFftPtNum = 1024;
                    break;
            }


            nWindowType = this.WindowType.SelectedIndex;

            fCalOffset = Convert.ToInt32(CalOffset.Value);

            nExpPara = Convert.ToInt32(this.ExpPara.Value);


            if (!this.ClearDc.Checked)
                nClearDc = 0;


            nSpectrumType = this.SpectrumType.SelectedIndex;
            nAverageType = this.AverageType.SelectedIndex; ;
            nCascadePercent = Convert.ToInt32(this.CascadePercent.Value); ;
            if (DaspSDK.DaspAutoSpectrum(indata, nWaveOffset, nWavePtNum, nFftPtNum, nWindowType, fCalCv, fWaveSf, fCalOffset, nExpPara, nClearDc, nSpectrumType, nAverageType, nCascadePercent, out SpecData))
            {
                iscalculating = true;
                cmplst[1] = SpecData;
                //this.mcadLine1.DrawDatalstPara = cmplst;
               
            }
        }
    }
}
