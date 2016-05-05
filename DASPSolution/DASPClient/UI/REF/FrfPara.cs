using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP_UI
{
     /// <summary>
     /// 自谱分析参数
    ///    /// <param name="pSpec">自谱，若nSpectrumType>0,长度不小于 nFftPtNum/2+1</param>
    /// <param name="nWaveOffset">时域波形的计算起始点</param>
    /// <param name="nWavePtNum">时域波形的计算总点数,不是pWave 的总点数，而是从nWaveOffset开始的要进行计算的点数</param>
    /// <param name="nFftPtNum"></param>
    /// <param name="fWaveSf">时域波形采样频率</param>
    /// <param name="fCalOffset">时域波形先进行转换计算</param>
    /// <param name="fCalCv">时域波形先进行转换计算</param>
    /// <param name="nWindowType">窗函数类型 0:矩形窗; 1:指数窗; 2:Hanning 窗; 3:hamming; 4:平顶窗; 5:Kaiser 窗; 6:CosRectangle; 7Y1; 8Y2; 9Triangle; 10HalfCos</param>
    /// <param name="nExpPara"></param>
    /// <param name="nClearDc"></param>
    /// <param name="nSpectrumType"></param>
    /// <param name="nAverageType"></param>
    /// <param name="nCascadePercent"></param>
     /// </summary>
    public class FrfParas
    {
        public float fWaveSfIn
        {
            set;
            get;
        }
        public float fWaveSfOut
        {
            set;
            get;
        }
        public float fCalCv
        {
            set;
            get;
        }
        public int nWindowLL
        {
            set;
            get;
        }
       public int nWindowLR
       {
           set;
           get;
       }
       public int nCorePar
       {
           set;
           get;
       }
        /// <summary>
        /// 时域波形的计算总点数
        /// </summary>
        public int nWavePtNum
        {
            set;
            get;
        }
        /// <summary>
        /// 时域波形的计算起始点
        /// </summary>
        public int nWaveOffset
        {
            set;
            get;
        }
        /// <summary>
        /// FFT 计算点数(必须为2 的幂次方,并且不大于2 的20 次方)
        /// </summary>
        public int nFftPtNum
        {
            set;
            get;
        }
        /// <summary>
        /// 窗函数类型 0:矩形窗; 1:指数窗; 2:Hanning 窗; 3:hamming; 4:平顶窗; 5:Kaiser 窗; 6:CosRectangle; 7Y1; 8Y2; 9Triangle; 10HalfCos
        /// </summary>
        public int nWindowType
        {
            set;
            get;
        }

        public float fCalOffset
        {
            set;
            get;
        }
        /// <summary>
        /// 指数窗的系数(1－10),仅当nWindowType=1 时有效
        /// </summary>
        public int nExpPara
        {
            set;
            get;
        }
        /// <summary>
        /// 是否做去直流处理 0 否 1 是
        /// </summary>
        public int nClearDc
        {
            set;
            get;
        }
        /// <summary>
        /// 频谱类型 0 单峰值 1 有效值 2 功率谱 3PSD
        /// </summary>
        public int nSpectrumType
        {
            set;
            get;
        }
        /// <summary>
        /// 平均方式 0 线性平均 1 峰值保持+平滑 2 最大值保持 3 指数平均 4 峰值保持
        /// </summary>
        public int nAverageType
        {
            set;
            get;
        }
        /// <summary>
        /// 重叠比例（0-99）
        /// </summary>
        public int nCascadePercent
        {
            set;
            get;
        }
    }
}
