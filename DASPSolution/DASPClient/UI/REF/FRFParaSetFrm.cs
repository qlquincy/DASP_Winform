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
using DASP.Business.IManager;
using DASPClient.Utility;


namespace Dasp_UI
{
    public partial class FRFParaSetFrm : Form
    {
        public FrfParas frf = new FrfParas();
        public List<float> inlist = null;
        public List<float> outlist = null;
        ITBTestDataManager testDataManager = null;
        ITBTestParameterManager testParameterManager = null;
        public FRFParaSetFrm()
        {
            InitializeComponent();
            this.Load += new EventHandler(FRF_Load);
        }
        public FRFParaSetFrm(string inid,string outid)
        {
            InitializeComponent();
            this.Load += new EventHandler(FRF_Load);
            DrawWaveFromDB(inid, outid);
        }
        void FRF_Load(object sender, EventArgs e)
        {
            this.chk.Checked = true;
            this.cmb2.SelectedIndex = 2;
            this.cmb3.SelectedIndex = 0;
            this.cmb4.SelectedIndex = 2;
            this.cmbout.SelectedIndex = 1;
            
        }
        private void DrawWaveFromDB(string inid,string outid)
        {
            try
            {
                testDataManager = SpringUtils.Context.GetObject("TestDataManager") as ITBTestDataManager;
                testParameterManager = SpringUtils.Context.GetObject("TestParameterManager") as ITBTestParameterManager;
                DASP.Domain.Entitys.TBTestDataEntity inentity = testDataManager.Get(Guid.Parse(inid));
                DASP.Domain.Entitys.TBTestDataEntity outentity = testDataManager.Get(Guid.Parse(outid));
                DASP.Domain.Entitys.TBTestParameterEntity inparaentity = testParameterManager.Get(Guid.Parse(inid));
                DASP.Domain.Entitys.TBTestParameterEntity outparaentity = testParameterManager.Get(Guid.Parse(outid));
                inlist = DASP.Tools.SerializerUtils.SerializeToObject(inentity.Data) as List<float>;
                outlist = DASP.Tools.SerializerUtils.SerializeToObject(outentity.Data) as List<float>;
                float ingain = inparaentity.Gain;
                float incv = Convert.ToSingle(inparaentity.CV);
                //this.CalCv.Text = Convert.ToString(cv);
                //this.WavePtNum.Text = "1024";
                this.txt4.Text = Convert.ToString(inparaentity.SF);
                this.txt2.Text = Convert.ToString(outparaentity.SF);
                this.txt1.Text = Convert.ToString(inlist.Count);
                //  nWavePtNum = paraentity.
                for (int i = 0; i < inlist.Count; i++)
                {
                    inlist[i] = inlist[i] * ingain / incv;
                }
                for (int i = 0; i < outlist.Count; i++)
                {
                    outlist[i] = outlist[i] * outparaentity.Gain / Convert.ToSingle(outparaentity.CV);
                }
                IList<IList<float>[]> datalsts = new List<IList<float>[]>();
                IList<float>[] waveData = new IList<float>[1];//波形图只有一组绘制数据
                waveData[0] = inlist;// new List<float>();  //初始化第一组数据
                datalsts.Add(waveData);

                waveData = new IList<float>[1];//波形图只有一组绘制数据
                waveData[0] = outlist;
                
                datalsts.Add(waveData);

                this.mcadLine1.DrawParts = 2;
                this.mcadLine1.BmSpan = 30;
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
        private void SetdefaultPara()
        {
            this.cmb2.SelectedIndex = 2;
            this.cmb3.SelectedIndex = 0;
            this.cmb4.SelectedIndex = 0;
           
            this.chk.Checked = true;
        }
        private List<float>[] lstFrf = null;
        private void btnfrf_Click(object sender, EventArgs e)
        {
            
           
            lstFrf = null;
            int nFftPtNum = 1024 ;
          
            //if (DaspSDK.CalFRF(indata, outdata, out lstFrf, frf.nWavePtNum, frf.nFftPtNum, frf.fWaveSfOut, frf.fWaveSfIn, frf.nWindowType, frf.nExpPara, frf.nWindowLL, frf.nWindowLR, frf.nClearDc, frf.nSpectrumType, frf.nCorePar, frf.nCascadePercent))
            //{
               
               
            //}
        }

        private void btnOpenData_Click(object sender, EventArgs e)
        {
            switch (this.cmb2.SelectedIndex)
            {
                case 0:
                    frf.nFftPtNum = 256;
                    break;
                case 1:
                    frf.nFftPtNum = 512;
                    break;
                case 2:
                    frf.nFftPtNum = 1024;
                    break;
            }


            switch (this.cmb3.SelectedIndex)
            {
                case 0:
                    frf.nWindowType = -1;
                    break;
                case 1:
                    frf.nWindowType = 0;
                    break;
                case 2:
                    frf.nWindowType = 1;
                    break;
                case 3:
                    frf.nWindowType = 2;
                    break;
                case 4:
                    frf.nWindowType = 3;
                    break;
                case 5:
                    frf.nWindowType = 4;
                    break;

                case 6:
                    frf.nWindowType = 5;
                    break;
                case 7:
                    frf.nWindowType = 6;
                    break;
                case 8:
                    frf.nWindowType = 7;
                    break;
                case 9:
                    frf.nWindowType = 8;
                    break;
                case 10:
                    frf.nWindowType = 9;
                    break;
                case 11:
                    frf.nWindowType = 10;
                    break;



            }
            frf.nExpPara = Convert.ToInt32(this.num1.Value);
            frf.nWindowLL = Convert.ToInt32(this.txt5.Text);
            frf.nWindowLR = Convert.ToInt32(this.txt6.Text);
            frf.nClearDc = 1;
            if (!this.chk.Checked)
                frf.nClearDc = 0;

            switch (this.cmb4.SelectedIndex)
            {
                case 0:
                    frf.nSpectrumType = -2;
                    break;
                case 1:
                    frf.nSpectrumType = -1;
                    break;
                case 2:
                    frf.nSpectrumType = 0;
                    break;
                case 3:
                    frf.nSpectrumType = 1;
                    break;
                case 4:
                    frf.nSpectrumType = 2;
                    break;
            }
            frf.nCorePar = Convert.ToInt32(this.num2.Value); ;
            frf.nCascadePercent = Convert.ToInt32(this.num3.Value);
            frf.nWavePtNum = Convert.ToInt32(this.txt1.Text);
            frf.fWaveSfIn = Convert.ToSingle(txt4.Text);
            frf.fWaveSfOut = Convert.ToSingle(txt2.Text);
        }
      
      
        
    }
}
