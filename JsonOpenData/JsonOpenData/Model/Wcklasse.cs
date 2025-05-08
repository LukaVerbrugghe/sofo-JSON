using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

using System.Net.Http;

namespace JsonOpenData
{
    public class Wcklasse
    {
        private string _adres;
        private int _aantalToiletten;
        private int _aantalUrinoirs;
        private List<Wcklasse> _listWcs;

        public string adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public int toiletten
        {
            get { return _aantalToiletten; }
            set { _aantalToiletten = value; }
        }

        public int urinoirs
        {
            get { return _aantalUrinoirs; }
            set { _aantalUrinoirs = value; }
        }

        public List<Wcklasse> ListWcs
        {
            get
            {
                string json = File.ReadAllText("wcklasse.json");
                _listWcs = JsonConvert.DeserializeObject<List<Wcklasse>>(json);
                return _listWcs;
            }
            set
            {
                _listWcs = value;
            }
        }

        public override string ToString()
        {
            return this.adres + " - Aantal toiletten: " + this.toiletten + " - Aantal urinoirs: " + this.urinoirs;
        }
    }
}
