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

        public delegate void DefinisanStandardHandler(IVremenskiParametar vParam);
        public static event DefinisanStandardHandler DefinisanStandardDogadjaj;

        public DefinicijaStandardaForma(IVremenskiParametar param)
        {
            InitializeComponent();
            paramImeLabel.Text = param.Ime;
            paramImeLabel.Visible = true;
            parametar = param;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!parametar.postaviStandard((double)minNumericUpDown.Value, (double)maxNumericUpDown.Value))
            {
                MessageBox.Show("Minimalna vrednost ne može biti veća od maksimalne!");
            } else
            {
                MessageBox.Show("Uspesno ste definisali standard za parametar: " + parametar.Ime);
                this.Close();
                DefinisanStandardDogadjaj.Invoke(parametar);
            }
            
        }
    }
}
