using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusProject
{
    public class ModbusSetup
    {

        public string ServerIP { get; set; }
        public int Port { get; set; }

        public int SlaveId { get; set; }

        public string Function { get; set; }

        public int Address { get; set; }

        public int Quantity { get; set; }

        public ModbusRegister[] Registers = new ModbusRegister[125];
    }

    public class ModbusRegister
    {

        
        public int RegisterNr { get; set; }

        public string Description { get; set; }

        public string RegisterValue { get; set; }
    }
}
