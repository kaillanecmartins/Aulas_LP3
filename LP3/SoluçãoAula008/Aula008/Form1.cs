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
            string fruta = cmbFrutas.Text;
            MessageBox.Show("A fruta escolhida foi " + fruta);
        }
    }
}