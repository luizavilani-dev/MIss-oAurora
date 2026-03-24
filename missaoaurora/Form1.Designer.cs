namespace missaoaurora
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            numPotencia = new NumericUpDown();
            btAceletar = new Button();
            labValue = new Label();
            labPorcentagem = new Label();
            trackOxigenio = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)numPotencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackOxigenio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(150, 20);
            label1.Name = "label1";
            label1.Size = new Size(399, 37);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE BORDO-AURORA";
            // 
            // numPotencia
            // 
            numPotencia.Location = new Point(118, 238);
            numPotencia.Name = "numPotencia";
            numPotencia.Size = new Size(120, 23);
            numPotencia.TabIndex = 1;
            numPotencia.ValueChanged += numPotencia_ValueChanged;
            // 
            // btAceletar
            // 
            btAceletar.Location = new Point(260, 238);
            btAceletar.Name = "btAceletar";
            btAceletar.Size = new Size(100, 23);
            btAceletar.TabIndex = 2;
            btAceletar.Text = "ACELERAR";
            btAceletar.UseVisualStyleBackColor = true;
            btAceletar.Click += btAceletar_Click;
            // 
            // labValue
            // 
            labValue.AutoSize = true;
            labValue.Location = new Point(380, 242);
            labValue.Name = "labValue";
            labValue.Size = new Size(76, 15);
            labValue.TabIndex = 3;
            labValue.Text = "Velocidade: 0";
            // 
            // labPorcentagem
            // 
            labPorcentagem.AutoSize = true;
            labPorcentagem.Location = new Point(330, 150);
            labPorcentagem.Name = "labPorcentagem";
            labPorcentagem.Size = new Size(89, 15);
            labPorcentagem.TabIndex = 5;
            labPorcentagem.Text = "Oxigenio: 100%";
            // 
            // trackOxigenio
            // 
            trackOxigenio.Location = new Point(118, 150);
            trackOxigenio.Name = "trackOxigenio";
            trackOxigenio.Size = new Size(200, 45);
            trackOxigenio.TabIndex = 4;
            trackOxigenio.Scroll += trackOxigenio_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(numPotencia);
            Controls.Add(btAceletar);
            Controls.Add(labValue);
            Controls.Add(trackOxigenio);
            Controls.Add(labPorcentagem);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numPotencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackOxigenio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private NumericUpDown numPotencia;
        private Button btAceletar;
        private Label labValue;
        private Label labPorcentagem;
        private TrackBar trackOxigenio;
    }
}