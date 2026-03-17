namespace missaoaurora
{
    public partial class Form1 : Form
    {
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
