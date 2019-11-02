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
using System.Windows.Forms.DataVisualization.Charting;

namespace VremenskaStanica
{
    public partial class FormChart : Form, IUpdatable
    {
        private int N;
        private string paramIme;

        public FormChart(IVremenskiParametar param, int N)
        {
            this.paramIme = param.Ime;
            this.N = N;
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
                    if (N != 0 && jedanParametarChart.Series[0].Points.Count == N)
                        jedanParametarChart.Series[0].Points.RemoveAt(0);
                    if (N != 0 && jedanParametarChart.Series[1].Points.Count == N)
                        jedanParametarChart.Series[1].Points.RemoveAt(0);

                    double vr = vrednostiVremenskihParametara[vParam];
                    jedanParametarChart.Series[0].Points.AddY(vr); // linear series[0]
                    if (vr >= 0.0)
                        jedanParametarChart.Series[1].Points.AddY(vr); // logarithmic series[1]

                    jedanParametarChart.ChartAreas[0].RecalculateAxesScale();
                    jedanParametarChart.ChartAreas[1].RecalculateAxesScale();
                    break; // parametri unutar recnika su jedinstveni, ne moramo da trazimo dalje
                }
            }
        }
    }
}
