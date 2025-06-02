using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.IO;

namespace prjJsonExtraOef.Model
{
    public class leerlingenklasse
    {
        private string _naam;
        private string _geboortedatum;
        private string _klas;
        private string _email;
        
        private List<leerlingenklasse> _listLeerlingen;

        public string Naam {  get; set; }
        public string Geboortedatum { get; set; }
        public string Klas { get; set; }
        public string Email { get; set; }

        public List<leerlingenklasse> ListLeerlingen { get
            {
                string json = File.ReadAllText("leerlingen.json");
                _listLeerlingen = JsonConvert.DeserializeObject<List<leerlingenklasse>>(json);
                return _listLeerlingen;
            }
            set
            {
                _listLeerlingen = value;
            }
        }

        public override string ToString()
        {
            return this.Naam + " - " + this.Klas + " - " + this.Email + " - " + this.Geboortedatum;
        }
    }
}
