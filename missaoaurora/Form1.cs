namespace missaoaurora
{
    public partial class Form1 : Form
    {
        int velocidadeTotal = 0;
        public Form1()
        {
            InitializeComponent();
            labValue.Text = "Velocidade: " + velocidadeTotal;

        }

        private void numPotencia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btAceletar_Click(object sender, EventArgs e)
        {
            velocidadeTotal += (int)numPotencia.Value;

            labValue.Text = "Velocidade: " + velocidadeTotal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void labValue_Click(object sender, EventArgs e)
        {

        }
    }
}
