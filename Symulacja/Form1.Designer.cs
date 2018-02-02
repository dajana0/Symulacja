namespace Symulacja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bramka1 = new System.Windows.Forms.Button();
            this.bramka3 = new System.Windows.Forms.Button();
            this.bramka2 = new System.Windows.Forms.Button();
            this.btNowaGra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbLiczbaGier = new System.Windows.Forms.Label();
            this.lbWygranePierwotnyWybor = new System.Windows.Forms.Label();
            this.lbWygraneZmienionyWybor = new System.Windows.Forms.Label();
            this.lbPrzegranePierwotnyWybor = new System.Windows.Forms.Label();
            this.lbPrzegraneZmienionyWybor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProcent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bramka1
            // 
            this.bramka1.Location = new System.Drawing.Point(12, 12);
            this.bramka1.Name = "bramka1";
            this.bramka1.Size = new System.Drawing.Size(176, 193);
            this.bramka1.TabIndex = 0;
            this.bramka1.Text = "Bramka 1";
            this.bramka1.UseVisualStyleBackColor = true;
            this.bramka1.Click += new System.EventHandler(this.bramka1_Click);
            // 
            // bramka3
            // 
            this.bramka3.Location = new System.Drawing.Point(401, 12);
            this.bramka3.Name = "bramka3";
            this.bramka3.Size = new System.Drawing.Size(176, 193);
            this.bramka3.TabIndex = 1;
            this.bramka3.Text = "Bramka 3";
            this.bramka3.UseVisualStyleBackColor = true;
            this.bramka3.Click += new System.EventHandler(this.bramka3_Click);
            // 
            // bramka2
            // 
            this.bramka2.Location = new System.Drawing.Point(203, 12);
            this.bramka2.Name = "bramka2";
            this.bramka2.Size = new System.Drawing.Size(176, 193);
            this.bramka2.TabIndex = 2;
            this.bramka2.Text = "Bramka 2";
            this.bramka2.UseVisualStyleBackColor = true;
            this.bramka2.Click += new System.EventHandler(this.bramka2_Click);
            // 
            // btNowaGra
            // 
            this.btNowaGra.Location = new System.Drawing.Point(12, 332);
            this.btNowaGra.Name = "btNowaGra";
            this.btNowaGra.Size = new System.Drawing.Size(75, 23);
            this.btNowaGra.TabIndex = 5;
            this.btNowaGra.Text = "Nowa Gra";
            this.btNowaGra.UseVisualStyleBackColor = true;
            this.btNowaGra.Click += new System.EventHandler(this.btNowaGra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Liczba gier: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Wygrane pozostając przy pierwotnym wyborze: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Przegrane pozostając przy pierwotnym wyborze: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Przegrane zmieniając pierwotny wybór:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Wygrane zmieniając pierwotny wybór:";
            // 
            // lbLiczbaGier
            // 
            this.lbLiczbaGier.AutoSize = true;
            this.lbLiczbaGier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLiczbaGier.Location = new System.Drawing.Point(83, 222);
            this.lbLiczbaGier.Name = "lbLiczbaGier";
            this.lbLiczbaGier.Size = new System.Drawing.Size(14, 13);
            this.lbLiczbaGier.TabIndex = 11;
            this.lbLiczbaGier.Text = "0";
            // 
            // lbWygranePierwotnyWybor
            // 
            this.lbWygranePierwotnyWybor.AutoSize = true;
            this.lbWygranePierwotnyWybor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbWygranePierwotnyWybor.Location = new System.Drawing.Point(248, 243);
            this.lbWygranePierwotnyWybor.Name = "lbWygranePierwotnyWybor";
            this.lbWygranePierwotnyWybor.Size = new System.Drawing.Size(14, 13);
            this.lbWygranePierwotnyWybor.TabIndex = 12;
            this.lbWygranePierwotnyWybor.Text = "0";
            // 
            // lbWygraneZmienionyWybor
            // 
            this.lbWygraneZmienionyWybor.AutoSize = true;
            this.lbWygraneZmienionyWybor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbWygraneZmienionyWybor.Location = new System.Drawing.Point(202, 285);
            this.lbWygraneZmienionyWybor.Name = "lbWygraneZmienionyWybor";
            this.lbWygraneZmienionyWybor.Size = new System.Drawing.Size(14, 13);
            this.lbWygraneZmienionyWybor.TabIndex = 13;
            this.lbWygraneZmienionyWybor.Text = "0";
            // 
            // lbPrzegranePierwotnyWybor
            // 
            this.lbPrzegranePierwotnyWybor.AutoSize = true;
            this.lbPrzegranePierwotnyWybor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPrzegranePierwotnyWybor.Location = new System.Drawing.Point(248, 265);
            this.lbPrzegranePierwotnyWybor.Name = "lbPrzegranePierwotnyWybor";
            this.lbPrzegranePierwotnyWybor.Size = new System.Drawing.Size(14, 13);
            this.lbPrzegranePierwotnyWybor.TabIndex = 14;
            this.lbPrzegranePierwotnyWybor.Text = "0";
            // 
            // lbPrzegraneZmienionyWybor
            // 
            this.lbPrzegraneZmienionyWybor.AutoSize = true;
            this.lbPrzegraneZmienionyWybor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPrzegraneZmienionyWybor.Location = new System.Drawing.Point(202, 307);
            this.lbPrzegraneZmienionyWybor.Name = "lbPrzegraneZmienionyWybor";
            this.lbPrzegraneZmienionyWybor.Size = new System.Drawing.Size(14, 13);
            this.lbPrzegraneZmienionyWybor.TabIndex = 15;
            this.lbPrzegraneZmienionyWybor.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Procent wygranych gier zmieniajac wybór";
            // 
            // lbProcent
            // 
            this.lbProcent.AutoSize = true;
            this.lbProcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbProcent.Location = new System.Drawing.Point(369, 247);
            this.lbProcent.Name = "lbProcent";
            this.lbProcent.Size = new System.Drawing.Size(65, 37);
            this.lbProcent.TabIndex = 17;
            this.lbProcent.Text = "0%";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(589, 370);
            this.Controls.Add(this.lbProcent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPrzegraneZmienionyWybor);
            this.Controls.Add(this.lbPrzegranePierwotnyWybor);
            this.Controls.Add(this.lbWygraneZmienionyWybor);
            this.Controls.Add(this.lbWygranePierwotnyWybor);
            this.Controls.Add(this.lbLiczbaGier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btNowaGra);
            this.Controls.Add(this.bramka2);
            this.Controls.Add(this.bramka3);
            this.Controls.Add(this.bramka1);
            this.Name = "Form1";
            this.Text = "Symulacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbKomenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bramka1;
        private System.Windows.Forms.Button bramka3;
        private System.Windows.Forms.Button bramka2;
        private System.Windows.Forms.Button btNowaGra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbLiczbaGier;
        private System.Windows.Forms.Label lbWygranePierwotnyWybor;
        private System.Windows.Forms.Label lbWygraneZmienionyWybor;
        private System.Windows.Forms.Label lbPrzegranePierwotnyWybor;
        private System.Windows.Forms.Label lbPrzegraneZmienionyWybor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbProcent;
    }
}

