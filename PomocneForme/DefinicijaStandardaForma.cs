using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParametarskiStandardi;

namespace PomocneForme
{
    public partial class DefinicijaStandardaForma : Form
    {
        private IVremenskiParametar parametar;
        private TextBox textBoxZaOmoguciti;

        public DefinicijaStandardaForma(IVremenskiParametar param, TextBox odgovarajuciTextBox)
        {
            InitializeComponent();
            paramImeLabel.Text = param.Ime;
            paramImeLabel.Visible = true;
            parametar = param;
            textBoxZaOmoguciti = odgovarajuciTextBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!parametar.postaviStandard((double)minNumericUpDown.Value, (double)maxNumericUpDown.Value))
            {
                MessageBox.Show("Minimalna vrednost ne može biti veća od maksimalne!");
            } else
            {
                textBoxZaOmoguciti.Enabled = true;
                MessageBox.Show("Uspesno ste definisali standard za parametar: " + parametar.Ime);
                this.Close();
            }
            
        }
    }
}
