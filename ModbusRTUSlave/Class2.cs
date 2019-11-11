using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusRTUSlave
{
    class pcs
    {
        private ushort[] reg = new ushort[60];
        
        private double v = 0;
        private double f = 0;
        private double p = 0;
        private double q = 0;
        public ushort[] REG { get { return reg; } set { reg = value; } }
        public double getV { get { return v; } set { v = value; } }
        public double getF { get { return f; } set { f = value; } }
        public double getP { get { return p; } set { p = value; } }
        public double getQ { get { return q; } set { q = value; } }
        private static double complement(ushort num) //2' 補數轉換
        {
            double result = 0;
            if (num >= 32768)
            {
                result = num - 65535;
            }
            else
            {
                result = num;
            }
            return result;
        }
        public void putData()
        {
            v = (REG[6] + REG[7] + REG[8]) / 3;
            f = REG[16];
            p = REG[24];
            q = REG[25];
        }
    }
}
