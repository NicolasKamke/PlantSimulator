using PlantSimulator.Communication.Rest.Models;
using PlantSimulator_Server;
using System.Linq;
using System.Web.Http;

namespace PlantSimulator.Communication.Rest.Controllers
{
    public class DadosController : ApiController
    {
        private static Dados data = new Dados();        
  
        public string Get(string id)
        {

            MonitoraConexao.ReceiveFlow();

            if (id == "input") return data.Input.ToString();

            if (id == "output") return Sistema.saida.ToString();           

            else return null;
        }


        public void Post(string input)
        {
            MonitoraConexao.SendFlow();

            data.RecebeDados(input);
           
            //data.Output = Sistema.Resposta.MalhaAberta(data.Input);

        }
    }
}
