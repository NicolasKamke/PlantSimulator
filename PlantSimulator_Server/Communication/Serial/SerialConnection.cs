using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSimulator.Communication.Serial
{
    public static class SerialConnection
    {
        public static SerialPort serialPort = new SerialPort();
        public static string portName;
        public static int baudRate;
        public static string status = "Desconectado";
        public static bool connect = false;

        
        public static void connectDevice(string PortName, string BaudRate)
        {
            try
            {
                serialPort.PortName = PortName;
                serialPort.BaudRate = int.Parse(BaudRate);
                serialPort.Open();
                status = "Conectado";
                connect = true;                

            }

            catch
            {
                status = "Erro de conexão";
                
            }

        }
        public static void disconnectDevice()
        {
            serialPort.Close();
            connect = false;
        }


        public static void receiveDataDevice()
        {
            if (serialPort.IsOpen)
            {
                serialPort.ReadLine();
            }
        }

        public static void sendDataDevice(string data)
        {
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(data);
            }
        }
    }
}
