namespace ProjetoCondominioJupiter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void petToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadPets frmCadPets = new FrmCadPets();
            frmCadPets.MdiParent = this;
            frmCadPets.Show();
        }
    }
}