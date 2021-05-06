using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PlantSimulator;
using PlantSimulator.Communication.OPC.Forms;
using PlantSimulator.Communication.Rest.Forms;

namespace PlantSimulator_Server
{    
    public partial class Form1 : Form
    {
        #region Inicialize
        public Form1()
        {
            InitializeComponent();
            CalculaParametrosPrimeiraOrdem();
            MonitoraConexao.ConstructorMonitoraFluxo(this);            
            cbxSitema.SelectedIndex = 0;
            

        }
        #endregion        

        #region Components Methods

        public Button BtnDataSend
        {
            get { return btnDataSend; }
        }

        public Button BtnDataReceive
        {
            get { return btnDataReceive; }
        }

        public PictureBox PicRestButton
        {
            get { return picRestButton; }
        }

        public PictureBox PicOpcButton
        {
            get { return picOpcButton; }
        }

        #endregion

        #region Calcular Parâmetros
        public void CalculaParametrosPrimeiraOrdem()
        {
            txtT.Text = txtTau.Text;
            txtTE.Text = (2.2 / Double.Parse(txtA.Text)).ToString();
            txtTS.Text = (4 / Double.Parse(txtA.Text)).ToString();
        }
        #endregion

        #region Seleção do tipo de sistema
        private void cbxSitema_SelectedIndexChanged(object sender, EventArgs e)
        {                   

            switch (cbxSitema.SelectedIndex)
            {
                case 0:
                    MonitoraConexao.sistema = 1;
                    grpPrimeiraOrdem.Visible = true;
                    grpSegundaOrdem.Visible = false;
                    grpParametrosPrimeiraOrdem.Visible = true;
                    Sistema.PrimeiraOrdem.SetParameters(txtGainK.Text, txtTau.Text, txtSignal.Text, txtA.Text);
                    break;

                case 1:
                    MonitoraConexao.sistema = 2;
                    grpPrimeiraOrdem.Visible = false;
                    grpSegundaOrdem.Visible = true;
                    grpParametrosPrimeiraOrdem.Visible = false;
                    Sistema.SegundaOrdem.SetParameters(txtWn2.Text, txtbA.Text, textSignal1.Text, txtKsiWn.Text);

                    break;
            }

        }
        #endregion

        #region Bloqueio de digitação de caracteres indesejados
        private void BlockNumberCharacteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("[0-9\b,-]");

            e.Handled = !regex.IsMatch(e.KeyChar.ToString());

        }

        private void BlockSignalCharacteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("[\b+-]");

            e.Handled = !regex.IsMatch(e.KeyChar.ToString());                
            
        }
        #endregion

        #region Auto preenchimento para campos vazios
        private void emptyTxtBoxVerify(object sender, EventArgs e)
        {
            if (sender.ToString().Split(':')[1].Trim() == "")
            {   
                ((TextBox)sender).Text = "1";
            }

        }

        #endregion

        #region Setar parâmetros do sistema      

        private void tranferFunction_TextChanged(object sender, EventArgs e)
        {
            if (MonitoraConexao.sistema == 1)
            {
                if (sender.ToString().Split(':')[1].Trim() != "")
                {
                    if (Convert.ToDecimal(txtTau.Text) + Convert.ToDecimal(txtA.Text) == 0
                        || Convert.ToDecimal(txtGainK.Text) == 0)
                    {
                        ((TextBox)sender).Text = "1";
                    }

                    Sistema.PrimeiraOrdem.SetParameters(txtGainK.Text, txtTau.Text, txtSignal.Text, txtA.Text);
                    CalculaParametrosPrimeiraOrdem();

                }
            }
            if (MonitoraConexao.sistema == 2)
            {
                if (sender.ToString().Split(':')[1].Trim() != "")
                {
                    if (Convert.ToDecimal(txtTau.Text) + Convert.ToDecimal(txtA.Text) == 0
                        || Convert.ToDecimal(txtGainK.Text) == 0)
                    {
                        ((TextBox)sender).Text = "1";
                    }

                    Sistema.SegundaOrdem.SetParameters(txtWn2.Text, txtbA.Text, textSignal1.Text, txtKsiWn.Text);
                    //CalculaParametrosPrimeiraOrdem();

                }
            }
        }

        #endregion

        #region Comunicação

        #region REST
     
        private void picRestButton_Click(object sender, EventArgs e)
        {
            if (MonitoraConexao.selectCommunication == "" || MonitoraConexao.selectCommunication == "rest")
            {
                FormRest RestConnectionPage = new FormRest();
                RestConnectionPage.Show();
            }
            else
            {
                MessageBox.Show("A conexão " + MonitoraConexao.selectCommunication.ToUpper() + " está ativa, desative-a para acessar essa!");
            }
        }
        #endregion

        #region OPC       

        private void picOpcButton_Click(object sender, EventArgs e)
        {
            if (MonitoraConexao.selectCommunication == "" || MonitoraConexao.selectCommunication == "opc") {
                FormOPC FormOPCPage = new FormOPC();
                FormOPCPage.Show(); 
            }
            else
            {
                MessageBox.Show("A conexão " + MonitoraConexao.selectCommunication.ToUpper() + " está ativa, desative-a para acessar essa!");
            }
        }
        #endregion

        #endregion

        #region Botão Connection
        private void btnConnectionPage_Click_1(object sender, EventArgs e)
        {

            FormDevicesConnection DevicesConnectionPage = new FormDevicesConnection();
            DevicesConnectionPage.Show();

        }
        #endregion

    }
}