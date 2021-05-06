using PlantSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSimulator_Server
{
    public static class Sistema
    {
 
        static public double step = 1;
        static public double initialPoint = 0;
        static public double initialStepTime = 0;

        #region Sistema de primeira ordem
        public static class PrimeiraOrdem
        {
            static public double gainK { get; private set; }
            static public double tau { get; private set; }
            static public double a { get; private set; }



            public static void SetParameters(string stringGainK, string stringTau, string stringSignal, string stringA)
            {
                gainK = double.Parse(stringGainK);
                tau = double.Parse(stringTau);
                a = double.Parse(stringSignal + stringA);

            }


            public static double RespostaMalhaAberta(double time, double degrau)
            {
                if (time == 0) return 0;
                step = degrau;
                return ((step * (((gainK / a) * (1 - Math.Exp(-(a * (time - initialStepTime)) / tau))) / tau)) + initialPoint);
            }

            public static void SetInitialPoint(double initialPointValue)
            {
                initialPoint = initialPointValue;
            }

            public static void SetInitialStepTime(double initialStepPointValue)
            {
                initialStepTime = initialStepPointValue;
            }

            public static void SetStep(double newStep)
            {
                step = newStep;
            }


        }
        #endregion

        #region Sistema de segunda ordem
        public static class SegundaOrdem
        {
            static public double wn { get; private set; }
            static public double ksi { get; private set; }
            static public double a { get; private set; }


            public static void SetParameters(string stringWn2, string stringA, string stringSignal, string stringKsiWn)
            {
                wn = Math.Sqrt(double.Parse(stringWn2));
                ksi = double.Parse(stringSignal + stringKsiWn) / (2 * wn);
                a = double.Parse(stringA);

            }

            public static double RespostaMAbertaSubamortecida(double time, double degrau)//RespostaSubamortecida
            {
                if (time == 0) return 0;
                step = degrau;
                double x = step * (1 - (((Math.Exp(-ksi * wn * (time - initialStepTime))) / (Math.Sqrt(1 - Math.Pow(ksi, 2)))) * Math.Sin((wn * Math.Sqrt(1 - Math.Pow(ksi, 2))) * (time - initialStepTime) + Math.Atan((Math.Sqrt(1 - Math.Pow(ksi, 2))) / ksi)))) + initialPoint;
                return x;
            }
            public static double RespostaMAbertaCriticamenteAmortecido(double time, double degrau)//RespostaCriticamenteAmortecido
            {
                if (time == 0) return 0;
                step = degrau;
                double x = step * (1 - Math.Exp(-wn * (time - initialStepTime)) * (1 + wn * (time - initialStepTime))) + initialPoint;
                return x;
            }
            public static double RespostaMAbertaSuperamortecido(double time, double degrau)//RespostaSuperamortecido
            {
                if (time == 0) return 0;
                step = degrau;
                double S1 = wn * (ksi + Math.Sqrt(Math.Pow(ksi, 2) - 1));
                double S2 = wn * (ksi - Math.Sqrt(Math.Pow(ksi, 2) - 1));
                double A = wn / (2 * Math.Sqrt(Math.Pow(ksi, 2) - 1));
                double B = Math.Exp(-S1 * (time - initialStepTime)) / S1;
                double C = Math.Exp(-S2 * (time - initialStepTime)) / S2;
                double H = 1 + A * (B - C);
                double x = step * H + initialPoint;
                return x;
            }


            public static void SetInitialPoint(double initialPointValue)
            {
                initialPoint = initialPointValue;
            }

            public static void SetInitialStepTime(double initialStepPointValue)
            {
                initialStepTime = initialStepPointValue;
            }

            public static void SetStep(double newStep)
            {
                step = newStep;
            }
        }

        #endregion

        #region Return Responta em Malha Aberta
        public static class Resposta
        {
            static public double MalhaAberta (double Input, double Step)
            {
                if (MonitoraConexao.sistema == 1)
                {

                    return PrimeiraOrdem.RespostaMalhaAberta(Input, Step);


                }
                if (MonitoraConexao.sistema == 2)
                {

                    if (Sistema.SegundaOrdem.ksi >= 0 && Sistema.SegundaOrdem.ksi < 1)
                        return Sistema.SegundaOrdem.RespostaMAbertaSubamortecida(Input, Step);

                    else if (Sistema.SegundaOrdem.ksi == 1)
                        return Sistema.SegundaOrdem.RespostaMAbertaCriticamenteAmortecido(Input, Step);

                    else if (Sistema.SegundaOrdem.ksi > 1)
                        return Sistema.SegundaOrdem.RespostaMAbertaSuperamortecido(Input, Step);
                }

                return 0;
            }

        }

        #endregion

    }
}
