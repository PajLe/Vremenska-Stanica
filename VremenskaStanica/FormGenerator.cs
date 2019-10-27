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
        private static Temperatura tempStandard;
        private static Vlaznost vlaznostStandard;
        private static Pritisak pritisakStandard;

        public FormGenerator()
        {
            InitializeComponent();
        }

        private void temperaturaStandardSetButton_Click(object sender, EventArgs e)
        {
            DefinicijaStandardaForma forma = new DefinicijaStandardaForma(Temperatura.instance(), temperaturaTextBox);
            forma.ShowDialog();
        }

        private void pritisakStandardSetButton_Click(object sender, EventArgs e)
        {
            DefinicijaStandardaForma forma = new DefinicijaStandardaForma(Pritisak.instance(), pritisakTextBox);
            forma.ShowDialog();
        }

        private void vlaznostStandardSetButton_Click(object sender, EventArgs e)
        {
            DefinicijaStandardaForma forma = new DefinicijaStandardaForma(Vlaznost.instance(), vlaznostTextBox);
            forma.ShowDialog();
        }
    }
}
