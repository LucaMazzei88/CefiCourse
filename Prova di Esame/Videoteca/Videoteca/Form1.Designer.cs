namespace Videoteca
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVis = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.txtAtt = new System.Windows.Forms.TextBox();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.txtTit = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVis);
            this.panel1.Controls.Add(this.btnIns);
            this.panel1.Controls.Add(this.txtAtt);
            this.panel1.Controls.Add(this.txtAnno);
            this.panel1.Controls.Add(this.txtTit);
            this.panel1.Controls.Add(this.txtCod);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 196);
            this.panel1.TabIndex = 0;
            // 
            // btnVis
            // 
            this.btnVis.Location = new System.Drawing.Point(107, 167);
            this.btnVis.Name = "btnVis";
            this.btnVis.Size = new System.Drawing.Size(75, 23);
            this.btnVis.TabIndex = 9;
            this.btnVis.Text = "Visualizza";
            this.btnVis.UseVisualStyleBackColor = true;
            this.btnVis.Click += new System.EventHandler(this.btnVis_Click);
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(26, 167);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(75, 23);
            this.btnIns.TabIndex = 8;
            this.btnIns.Text = "Inserisci";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // txtAtt
            // 
            this.txtAtt.Location = new System.Drawing.Point(104, 101);
            this.txtAtt.Multiline = true;
            this.txtAtt.Name = "txtAtt";
            this.txtAtt.Size = new System.Drawing.Size(308, 49);
            this.txtAtt.TabIndex = 7;
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(104, 69);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(308, 20);
            this.txtAnno.TabIndex = 6;
            // 
            // txtTit
            // 
            this.txtTit.Location = new System.Drawing.Point(104, 45);
            this.txtTit.Name = "txtTit";
            this.txtTit.Size = new System.Drawing.Size(308, 20);
            this.txtTit.TabIndex = 5;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(104, 19);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(308, 20);
            this.txtCod.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titolo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 196);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(507, 302);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codice";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titolo";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Anno";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Attori";
            this.columnHeader4.Width = 133;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 498);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(440, 460);
            this.Name = "Form1";
            this.Text = "Videoteca";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAtt;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.TextBox txtTit;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnVis;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

