using PlantSimulator.Communication.Rest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace PlantSimulator.Communication.Rest.Controllers
{
    public class DadosController : ApiController
    {
        private static Dados data = new Dados();

        public string Get(string id)
        {
            if (id == "input") return data.Input;


            if (id == "output") return data.Output;
            else return null;

        }


        public void Post(string input)
        {
            data.Input = input;
            data.Output = input + " 1234";
        }
    }
}
