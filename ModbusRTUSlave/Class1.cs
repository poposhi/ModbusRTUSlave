using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusRTUSlave
{
    class Class1
    {
    }
    class pcs
    {
        private ushort[] value = new ushort[60];
        public int vvv()
        {
            return (value[5] + value[6] + value[7]) / 3;
        }

    }
}
