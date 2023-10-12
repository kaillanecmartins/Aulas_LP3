namespace CondominioJupiter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void condominioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCondominio cdc = new CadCondominio();
            cdc.MdiParent= this;
            cdc.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            resultado = MessageBox.Show("Deseja mesmo sair?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(resultado == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}