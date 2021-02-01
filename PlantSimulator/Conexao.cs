using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PlantSimulator
{
    public static class Conexao
    {
        public static string portName;
        public static int baudRate;
        public static string status = "Desconectado";
        public static bool connect = false;

        public static void Connect(string PortName, string BaudRate)
        {
            portName = PortName;
            baudRate = int.Parse(BaudRate);
            status = "Conectado";
            

        }

        public static void Disconnect()
        {
            status = "Desconectado";
        }

    }
}
