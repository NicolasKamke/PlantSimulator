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
using ZedGraph;

namespace PlantSimulator
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


        public Form1()
        {
            InitializeComponent();
            ConfigureGraph();

            grpSistemas.Visible = false;
            grpCommand.Visible = false;
            grpParameters.Visible = false;
            btnStep.Visible = false;

        }

        public void ConfigureGraph()
        {
            myPaneGraph = zedGraph.GraphPane;

            myPaneGraph.Title.Text = "Resposta ao degrau";

            myPaneGraph.XAxis.Title.Text = "t(s)";

            myPaneGraph.YAxis.Title.Text = "C(t)";    
            
            

            //myPaneGraph.YAxis.Scale.Format = "F2";

            //myPaneGraph.YAxis.Scale.MagAuto = false;

            //myPaneGraph.YAxis.ScaleFormatEvent += new Axis.ScaleFormatHandler(YAxis_ScaleFormatEvent); 

            myCurveGraph = myPaneGraph.AddCurve(null, listPoint, Color.Red, SymbolType.None);

            myCurveGraph.Line.Width = 3;

        }


        //string YAxis_ScaleFormatEvent(GraphPane myPaneGraph, Axis axis, double val, int index)
        //{
        //    //return String.Format("{0}", Decimal.Round((Decimal)val, 2));
        //    if (index % 4 == 0) return val.ToString();
        //    else if (index == 5) return val.ToString();
        //    else return "";

        //    //if (val == 0) return (val-1).ToString();
        //    //else if (val == 0) return "Max";
        //    //else if (val == 0.5) return val.ToString();
        //    //else return "";

        //    return index.ToString();
        //}

        public void CalculaParametrosPrimeiraOrdem()
        {
            txtT.Text = txtTau.Text;
            txtTE.Text = (2.2 / Double.Parse(txtA.Text)).ToString();
            txtTS.Text = (4 / Double.Parse(txtA.Text)).ToString();
        }

        private void cbxSitema_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpCommand.Visible = true;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();
            Task.Run(() => ContinuousSampling(), tokenSource.Token);
            CalculaParametrosPrimeiraOrdem();
            grpSistemas.Enabled = false;
            btnStep.Visible = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            controlLoopTask = false;
            grpSistemas.Enabled = true;
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

            //myPaneGraph.YAxis.Scale.Max = degrauAntigo+5;
            //zedGraph.RestoreScale(myPaneGraph);

        }

        public void ContinuousSampling()
        {
            samplingTime = 0;
            controlLoopTask = true;
            degrauAntigo = Convert.ToDouble(txtStep.Text);

            Sistema.PrimeiraOrdem sistemaPrimeiraOrdem = new Sistema.PrimeiraOrdem(txtGain.Text, txtTau.Text, txtSignal.Text, txtA.Text, Convert.ToDecimal(txtStep.Text));

            listPoint.Clear();
            ConfigureGraph();

            while (controlLoopTask)
            {

                if (newStepInGraph)
                {
                    decimal newStep = Convert.ToDecimal(txtStep.Text) - (decimal)degrauAntigo;
                    sistemaPrimeiraOrdem.SetInitialPoint(sistemaPrimeiraOrdem.RespostaFuncaoPrimeiraOrdem(samplingTime));
                    sistemaPrimeiraOrdem.SetStep(newStep);
                    sistemaPrimeiraOrdem.SetInitialStepTime(samplingTime);
                    degrauAntigo = Convert.ToDouble(txtStep.Text);
                    newStepInGraph = false;

                }

                listPoint.Add(new PointPair(samplingTime, sistemaPrimeiraOrdem.RespostaFuncaoPrimeiraOrdem(samplingTime)));
                myPaneGraph.XAxis.Scale.Max = samplingTime;

                myPaneGraph.AxisChange();

                this.zedGraph.Invoke((MethodInvoker)delegate
                {
                    zedGraph.Refresh();
                    zedGraph.Invalidate();


                });

                samplingTime += 0.1;
             
                Thread.Sleep(50);


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