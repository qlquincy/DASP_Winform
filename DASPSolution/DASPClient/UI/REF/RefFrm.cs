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
        }
        public REF(string fname)
        {
           
            InitializeComponent();
            this.Load += new EventHandler(Spectrum_Load);
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
            GetWavData();
        }
        private void GetWavData()
        {
            IList<IList<float>[]> datalsts = new List<IList<float>[]>();
            IList<float>[] waveData =  new IList<float>[1];//波形图只有一组绘制数据
           
            if (DaspSDK.CalFRF(indata, outdata, out lstFrf, frf.nWavePtNum, frf.nFftPtNum, frf.fWaveSfOut, frf.fWaveSfIn, frf.nWindowType, frf.nExpPara, frf.nWindowLL, frf.nWindowLR, frf.nClearDc, frf.nSpectrumType, frf.nCorePar, frf.nCascadePercent))
            {
                waveData[0] = lstFrf[0];               
                datalsts.Add(waveData);

                waveData = new IList<float>[1];
                waveData[0] = lstFrf[1];
                datalsts.Add(waveData);

                waveData = new IList<float>[1];
                waveData[0] = lstFrf[2];
                datalsts.Add(waveData);

               
                this.mcadLine1.BmSpan = 30;
                this.mcadLine1.drawall = true;
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







       
    }
}
