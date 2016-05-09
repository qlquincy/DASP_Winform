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
using DASP_UI;

namespace ChartTrialProgram
{
    public partial class SpectrumPara : Form
    {
        private List<float> indata;
        private int nWavePtNum = 1024;

        public SpectrumPara()
        {
            InitializeComponent();
            this.Load += new EventHandler(Spectrum_Load);
        }

        void Spectrum_Load(object sender, EventArgs e)
        {
            this.FftPtNum.SelectedIndex = 2;
            this.WindowType.SelectedIndex = 0;
            this.SpectrumType.SelectedIndex = 0;
            this.AverageType.SelectedIndex = 0;
        }

        private List<float>[] cmplst = new List<float>[2];
        private SpectrumParas spe = new SpectrumParas();
        private void btnCal_Click(object sender, EventArgs e)
        {

            List<float> SpecData = null;

            iscalculating = false;
            spe.fCalCv = Convert.ToSingle(CalCv.Text);
            spe.fWaveSf = Convert.ToSingle(WaveSf.Text); ;
            spe.nWavePtNum = Convert.ToInt32(WavePtNum.Text);
            spe.nWaveOffset = Convert.ToInt32(WaveOffset.Text);
            switch (this.FftPtNum.SelectedIndex)
            {
                case 0:
                    spe.nFftPtNum = 256;
                    break;
                case 1:
                    spe.nFftPtNum = 512;
                    break;
                case 2:
                    spe.nFftPtNum = 1024;
                    break;
            }
            spe.nWindowType = this.WindowType.SelectedIndex;
            spe.fCalOffset = Convert.ToInt32(CalOffset.Value);
            spe.nExpPara = Convert.ToInt32(this.ExpPara.Value);
            if (!this.ClearDc.Checked)
                spe.nClearDc = 0;
            spe.nSpectrumType = this.SpectrumType.SelectedIndex;
            spe.nAverageType = this.AverageType.SelectedIndex; ;
            spe.nCascadePercent = Convert.ToInt32(this.CascadePercent.Value); ;
            if (DaspSDK.DaspAutoSpectrum(indata, spe.nWaveOffset, spe.nWavePtNum, spe.nFftPtNum, spe.nWindowType, spe.fCalCv, spe.fWaveSf, spe.fCalOffset, spe.nExpPara, spe.nClearDc, spe.nSpectrumType, spe.nAverageType, spe.nCascadePercent, out SpecData))
            {
                iscalculating = true;

                cmplst[0] = SpecData;
            }
        }

        public float fWaveSfIn { get; set; }

        private void cmb3_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                        this.CalCv.Text = Convert.ToString(DaspSDK.ChangeDataToD(paras[7]));
                        // this.CalCv.Text = paras[7];
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
            //if (0 < dasptool.DaspAmplyStaticInMemoryFloat(indata.ToArray(), nWavePtNum, out  fMean, out  fMax, out  fMin, out  fVariance, out  fRV, out  fMS, out   fRMS))
            //{
            //    //this.fMax.Text = Convert.ToString(fMax);
            //    //this.fMean.Text = Convert.ToString(fMean);
            //    //this.fMax.Text = Convert.ToString(fMax);
            //    //this.fMin.Text = Convert.ToString(fMin);
            //    //this.fVariance.Text = Convert.ToString(fVariance);
            //    //this.fRV.Text = Convert.ToString(fRV);
            //    //this.fMS.Text = Convert.ToString(fMS);
            //    //this.fRMS.Text = Convert.ToString(fRMS);
            //}
        }

        public bool iscalculating { get; set; }

        private void btncmp_Click(object sender, EventArgs e)
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
                        this.CalCv.Text = Convert.ToString(DaspSDK.ChangeDataToD(paras[7]));
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
                    SetSecondlstdata();
                }
                catch { }
            }
        }

        private void SetSecondlstdata()
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
            if (DaspSDK.DaspAutoSpectrum(indata, nWaveOffset, nWavePtNum, nFftPtNum, nWindowType, Convert.ToSingle(CalCv.Text), Convert.ToSingle(WaveSf.Text), fCalOffset, nExpPara, nClearDc, nSpectrumType, nAverageType, nCascadePercent, out SpecData))
            {
                iscalculating = true;
                cmplst[1] = SpecData;
            }
        }
    }
}
