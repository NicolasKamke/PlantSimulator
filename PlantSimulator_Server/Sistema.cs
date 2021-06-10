using PlantSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PlantSimulator_Server
{
    public static class Sistema
    {
        static public double discretizationTime = 0.005;
        static public double entradaOldOld = 0;
        static public double entradaOld = 0;
        static public double entrada = 0;
        static public double saida = 0;
        static public double saidaTemp = 0;
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

                saidaTemp = (gainK / a) * (1 - Math.Exp(-discretizationTime * a / tau)) * entradaOld + Math.Exp(-a * discretizationTime / tau) * saidaOld;
                                
                saidaOld = saidaTemp;                
                entradaOld = entrada;

                return saidaTemp;
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
                if (stringWn2.Trim() != "") wn = Math.Sqrt(double.Parse(stringWn2));
                if (stringKsiWn.Trim() != "") ksi = (double.Parse(stringSignal + stringKsiWn) / (2 * wn)) == 1 ?
                            (double.Parse(stringSignal + stringKsiWn) / (2 * wn)) + 0.0000000001 :
                            (double.Parse(stringSignal + stringKsiWn) / (2 * wn));
                a = double.Parse(stringA);

            }

            public static double RespostaMalhaAberta(double entrada)
            {
                double a = ksi * wn;
                Complex bComplex = Complex.Sqrt(wn * wn - ksi * ksi * wn * wn);
                double b = bComplex.Real;

                saidaTemp = ((1 - Math.Exp(-a * discretizationTime) * Math.Cos(b * discretizationTime) - a * Math.Exp(-a * discretizationTime) * Math.Sin(b * discretizationTime) / b)) * entradaOld + ((Math.Exp(-2 * a * discretizationTime) + a * Math.Exp(-a * discretizationTime) * Math.Sin(b * discretizationTime) / b - Math.Exp(-a * discretizationTime) * Math.Cos(b * discretizationTime))) * entradaOldOld + (2 * Math.Exp(-a * discretizationTime) * Math.Cos(b * discretizationTime)) * saidaOld - (Math.Exp(-2 * a * discretizationTime)) * saidaOldOld;


                saidaOldOld = saidaOld;
                saidaOld = saidaTemp;
                
                entradaOldOld = entradaOld;
                entradaOld = entrada;

                return saidaTemp;
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
