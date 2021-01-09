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

            myCurveGraph = myPaneGraph.AddCurve(null, listPoint, Color.Red, SymbolType.None);

            myCurveGraph.Line.Width = 3;

        }

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
            Task.Run(() => ContinuousSampling());
            CalculaParametrosPrimeiraOrdem();
            grpSistemas.Enabled = false;
            btnStep.Visible = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
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
                    myPaneGraph.AxisChange();
                    

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