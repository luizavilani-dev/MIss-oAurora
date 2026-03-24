namespace missaoaurora
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
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
=======
        int oxigenio = 100;
        public Form1()
        {
            InitializeComponent();
            trackOxigenio.Minimum = 0;
            trackOxigenio.Maximum = 100;
            labPorcentagem.Text = "Oxigenio é %" + oxigenio;
        }

        private void trackOxigenio_Scroll(object sender, EventArgs e)
        {
            oxigenio = trackOxigenio.Maximum - trackOxigenio.Value;

            labPorcentagem.Text = "Oxigenio é %" + oxigenio;
>>>>>>> origin/dev-suporte
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
        }

        private void labValue_Click(object sender, EventArgs e)
        {
=======
>>>>>>> origin/dev-suporte

        }
    }
}
