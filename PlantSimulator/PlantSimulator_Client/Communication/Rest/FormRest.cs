using System.Windows.Forms;

namespace PlantSimulator.Communication.Rest
{
    public partial class FormRest : Form
    {        
        public FormRest()
        {
            InitializeComponent();

            txtIP.Text = RestClient.portaURL;

            if (txtIP.Text.Length == 0)
            {
                txtIP.Text = "http://localhost:8080";
            }
        }

        private void txtIP_TextChanged(object sender, System.EventArgs e)
        {
            RestClient.portaURL = txtIP.Text;
        }
    }
}
