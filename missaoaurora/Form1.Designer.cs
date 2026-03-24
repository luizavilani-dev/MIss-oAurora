namespace missaoaurora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            numPotencia = new NumericUpDown();
            btAceletar = new Button();
            labValue = new Label();
            ((System.ComponentModel.ISupportInitialize)numPotencia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 32);
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
            btAceletar.Location = new Point(308, 238);
            btAceletar.Name = "btAceletar";
            btAceletar.Size = new Size(75, 23);
            btAceletar.TabIndex = 2;
            btAceletar.Text = "&ACELERAR";
            btAceletar.UseVisualStyleBackColor = true;
            btAceletar.Click += btAceletar_Click;
            // 
            // labValue
            // 
            labValue.AutoSize = true;
            labValue.Location = new Point(449, 242);
            labValue.Name = "labValue";
            labValue.Size = new Size(38, 15);
            labValue.TabIndex = 3;
            labValue.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(labValue);
            Controls.Add(btAceletar);
            Controls.Add(numPotencia);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numPotencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numPotencia;
        private Button btAceletar;
        private Label labValue;
    }
}
