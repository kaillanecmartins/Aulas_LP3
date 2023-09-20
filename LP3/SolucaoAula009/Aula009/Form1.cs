namespace Aula009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string salgado = cmbSalgados.Text;
            string modoPreparo, acompanhamentos = "";

            if (rdbFrito.Checked)
            {
                modoPreparo = "Frito";
            }
            else
            {
                modoPreparo = "Assado";
            }

            if (ckbRefrigerante.Checked)
            {
                acompanhamentos = "Refrigerante ";
            }
            if (ckbSuco.Checked)
            {
                acompanhamentos += "Suco ";
            }
            if (ckbChocolate.Checked)
            {
                acompanhamentos += "Chocolate";
            }
            MessageBox.Show("Nome do salgado:" + salgado + "\nModo de preparo: " + modoPreparo + "\nAcompanhamentos: " + acompanhamentos);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}