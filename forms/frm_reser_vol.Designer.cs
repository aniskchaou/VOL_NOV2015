namespace gestion_reservation_vol.forms
{
    partial class frm_reser_vol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_res = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.heure_arr = new System.Windows.Forms.TextBox();
            this.heure_dep = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.combo_vol = new System.Windows.Forms.ComboBox();
            this.date_dep = new System.Windows.Forms.DateTimePicker();
            this.sate_arr = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_adr = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.combo_pass = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.date_res);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information reservation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // date_res
            // 
            this.date_res.Location = new System.Drawing.Point(252, 38);
            this.date_res.Name = "date_res";
            this.date_res.Size = new System.Drawing.Size(200, 20);
            this.date_res.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sate_arr);
            this.groupBox2.Controls.Add(this.date_dep);
            this.groupBox2.Controls.Add(this.combo_vol);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.heure_dep);
            this.groupBox2.Controls.Add(this.heure_arr);
            this.groupBox2.Controls.Add(this.txt_des);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(18, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 294);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "information vol";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combo_pass);
            this.groupBox3.Controls.Add(this.txt_tel);
            this.groupBox3.Controls.Add(this.txt_nom);
            this.groupBox3.Controls.Add(this.txt_email);
            this.groupBox3.Controls.Add(this.txt_adr);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(362, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 294);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "information passager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "date arrive";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "date depart";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "heure arrive";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "heure depart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "nom compagnie";
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(95, 84);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(100, 20);
            this.txt_des.TabIndex = 7;
            // 
            // heure_arr
            // 
            this.heure_arr.Location = new System.Drawing.Point(94, 235);
            this.heure_arr.Name = "heure_arr";
            this.heure_arr.Size = new System.Drawing.Size(100, 20);
            this.heure_arr.TabIndex = 8;
            this.heure_arr.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // heure_dep
            // 
            this.heure_dep.Location = new System.Drawing.Point(95, 188);
            this.heure_dep.Name = "heure_dep";
            this.heure_dep.Size = new System.Drawing.Size(100, 20);
            this.heure_dep.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 262);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // combo_vol
            // 
            this.combo_vol.FormattingEnabled = true;
            this.combo_vol.Location = new System.Drawing.Point(94, 27);
            this.combo_vol.Name = "combo_vol";
            this.combo_vol.Size = new System.Drawing.Size(121, 21);
            this.combo_vol.TabIndex = 11;
            this.combo_vol.SelectedIndexChanged += new System.EventHandler(this.combo_vol_SelectedIndexChanged);
            // 
            // date_dep
            // 
            this.date_dep.Location = new System.Drawing.Point(95, 115);
            this.date_dep.Name = "date_dep";
            this.date_dep.Size = new System.Drawing.Size(200, 20);
            this.date_dep.TabIndex = 12;
            // 
            // sate_arr
            // 
            this.sate_arr.Location = new System.Drawing.Point(95, 152);
            this.sate_arr.Name = "sate_arr";
            this.sate_arr.Size = new System.Drawing.Size(200, 20);
            this.sate_arr.TabIndex = 13;
            this.sate_arr.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "adresse";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "cin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "nom&prenom";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "telephone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "confirmer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(92, 112);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 14;
            // 
            // txt_adr
            // 
            this.txt_adr.Location = new System.Drawing.Point(92, 65);
            this.txt_adr.Name = "txt_adr";
            this.txt_adr.Size = new System.Drawing.Size(100, 20);
            this.txt_adr.TabIndex = 15;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(92, 155);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 19;
            this.txt_nom.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(92, 202);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 20;
            this.txt_tel.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // combo_pass
            // 
            this.combo_pass.FormattingEnabled = true;
            this.combo_pass.Location = new System.Drawing.Point(92, 28);
            this.combo_pass.Name = "combo_pass";
            this.combo_pass.Size = new System.Drawing.Size(121, 21);
            this.combo_pass.TabIndex = 14;
            this.combo_pass.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // frm_reser_vol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 480);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_reser_vol";
            this.Text = "frm_reser_vol";
            this.Load += new System.EventHandler(this.frm_reser_vol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker sate_arr;
        private System.Windows.Forms.DateTimePicker date_dep;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox heure_dep;
        private System.Windows.Forms.TextBox heure_arr;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox combo_pass;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_adr;
        public System.Windows.Forms.ComboBox combo_vol;
    }
}