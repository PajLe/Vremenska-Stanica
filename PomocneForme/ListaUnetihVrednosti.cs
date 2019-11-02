using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomocneForme
{
    public partial class ListaUnetihVrednosti : Form
    {

        public ListaUnetihVrednosti(Queue<string> entries, string paramIme)
        {
            InitializeComponent();
            vParametarLab.Text = paramIme;
            vParametarListBox.Items.AddRange(entries.ToArray());
        }

    }
}
