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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void formGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenerator forma = new FormGenerator();
            forma.MdiParent = this;
            forma.Show();
        }
    }
}
