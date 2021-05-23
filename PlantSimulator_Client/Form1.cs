using PlantSimulator.Communication.OPC;
using PlantSimulator.Communication.Rest;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Xml.Linq;
using System.IO;
using System.Text;

namespace PlantSimulator_Client
{
    public partial class Form1 : Form
    {
        #region Inicialização de variáveis globais
        string csvPath = AppDomain.CurrentDomain.BaseDirectory + "\\plantResponse.csv";

        CancellationTokenSource tokenSource = null;

        GraphPane myPaneGraph = new GraphPane();

        PointPairList listPoint = new PointPairList();

        LineItem myCurveGraph;
        double graphWindowTime;
        bool controlLoopTask;
        bool closeLoop = false;
        bool newStepInGraph = false;
        double samplingTime = 0;
        int velocityPloting = 57;
        string selectCommunication = "";
        double step = 1;

        double controllerAction;
        bool controller = false;

        #endregion

        #region Initialize Components
        public Form1()
        {
            InitializeComponent();
            ConfigureGraph();
            btnStep.Visible = false;

        }
        #endregion        

        #region Configurações do gráfico
        public void ConfigureGraph()
        {
            myPaneGraph = zedGraph.GraphPane;

            myPaneGraph.Title.Text = "Resposta ao degrau";

            myPaneGraph.XAxis.Title.Text = "t(s)";

            myPaneGraph.YAxis.Title.Text = "C(t)";

            myPaneGraph.XAxis.MajorGrid.IsVisible = true;

            myPaneGraph.YAxis.MajorGrid.IsVisible = true;

            myCurveGraph = myPaneGraph.AddCurve(null, listPoint, Color.Red, SymbolType.None);

            myCurveGraph.Line.Width = 3;

        }
        #endregion

        #region Enventos Botões click
        private void btnStart_Click(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();
            Task.Run(() => ContinuousSampling(), tokenSource.Token);
            btnStep.Visible = true;

            txtWindowTime.Enabled = false;
            grpController.Enabled = false;

            graphWindowTime = Double.Parse(txtWindowTime.Text);
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            controlLoopTask = false;
            tokenSource.Cancel(); 
            btnStart.Visible = true;
            btnStep.Visible = false;
            try
            {
                await RestClient.Post("0/0");
            }
            catch
            {
                ErrorInThread("ERROR: Sem conexão com o servidor");
            }

            txtWindowTime.Enabled = true;
            grpController.Enabled = true;
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            newStepInGraph = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listPoint.Clear();
            myPaneGraph.XAxis.Scale.Min = samplingTime;
        }

        private void btnCloseLoop_Click(object sender, EventArgs e)
        {


            if (closeLoop)
            {
                btnCloseLoop.BackColor = Color.Lime;
                btnCloseLoop.Text = "Open";
                lblMalha.Text = "Malha Fechada";
                closeLoop = !closeLoop;
            }
            else
            {
                btnCloseLoop.BackColor = Color.Red;
                btnCloseLoop.Text = "Close";
                lblMalha.Text = "Malha Aberta";
                closeLoop = !closeLoop;
            }
        }

        private void btnController_Click(object sender, EventArgs e)
        {
            if (controller)
            {
                btnController.Text = "OFF";
                btnController.BackColor = Color.Red;
                controller = !controller;
            }
            else
            {
                btnController.Text = "ON";
                btnController.BackColor = Color.Lime;
                controller = !controller;
            }
        }

        #endregion

        #region Abrir forms de conexão

        #region REST
        private void picRestButton_DoubleClick(object sender, EventArgs e)
        {
            FormRest FormRestPage = new FormRest();
            FormRestPage.Show();
        }

        private void picRestButton_Click(object sender, EventArgs e)
        {
            if (selectCommunication == "" || selectCommunication == "rest")
            {
                if (picRestButton.BackColor == Color.Green)
                {
                    picRestButton.BackColor = Color.White;
                    selectCommunication = "";
                }
                else
                {
                    picRestButton.BackColor = Color.Green;
                    selectCommunication = "rest";
                }
            }

        }
        #endregion

        #region OPC
        private void picOpcButton_DoubleClick(object sender, EventArgs e)
        {
            FormOPC FormOPCPage = new FormOPC();
            FormOPCPage.Show();
        }

