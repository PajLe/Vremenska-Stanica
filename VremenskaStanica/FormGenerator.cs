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
        private Dictionary<IVremenskiParametar, TextBox> standardToTextBox = new Dictionary<IVremenskiParametar, TextBox>();
        private Dictionary<TextBox, IVremenskiParametar> textBoxToStandard = new Dictionary<TextBox, IVremenskiParametar>();

        public FormGenerator()
        {
            InitializeComponent();
            inicijalizacijaRecnika();
            inicijalizacijaTextBoxova();
        }

        private void inicijalizacijaRecnika()
        {
            // std - txtb
            standardToTextBox.Add(Temperatura.instance(), temperaturaTextBox);
            standardToTextBox.Add(Pritisak.instance(), pritisakTextBox);
            standardToTextBox.Add(Vlaznost.instance(), vlaznostTextBox);

            // txtb - std
            textBoxToStandard.Add(temperaturaTextBox, Temperatura.instance());
            textBoxToStandard.Add(pritisakTextBox, Pritisak.instance());
            textBoxToStandard.Add(vlaznostTextBox, Vlaznost.instance());
        }

        private void inicijalizacijaTextBoxova()
        {
            DefinicijaStandardaForma.DefinisanStandardDogadjaj += obradaDogadjajaDefinisanjaStandarda;
            foreach (IVremenskiParametar parametar in standardToTextBox.Keys)
            {
                if (parametar.imaDefinisanStandard())
                {
                    standardToTextBox[parametar].Enabled = true;
                }
            }
        }

        private void obradaDogadjajaDefinisanjaStandarda(IVremenskiParametar param) {
            standardToTextBox[param].Enabled = true;
            standardToTextBox[param].Text = "";
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

        private void temperaturaTextBox_Leave(object sender, EventArgs e)
        {
            validateAndFixTextBox(sender as TextBox, tempErrorProvider);
        }

        private void validateAndFixTextBox(TextBox tb, ErrorProvider ep)
        {
            if (string.IsNullOrEmpty(tb.Text))
                ep.SetError(tb, "Parametar " + textBoxToStandard[tb].Ime + " ne sme biti prazan!");
            else
            {
                double vrednost;
                if (double.TryParse(tb.Text, out vrednost))
                {
                    if (vrednost > textBoxToStandard[tb].MaxStandard)
                        vrednost = textBoxToStandard[tb].MaxStandard;
                    else if (vrednost < textBoxToStandard[tb].MinStandard)
                        vrednost = textBoxToStandard[tb].MinStandard;
                    tb.Text = vrednost.ToString();
                }
                else
                {
                    tb.Text = "";
                    ep.SetError(tb, "Nevalidna vrednost za parametar: " + textBoxToStandard[tb].Ime);
                }
            }
        }

        private void temperaturaTextBox_Enter(object sender, EventArgs e)
        {
            tempErrorProvider.Clear();
        }

        private void pritisakTextBox_Leave(object sender, EventArgs e)
        {
            validateAndFixTextBox(sender as TextBox, pritisakErrorProvider);
        }

        private void pritisakTextBox_Enter(object sender, EventArgs e)
        {
            pritisakErrorProvider.Clear();
        }

        private void vlaznostTextBox_Leave(object sender, EventArgs e)
        {
            validateAndFixTextBox(sender as TextBox, vlaznostErrorProvider);
        }

        private void vlaznostTextBox_Enter(object sender, EventArgs e)
        {
            vlaznostErrorProvider.Clear();
        }
    }
}
