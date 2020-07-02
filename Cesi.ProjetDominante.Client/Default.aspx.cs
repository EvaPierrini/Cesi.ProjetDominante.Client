using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Cesi.ProjetDominante.Client
{

    public partial class Default: System.Web.UI.Page
    {
        private const string URL = "https://localhost:5001/api/ping";
        private string urlParameters = "?api_key=123";

        public void button1Clicked(object sender, EventArgs e)
        {
            string tokenApp = "123abc";

            string username = UserName.Text;
            string password = Password.Text;

            button1.Text = button1.Text = APICall().Result;

      
        }

        public async Task<string> APICall()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = await client.GetAsync(URL);  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                //// Parse the response body.
                //var response = response;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                var t = await response.Content.ReadAsStringAsync();
                return "true";

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return "false";
            }

            //Make any other calls using HttpClient here.

            //Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();

            return "";

        }

    }
}
