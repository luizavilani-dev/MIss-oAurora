using System;
using System.Windows.Forms;

namespace missaoaurora
{
    public partial class Form1 : Form
    {
        int velocidadeTotal = 0;
        int oxigenio = 100;

        public Form1()
        {
            InitializeComponent();

            // Inicialização velocidade
            labValue.Text = "Velocidade: " + velocidadeTotal;

            // Inicialização oxigênio
            trackOxigenio.Minimum = 0;
            trackOxigenio.Maximum = 100;
            labPorcentagem.Text = "Oxigenio: " + oxigenio + "%";
        }

        private void numPotencia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btAceletar_Click(object sender, EventArgs e)
        {
            velocidadeTotal += (int)numPotencia.Value;
            labValue.Text = "Velocidade: " + velocidadeTotal;
        }

        private void trackOxigenio_Scroll(object sender, EventArgs e)
        {
            oxigenio = trackOxigenio.Maximum - trackOxigenio.Value;
            labPorcentagem.Text = "Oxigenio: " + oxigenio + "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(velocidadeTotal > 100 || oxigenio < 20)
            {
                MessageBox.Show("A nave explodiu!");
            }
            else
            {
                MessageBox.Show("Pouso bem-sucedido na base Aurora!");
            }
        }
    }
}