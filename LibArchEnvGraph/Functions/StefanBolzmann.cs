﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArchEnvGraph.Functions
{
    /// <summary>
    /// シュテファン-ボルツマンの法則
    /// </summary>
    public class StefanBolzmann : IVariable<double>
    {
        /// <summary>
        /// 灰色体1の放射率 [-]
        /// </summary>
        public double e1 { get; set; }

        /// <summary>
        /// 灰色体2の放射率 [-]
        /// </summary>
        public double e2 { get; set; }

        /// <summary>
        /// 灰色体1の面から灰色体2の面への形態係数 [-]
        /// </summary>
        public double F12 { get; set; }

        /// <summary>
        /// 灰色体1の表面温度 [K]
        /// </summary>
        public IVariable<double> T1 { get; set; }

        /// <summary>
        /// 灰色体2の表面温度 [K]
        /// </summary>

        public IVariable<double> T2 { get; set; }


        public double Get(int t)
        {
            var dU = F12 * e1 * e2 * (Math.Pow(T1.Get(t), 4.0) - Math.Pow(T2.Get(t), 4.0));
            return dU;
        }
    }
}
