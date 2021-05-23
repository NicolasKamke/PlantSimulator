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
        public double Step { get; set; }
        public double InitialPoint { get; set; }
        public double InitialStepTime { get; set; }

        public Dados() { }

        public void RecebeDados(string input)
        {
            if ((input.Count(f => (f == '/'))) == 1)
            {
                //string[] status = input.Split('/');

                //if (status[1] == "stop")
                //    Sistema.status = false;
                //if (status[1] == "start")
                //    Sistema.status = true;

                Sistema.entradaOldOld = 0;
                Sistema.entradaOld = 0;
              
                Sistema.saidaOld = 0;
                Sistema.saidaOldOld = 0;

                return;
            }


            else if (input.Count(f => (f == '/')) == 0)
            {
                Input = double.Parse(input);
            }
        }

    }
}
