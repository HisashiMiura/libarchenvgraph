﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArchEnvGraph.Functions
{
    /// <summary>
    /// 熱量から温度への変換
    /// </summary>
    public class HeatToTemp : IVariable<double>
    {
        /// <summary>
        /// 容積 [m3]
        /// </summary>
        public double V { get; set; }

        /// <summary>
        /// 容積比熱 cρ [kJ/m^3・K]
        /// </summary>
        public double cro { get; set; }

        /// <summary>
        /// 熱量 [J]
        /// </summary>
        public IVariable<double> U { get; set; }

        public double Get(int t)
        {
            var C = cro * 1000 * V;
            var T = U.Get(t) / C;
            return T;
        }
    }
}
