using prjJsonExtraOef.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjJsonExtraOef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inladenLeerlingen();
        }

        private void inladenLeerlingen()
        {
            leerlingenklasse leerlingenklasseobj = new leerlingenklasse();
            foreach(leerlingenklasse l in leerlingenklasseobj.ListLeerlingen)
            {
                lsbLeerlingen.Items.Add(l);
            }
        }
    }
}
