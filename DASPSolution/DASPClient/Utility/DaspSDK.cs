using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace Dasp
{
    public class DaspSDK
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szTspFileName">文件名称</param>
        /// <param name="nWavePoints">波形的数据点数</param>
        /// <param name="fFreqSampling">采样频率</param>
        /// <param name="fGain">增益倍数</param>
        /// <param name="fCv">标定值</param>
        /// <param name="szUnit">工程单位</param>
        /// <returns></returns>
        //[DllImport(@"DaspSaApi.dll", CallingConvention = CallingConvention.Cdecl)]
        //public static extern int DaspGetTspParaFloat(string  szTspFileName, ref int nWavePoints, ref float fFreqSampling, ref float fGain, ref float fCv,ref string  szUnit);

        //public void TestGetTspParaFloat()
        //{
        //    string  szTspFileName = @"ABC1#1.tsp";
        //     int nWavePoint;
        //    float fFreqSampling;
        //    float fGain;
        //    float fCv;
        //    string szUnit;
        //  int rt =    DaspGetTspParaFloat(  szTspFileName, ref  nWavePoints, ref  fFreqSampling, ref  fGain, ref  fCv,ref  szUnit);

        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pWaveform">时域波形</param>
        /// <param name="pSpec">自谱，若nSpectrumType>0,长度不小于 nFftPtNum/2+1</param>
        /// <param name="nWaveOffset">时域波形的计算起始点</param>
        /// <param name="nWavePtNum">时域波形的计算总点数,不是pWave 的总点数，而是从nWaveOffset开始的要进行计算的点数</param>
        /// <param name="nFftPtNum">FFT 计算点数(必须为2 的幂次方,并且不大于2 的20 次方)</param>
        /// <param name="fWaveSf">时域波形采样频率</param>
        /// <param name="fCalOffset">时域波形先进行转换计算</param>
        /// <param name="fCalCv">时域波形先进行转换计算</param>
        /// <param name="nWindowType">窗函数类型 0:矩形窗; 1:指数窗; 2:Hanning 窗; 3:hamming; 4:平顶窗; 5:Kaiser 窗; 6:CosRectangle; 7Y1; 8Y2; 9Triangle; 10HalfCos</param>
        /// <param name="nExpPara">指数窗的系数(1－10),仅当nWindowType=1 时有效</param>
        /// <param name="nClearDc">是否做去直流处理 0 否 1 是</param>
        /// <param name="nSpectrumType">频谱类型 0 单峰值 1 有效值 2 功率谱 3PSD</param>
        /// <param name="nAverageType">平均方式 0 线性平均 1 峰值保持+平滑 2 最大值保持 3 指数平均 4 峰值保持</param>
        /// <param name="nCascadePercent">重叠比例（0-99）</param>
        /// <param name="nProgress">当前计算进度的百分比，计算过程中不断刷新该数据，若为0，则不输出此项</param>
        /// <returns>int, >0 实际平均次数 -1:内存不足 -2:无软件授权 -20:nFftPtNum 不符合要求 -21:频谱类型未知 -22:平均方式未知 -23:重叠比例超出范围</returns>
        //[DllImport(@"DaspSaApi.dll", CallingConvention = CallingConvention.Cdecl)]
        
        //public static extern int DaspAutoSpectrumAverageInMemoryFloat(float[] pWaveform, IntPtr pSpec, int nWaveOffset,
        //                          int nWavePtNum, int nFftPtNum, float fWaveSf, float fCalOffset, float fCalCv, int nWindowType,
        //                          int nExpPara, int nClearDc, int nSpectrumType, int nAverageType, int nCascadePercent, out int nProgress);

        public static bool DaspAutoSpectrum(List<float> resolveData, int nWaveOffset,int nWavePtNum, int nFftPtNum, int nWindowType, float fCalCv, float fWaveSf, float fCalOffset, int nExpPara ,int nClearDc,int nSpectrumType , int nAverageType,int nCascadePercent,out List<float> SpecData)
        {
            int rc = -1;
            bool br = false;
            int nProgress = 0;
            SpecData = new List<float>();
            IntPtr pSpec = Marshal.AllocHGlobal(4 * (nFftPtNum/2 +1));
            float[] pSpecData = new float[nFftPtNum/2 + 1];
            rc = DaspAutoSpectrumAverageInMemoryFloat(resolveData.ToArray(), pSpec, nWaveOffset, nWavePtNum, nFftPtNum, fWaveSf, fCalOffset, fCalCv, nWindowType, nExpPara, nClearDc, nSpectrumType, nAverageType, nCascadePercent, out nProgress);
            if (rc > 0)
            {
                Marshal.Copy(pSpec, pSpecData, 0, nFftPtNum / 2 + 1);
                for (int i = 0; i < nFftPtNum / 2 + 1; i++)
                {
                    SpecData.Add(pSpecData[i]);
                }
                br = true;
            }
            return br;
        }
        /// <summary>
        /// 从内存数据进行自谱分析
        /// </summary>
        /// <param name="resolveData"></param>
        /// <returns></returns>
        public  List<float>  TestDll2_ext(List<float> resolveData,float cv,float ff)
        {
            List<float> fData = new List<float>();
            IntPtr pSpec = Marshal.AllocHGlobal(4 * 1024);
            float[] pSpecData = new float[1024];
            int nWavePtNum = 3 * 1024;
            int nProgress = 0;
            int nFftPtNum = 1024;
            int nWindowType = 0;
            float fCalOffset = 0;
            float fCalCv = cv;
            float fWaveSf = ff;
          //  float df = df = fWaveSf / nFftPtNum;


            //int nWavePtNum = 3 * 1024, nProgress = 0, nFftPtNum = 1024, nWindowType = 2;
            //float fCalOffset = 0, fCalCv = 41.9169, fWaveSf = 25600.0, df;
            //df = fWaveSf / nFftPtNum;

            int nExpPara = 1;
            int nClearDc = 1;
            int nSpectrumType = 0;
            int nAverageType = 0;
            int nCascadePercent = 0;
            int nRC = DaspAutoSpectrumAverageInMemoryFloat(resolveData.ToArray(),pSpec,0, nWavePtNum, nFftPtNum, fWaveSf, fCalOffset, fCalCv, nWindowType, 1, 1, 0, 0, 0, out nProgress);
            if (nRC > 0)
            {
                Marshal.Copy(pSpec, pSpecData, 0, 1024);
                for (int i = 0; i < nFftPtNum / 2 + 1; i++)
                {
                    fData.Add(pSpecData[i]);
                }
            }
            return fData;
        }

        /// <summary>
        /// 从内存文件进行自谱分析
        /// </summary>
        /// <param name="resolveData"></param>
        /// <returns></returns>
        public List<float> TestDll2_ext(List<float> resolveData)
        {
            List<float> fData = new List<float>();
            IntPtr pSpec = Marshal.AllocHGlobal(4 * 1024);
            float[] pSpecData = new float[1024];
            int nWavePtNum = 3 * 1024;
            int nProgress = 0;
            int nFftPtNum = 1024;
            int nWindowType = 0;
            float fCalOffset = 0;
            float fCalCv = 0.425f;
            float fWaveSf = 25600.0f;
            float df = df = fWaveSf / nFftPtNum;


            //int nWavePtNum = 3 * 1024, nProgress = 0, nFftPtNum = 1024, nWindowType = 2;
            //float fCalOffset = 0, fCalCv = 41.9169, fWaveSf = 25600.0, df;
            //df = fWaveSf / nFftPtNum;


            int nRC = DaspAutoSpectrumAverageInMemoryFloat(resolveData.ToArray(), pSpec, 0, nWavePtNum, nFftPtNum, fWaveSf, fCalOffset, fCalCv, nWindowType, 1, 1, 0, 0, 0, out nProgress);
            if (nRC > 0)
            {
                Marshal.Copy(pSpec, pSpecData, 0, 1024);
                for (int i = 0; i < nFftPtNum / 2 + 1; i++)
                {
                    fData.Add(pSpecData[i]);
                }
            }
            return fData;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szStsFileName">后缀STS 的111 格式的时域波形数据文件（每个数据点为一个float单精度4 字节浮点数）</param>
        /// <param name="nWaveOffset">时域波形数据文件的计算起始点</param>
        /// <param name="nWavePtNum">时域波形数据文件的计算总点数,不是文件的总点数，而是从nWaveOffset 开始的要进行计算的点数</param>
        /// <param name="fWaveSf">时域波形采样频率</param>
        /// <param name="fCalOffset">时域波形先进行转换计</param>
        /// <param name="fCalCv">y = (x - fCalOffset)/fCalCv，fCalCv 不可为0</param>
        /// <param name="pSpec">自谱，若nSpectrumType>0,长度不小于 nFftPtNum/2+1</param>
        /// <param name="nFftPtNum">FFT 计算点数(必须为2 的幂次方,并且不大于2 的20 次方)</param>
        /// <param name="nWindowType">窗函数类型 0:矩形窗; 1:指数窗; 2:Hanning 窗; 3:hamming; 4:平顶窗; 5:Kaiser 窗; 6:CosRectangle; 7Y1; 8Y2; 9Triangle; 10HalfCos</param>
        /// <param name="nExpPara">指数窗的系数(1－10),仅当nWindowType=1 时有效</param>
        /// <param name="nClearDc">是否做去直流处理 0 否 1 是</param>
        /// <param name="nSpectrumType">频谱类型 0 单峰值 1 有效值 2 功率谱 3PSD</param>
        /// <param name="nAverageType">平均方式 0 线性平均 1 峰值保持+平滑 2 最大值保持 3 指数平均 4 峰值保持</param>
        /// <param name="nCascadePercent">重叠比例（0-99）</param>
        /// <param name="nProgress">当前计算进度的百分比，计算过程中不断刷新该数据，若为0，则不输出此项</param>
        /// <returns></returns>
        [DllImport(@"DaspSaApi.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int DaspAutoSpectrumAverageInFileFloat(string szStsFileName, int nWaveOffset, int
                                         nWavePtNum, float fWaveSf, float fCalOffset, float fCalCv, IntPtr pSpec, int nFftPtNum, int
                                         nWindowType, int nExpPara, int nClearDc, int nSpectrumType, int nAverageType, int
                                         nCascadePercent, out int nProgress);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pWaveform">时域波形</param>
        /// <param name="pSpec">自谱，若nSpectrumType>0,长度不小于 nFftPtNum/2+1</param>
        /// <param name="nWaveOffset">时域波形的计算起始点</param>
        /// <param name="nWavePtNum">时域波形的计算总点数,不是pWave 的总点数，而是从nWaveOffset开始的要进行计算的点数</param>
        /// <param name="nFftPtNum">FFT 计算点数(必须为2 的幂次方,并且不大于2 的20 次方)</param>
        /// <param name="fWaveSf">时域波形采样频率</param>
        /// <param name="fCalOffset">时域波形先进行转换计算</param>
        /// <param name="fCalCv">时域波形先进行转换计算</param>
        /// <param name="nWindowType">窗函数类型 0:矩形窗; 1:指数窗; 2:Hanning 窗; 3:hamming; 4:平顶窗; 5:Kaiser 窗; 6:CosRectangle; 7Y1; 8Y2; 9Triangle; 10HalfCos</param>
        /// <param name="nExpPara">指数窗的系数(1－10),仅当nWindowType=1 时有效</param>
        /// <param name="nClearDc">是否做去直流处理 0 否 1 是</param>
        /// <param name="nSpectrumType">频谱类型 0 单峰值 1 有效值 2 功率谱 3PSD</param>
        /// <param name="nAverageType">平均方式 0 线性平均 1 峰值保持+平滑 2 最大值保持 3 指数平均 4 峰值保持</param>
        /// <param name="nCascadePercent">重叠比例（0-99）</param>
        /// <param name="nProgress">当前计算进度的百分比</param>
        /// <returns></returns>

        [DllImport(@"DaspSaApi.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int DaspAutoSpectrumAverageInMemoryFloat(float[] pWaveform, IntPtr pSpec, int nWaveOffset,
                    int nWavePtNum, int nFftPtNum, float fWaveSf, float fCalOffset, float fCalCv, int nWindowType,
                    int nExpPara, int nClearDc, int nSpectrumType, int nAverageType, int nCascadePercent, out int nProgress);

        //[DllImport(@"DaspSaApi.dll", CallingConvention = CallingConvention.Cdecl)]
        //public static extern int DaspFrfAverageInMemoryFloat(float[] pWaveIn, float[] pWaveOut,out  PFrf/*IntPtr*/ pFrf, int nWavePtNum, int nFftPtNum, float fWaveSfOut, int nVtbScale, float fGainCvInec, float fGainCvOut, /*WindowPara*/IntPtr nWindowPara, int nClearDc, int nCalculousType, int nCorePar, int nCascadePercent, out int nProgress);
            
//            float** pFrf, int
//nWavePtNum, int nFftPtNum, float fWaveSfOut, int nVtbScale, int* nWindowPara, int nClearDc,
//int nCalculousType, int nCorePar, int nCascadePercent, int* nProgress);
        
        //public void TestDll(float[] data,int len)
        //{
        //    float[] pSpec = new float[1024];
        //    int nWavePtNum=  256*1024;
        //    int nProgress=0;
        //    int nFftPtNum = 1024;
        //    int nWindowType = 2;
        //    float fCalOffset = 0;
        //    float fCalCv = 41.9169f;
        //    float fWaveSf = 51200.0f;
        //    float df =    df = fWaveSf / nFftPtNum;

        //    int nRC = DaspAutoSpectrumAverageInMemoryFloat(data, out pSpec, nWavePtNum, fWaveSf, fCalOffset, fCalCv,
        //    pSpec, nFftPtNum, nWindowType, 1, 1, 0, 0, 0,out nProgress);
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inFileName">力的波形文件</param>
        /// <param name="outFileName">加速度的波形文件</param>
        /// <param name="pFrf">FRF 计算结果，为两维数组，其size 不小于 [8][nFftPtNum/2+1]其中 pFrf[0]:幅频 pFrf[1]:相频（单位：度） pFrf[2]:相干 pFrf[3]:实部 pFrf[4]:虚部 pFrf[5]:输入自谱 pFrf[6]:输出自谱 pFrf[7]:相干幅频</param>
        /// <param name="nWavePtNum">时域波形数据文件的总点数</param>
        /// <param name="nFftPtNum">计算点数</param>
        /// <param name="fWaveSfOut">输出信号的采样频率</param>
        /// <param name="nVtbScale">变时基倍数， 小于等于 1 表示无变时基，输入信号的采样频率等于fWaveSf*nVtbScale</param>
        /// <param name="fGainCvInec">输入信号时域波形采样增益倍数乘以标定值，不可为0</param>
        /// <param name="fGainCvOut">输出信号时域波形采样增益倍数乘以标定值，不可为0</param>
        /// <param name="nWindowPara">nWindowPara[0]: 输入加窗形式 -1 力窗/ 指数窗 0:矩形窗; 1: 指数窗;
        ///2:Hanning窗; 3:hamming; 4:平顶窗; 5:Kaiser 窗; 6:CosRectangle; 7Y1; 8Y2; 9Triangle;10HalfCos
        ///nWindowPara[1]: 指数窗的系数(1－10),仅当指数窗时有效
        ///nWindowPara[2]: 力窗左边界位置（ 波形的点号， 从0 开始计数， 当
        ///nWindowPara[0]=-1 时有效）
        ///nWindowPara[3]: 力窗右边界位置（ 波形的点号， 从0 开始计数， 当
        ///nWindowPara[0]=-1 时有效）</param>
        /// <param name="nClearDc">是否做去直流处理 0 否 1 是</param>
        /// <param name="nCalculousType">输出信号进行微积分转换的方式 -2:二次微分 -1:一次微分 0:线性（缺省） 1:一次积分 2:二次积分</param>
        /// <param name="nCorePar">谱修正系数 0-3 ， 缺省 0</param>
        /// <param name="nCascadePercent">重叠比例（0-99）</param>
        /// <param name="nProgress">当前计算进度的百分比，计算过程中不断刷新该数据，若为0，则不输出此项</param>
        /// <returns></returns>
        [DllImport(@"DaspSaApi.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int DaspFrfAverageInFileFloat(string inFileName, string outFileName,out  PFrf/*IntPtr*/ pFrf, int nWavePtNum, int nFftPtNum, float fWaveSfOut, int nVtbScale, float fGainCvInec, float fGainCvOut, /*WindowPara*/IntPtr nWindowPara, int nClearDc, int nCalculousType, int nCorePar, int nCascadePercent, out int nProgress);
       //public static extern int DaspFrfAverageInFileFloat((char * szStsFileNameIn,char * szStsFileNameOut,        float **pFrf,  int nWavePtNum, int nFftPtNum,  float fWaveSfOut, int nVtbScale, float fGainCvIn,   float fGainCvOut,           int *nWindowPara,   int nClearDc, int nCalculousType ,int nCorePar, int nCascadePercent      ,int * nProgress);
            //        int CoinvFrfAverageInFileFloat(char* szStsFileNameIn, char* szStsFileNameOut, float** pFrf,
            //int nWavePtNum, int nFftPtNum, float fWaveSfOut, int nVtbScale, float fGainCvIn, float
            //fGainCvOut, int* nWindowPara, int nClearDc, int nCalculousType, int nCorePar, int
            //nCascadePercent, int* nProgress);

        [DllImport(@"DaspSaApi.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int DaspFrfAverageInMemoryFloat(float[] pWaveIn, float[] pWaveOut, out  PFrf/*IntPtr*/ pFrf, int nWavePtNum, int nFftPtNum, float fWaveSfOut, int nVtbScale,/*, float fGainCvInec, float fGainCvOut,*/ /*WindowPara*/IntPtr nWindowPara, int nClearDc, int nCalculousType, int nCorePar, int nCascadePercent, out int nProgress);
        //public static extern int DaspFrfAverageInMemoryFloat(IntPtr pWaveIn, IntPtr pWaveOut, out  PFrf/*IntPtr*/ pFrf,   int nWavePtNum, int nFftPtNum, float fWaveSfOut, int nVtbScale,/*, float fGainCvInec, float fGainCvOut,*/ /*WindowPara*/IntPtr nWindowPara, int nClearDc, int nCalculousType, int nCorePar, int nCascadePercent, out int nProgress);
         //                      DaspFrfAverageInFileFloat(string inFileName, string outFileName,out  PFrf/*IntPtr*/ pFrf, int nWavePtNum, int nFftPtNum, float fWaveSfOut, int nVtbScale, float fGainCvInec, float fGainCvOut, /*WindowPara*/IntPtr nWindowPara, int nClearDc, int nCalculousType, int nCorePar, int nCascadePercent, out int nProgress);
       //                                                    char * szStsFileNameIn, char * szStsFileNameOut, float **pFrf, int nWavePtNum, int nFftPtNum, float fWaveSfOut, int nVtbScale, float fGainCvIn,   float fGainCvOut, int *nWindowPara                , int nClearDc, int nCalculousType, int nCorePar, int nCascadePercent, int * nProgress);
        public void CalFRF(List<float> indata, List<float> outdata)
        {
            PFrf pFef = new PFrf();
            ////Marshal.
            pFef.p0 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p1 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p2 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p3 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p4 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p5 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p6 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p7 = Marshal.AllocHGlobal(4 * 1024);


            int nWavePtNum = 3 * 1024;
            int nProgress = 0;
            int nFftPtNum = 1024;
            float fWaveSfOut = 6400f;
            int nVtbScale = 4;
            int[] para = new int[4];
            para[0] = 0;
            para[1] = 1;
            para[2] = 24;
            para[3] = 85;
            float[] pFrfd0 = new float[1024];
            float[] pFrfd1 = new float[1024];
            float[] pFrfd2 = new float[1024];
            float[] pFrfd3 = new float[1024];
            float[] pFrfd4 = new float[1024];
            float[] pFrfd5 = new float[1024];
            float[] pFrfd6 = new float[1024];
            float[] pFrfd7 = new float[1024];

            WindowPara nWindowPara = new WindowPara();
            nWindowPara.p1 = -1;
            nWindowPara.p2 = 1;
            nWindowPara.p3 = 24;
            nWindowPara.p4 = 85;
            IntPtr tmp = Marshal.AllocHGlobal(16);
            Marshal.StructureToPtr(nWindowPara, tmp, true);

            int nClearDc = 1;
            int nRC = 0;
            try
            {
                nRC = DaspFrfAverageInMemoryFloat(/*pWaveIn, pWaveOut,*/indata.ToArray(), outdata.ToArray(), out pFef, nWavePtNum, nFftPtNum, fWaveSfOut, nVtbScale,/* fGainCvInec, fGainCvOut,*/ tmp/* nWindowPara*/, nClearDc, 0, 0, 0, out nProgress);
            }
            catch (Exception ex)
            {

            }
            if (nRC > 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Marshal.Copy(pFef.p0, pFrfd0, 0, 1024);
                            break;
                        case 1:
                            Marshal.Copy(pFef.p1, pFrfd1, 0, 1024);
                            break;
                        case 2:
                            Marshal.Copy(pFef.p2, pFrfd2, 0, 1024);
                            break;
                        case 3:
                            Marshal.Copy(pFef.p3, pFrfd3, 0, 1024);
                            break;
                        case 4:
                            Marshal.Copy(pFef.p4, pFrfd4, 0, 1024);
                            break;
                        case 5:
                            Marshal.Copy(pFef.p5, pFrfd5, 0, 1024);
                            break;
                        case 6:
                            Marshal.Copy(pFef.p6, pFrfd6, 0, 1024);
                            break;
                        case 7:
                            Marshal.Copy(pFef.p7, pFrfd7, 0, 1024);
                            break;
                    }
                }
            }
        }
        public void CalFRF(List<float> indata, List<float> outdata, float outff, float inff, float outcv, float incv)
        {
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="indata">观测输入数据</param>
        /// <param name="outdata">观测输出数据</param>
        /// <param name="lstFrf">计算结果数据</param>
        /// <param name="nWavePtNum">时域波形的点数</param>
        /// <param name="nFftPtNum">计算点数</param>
        /// <param name="fWaveSfOut">输出信号的采样频率</param>
        /// <param name="fWaveSfIn">输入信号的采样频率</param>
        /// <param name="nWindowType">输入加窗形式</param>
        /// <param name="nExpPara">指数窗的系数</param>
        /// <param name="nWindowLL">力窗左边界位置</param>
        /// <param name="nWindowLR">力窗右边界位置</param>
        /// <param name="nClearDc">是否做去直流处理</param>
        /// <param name="nSpectrumType">输出信号进行微积分转换的方式</param>       
        /// <param name="nCorePar">谱修正系数</param>
        /// <param name="nCascadePercent">重叠比例</param>
        /// <returns></returns>
        public static bool  CalFRF(List<float> indata, List<float> outdata, out List<float>[] lstFrf, int nWavePtNum, int nFftPtNum, float fWaveSfOut, float fWaveSfIn, int nWindowType, int nExpPara, int nWindowLL,int nWindowLR,int nClearDc, int nSpectrumType, int nCorePar, int nCascadePercent)
        {
            bool br = false;
            PFrf pFef = new PFrf();
            lstFrf = new List<float>[8];
           
            int outnFftPtNum = nFftPtNum / 2 + 1;
            
            pFef.p0 = Marshal.AllocHGlobal(4 * outnFftPtNum);
            pFef.p1 = Marshal.AllocHGlobal(4 * outnFftPtNum);
            pFef.p2 = Marshal.AllocHGlobal(4 * outnFftPtNum);
            pFef.p3 = Marshal.AllocHGlobal(4 * outnFftPtNum);
            pFef.p4 = Marshal.AllocHGlobal(4 * outnFftPtNum);
            pFef.p5 = Marshal.AllocHGlobal(4 * outnFftPtNum);
            pFef.p6 = Marshal.AllocHGlobal(4 * outnFftPtNum);
            pFef.p7 = Marshal.AllocHGlobal(4 * outnFftPtNum);
            int nProgress = 0;
            int nVtbScale = Convert.ToInt32(fWaveSfIn/fWaveSfOut);

            float[] pFrfd0 = new float[nFftPtNum];
            float[] pFrfd1 = new float[nFftPtNum];
            float[] pFrfd2 = new float[nFftPtNum];
            float[] pFrfd3 = new float[nFftPtNum];
            float[] pFrfd4 = new float[nFftPtNum];
            float[] pFrfd5 = new float[nFftPtNum];
            float[] pFrfd6 = new float[nFftPtNum];
            float[] pFrfd7 = new float[nFftPtNum];

            WindowPara nWindowPara = new WindowPara();
            nWindowPara.p1 = nWindowType;// -1;
            nWindowPara.p2 = nExpPara;// 1;
            nWindowPara.p3 = nWindowLL;// 24;
            nWindowPara.p4 = nWindowLR;// 85;
            IntPtr tmp = Marshal.AllocHGlobal(16);
            Marshal.StructureToPtr(nWindowPara, tmp, true);

            //int nClearDc = 1;
            int nRC = 0;
            try
            {
                nRC = DaspFrfAverageInMemoryFloat(/*pWaveIn, pWaveOut,*/indata.ToArray(),outdata.ToArray(), out pFef, nWavePtNum, nFftPtNum, fWaveSfOut, nVtbScale,/* fGainCvInec, fGainCvOut,*/ tmp/* nWindowPara*/, nClearDc,  nSpectrumType,  nCorePar,  nCascadePercent, out nProgress);
            }
            catch (Exception ex)
            {

            }
            lstFrf[0] = new List<float>(outnFftPtNum);
            lstFrf[1] = new List<float>(outnFftPtNum);
            lstFrf[2] = new List<float>(outnFftPtNum);
            lstFrf[3] = new List<float>(outnFftPtNum);
            lstFrf[4] = new List<float>(outnFftPtNum);
            lstFrf[5] = new List<float>(outnFftPtNum);
            lstFrf[6] = new List<float>(outnFftPtNum);
            lstFrf[7] = new List<float>(outnFftPtNum);
            if (nRC > 0)
            {
                br = true;
                for (int i = 0; i < 8; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Marshal.Copy(pFef.p0, pFrfd0, 0, outnFftPtNum);
                            lstFrf[0] = new List<float>(pFrfd0);
                            break;
                        case 1:
                            Marshal.Copy(pFef.p1, pFrfd1, 0, outnFftPtNum);
                            lstFrf[1] = new List<float>(pFrfd1);
                            break;
                        case 2:
                            Marshal.Copy(pFef.p2, pFrfd2, 0, outnFftPtNum);
                            lstFrf[2] = new List<float>(pFrfd2);
                            break;
                        case 3:
                            Marshal.Copy(pFef.p3, pFrfd3, 0, outnFftPtNum);
                            lstFrf[3] = new List<float>(pFrfd3);
                            break;
                        case 4:
                            Marshal.Copy(pFef.p4, pFrfd4, 0, outnFftPtNum);
                            lstFrf[4] = new List<float>(pFrfd4);
                            break;
                        case 5:
                            Marshal.Copy(pFef.p5, pFrfd5, 0, outnFftPtNum);
                            lstFrf[5] = new List<float>(pFrfd5);
                            break;
                        case 6:
                            Marshal.Copy(pFef.p6, pFrfd6, 0, outnFftPtNum);
                            lstFrf[6] = new List<float>(pFrfd6);
                            break;
                        case 7:
                            Marshal.Copy(pFef.p7, pFrfd7, 0, outnFftPtNum);
                            lstFrf[7] = new List<float>(pFrfd7);
                            break;
                    }
                }
            }
            return br;
        }
        
        public  void TestDll3(string fn)
        {
            string ifiles = "ABC1#1.sts";
            string outfile = "ABC1#2.sts";
            //float[,] PFrf = new float[8][];
            //PFrf[0] = new float[4096];
          //  IntPtr PFrf = Marshal.AllocHGlobal(8 * 4 * 1024);
            PFrf pFef = new PFrf();
            ////Marshal.
            pFef.p0 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p1 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p2 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p3 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p4 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p5 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p6 = Marshal.AllocHGlobal(4 * 1024);
            pFef.p7 = Marshal.AllocHGlobal(4 * 1024);
          //  float[] pSpecData = new float[8*1024];
          //  IntPtr pFrf = Marshal.AllocHGlobal(8*4 * 1024); ;
          //  Marshal.StructureToPtr(pSpecData, pFrf, true);
            int nWavePtNum = 3 * 1024;
            int nProgress = 0;
            int nFftPtNum = 1024;
            float fWaveSfOut = 6400f;
            int nVtbScale = 4;
            float fGainCvOut = 10.02f;
            float fGainCvInec = 0.425f;
            int[] para = new int[4];
            para[0] = -1;
            para[1] = 1;
            para[2] = 24;
            para[3] = 85;
            float[] pFrfd0 = new float[1024];
             float[] pFrfd1 = new float[1024];
             float[] pFrfd2 = new float[1024];
             float[] pFrfd3 = new float[1024];
             float[] pFrfd4 = new float[1024];
             float[] pFrfd5 = new float[1024];
             float[] pFrfd6 = new float[1024];
             float[] pFrfd7 = new float[1024];

            WindowPara nWindowPara = new WindowPara();
            nWindowPara.p1 = -1;
            nWindowPara.p2 = 1;
            nWindowPara.p3 = 24;
            nWindowPara.p4 = 85;
            IntPtr tmp = Marshal.AllocHGlobal(16); 
            Marshal.StructureToPtr(nWindowPara, tmp, true);
            int a = Marshal.ReadInt32(tmp);
          //Marshal.StructureToPtr(person, intPtr, true);
            //IntPtr nWindowPara =  Marshal.AllocHGlobal(4*4);
            ////nWindowPara.s
            ////nWindowPara[0] = -1;
            ////nWindowPara[1] = 1;
            ////nWindowPara[2] = 24;
            ////nWindowPara[3] = 85;

            int nClearDc = 1;
            int nRC = 0;
            try
            {
                nRC = DaspFrfAverageInFileFloat(ifiles, outfile, out pFef, nWavePtNum, nFftPtNum, fWaveSfOut, nVtbScale, fGainCvInec, fGainCvOut,tmp/* nWindowPara*/, nClearDc, 0, 0, 0, out nProgress);
            }
            catch (Exception ex)
            {
               
            }
            if (nRC > 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Marshal.Copy(pFef.p0, pFrfd0, 0, 1024);
                            break;
                        case 1:
                            Marshal.Copy(pFef.p1, pFrfd1, 0, 1024);
                            break;
                        case 2:
                            Marshal.Copy(pFef.p2, pFrfd2, 0, 1024);
                            break;
                        case 3:
                            Marshal.Copy(pFef.p3, pFrfd3, 0, 1024);
                            break;
                        case 4:
                            Marshal.Copy(pFef.p4, pFrfd4, 0, 1024);
                            break;
                        case 5:
                            Marshal.Copy(pFef.p5, pFrfd5, 0, 1024);
                            break;
                        case 6:
                            Marshal.Copy(pFef.p6, pFrfd6, 0, 1024);
                            break;
                        case 7:
                            Marshal.Copy(pFef.p7, pFrfd7, 0, 1024);
                            break;
                    }
                }
            }
            MessageBox.Show(nRC.ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szTspFileName">DASP 的TSP 文件全路径名称,如 c:\daspout\abc1#1.tsp</param>
        /// <param name="nWavePoints">波形的数据点数</param>
        /// <param name="fFreqSampling">采样频率</param>
        /// <param name="fGain">增益倍数</param>
        /// <param name="fCv">标定值</param>
        /// <param name="szUnit">工程单位</param>
        /// <returns>数据的AD 版本</returns>
         [DllImport(@"DaspSaApi.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int DaspGetTspParaFloat(string szTspFileName, out int nWavePoints, out float fFreqSampling, out  float fGain, out float fCv, StringBuilder szUnit);
        //int DaspGetTspParaFloat(char* szTspFileName, int* nWavePoints, float* fFreqSampling, float*fGain, float* fCv, char* szUnit);

         public static bool DaspGetTspPara(string szTspFileName, out int nWavePoints,out float fFreqSampling,out float fGain, out float fCv, StringBuilder szUnit)
         {
             //string szTspFileName = "ABC1#1.tsp";
             //int  nWavePoints;
             // float fFreqSampling;
             // float fGain;
             // float  fCv;
             // StringBuilder szUnit = new StringBuilder(); ;

              int rn = DaspGetTspParaFloat(szTspFileName, out nWavePoints,out fFreqSampling,out fGain, out fCv, szUnit);//IntPtr.Zero);
              return (rn > 0);
         }
       /// <summary>
       /// 测试自谱分析
       /// </summary>
       /// <param name="fn"></param>
       /// <returns></returns>
        public  List<float>  TestDll2(string fn)
        {
            List<float> fData = new List<float>();
            fn = "ABC1#1.sts";
            IntPtr pSpec = Marshal.AllocHGlobal(4 * 1024);
            float[] pSpecData = new float[1024];
            int nWavePtNum = 3 * 1024;
            int nProgress = 0;
            int nFftPtNum = 1024;
            int nWindowType = 0;
            float fCalOffset = 0;
            float fCalCv = 0.425f;
            float fWaveSf = 25600.0f;
            float df = df = fWaveSf / nFftPtNum;


            //int nWavePtNum = 3 * 1024, nProgress = 0, nFftPtNum = 1024, nWindowType = 2;
            //float fCalOffset = 0, fCalCv = 41.9169, fWaveSf = 25600.0, df;
            //df = fWaveSf / nFftPtNum;


            int nRC = DaspAutoSpectrumAverageInFileFloat(fn,0, nWavePtNum, fWaveSf, fCalOffset, fCalCv,
             pSpec, nFftPtNum, nWindowType, 1, 1, 0, 0, 0, out nProgress);
            if (nRC > 0)
            {
                Marshal.Copy(pSpec, pSpecData, 0, 1024);
                for (int i = 0; i < nFftPtNum / 2 + 1; i++)
                {
                    fData.Add(pSpecData[i]);
                }
            }
            return fData;
        }
        /// <summary>
        /// 时域波形文件进行幅域基本参数统计
        /// </summary>
        /// <param name="szStsFileName"></param>
        /// <param name="nWaveOffset">时域波形数据文件的计算起始点</param>
        /// <param name="nWavePtNum">时域波形数据文件的计算起始点</param>
        /// <param name="fCalOffset"></param>
        /// <param name="fCalCv"></param>
        /// <param name="fMean">信号的平均值</param>
        /// <param name="fMax">信号的最大值</param>
        /// <param name="fMin">信号的最小值</param>
        /// <param name="fVariance">信号的方差</param>
        /// <param name="fRV">信号的标准差</param>
        /// <param name="fMS">信号的均方值</param>
        /// <param name="fRMS">信号的有效值</param>
        /// <param name="nProgress"></param>
        /// <returns></returns>
        [DllImport(@"DaspSaApi.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int DaspAmplyStaticInFileFloat(string szStsFileName, int nWaveOffset, int nWavePtNum, float
        fCalOffset, float fCalCv,out  float fMean, out float fMax, out float fMin,out  float fVariance,out  float fRV,
        out float fMS,out  float fRMS, out int nProgress);
        /// <summary>
        /// 对内存中的一段时域波形进行幅域基本参数统计
        /// </summary>
        /// <param name="pfWave">信号时域数据</param>
        /// <param name="nWavePtNum">信号时域数据的点数</param>
        /// <param name="fMean">信号的平均值</param>
        /// <param name="fMax">信号的最大值</param>
        /// <param name="fMin">信号的最小值</param>
        /// <param name="fVariance">信号的方差</param>
        /// <param name="fRV">信号的标准差</param>
        /// <param name="fMS">信号的均方值</param>
        /// <param name="fRMS">信号的有效值</param>
        /// <returns>>0 成功</returns>
        [DllImport(@"DaspSaApi.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int DaspAmplyStaticInMemoryFloat(float[] pfWave, int nWavePtNum, out float fMean, out float
 fMax, out float fMin, out float fVariance, out float fRV, out float fMS,out  float fRMS);

        public static void TestStaticAmpInMemory(float[] pfWave, int nWavePtNum, out float fMean, out float fMax, out float fMin, out float fVariance, out float fRV, out float fMS, out  float fRMS)
        {
            int rc = -1;
            rc = DaspAmplyStaticInMemoryFloat( pfWave,  nWavePtNum, out  fMean, out  fMax, out  fMin, out  fVariance, out  fRV, out  fMS, out   fRMS);
        }
        public void TestAmplyStatic()
        {
            string fn = "ABC1#1.sts";

            int nWavePtNum = 3 * 1024;
            int nProgress = 0;
            int nFftPtNum = 1024;
            int nWindowType = 0;
            float fCalOffset = 0;
            float fCalCv = 0.425f;
            float fWaveSf = 25600.0f;

            float fMean;
            float fMax;
            float fMin;
            float fVariance;
            float fRV;
            float fMS;
            float fRMS;


            int nRC = DaspAmplyStaticInFileFloat(fn, 0, nWavePtNum, fCalOffset, fCalCv,
            out   fMean, out fMax, out fMin, out fVariance, out fRV, out fMS, out fRMS, out nProgress);
            if (nRC > 0)
            {
                // Marshal.Copy(pSpec, pSpecData, 0, 1024);
            }
        }

//        int DaspAmplyStaticInFileFloat(char* szStsFileName, int nWaveOffset, int nWavePtNum, float
//fCalOffset, float fCalCv, float* fMean, float* fMax, float* fMin, float* fVariance, float* fRV,
//float* fMS, float* fRMS, int* nProgress);

        /// <summary>
        /// 读头观测文件信息
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string[] Read(string path)
        {
            //path = path + ".TSP";
            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                break;
            }
            return line.Split(new Char[] { ',' });

            // 加速度=电压（你读出来的数）/Gain（配置文件中有）/CV（配置文件）
        }
        /// <summary>
        /// 将科学计数的字符串转换成浮点树
        /// </summary>
        /// <param name="strData"></param>
        /// <returns></returns>
        public static float ChangeDataToD(string strData)
        {
            Decimal dData = 0.0M;
            if (strData.Contains("E"))
            {
                dData = Convert.ToDecimal(Decimal.Parse(strData.ToString(), System.Globalization.NumberStyles.Float));
                return Convert.ToSingle(dData);
            }
            else
            {
                return Convert.ToSingle(strData);
            }
        }
        public static float GetSacle(float fValue)
        {
            float scale = 1f;

            string b = fValue.ToString("E8");
            int b1 = b.IndexOf('E');
            string c = b.Substring(b1 + 1, 1);
            string d = b.Substring(b1 + 2, 3);
            int d1 = Convert.ToInt32(d);
            int c1 = 1;
            if (c.Equals("-"))
            {
                c1 = -1;
                scale = Convert.ToSingle(Math.Pow(10, c1 * (d1 + 1)));
            }
            else
            {
                scale = Convert.ToSingle(Math.Pow(10, c1 * (d1 - 1)));
            }
            return scale;
        }
    }
    public struct WindowPara
    {
        public int p1;
        public int p2;
        public int p3;
        public int p4;

    }
    public struct PFrf
    {
        public IntPtr p0;
        public IntPtr p1;
        public IntPtr p2;
        public IntPtr p3;
        public IntPtr p4;
        public IntPtr p5;
        public IntPtr p6;
        public IntPtr p7;

    }
}
