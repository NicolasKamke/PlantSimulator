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
        Form1 form1;
        public FormDevicesConnection(Form1 masterform)
        {
            InitializeComponent();
            txtStatus.Text = Conexao.status;
            form1 = masterform;

            if (Conexao.connect)
            {
                btnConnect.Visible = false;
                btnDisconnect.Visible = true;
                cmbCOMPort.Text = Conexao.portName;
                cmbBaudRate.Text = Conexao.baudRate.ToString();
            }
            else
            {
                btnDisconnect.Visible = false;
                btnConnect.Visible = true;
            }
        }

        private void FormDevicesConnection_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbCOMPort.Items.AddRange(ports);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {

            Conexao.Disconnect();
            form1.disconnectDevice();
            btnDisconnect.Visible = false;
            btnConnect.Visible = true;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Conexao.Connect(cmbCOMPort.Text, cmbBaudRate.Text);            
            btnConnect.Visible = false;
            btnDisconnect.Visible = true;
            form1.connectDevice();

        }

        private void btnTestSend_Click(object sender, EventArgs e)
        {            
            form1.sendDataDevice(txtTestSend.Text);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            form1.receiveDataDevice();
        }
    }
}
