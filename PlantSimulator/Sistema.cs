using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSimulator
{
    class Sistema
    {
        public class PrimeiraOrdem
        {
            double gain;
            double tau;
            double a;
            double step;
            double initialPoint = 0;
            double initialStepTime = 0;


            public PrimeiraOrdem(string stringGain, string stringTau, string stringSignal, string stringA, decimal stepValue)
            {
                this.gain = double.Parse(stringGain);
                this.tau = double.Parse(stringTau);
                this.a = double.Parse(stringSignal + stringA);
                this.step = (double)stepValue;
            }
            public double RespostaFuncaoPrimeiraOrdem(double time)
            {
                return (this.step * (((this.gain / this.a) * (1 - Math.Exp(-(this.a * (time - this.initialStepTime)) / this.tau))) / this.tau)) + this.initialPoint;
            }

            public void SetStep(decimal stepValue)
            {
                this.step = (double)stepValue;
            }
            public double GetStep()
            {
                return this.step;
            }

            public void SetInitialPoint(double initialPointValue)
            {
                this.initialPoint = initialPointValue;
            }

            public void SetInitialStepTime(double initialStepPointValue)
            {
                this.initialStepTime = initialStepPointValue;
            }


        }

    }
}