        private void picOpcButton_Click(object sender, EventArgs e)
        {
            if (selectCommunication == "" || selectCommunication == "opc")
            {
                if (picOpcButton.BackColor == Color.Green)
                {
                    picOpcButton.BackColor = Color.White;
                    selectCommunication = "";
                }
                else
                {
                    picOpcButton.BackColor = Color.Green;
                    selectCommunication = "opc";
                }
            }

        }
        #endregion
        #endregion

        #region ZedGraph Plotagem

        public void PlotGraph(double samplingTime, double receiveData)
        {
            listPoint.Add(new PointPair(samplingTime, receiveData));

            myPaneGraph.XAxis.Scale.Max = samplingTime;

            myPaneGraph.AxisChange();

          

            if (myCurveGraph.NPts == (int)(graphWindowTime*60/0.1))
            {
                myCurveGraph.RemovePoint(0);
                myPaneGraph.XAxis.Scale.Min += 0.1;
            }
                

           

            this.zedGraph.Invoke((MethodInvoker)delegate
            {
                zedGraph.Refresh();

                zedGraph.Invalidate();

            });

        }


        #endregion

        #region Thread de envio e recebimento de dados
        public async void ContinuousSampling()
        {
            string receive = "0";  
            double receiveData = 0;
            samplingTime = 0;
            controllerAction = 0;
            
            controlLoopTask = true;
            step = Double.Parse(txtStep.Text);

            listPoint.Clear();
            myPaneGraph.XAxis.Scale.Min = samplingTime;

            try
            {
                await RestClient.Post("0/0");
            }                
            catch
            {
                ErrorInThread("ERROR: Verifique a comunicação");
            }

            while (controlLoopTask)
            {

                if (selectCommunication == "")
                {
                    ErrorInThread("Selecione um protocolo de comunicação!");
                    return;
                }
                if (selectCommunication == "rest")
                {
                    try
                    {                     
                        receive = await RestCommunication(receive);

                    }
                    catch
                    {
                        ErrorInThread("Não foi possível estabelecer conexão com o servidor!");
                        
                    }
                }
                
                receiveData = Double.Parse(receive);

                PlotGraph(samplingTime, receiveData);

                samplingTime += 0.1;

                
               
            }

    


        }
        #endregion

        #region Comunicação  
        double saidaIntegralOld = 0;
        double entradaOld = 0;

        public async Task<string> RestCommunication(string receive)
        {
            
            double erro = 0;
            double proporcional = 0;
            double integral = 0;
            double derivativo = 0;


            try
            {
                double x = closeLoop ? 0 : Convert.ToDouble(receive);
                erro = (step - x);

                controllerAction = erro;

                if (controller)
                {
                    if (txtKp.Text != "0")
                        proporcional = erro * Double.Parse(txtKp.Text);
                    if (txtKi.Text != "0")
                        //integral = Double.Parse(txtKi.Text)*erro*0.1 + saidaOld;
                        integral = Double.Parse(txtKi.Text) * (saidaIntegralOld + erro * 0.1);
                    if (txtKd.Text != "0")
                        derivativo = Double.Parse(txtKd.Text)*((erro-entradaOld)/0.1);

                    controllerAction = proporcional + integral + derivativo;

                }

                saidaIntegralOld = integral;
                entradaOld = erro;

                await RestClient.Post((controllerAction).ToString());
                

                if (newStepInGraph)
                {
                    step = Convert.ToDouble(txtStep.Text);

                    await RestClient.Post((step - erro).ToString());                    

                    newStepInGraph = false;

                }

                Thread.Sleep(velocityPloting);

                return await RestClient.Get("output");

            }
            catch
            {
                ErrorInThread("Não foi possível estabelecer conexão com o servidor!");
                return null;
            }            
        }

        #endregion

        #region Mensagens de Erro
        public void ErrorInThread(string mensagem)
        {           
            MessageBox.Show(mensagem);
            tokenSource.Cancel();
            this.grpCommand.Invoke((MethodInvoker)delegate
            {
                controlLoopTask = false;
                btnStart.Visible = true;
                btnStep.Visible = false;
            });                
        }
        public void ErrorWriteFile(string mensagem)
        {           
            MessageBox.Show(mensagem);
        }


