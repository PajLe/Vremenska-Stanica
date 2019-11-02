using ParametarskiStandardi;
using PomocneForme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VremenskaStanica
{
    public partial class FormChart : Form, IUpdatable
    {
        private int N;
        private string paramIme;
        private Queue<string> entries;

        public FormChart(IVremenskiParametar param, int N)
        {
            this.paramIme = param.Ime;
            this.N = N;
            this.entries = new Queue<string>();

            InitializeComponent();

            jedanParametarChart.Series[0].Name = paramIme;
            jedanParametarChart.Series[1].Name = paramIme + " (log)";
        }

        public FormChart(IVremenskiParametar param)
            : this(param, 0)
        {
            
        }

        public void Update(Dictionary<IVremenskiParametar, double> vrednostiVremenskihParametara, DateTime vremeSlanja)
        {
            foreach (IVremenskiParametar vParam in vrednostiVremenskihParametara.Keys)
            {
                if (vParam.Ime.Equals(paramIme)) {
                    if (N != 0 && jedanParametarChart.Series[0].Points.Count == N) // linear
                    {
                        jedanParametarChart.Series[0].Points.RemoveAt(0);
                        entries.Dequeue();
                    }
                        
                    if (N != 0 && jedanParametarChart.Series[1].Points.Count == N) // logarithmic
                        jedanParametarChart.Series[1].Points.RemoveAt(0);

                    double vr = vrednostiVremenskihParametara[vParam];
                    jedanParametarChart.Series[0].Points.AddY(vr); // linear series[0]
                    if (vr >= 0.0)
                        jedanParametarChart.Series[1].Points.AddY(vr); // logarithmic series[1]

                    jedanParametarChart.ChartAreas[0].RecalculateAxesScale();
                    jedanParametarChart.ChartAreas[1].RecalculateAxesScale();
                    this.Text = vr.ToString();
                    entries.Enqueue(paramIme + " - " + vr + "   " + vremeSlanja.ToString());
                    break; // parametri unutar recnika su jedinstveni, ne moramo da trazimo dalje
                }
            }
        }

        private void jedanParametarChart_Click(object sender, EventArgs e)
        {
            ListaUnetihVrednosti lista = new ListaUnetihVrednosti(entries, paramIme);
            lista.Show();
        }
    }
}
