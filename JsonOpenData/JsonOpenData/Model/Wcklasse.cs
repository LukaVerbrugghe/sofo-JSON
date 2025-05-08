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

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public int AantalToiletten
        {
            get { return _aantalToiletten; }
            set { _aantalToiletten = value; }
        }

        public int AantalUrinoirs
        {
            get { return _aantalUrinoirs; }
            set { _aantalUrinoirs = value; }
        }

        public override string ToString()
        {
            return this.Adres + " - Aantal toiletten: " + this.AantalToiletten + " - Aantal urinoirs: " + this.AantalUrinoirs;
        }
    }
}
