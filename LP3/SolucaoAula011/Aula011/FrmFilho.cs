using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula011
{
    public partial class FrmFilho : Form
    {
        public FrmFilho()
        {
            InitializeComponent();
        }

        private void btnAqui_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Either way, i'm good...", "Dive into IVE!");
        }

        private void btnNwjns_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stay in the mirror...", "Payola Girls");
        }

        private void btnSserafinas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anti-ti-ti-ti fragile...", "i'm fearless");
        }
    }
}
