using CondominioJupiter.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondominioJupiter
{
    public partial class CadCondominio : Form
    {
        public CadCondominio()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCep.Text = txtEndereco.Text = txtNome.Text = txtNumero.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           Condominio condominio = new Condominio(txtNome.Text, txtCep.Text, txtEndereco.Text, Convert.ToInt32(txtNumero.Text));
           MessageBox.Show(condominio.ToString());
        }
    }
}
