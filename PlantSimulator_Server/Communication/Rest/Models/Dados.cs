using PlantSimulator_Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSimulator.Communication.Rest.Models
{
    public class Dados
    {
        public double Input { get; set; }
        public double Output { get; set; }

        public Dados() { }

        public void RecebeDados(string input)
        {
            if ((input.Count(f => (f == '/'))) == 1)
            {
                Sistema.entradaOldOld = 0;
                Sistema.entradaOld = 0;
                Sistema.entrada = 0;
                Sistema.saida = 0;
                Sistema.saidaTemp = 0;
                Sistema.saidaOld = 0;
                Sistema.saidaOldOld = 0;

                Input = 0;
                Output = 0;

                return;
            }


            else if (input.Count(f => (f == '/')) == 0)
            {
                try
                {
                    Input = double.Parse(input);
                    Sistema.entrada = Input;
                }
                catch
                {

                }
            }
        }

    }
}
