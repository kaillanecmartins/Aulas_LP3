namespace Aula011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void janelaFilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilho filho = new FrmFilho();
            filho.MdiParent= this;
            filho.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string titulo, mensagem;
            titulo = "sair da aplica��o";
            mensagem = "Voc� deseja sair da aplica��o?";
            MessageBoxButtons botao = MessageBoxButtons.YesNo;
            
            DialogResult resultado = MessageBox.Show(mensagem, titulo, botao, MessageBoxIcon.Warning);

            if(resultado == DialogResult.Yes){
                this.Close();
            }
            
        }

        private void relat�rio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorio1 r1 = new FrmRelatorio1();
            r1.MdiParent = this;
            r1.Show();
        }

        private void relat�rio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorio2 r2 = new FrmRelatorio2();
            r2.MdiParent = this;
            r2.Show();
        }

        private void relat�rio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorio3 r3 = new FrmRelatorio3();
            r3.MdiParent = this;
            r3.Show();
        }
    }
}