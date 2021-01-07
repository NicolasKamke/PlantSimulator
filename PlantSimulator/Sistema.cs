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


            public PrimeiraOrdem(string stringGain, string stringTau, string stringSignal, string stringA, decimal stepValue)
            {
                this.gain = double.Parse(stringGain);
                this.tau = double.Parse(stringTau);
                this.a = double.Parse(stringSignal + stringA);
                this.step = (double)stepValue;
            }
            public double RespostaFuncaoPrimeiraOrdem (double time)
            {
                return this.step*(((this.gain / this.a) * (1 - Math.Exp(-(this.a * time) / this.tau))) / this.tau);
            }


        }

    }
}
