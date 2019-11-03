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

namespace VremenskaStanica
{
    public partial class FormStatisticalData : Form, IUpdatable
    {
        private Dictionary<IVremenskiParametar, TextBox> paramToTextBox;
        private Dictionary<IVremenskiParametar, List<double>> paramToValues; // custom data struct za O(1)
        private Dictionary<IVremenskiParametar, Label> paramToLabel;

        public FormStatisticalData()
        {
            paramToTextBox = new Dictionary<IVremenskiParametar, TextBox>();
            paramToValues = new Dictionary<IVremenskiParametar, List<double>>();
            paramToLabel = new Dictionary<IVremenskiParametar, Label>();
            InitializeComponent();
            inicijalizacijaRecnika();
        }

        private void inicijalizacijaRecnika()
        {
            // param - txtb
            paramToTextBox.Add(Temperatura.instance(), temperaturaTextBox);
            paramToTextBox.Add(Pritisak.instance(), pritisakTextBox);
            paramToTextBox.Add(Vlaznost.instance(), vlaznostTextBox);

            // param - values
            paramToValues.Add(Temperatura.instance(), new List<double>());
            paramToValues.Add(Pritisak.instance(), new List<double>());
            paramToValues.Add(Vlaznost.instance(), new List<double>());

            // param - label
            paramToLabel.Add(Temperatura.instance(), temperaturaLabel);
            paramToLabel.Add(Pritisak.instance(), pritisakLabel);
            paramToLabel.Add(Vlaznost.instance(), vlaznostLabel);
        }

        public void Update(Dictionary<IVremenskiParametar, double> vrednostiVremenskihParametara, DateTime vremeSlanja)
        {
            foreach(IVremenskiParametar vParam in vrednostiVremenskihParametara.Keys)
            {
                handleBrojVrednosti(vParam);

                paramToTextBox[vParam].Text = vrednostiVremenskihParametara[vParam].ToString();
                paramToValues[vParam].Add(vrednostiVremenskihParametara[vParam]);

                string minMaxAvg = "avg: " + string.Format("{0:f2}", paramToValues[vParam].Average()) + ", min: " + paramToValues[vParam].Min() + ", max: " + paramToValues[vParam].Max();
                paramToLabel[vParam].Text = minMaxAvg;
            }
        }

        private void handleBrojVrednosti(IVremenskiParametar vParam)
        {
            if (uradiStatCheckBox.Checked)
            {
                int brVr;
                if (int.TryParse(brojVrednostiTextBox.Text, out brVr))
                {
                    while (paramToValues[vParam].Count >= brVr)
                    {
                        paramToValues[vParam].RemoveAt(0);
                    }
                }
            }
        }

        private void uradiStatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (uradiStatCheckBox.Checked)
            {
                if (string.IsNullOrEmpty(brojVrednostiTextBox.Text))
                {
                    brVrednostiErrorProvider.SetError(brojVrednostiTextBox, "Unesi broj vrednosti");
                    uradiStatCheckBox.Checked = false;
                }
            }
        }


        private void brojVrednostiTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            int brVrednosti;
            if (int.TryParse(brojVrednostiTextBox.Text, out brVrednosti))
            {
                if (brVrednosti < 1)
                    brVrednosti = 1;
                brojVrednostiTextBox.Text = brVrednosti.ToString();
                brVrednostiErrorProvider.Clear();
            }
            else
                brojVrednostiTextBox.Text = "";
        }
    }
}
