namespace gestion_reservation_vol.forms
{
    partial class frm_nv_passager
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_pass_cin = new System.Windows.Forms.TextBox();
            this.txt_pass_nom = new System.Windows.Forms.TextBox();
            this.txt_pass_email = new System.Windows.Forms.TextBox();
            this.txt_pass_tel = new System.Windows.Forms.TextBox();
            this.txt_pass_adr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_pass_cin
            // 
            this.txt_pass_cin.Location = new System.Drawing.Point(81, 25);
            this.txt_pass_cin.Name = "txt_pass_cin";
            this.txt_pass_cin.Size = new System.Drawing.Size(141, 20);
            this.txt_pass_cin.TabIndex = 0;
            // 
            // txt_pass_nom
            // 
            this.txt_pass_nom.Location = new System.Drawing.Point(81, 77);
            this.txt_pass_nom.Name = "txt_pass_nom";
            this.txt_pass_nom.Size = new System.Drawing.Size(141, 20);
            this.txt_pass_nom.TabIndex = 1;
            // 
            // txt_pass_email
            // 
            this.txt_pass_email.Location = new System.Drawing.Point(81, 132);
            this.txt_pass_email.Name = "txt_pass_email";
            this.txt_pass_email.Size = new System.Drawing.Size(141, 20);
            this.txt_pass_email.TabIndex = 2;
            // 
            // txt_pass_tel
            // 
            this.txt_pass_tel.Location = new System.Drawing.Point(361, 77);
            this.txt_pass_tel.Name = "txt_pass_tel";
            this.txt_pass_tel.Size = new System.Drawing.Size(157, 20);
            this.txt_pass_tel.TabIndex = 3;
            // 
            // txt_pass_adr
            // 
            this.txt_pass_adr.Location = new System.Drawing.Point(361, 25);
            this.txt_pass_adr.Name = "txt_pass_adr";
            this.txt_pass_adr.Size = new System.Drawing.Size(157, 20);
            this.txt_pass_adr.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "nom et prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "telephone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_pass_cin);
            this.groupBox1.Controls.Add(this.txt_pass_nom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_pass_email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_pass_tel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_pass_adr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(86, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 284);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiche Passager";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_nv_passager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 417);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_nv_passager";
            this.Text = "nouveau  passager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pass_cin;
        private System.Windows.Forms.TextBox txt_pass_nom;
        private System.Windows.Forms.TextBox txt_pass_email;
        private System.Windows.Forms.TextBox txt_pass_tel;
        private System.Windows.Forms.TextBox txt_pass_adr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}