namespace LP3aula005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tipo: " + txtTipo.Text + "\nNome:" + txtNome.Text);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void lblTipo_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTipo.Text = null;
            txtNome.Text = null;
        }
    }
}