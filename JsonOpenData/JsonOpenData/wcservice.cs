using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JsonOpenData
{
    public class wcservice
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<List<Wcklasse>> GetListWcsAsync()
        {
            string url = "https://data.stad.gent/api/v2/catalog/datasets/publiek-sanitair-gent/";
            string response = await _httpClient.GetStringAsync(url);

            RootObject root = JsonConvert.DeserializeObject<RootObject>(response);

            if (root?.records == null)
            {
                return new List<Wcklasse>(); // of throw een custom error
            }

            return root.records
                .Where(r => r.fields != null)
                .Select(r => new Wcklasse
                {
                    Adres = r.fields.adres,
                    AantalToiletten = r.fields.aantal_toiletten ?? 0,
                    AantalUrinoirs = r.fields.aantal_urinoirs ?? 0
                })
                .ToList();

        }
    }
}
