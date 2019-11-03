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
        private Timer timer = new Timer();
        

        public FormGenerator()
        {
            InitializeComponent();
            inicijalizacijaRecnika();
            inicijalizacijaTextBoxova();
            timer.Tick += new EventHandler(proslediButton_Click);
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
            if (string.IsNullOrEmpty(tb.Text) && !cbIgnorisiGranice.Checked)
                ep.SetError(tb, "Parametar " + textBoxToStandard[tb].Ime + " ne sme biti prazan!");
            else
            {
                double vrednost;
                if (double.TryParse(tb.Text, out vrednost))
                {
                    bool changed = false;
                    if (vrednost > textBoxToStandard[tb].MaxStandard)
                    {
                        vrednost = textBoxToStandard[tb].MaxStandard;
                        changed = true;
                    }
                    else if (vrednost < textBoxToStandard[tb].MinStandard)
                    {
                        vrednost = textBoxToStandard[tb].MinStandard;
                        changed = true;
                    }
                    tb.Text = vrednost.ToString();
                    if (changed && cbIgnorisiGranice.Checked)
                        tb.Text = "";
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

        private void proslediButton_Click(object sender, EventArgs e)
        {
            Dictionary<IVremenskiParametar, double> zaProslediti = new Dictionary<IVremenskiParametar, double>();
            foreach(TextBox vrednostParametra in textBoxToStandard.Keys)
            {
                double vrednost;
                if (double.TryParse(vrednostParametra.Text, out vrednost))
                {
                    zaProslediti.Add(textBoxToStandard[vrednostParametra], vrednost);
                }
            }

            INotifier notifier = this.MdiParent as INotifier;
            if (notifier != null)
            {
                notifier.Notify(zaProslediti, DateTime.Now);
            }
        }

        private void autoGenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoGenCheckBox.Checked)
            {
                if (string.IsNullOrEmpty(autoGenIntervalTextBox.Text))
                {
                    intervalErrorProvider.SetError(autoGenIntervalTextBox, "Unesite interval u sekundama [1-9]");
                    autoGenCheckBox.Checked = false;
                } else 
                {
                    int vrednostIntervala;
                    if (int.TryParse(autoGenIntervalTextBox.Text, out vrednostIntervala))
                    {
                        if (vrednostIntervala > 9)
                            vrednostIntervala = 9;
                        else if (vrednostIntervala < 1)
                            vrednostIntervala = 1;    
                        
                        proslediButton.Enabled = false;
                        autoGenIntervalTextBox.Text = vrednostIntervala.ToString();
                        autoGenIntervalTextBox.Enabled = false;
                        
                        timer.Interval = vrednostIntervala * 1000;
                        timer.Start();
                    } else
                    {
                        autoGenIntervalTextBox.Text = "";
                    }
                }
            } else
            {
                proslediButton.Enabled = true;
                timer.Stop();
                autoGenIntervalTextBox.Enabled = true;
            }
        }

        private void autoGenIntervalTextBox_Enter(object sender, EventArgs e)
        {
            intervalErrorProvider.Clear();
        }

        private void autoGenIntervalTextBox_Leave(object sender, EventArgs e)
        {
            if (autoGenCheckBox.Checked)
                autoGenCheckBox.Checked = false;
        }
    }
}
