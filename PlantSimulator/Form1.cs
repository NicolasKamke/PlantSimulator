using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace PlantSimulator
{
    public partial class Form1 : Form
    {


        GraphPane myPaneGraph = new GraphPane();

        PointPairList listPoint = new PointPairList();

        LineItem myCurveGraph;

        bool controlLoopTask;

        public Form1()
        {
            InitializeComponent();

            grpPrimeiraOrdem.Visible = false;
            btnStart.Visible = false;
            btnStop.Visible = false;
            zedGraph.Visible = false;
            grpCommand.Visible = false;

            ConfigureGraph();
        }

        public void ConfigureGraph()
        {
            myPaneGraph = zedGraph.GraphPane;

            myPaneGraph.Title.Text = "Resposta ao degrau";

            myPaneGraph.XAxis.Title.Text = "t(s)";

            myPaneGraph.YAxis.Title.Text = "C(t)";

            myPaneGraph.YAxis.Scale.Min = 0;

            myCurveGraph = myPaneGraph.AddCurve(null, listPoint, Color.Red, SymbolType.None);

            myCurveGraph.Line.Width = 3;


        }

        private void cbxSitema_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStart.Visible = true;
            grpCommand.Visible = true;

            if (cbxSitema.SelectedIndex == 0)
            {
                grpPrimeiraOrdem.Visible = true;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Task.Run(() => ContinuousSampling());
            btnStart.Visible = false;
            btnStop.Visible = true;
            //updownStep.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            controlLoopTask = false;
            btnStart.Visible = true;
            btnStop.Visible = false;
            updownStep.Enabled = true;

        }

        public void ContinuousSampling()
        {
            controlLoopTask = true;
            double degrauAntigo = (double)updownStep.Value;

            Sistema.PrimeiraOrdem sistemaPrimeiraOrdem = new Sistema.PrimeiraOrdem(txtGain.Text, txtTau.Text, txtSignal.Text, txtA.Text, updownStep.Value);

            listPoint.Clear();
            ConfigureGraph();

            this.zedGraph.Invoke((MethodInvoker)delegate
            {
                zedGraph.Visible = true;

            });

            double samplingTime = 0;


            while (controlLoopTask)
            {

                if ((double)updownStep.Value != degrauAntigo)
                {
                    decimal newStep = updownStep.Value - (decimal)degrauAntigo;
                    sistemaPrimeiraOrdem.SetInitialPoint(sistemaPrimeiraOrdem.RespostaFuncaoPrimeiraOrdem(samplingTime));                  
                    sistemaPrimeiraOrdem.SetStep(newStep);
                    degrauAntigo = (double)updownStep.Value;
                    listPoint.Clear();
                    samplingTime = 0;

                }

                listPoint.Add(new PointPair(samplingTime, sistemaPrimeiraOrdem.RespostaFuncaoPrimeiraOrdem(samplingTime)));
                myPaneGraph.XAxis.Scale.Max = samplingTime;

                myPaneGraph.AxisChange();

                this.zedGraph.Invoke((MethodInvoker)delegate
                {
                    zedGraph.Refresh();

                });

                samplingTime += 0.1;

                Thread.Sleep(50);

            }
        }

        private void btnConnectionPage_Click_1(object sender, EventArgs e)
        {

            FormDevicesConnection DevicesConnectionPage = new FormDevicesConnection();
            DevicesConnectionPage.Show();

        }
    }
}