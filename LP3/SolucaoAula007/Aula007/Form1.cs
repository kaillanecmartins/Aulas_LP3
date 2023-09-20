namespace Aula007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O tipo do animal é " + txtTipo.Text + "\nseu nome é " + txtNome.Text + "\ne seu peso é " + txtPeso.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtPeso.Text = "";
            txtTipo.Text = "";
            txtTipo.Focus();
        }

        private void btnEngorda_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            txtPeso.Text = (peso + 1.5).ToString();
        }

        private void btnEmagrace_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            txtPeso.Text = (peso - 0.5).ToString();
        }
    }
}