using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace PlantSimulator.Communication.Rest.App_Start
{
    public class WebApiConfig
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure Web API for self-host
            var config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            app.UseWebApi(config);

        }


    }
}