            #endregion

        #region Evento de bloqueia digitação de caracteres inválidos
        private void BlockNumberCharacteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("[0-9\b,-]");

            e.Handled = !regex.IsMatch(e.KeyChar.ToString());
        }

        private void BlockNumberAndSignalsCharacteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("[0-9\b,]");

            e.Handled = !regex.IsMatch(e.KeyChar.ToString());
        }



        #endregion

        #region Evento de verificação de campos vazios
        private void emptyTxtBoxVerify(object sender, EventArgs e)
        {     
            if (sender.ToString().Split(':')[1].Trim() == "")
            {
                switch (((TextBox)sender).Name)
                {
                    case "txtInicio":
                        ((TextBox)sender).Text = "0";
                        break;
                    case "txtKp":
                        ((TextBox)sender).Text = "0";
                        break;
                    case "txtKi":
                        ((TextBox)sender).Text = "0";
                        break;
                    case "txtKd":
                        ((TextBox)sender).Text = "0";
                        break;
                    case "txtWindowTime":
                        ((TextBox)sender).Text = "2";
                        break;
                    case "txtTermino":
                        ((TextBox)sender).Text = "10";
                        break;
                    case "txtPasso":
                        ((TextBox)sender).Text = "100";
                        break;
                    default:
                        ((TextBox)sender).Text = "1";
                        break;
                }
               
                
            }

        }





        #endregion

        #region Comunicação Serial

        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{
        //    textBox10.Text = trackBar1.Value.ToString();
        //    velocityPloting = trackBar1.Value;
        //}

        //private void textBox10_TextChanged(object sender, EventArgs e)
        //{
        //    trackBar1.Value = int.Parse(textBox10.Text);
        //    velocityPloting = trackBar1.Value;
        //}

        //public void connectDevice()
        //{       
        //    try
        //    {
        //        serialPort.PortName = Conexao.portName;
        //        serialPort.BaudRate = Conexao.baudRate;
        //        serialPort.Open();
        //        Conexao.status = "Conectado";
        //        Conexao.connect = true;
        //        textBox11.Text = "Conectado";

        //    }

        //    catch
        //    {
        //        Conexao.status = "Erro de conexão";
        //        textBox11.Text = "Erro de conexão";
        //    }

        //}
        //public void disconnectDevice()
        //{
        //    serialPort.Close();
        //    Conexao.connect = false;
        //}


        //    public void receiveDataDevice()
        //{
        //    if (serialPort.IsOpen)
        //    {
        //        textBox11.Text = serialPort.ReadLine();
        //    }
        //}

        //public void sendDataDevice(string data)
        //{
        //    if (serialPort.IsOpen)
        //    {
        //        serialPort.WriteLine(data);
        //    }
        //}
        #endregion

        #region Gerar CSV
        private async void btnGerarCSV_Click(object sender, EventArgs e)
        {
            string receive = "0";
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("r(t) - SetPoint; t - Tempo;e(t) - Erro;u(t) - Saído do Controlador;y(t) - Variável de Processo");
            
            for (double x = Convert.ToDouble(txtInicio.Text); x < Convert.ToDouble(txtTermino.Text) ; x += (Convert.ToDouble(txtPasso.Text)*Math.Pow(10,-3)))
            {
                samplingTime = x;
                receive = await RestCommunication(receive);
                double error = Convert.ToDouble(txtStep.Text) - Convert.ToDouble(receive);
                
                string step = txtStep.Text.Replace(',','.');
                string time = Math.Round(x,10).ToString().Replace(',', '.');
                string erro = error.ToString().Replace(',', '.');
                string saidaPlanta = receive.Replace(',', '.');

                csvContent.AppendLine(step + ";" + time + ";" + erro + ";" + erro + ";" + saidaPlanta);
                
            }            

            try
            {
                File.WriteAllText(csvPath, csvContent.ToString(), Encoding.GetEncoding(28591));
                await RestClient.Post("0/0");
            }

            catch
            {
                ErrorWriteFile("O arquivo já está sendo usado por outro processo");
            }


        }

        #endregion

       
    }
}