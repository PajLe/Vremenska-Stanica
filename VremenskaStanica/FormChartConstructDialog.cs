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
    public partial class FormChartConstructDialog : Form
    {
        private IVremenskiParametar param;
        private Form mdiParent;

        public FormChartConstructDialog(IVremenskiParametar param, Form mdiParent)
        {
            this.param = param;
            this.mdiParent = mdiParent;
            InitializeComponent();
            paramLabel.Text = param.Ime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            FormChart fc;
            if (sveVrednostiCheckBox.Checked)
                fc = new FormChart(param);
            else
                fc = new FormChart(param, (int)nNumericUpDown.Value);
            fc.MdiParent = mdiParent;
            this.Close();
            fc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void sveVrednostiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            nNumericUpDown.Enabled = !sveVrednostiCheckBox.Checked;
        }
    }
}
