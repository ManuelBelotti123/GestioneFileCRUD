namespace GestioneFileCRUD
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
            this.aggiungi = new System.Windows.Forms.Button();
            this.cancella = new System.Windows.Forms.Button();
            this.leggi = new System.Windows.Forms.Button();
            this.modifica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.visualizza = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aggiungi
            // 
            this.aggiungi.Location = new System.Drawing.Point(58, 284);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(334, 23);
            this.aggiungi.TabIndex = 0;
            this.aggiungi.Text = "Aggiungi";
            this.aggiungi.UseVisualStyleBackColor = true;
            this.aggiungi.Click += new System.EventHandler(this.aggiungi_Click);
            // 
            // cancella
            // 
            this.cancella.Location = new System.Drawing.Point(58, 313);
            this.cancella.Name = "cancella";
            this.cancella.Size = new System.Drawing.Size(334, 24);
            this.cancella.TabIndex = 1;
            this.cancella.Text = "Cancella";
            this.cancella.UseVisualStyleBackColor = true;
            // 
            // leggi
            // 
            this.leggi.Location = new System.Drawing.Point(58, 343);
            this.leggi.Name = "leggi";
            this.leggi.Size = new System.Drawing.Size(334, 24);
            this.leggi.TabIndex = 2;
            this.leggi.Text = "Leggi";
            this.leggi.UseVisualStyleBackColor = true;
            this.leggi.Click += new System.EventHandler(this.leggi_Click);
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(58, 373);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(334, 22);
            this.modifica.TabIndex = 3;
            this.modifica.Text = "Modifica";
            this.modifica.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "CRUD per la Gestione FIle";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(128, 165);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(190, 20);
            this.nome.TabIndex = 5;
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(128, 229);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(190, 20);
            this.prezzo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome del Prodotto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prezzo del Prodotto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Inserimento Dati del Prodotto";
            // 
            // visualizza
            // 
            this.visualizza.HideSelection = false;
            this.visualizza.Location = new System.Drawing.Point(484, 124);
            this.visualizza.Name = "visualizza";
            this.visualizza.Size = new System.Drawing.Size(269, 271);
            this.visualizza.TabIndex = 10;
            this.visualizza.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(548, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lettura del File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.visualizza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.leggi);
            this.Controls.Add(this.cancella);
            this.Controls.Add(this.aggiungi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.Button cancella;
        private System.Windows.Forms.Button leggi;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView visualizza;
        private System.Windows.Forms.Label label5;
    }
}

