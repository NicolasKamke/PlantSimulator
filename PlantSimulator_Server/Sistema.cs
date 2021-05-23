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
        static public double discretizationTime = 0.1;
        static public bool status = false;
        static public double entradaOldOld = 0;
        static public double entradaOld = 0;
        static public double saida = 0;
        static public double saidaOld = 0;
        static public double saidaOldOld = 0;
     
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


            public static double RespostaMalhaAberta(double entrada)
            {

                saida = (gainK / a) * (1 - Math.Exp(-discretizationTime * a)) * entradaOld + Math.Exp(-a * discretizationTime / tau) * saidaOld;
                                
                saidaOld = saida;                
                entradaOld = entrada;

                return saida;
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

            public static double RespostaMalhaAberta(double entrada)
            {
                saida = (wn / Math.Pow((2 * ksi * wn),2)) * (2 * wn * discretizationTime * ksi - 1 + 1 * Math.Exp(-2 * wn * ksi * discretizationTime)) * entradaOld + (wn / Math.Pow((2 * ksi * wn),2)) * (-(2 * discretizationTime * ksi * wn + 1) * Math.Exp(-2 * discretizationTime * ksi * wn) + 1) * entradaOldOld + 2 * Math.Exp(-wn * ksi * discretizationTime) * Math.Cos(wn * discretizationTime * Math.Sqrt(1 - Math.Pow(ksi, 2))) * saidaOld - Math.Exp(-2 * ksi * wn * discretizationTime) * saidaOldOld;
                
                saidaOldOld = saidaOld;
                saidaOld = saida;
                
                entradaOldOld = entradaOld;
                entradaOld = entrada;

                return saida;
            }           

        }

        #endregion

        #region Return Responta em Malha Aberta
        public static class Resposta
        {
            static public double MalhaAberta (double Input)
            {
               

                if (MonitoraConexao.sistema == 1)
                {

                    return PrimeiraOrdem.RespostaMalhaAberta(Input);


                }
                if (MonitoraConexao.sistema == 2)
                {
                    return SegundaOrdem.RespostaMalhaAberta(Input);
                }

                return 0;
            }

        }

        #endregion

    }
}
