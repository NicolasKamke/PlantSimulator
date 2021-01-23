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

namespace PlantSimulator
{
    public partial class FormDevicesConnection : Form
    {
        public FormDevicesConnection()
        {
            InitializeComponent();
        }

        private void FormDevicesConnection_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbCOMPort.Items.AddRange(ports);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                txtStatus.Text = "Desconectado";
                btnDisconnect.Visible = false;
                btnConnect.Visible = true;

            }
        }

            private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = cmbCOMPort.Text;
                serialPort.BaudRate = int.Parse(cmbBaudRate.Text);
                txtStatus.Text = "Conectado";
                serialPort.Open();
                btnConnect.Visible = false;
                btnDisconnect.Visible = true;
            }
            catch
            {
                txtStatus.Text = "Erro de conexão";
            }
            
        }

        private void btnTestSend_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(txtTestSend.Text);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                txtReceive.Text = serialPort.ReadLine();
            }
        }
    }
}
