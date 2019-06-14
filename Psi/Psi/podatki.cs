using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Psi
{

    public class Podatki
    {
        public string status { get; set; }
        public string[] message { get; set; }
    }
    public class Slika
    {
        public string Pot { get; set; }
    }
    public class Klic
    {
        public static async Task NapolniPsi(ObservableCollection<Slika> poti)
        {
            string url = "https://dog.ceo/api/breed/terrier/tibetan/images";
            Podatki p = new Podatki();
            using (var klient = new HttpClient())
            {
                HttpResponseMessage sp = await klient.GetAsync(url);
                p = await sp.Content.ReadAsAsync<Podatki>();
            }
            int k = 0;
            foreach(string x in p.message)
            {
                Slika s = new Slika();
                s.Pot = x;
                poti.Add(s);
                k++;
                if (k > 0) break;
            }
        }
    }

}
