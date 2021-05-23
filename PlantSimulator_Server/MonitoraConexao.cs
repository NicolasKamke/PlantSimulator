using PlantSimulator_Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSimulator
{
    static class MonitoraConexao
    {
        static public string selectCommunication { get; set; }
        static public int sistema { get; set; }
        static bool send = false;
        static bool receive = false;
        static Form1 Board;

        static public void ConstructorMonitoraFluxo(Form1 board)
        {
            Board = board;
            selectCommunication = "";
        }

        static public void SendFlow()
        {
            if (send)
            {
                Board.BtnDataSend.BackColor = Color.Green;
                send = false;                
            }
            else
            {
                Board.BtnDataSend.BackColor = Color.DarkRed;
                send = true;
            }
        }

        static public void ReceiveFlow()
        {
            if (receive)
            {
                Board.BtnDataReceive.BackColor = Color.Green;
                receive = false;
            }
            else
            {
                Board.BtnDataReceive.BackColor = Color.DarkRed;
                receive = true;
            }
        }

        static public void ActiveConnection(string nomeProtocolo)
        {
            switch (nomeProtocolo)
            {
                case "rest":                                
                    Board.PicRestButton.BackColor = Color.Green;
                    MonitoraConexao.selectCommunication = "rest";
                    break;

                case "opc":
                    Board.PicOpcButton.BackColor = Color.Green;
                    MonitoraConexao.selectCommunication = "opc";
                    break;

            }
                
            
        }

        static public void InactiveConnection(string nomeProtocolo)
        {
            switch (nomeProtocolo)
            {
                case "rest":
                    Board.PicRestButton.BackColor = Color.White;
                    MonitoraConexao.selectCommunication = "";
                    break;

                case "opc":
                    Board.PicOpcButton.BackColor = Color.White;
                    MonitoraConexao.selectCommunication = "";
                    break;

            }
        }

    }
}
