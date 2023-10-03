using Aula010.modelo;

namespace Aula010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtRaca.Text = string.Empty;
            txtCor.Text = string.Empty;
            chkCastrado.Checked = false;
            chkVacinado.Checked = false;
            rdbFemea.Checked = false;
            cmbEspecie.SelectedIndex = -1;
        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string genero, observacoes = "";


            if (rdbFemea.Checked){
                genero = "Fêmea";
            }
            else
            {
                genero = "Macho";
            }

            if (chkCastrado.Checked)
            {
                observacoes = "castrado ";
            }
            if(chkVacinado.Checked)
            {
                observacoes += "vacinado";
            }
                Pet pet = new Pet(txtNome.Text, cmbEspecie.Text, txtRaca.Text, genero, txtCor.Text, observacoes);

            MessageBox.Show("Nome: " + pet.Nome + "\nEspecie: " + pet.Especie + "\nRaça: " + pet.Raca + "\nGenero: " + pet.Genero + 
                "\nCor: " + pet.Cor + "\nObservações: " + pet.Observacoes);
        }
    }
}