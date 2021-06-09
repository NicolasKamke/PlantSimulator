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
using System.Diagnostics;

namespace PlantSimulator_Client
{
    public partial class Form1 : Form
    {
        #region Inicialização de variáveis globais

        double graphIncrement = 0.08;
        double velocityPloting = 0.08;
        double samplingTime;

        string selectCommunication = "";
        double saidaIntegralOld = 0;
        double saidaDerivadaOld = 0;
        double erroOld = 0;
        double step = 1;

        bool newStepInGraph = false;
        bool cancelationCSV = false;
        bool controller = false;
        bool closeLoop = false;
        bool saturacao = false;

        string receive = "0";
        string receiveOld = "0";
        double receiveData = 0;

        string csvPath = AppDomain.CurrentDomain.BaseDirectory + "\\plantResponse.csv";
        CancellationTokenSource tokenSource = null;
        GraphPane myPaneGraph = new GraphPane();
        PointPairList listPoint = new PointPairList();

        StringBuilder csvContent = new StringBuilder();

        LineItem myCurveGraph;
        double graphWindowTime;
        bool controlLoopTask;        
        double erro;
        double controllerAction;
        

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
        private async void btnStart_Click(object sender, EventArgs e)
        {
            receive = "0";
            receiveOld = "0";
            receiveData = 0;
            samplingTime = -graphIncrement;
            controllerAction = 0;
            erro = 0;

            saidaIntegralOld = 0;
            erroOld = 0;

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

            tokenSource = new CancellationTokenSource();
            Task.Run(() => TimerPlotaGrafico(), tokenSource.Token);           
            btnStep.Visible = true;

            txtWindowTime.Enabled = false;
            grpController.Enabled = false;

            graphWindowTime = Double.Parse(txtWindowTime.Text);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            controlLoopTask = false;
            tokenSource.Cancel(); 
            btnStart.Visible = true;
            btnStep.Visible = false;
   
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
                lblMalha.BackColor = Color.Red;             
                btnCloseLoop.Text = "Open";
                lblMalha.Text = "Malha Fechada";             
                closeLoop = !closeLoop;
            }
            else
            {
                lblMalha.BackColor = Color.Lime;                
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

        private void btnSaturacao_Click(object sender, EventArgs e)
        {

            if (btnSaturacao.Text == "Ligar")
            {
                btnSaturacao.Text = "Desligar";
                saturacao = true;
            }
            else if (btnSaturacao.Text == "Desligar")
            {
                btnSaturacao.Text = "Ligar";
                saturacao = false;
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
          

            if (myCurveGraph.NPts == (int)(graphWindowTime*60/ graphIncrement))
            {                
                myCurveGraph.RemovePoint(0);
                myPaneGraph.XAxis.Scale.Min += graphIncrement;
            }
            else
            {
                myPaneGraph.XAxis.Scale.Min = 0;
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

            if (selectCommunication == "")
            {
                ErrorInThread("Selecione um protocolo de comunicação!");
                return;
            }
            if (selectCommunication == "rest")
            {
                try
                {
                        
                    receive = await RestCommunication(receiveOld);
                    receiveOld = receive;

                }
                catch
                {
                    ErrorInThread("Não foi possível estabelecer conexão com o servidor!");
                        
                }
            }
                
            receiveData = Double.Parse(receive);

            PlotGraph(samplingTime, receiveData);                             
               
         

        }
        #endregion

        #region Timer1
        private void TimerPlotaGrafico()
        {
            while (controlLoopTask)
            {
                var durationTicks = Math.Round(velocityPloting * Stopwatch.Frequency);
                var sw = Stopwatch.StartNew();

                while (sw.ElapsedTicks < durationTicks)
                {

                }

                Task.Run(() => ContinuousSampling());
            }

        }
        #endregion

        #region Comunicação
        public async Task<string> RestCommunication(string receive)
        {
            double proporcional = 0;
            double integral = 0;
            double derivativo = 0;

            try
            {
                double x = closeLoop ? 0 : Convert.ToDouble(receive)* Convert.ToDouble(txtFeedbackGain.Text);
                erro = (step - x);

                controllerAction = erro;               

                if (controller)
                {                   

                    double Kp = Double.Parse(txtKp.Text);
                    double Ki = Double.Parse(txtKi.Text);
                    double Kd = Double.Parse(txtKd.Text);
                    double N = 100;
                    double Td = 2;
                    double Ts = velocityPloting;


                    if (Kp != 0)
                        proporcional = Kp * erro;
                    if (Ki != 0)
                        integral = Ki * velocityPloting * erroOld + saidaIntegralOld;
                    if (Kd != 0)
                        derivativo = (Kd / velocityPloting) * (erro - erroOld);
                        //derivativo = Kd * ((N * Td * (erro - erroOld) - saidaDerivadaOld * (N * Ts - Td)) / Td);

                    controllerAction = proporcional + integral + derivativo;

                    saidaDerivadaOld = derivativo;
                    saidaIntegralOld = integral;
                    erroOld = erro;

                }                

                if(saturacao)
                {
                    if (controllerAction > Double.Parse(txtSaturacao.Text))
                        controllerAction = Double.Parse(txtSaturacao.Text);
                }              
                

                if (newStepInGraph)
                {
                    step = Convert.ToDouble(txtStep.Text);

                    await RestClient.Post((step - erro).ToString());                    

                    newStepInGraph = false;

                }

                string get = await RestClient.Get("output");

                await RestClient.Post((controllerAction).ToString());

                samplingTime += graphIncrement;

                return get;

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
                    case "txtSaturacao":
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

        #region Timer Gera CSV
        private async void TimerGeraCSV()
        {
            csvContent.Clear();
            csvContent.AppendLine("r(t) - SetPoint; t - Tempo;e(t) - Erro;u(t) - Saído do Controlador;y(t) - Variável de Processo");

            while (controlLoopTask)
            {
                var durationTicks = Math.Round(velocityPloting * Stopwatch.Frequency);
                var sw = Stopwatch.StartNew();

                while (sw.ElapsedTicks < durationTicks)
                {

                }

                //GerarCSV();
                Task.Run(() => GerarCSV());

                if ((samplingTime > Double.Parse(txtTermino.Text)) || cancelationCSV)
                    controlLoopTask = false;
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

            Invoke((MethodInvoker)delegate
            {
                btnGerarCSV.Text = "Gerar";

                grpCommand.Enabled = true;
                grpController.Enabled = true;

            });

        }

        #endregion

        #region Gerar CSV
        private async void btnGerarCSV_Click(object sender, EventArgs e)
        { 
            if(btnGerarCSV.Text == "Gerar")
            {
                try
                {
                    await RestClient.Post("0/0");
                }
                catch
                {
                    ErrorInThread("ERROR: Verifique a comunicação");
                }

                grpCommand.Enabled = false;
                grpController.Enabled = false;
                listPoint.Clear();
                samplingTime = -graphIncrement;
                controllerAction = 0;
                erro = 0;
                saidaIntegralOld = 0;         
                erroOld = 0;
                step = Double.Parse(txtStep.Text);
                myPaneGraph.XAxis.Scale.Min = samplingTime;
                receive = "0";
                receiveOld = "0";

                controlLoopTask = true;

                btnGerarCSV.Text = "Cancelar";
                cancelationCSV = false;
                //GerarCSV();
                Task.Run(() => TimerGeraCSV());
            }
            else if (btnGerarCSV.Text == "Cancelar")
            {
                btnGerarCSV.Text = "Gerar";
                cancelationCSV = true;
            }
        }

        async void GerarCSV() 
        {
            receive = await RestCommunication(receiveOld);
            receiveOld = receive;

            PlotGraph(samplingTime, Double.Parse(receiveOld));

            csvContent.AppendLine(
                txtStep.Text.Replace(',', '.') + ";" + 
                samplingTime.ToString().Replace(',', '.') + ";" + 
                erro.ToString().Replace(',', '.') + ";" + 
                controllerAction.ToString().Replace(',', '.') + ";" +
                receiveOld.Replace(',', '.'));

                      

        }


        #endregion

       
    }
}