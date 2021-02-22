using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ZedGraph;

namespace PlantSimulator_Server
{
    public partial class Form1 : Form
    {    

        public Form1()
        {
            InitializeComponent();          

            grpSistemas.Visible = false;
            grpParameters.Visible = false;
           

        }

        public void CalculaParametrosPrimeiraOrdem()
        {
            txtT.Text = txtTau.Text;
            txtTE.Text = (2.2 / Double.Parse(txtA.Text)).ToString();
            txtTS.Text = (4 / Double.Parse(txtA.Text)).ToString();
        }

        private void cbxSitema_SelectedIndexChanged(object sender, EventArgs e)
        {         
            grpSistemas.Visible = true;
            grpParameters.Visible = true;

            switch (cbxSitema.SelectedIndex)
            {
                case 0:
                    grpPrimeiraOrdem.Visible = true;
                    grpSegundaOrdem.Visible = false;
                    grpParametrosPrimeiraOrdem.Visible = true;
                    break;

                case 1:
                    grpPrimeiraOrdem.Visible = false;
                    grpSegundaOrdem.Visible = true;
                    grpParametrosPrimeiraOrdem.Visible = false;
                    break;
            }

        }      
        

        private void BlockNumberCharacteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("[0-9\b,-]");

            e.Handled = !regex.IsMatch(e.KeyChar.ToString());

        }

        private void BlockSignalCharacteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("[\b+-]");

            e.Handled = !regex.IsMatch(e.KeyChar.ToString());
                
            //sender.ToString().Split(':')[1].Contains('+');
        }

        private void btnConnectionPage_Click_1(object sender, EventArgs e)
        {

            FormDevicesConnection DevicesConnectionPage = new FormDevicesConnection();
            DevicesConnectionPage.Show();

        }

        private void emptyTxtBoxVerify(object sender, EventArgs e)
        {
            if (sender.ToString().Split(':')[1].Trim() == "")
            {
                ((TextBox)sender).Text = "1";
                
            }

        }


    }
}