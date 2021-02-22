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
using PlantSimulator_Client;

namespace PlantSimulator_Client
{
    public partial class Form1 : Form
    {
        CancellationTokenSource tokenSource = null;

        GraphPane myPaneGraph = new GraphPane();

        PointPairList listPoint = new PointPairList();

        LineItem myCurveGraph;
        bool controlLoopTask;
        bool newStepInGraph = false;
        double degrauAntigo;
        double samplingTime = 0;
        int velocityPloting;

        public Form1()
        {
            InitializeComponent();
            ConfigureGraph();



           
            grpCommand.Visible = false;
           
            btnStep.Visible = false;

        }

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

        private void btnStart_Click(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();
            Task.Run(() => ContinuousSampling(), tokenSource.Token);
  
            btnStep.Visible = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            controlLoopTask = false;
      
            btnStep.Visible = false;
            btnStart.Visible = true;
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

        public void ContinuousSampling()
        {
            samplingTime = 0;
            controlLoopTask = true;
            degrauAntigo = Convert.ToDouble(txtStep.Text);

            //Sistema.PrimeiraOrdem sistemaPrimeiraOrdem = new Sistema.PrimeiraOrdem(txtGainK.Text, txtFeedbackGain.Text, txtTau.Text, txtSignal.Text, txtA.Text, Convert.ToDecimal(txtStep.Text));

            listPoint.Clear();
            myPaneGraph.XAxis.Scale.Min = samplingTime;
            //ConfigureGraph();

            while (controlLoopTask)
            {

                if (newStepInGraph)
                {
                    decimal newStep = Convert.ToDecimal(txtStep.Text) - (decimal)degrauAntigo;
                    //sistemaPrimeiraOrdem.SetInitialPoint(sistemaPrimeiraOrdem.RespostaFuncaoPrimeiraOrdem(samplingTime));
                    //sistemaPrimeiraOrdem.SetStep(newStep);
                    //sistemaPrimeiraOrdem.SetInitialStepTime(samplingTime);
                    degrauAntigo = Convert.ToDouble(txtStep.Text);
                    newStepInGraph = false;

                }

                //listPoint.Add(new PointPair(samplingTime, sistemaPrimeiraOrdem.RespostaFuncaoPrimeiraOrdem(samplingTime)));
                myPaneGraph.XAxis.Scale.Max = samplingTime;

                myPaneGraph.AxisChange();

                this.zedGraph.Invoke((MethodInvoker)delegate
                {
                    zedGraph.Refresh();
                    zedGraph.Invalidate();
                    


                });

                samplingTime += 1;
             
                Thread.Sleep(velocityPloting);
                

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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox10.Text = trackBar1.Value.ToString();
            velocityPloting = trackBar1.Value;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            trackBar1.Value = int.Parse(textBox10.Text);
            velocityPloting = trackBar1.Value;
        }

        

        
        public void connectDevice()
        {       
            try
            {
                serialPort.PortName = Conexao.portName;
                serialPort.BaudRate = Conexao.baudRate;
                serialPort.Open();
                Conexao.status = "Conectado";
                Conexao.connect = true;
                textBox11.Text = "Conectado";

            }

            catch
            {
                Conexao.status = "Erro de conexão";
                textBox11.Text = "Erro de conexão";
            }

        }
        public void disconnectDevice()
        {
            serialPort.Close();
            Conexao.connect = false;
        }


            public void receiveDataDevice()
        {
            if (serialPort.IsOpen)
            {
                textBox11.Text = serialPort.ReadLine();
            }
        }

        public void sendDataDevice(string data)
        {
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(data);
            }
        }




    }
}