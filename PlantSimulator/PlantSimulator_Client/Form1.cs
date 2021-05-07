using PlantSimulator.Communication.OPC;
using PlantSimulator.Communication.Rest;
using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace PlantSimulator_Client
{
    public partial class Form1 : Form
    {
        #region Inicialização de variáveis globais
        CancellationTokenSource tokenSource = null;

        GraphPane myPaneGraph = new GraphPane();

        PointPairList listPoint = new PointPairList();

        LineItem myCurveGraph;
        bool controlLoopTask;
        bool closeLoop = false;
        bool newStepInGraph = false;        
        double samplingTime = 0;
        int velocityPloting = 100;
        string selectCommunication = "";

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

            //myPaneGraph.YAxis.Scale.Format = "F2";

            //myPaneGraph.YAxis.Scale.MagAuto = false;

            //myPaneGraph.YAxis.ScaleFormatEvent += new Axis.ScaleFormatHandler(YAxis_ScaleFormatEvent); 

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
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            await RestClient.Post("0/0/0");
            controlLoopTask = false;
            btnStart.Visible = true;
            btnStep.Visible = false;
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
                closeLoop = !closeLoop;
            }
            else
            {
                btnCloseLoop.BackColor = Color.Red;
                btnCloseLoop.Text = "Close";
                closeLoop = !closeLoop;
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
            string receive="0";
            double receiveData=0;
            samplingTime = 0;
            controlLoopTask = true;
            double degrauAntigo = Convert.ToDouble(txtStep.Text);
            double newStep = Convert.ToDouble(txtStep.Text);

            listPoint.Clear();
            myPaneGraph.XAxis.Scale.Min = samplingTime;
            //ConfigureGraph();

            while (controlLoopTask)
            {                

                if(selectCommunication == "")
                {
                    ErrorInThread("Selecione um protocolo de comunicação!");  
                    return;
                }
                if (selectCommunication == "rest")
                {
                    try
                    {
                        if (newStepInGraph)
                        {
                            await RestClient.Post(samplingTime.ToString() + "/" + newStep.ToString());
                            string initialPoint = await RestClient.Get("output");

                            newStep = Convert.ToDouble(txtStep.Text) - degrauAntigo;

                            await RestClient.Post(newStep.ToString() + "/" + initialPoint + "/" + samplingTime.ToString());

                            degrauAntigo = Convert.ToDouble(txtStep.Text);
                            newStepInGraph = false;

                        }

                        double x = closeLoop ? 0 : Convert.ToDouble(receive);
                        await RestClient.Post(samplingTime.ToString() + "/" + (newStep - x).ToString());
                        receive = await RestClient.Get("output");
                    }
                    catch
                    {
                        ErrorInThread("Não foi possível estabelecer conexão com o servidor!");
                        return;
                    }
                }

                receiveData = Double.Parse(receive);

                PlotGraph(samplingTime, receiveData);

                samplingTime += 0.1;
             
                Thread.Sleep(velocityPloting);
            }
        }
        #endregion

        #region Comunicação


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
        #endregion

        #region Evento de bloqueia digitação de caracteres inválidos
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

        #region Evento de verificação de campos vazios
        private void emptyTxtBoxVerify(object sender, EventArgs e)
        {
            if (sender.ToString().Split(':')[1].Trim() == "")
            {
                ((TextBox)sender).Text = "1";
                
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

       
    }
}