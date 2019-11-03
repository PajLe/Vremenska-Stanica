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
    public partial class MainForm : Form, INotifier
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void Notify(Dictionary<IVremenskiParametar, double> vrednostiVremenskihParametara, DateTime vremeSlanja)
        {
            foreach(Form form in this.MdiChildren)
            {
                IUpdatable client = form as IUpdatable;
                if (client == null)
                    continue;

                client.Update(vrednostiVremenskihParametara, vremeSlanja);
            }
        }

        private void formGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenerator forma = new FormGenerator();
            forma.MdiParent = this;
            forma.Show();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChartConstructDialog fcd = new FormChartConstructDialog(Temperatura.instance(), this);
            fcd.ShowDialog();
        }

        private void vlažnostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChartConstructDialog fcd = new FormChartConstructDialog(Vlaznost.instance(), this);
            fcd.ShowDialog();
        }

        private void pritisakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChartConstructDialog fcd = new FormChartConstructDialog(Pritisak.instance(), this);
            fcd.ShowDialog();
        }

        private void formStatisticalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatisticalData forma = new FormStatisticalData();
            forma.MdiParent = this;
            forma.Show();
        }
    }
}
