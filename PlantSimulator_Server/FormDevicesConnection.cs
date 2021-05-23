using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using PlantSimulator.Communication.Serial;
using PlantSimulator.Communication.Rest.App_Start;

namespace PlantSimulator_Server
{
    public partial class FormDevicesConnection : Form
    {
        
        public FormDevicesConnection()
        {
            InitializeComponent();

            #region Conexao Serial

            txtStatus.Text = SerialConnection.status;
           

            if (SerialConnection.connect)
            {
                btnConnect.Visible = false;
                btnDisconnect.Visible = true;
                cmbCOMPort.Text = SerialConnection.portName;
                cmbBaudRate.Text = SerialConnection.baudRate.ToString();
            }
            else
            {
                btnDisconnect.Visible = false;
                btnConnect.Visible = true;
            }

            #endregion

            #region Conexao Rest
            if (WebServer.StatusConnection)
            {
                txtStatusConnectionRest.Text = "SERVER ONLINE";
            }
            else
            {
                txtStatusConnectionRest.Text = "SERVER OFFLINE";
            }

            #endregion
        }

        #region Conexao Serial
        private void FormDevicesConnection_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbCOMPort.Items.AddRange(ports);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {

            
            SerialConnection.disconnectDevice();
            btnDisconnect.Visible = false;
            btnConnect.Visible = true;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
                    
            btnConnect.Visible = false;
            btnDisconnect.Visible = true;
            SerialConnection.connectDevice(cmbCOMPort.Text, cmbBaudRate.Text);

        }

        private void btnTestSend_Click(object sender, EventArgs e)
        {
            SerialConnection.sendDataDevice(txtTestSend.Text);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            SerialConnection.receiveDataDevice();
        }

        #endregion

        #region Conexao Rest

        private void btnStartRest_Click(object sender, EventArgs e)
        {
            if (WebServer.Start())
            {
                txtStatusConnectionRest.Text = "SERVER ONLINE";
            }
            else
            {
                txtStatusConnectionRest.Text = "ERRO DE ATIVAÇÃO";
            }
        }
        private void btnStopRest_Click(object sender, EventArgs e)
        {
            if (WebServer.Stop())
            {
                txtStatusConnectionRest.Text = "SERVER OFFLINE";
            }
            else
            {
                txtStatusConnectionRest.Text = "ERRO DE DESATIVAÇÃO";
            }
        }


        #endregion


    }
}
