using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KlicWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }

        private static async Task RunAsync()
        {
            using (var klient=new HttpClient())
            {
                klient.BaseAddress = new Uri("http://localhost:23102/");
                klient.DefaultRequestHeaders.Accept.Clear();
                klient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("aplication/json"));
                await klient.GetAsync("api/Products");
                HttpResponseMessage odg = await klient.GetAsync("api/Products/1");
                if (odg.IsSuccessStatusCode)
                {
                    Products p = await odg.Content.ReadAsAsync<Products>();
                    Console.WriteLine(p.Ime + " " + p.Cena);
                }
            }
        }
    }
}
