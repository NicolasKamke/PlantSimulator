using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlantSimulator.Communication.Rest.App_Start;
using PlantSimulator_Server;

namespace PlantSimulator.Communication.Rest.Forms
{
    public partial class FormRest : Form
    {
        public FormRest()
        {
            InitializeComponent();           

            #region Initialize FormRest

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

        #region Conexao Rest

        private void btnStartRest_Click(object sender, EventArgs e)
        {
            try 
            {               
                WebServer.Start();
                txtStatusConnectionRest.Text = "SERVER ONLINE";
                MonitoraConexao.ActiveConnection("rest");
            }
            catch
            {
                txtStatusConnectionRest.Text = "ERRO DE ATIVAÇÃO";
            }
        }
        private void btnStopRest_Click(object sender, EventArgs e)
        {
            try 
            {
                WebServer.Stop();
                txtStatusConnectionRest.Text = "SERVER OFFLINE";
                MonitoraConexao.InactiveConnection("rest");
            }
            catch
            {
                txtStatusConnectionRest.Text = "ERRO DE DESATIVAÇÃO";
            }
        }

        #endregion
    }
}
