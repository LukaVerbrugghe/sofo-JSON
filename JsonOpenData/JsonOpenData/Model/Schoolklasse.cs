using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//json gebruiken
using Newtonsoft.Json;
//dit hebben we ook nodig
using System.IO;

namespace JsonOpenData.Model
{
    //klassse public maken
    public class Schoolklasse
    {
        //!!!!!!!
        //eerst met nuget newtonsoft.json toevoegen (anders gaat het niet werken he sloeber)


        //fields maken om de waarden van de variabelen op te slaan
        //fields beginnen alijtd met een _
        private string _school;
        private string _vestiging;
        private int _aantal;
        //een lijst om al die scholen in te steken
        private List<Schoolklasse> _listScholen;

        //properties
        //de waarden van de properties in onze fields steken
        public string School {  get { return _school; } set { _school = value; } }
        public string Vestiging { get { return _vestiging; } set { _vestiging = value; } }
        public int Aantal { get { return _aantal; } set { _aantal = value; } }
        public List<Schoolklasse> ListScholen
        {
            get
            {
                //waarden uit de json file ophalen
                string josn = File.ReadAllText("Scholen.json");
                _listScholen = JsonConvert.DeserializeObject<List<Schoolklasse>>(josn);
                return _listScholen;
            }
            set
            {
                _listScholen = value;
            }
        }
        //om de gegevens mooi in de listbox te krijgen --> aparte methode maken waarin die geevens zitten
        //override string ToString
        public override string ToString()
        {
            return this.School + " - " + this.Vestiging + " - Aantal lln: " + this.Aantal;
        }
    }
}
