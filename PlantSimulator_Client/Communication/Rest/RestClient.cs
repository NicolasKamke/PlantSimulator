using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PlantSimulator.Communication.Rest
{
    public static class RestClient
    {
        public static string portaURL;

        #region GetAll     

        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(portaURL + "/api/"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();

                        if (data != null) return data;
                    }
                }
            }

            return string.Empty;
        }
        #endregion

        #region Get especificated ID
        public static async Task<string> Get(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(portaURL + "/api/Dados/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();

                        if (data != null) return data.Replace("\"", "");
                    }
                }
            }

            return string.Empty;
        }
        #endregion

        #region Post
        public static async Task<string> Post(string inputData)
        {
            var dict = new Dictionary<string, string>{
                {"",""}
            };

            var input = new FormUrlEncodedContent(dict);

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(portaURL + "/api/Dados?input=" + inputData, input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();

                        if (data != null) return data;
                    }
                }
            }

            return string.Empty;
        }


        #endregion
    }
}
