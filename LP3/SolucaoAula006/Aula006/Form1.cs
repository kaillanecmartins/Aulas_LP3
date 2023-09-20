namespace Aula006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O seu nome é " + txtNome.Text + " e sua idade é " + txtIdade.Text);
        }

        private void btnEnvelhecer_Click(object sender, EventArgs e)
        {
            int idade = 0;
            idade = System.Int32.Parse(txtIdade.Text);

            txtIdade.Text = (idade + 1).ToString();
        }
    }
}