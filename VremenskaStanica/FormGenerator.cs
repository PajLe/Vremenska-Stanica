using PomocneForme;
using ParametarskiStandardi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VremenskaStanica
{
    public partial class FormGenerator : Form
    {
        private Dictionary<IVremenskiParametar, TextBox> standardi = new Dictionary<IVremenskiParametar, TextBox>();

        public FormGenerator()
        {
            InitializeComponent();
            inicijalizacijaParametara();
            inicijalizacijaTextBoxova();
        }

        private void inicijalizacijaParametara()
        {
            standardi.Add(Temperatura.instance(), temperaturaTextBox);
            standardi.Add(Pritisak.instance(), pritisakTextBox);
            standardi.Add(Vlaznost.instance(), vlaznostTextBox);
        }

        private void inicijalizacijaTextBoxova()
        {
            DefinicijaStandardaForma.DefinisanStandardDogadjaj += obradaDogadjajaDefinisanjaStandarda;
            foreach (IVremenskiParametar parametar in standardi.Keys)
            {
                if (parametar.imaDefinisanStandard())
                {
                    standardi[parametar].Enabled = true;
                }
            }
        }

        private void obradaDogadjajaDefinisanjaStandarda(IVremenskiParametar param) {
            standardi[param].Enabled = true;
        }

        private void temperaturaStandardSetButton_Click(object sender, EventArgs e)
        {
            DefinicijaStandardaForma forma = new DefinicijaStandardaForma(Temperatura.instance());
            forma.ShowDialog();
        }

        private void pritisakStandardSetButton_Click(object sender, EventArgs e)
        {
            DefinicijaStandardaForma forma = new DefinicijaStandardaForma(Pritisak.instance());
            forma.ShowDialog();
        }

        private void vlaznostStandardSetButton_Click(object sender, EventArgs e)
        {
            DefinicijaStandardaForma forma = new DefinicijaStandardaForma(Vlaznost.instance());
            forma.ShowDialog();
        }

        private void FormGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            // event je static, moramo da vodimo racuna o odjavljivanju funkcije kada se forma iskljuci
            DefinicijaStandardaForma.DefinisanStandardDogadjaj -= obradaDogadjajaDefinisanjaStandarda;
        }
    }
}
