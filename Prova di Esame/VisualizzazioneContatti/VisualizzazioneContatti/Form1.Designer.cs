namespace VisualizzazioneContatti
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.btnPrimo = new System.Windows.Forms.Button();
            this.btnPrecedente = new System.Windows.Forms.Button();
            this.btnProssimo = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome e Cognome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Indirizzo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Città";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Età";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(301, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(112, 55);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(301, 20);
            this.txtIndirizzo.TabIndex = 5;
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(112, 81);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(301, 20);
            this.txtCitta.TabIndex = 6;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(112, 112);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(301, 20);
            this.txtEta.TabIndex = 7;
            // 
            // btnPrimo
            // 
            this.btnPrimo.Location = new System.Drawing.Point(16, 204);
            this.btnPrimo.Name = "btnPrimo";
            this.btnPrimo.Size = new System.Drawing.Size(75, 23);
            this.btnPrimo.TabIndex = 8;
            this.btnPrimo.Text = "Primo";
            this.btnPrimo.UseVisualStyleBackColor = true;
            this.btnPrimo.Click += new System.EventHandler(this.btnPrimo_Click);
            // 
            // btnPrecedente
            // 
            this.btnPrecedente.Location = new System.Drawing.Point(97, 204);
            this.btnPrecedente.Name = "btnPrecedente";
            this.btnPrecedente.Size = new System.Drawing.Size(75, 23);
            this.btnPrecedente.TabIndex = 9;
            this.btnPrecedente.Text = "Precedente";
            this.btnPrecedente.UseVisualStyleBackColor = true;
            this.btnPrecedente.Click += new System.EventHandler(this.btnPrecedente_Click);
            // 
            // btnProssimo
            // 
            this.btnProssimo.Location = new System.Drawing.Point(178, 204);
            this.btnProssimo.Name = "btnProssimo";
            this.btnProssimo.Size = new System.Drawing.Size(75, 23);
            this.btnProssimo.TabIndex = 10;
            this.btnProssimo.Text = "Prossimo";
            this.btnProssimo.UseVisualStyleBackColor = true;
            this.btnProssimo.Click += new System.EventHandler(this.btnProssimo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(259, 204);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 23);
            this.btnUltimo.TabIndex = 11;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 256);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnProssimo);
            this.Controls.Add(this.btnPrecedente);
            this.Controls.Add(this.btnPrimo);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.txtIndirizzo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rubrica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Button btnPrimo;
        private System.Windows.Forms.Button btnPrecedente;
        private System.Windows.Forms.Button btnProssimo;
        private System.Windows.Forms.Button btnUltimo;
    }
}

