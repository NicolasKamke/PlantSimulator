using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSimulator.Communication.Rest.App_Start
{
    public static class WebServer
    {
        private static IDisposable _webapp;
        public static bool StatusConnection = false;

        public static bool Start()
        {
            try
            {
                _webapp = WebApp.Start<WebApiConfig>("http://localhost:8080");
                StatusConnection = true;
                return StatusConnection;
            }
            catch
            {
                StatusConnection = false;
                return StatusConnection;
            }
        }

        public static bool Stop()
        {
            try
            {
                _webapp.Dispose();
                StatusConnection = false;
                return !StatusConnection;
            }
            catch
            {
                StatusConnection = true;
                return !StatusConnection;
            }
            
        }

    }
}
