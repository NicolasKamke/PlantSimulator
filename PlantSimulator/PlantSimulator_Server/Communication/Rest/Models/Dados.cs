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
            if ((input.Count(f => (f == '/'))) == 2)
            {
                string[] receive = input.Split('/');

                Step = double.Parse(receive[0]);
                InitialPoint = double.Parse(receive[1]);
                InitialStepTime = double.Parse(receive[2]);

                Sistema.step = Step;
                Sistema.initialPoint = InitialPoint;
                Sistema.initialStepTime = InitialStepTime;

                return;
            }


            else if (input.Count(f => (f == '/')) == 1)
            {
                string[] receive = input.Split('/');

                Input = double.Parse(receive[0]);
                Step = double.Parse(receive[1]);

            }
        }

    }
}
