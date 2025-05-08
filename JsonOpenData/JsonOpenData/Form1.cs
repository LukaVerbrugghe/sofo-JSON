using JsonOpenData.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace JsonOpenData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInlezenData_Click(object sender, EventArgs e)
        {
            //bij klikken op knip inlezen data
            //de gegevens komen van de json file en worden in de listbox geplaatst

            //object maken van de klasse schoolklasse
            Schoolklasse schoolklasse = new Schoolklasse();

            //itereren om alle scholen te overlopen
            foreach (Schoolklasse s in schoolklasse.ListScholen)
            {
                lsbScholen.Items.Add(s);
            }
        }

        private async void btnInladenDataToiletten_Click(object sender, EventArgs e)
        {
            wcservice service = new wcservice();
            List<Wcklasse> wcLijst = await service.GetListWcsAsync();

            lsbToilettenGent.Items.Clear();

            foreach(Wcklasse w in wcLijst)
            {
                lsbToilettenGent.Items.Add(w.ToString());
            }
        }
    }
}
