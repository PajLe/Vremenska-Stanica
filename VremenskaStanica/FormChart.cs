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
    public partial class FormChart : Form, IUpdatable
    {
        private int N;
        private IVremenskiParametar param;

        public FormChart(IVremenskiParametar param)
        {
            InitializeComponent();
            
        }

        public FormChart(IVremenskiParametar param, int N)
        {
            InitializeComponent();

        }

        public new void Update()
        {
            // handle update for this form
            throw new NotImplementedException();
        }
    }
}
