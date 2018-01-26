namespace gestion_reservation_vol.forms
{
    partial class frm_liste_vol
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_arrivee = new System.Windows.Forms.DateTimePicker();
            this.dateç_depart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.heire_arrive = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_destination = new System.Windows.Forms.TextBox();
            this.heure_depart = new System.Windows.Forms.TextBox();
            this.txt_numvol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rech_vol = new System.Windows.Forms.TextBox();
            this.ok_bt = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(94, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 188);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "liste des passagers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.click_cell);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.click_datacell);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ok_bt);
            this.groupBox1.Controls.Add(this.txt_rech_vol);
            this.groupBox1.Controls.Add(this.date_arrivee);
            this.groupBox1.Controls.Add(this.dateç_depart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.heire_arrive);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_destination);
            this.groupBox1.Controls.Add(this.heure_depart);
            this.groupBox1.Controls.Add(this.txt_numvol);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 187);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "fiche passager";
            // 
            // date_arrivee
            // 
            this.date_arrivee.Location = new System.Drawing.Point(377, 69);
            this.date_arrivee.Name = "date_arrivee";
            this.date_arrivee.Size = new System.Drawing.Size(200, 20);
            this.date_arrivee.TabIndex = 15;
            this.date_arrivee.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateç_depart
            // 
            this.dateç_depart.Location = new System.Drawing.Point(102, 69);
            this.dateç_depart.Name = "dateç_depart";
            this.dateç_depart.Size = new System.Drawing.Size(200, 20);
            this.dateç_depart.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "heure arrive";
            // 
            // heire_arrive
            // 
            this.heire_arrive.Location = new System.Drawing.Point(347, 110);
            this.heire_arrive.Name = "heire_arrive";
            this.heire_arrive.Size = new System.Drawing.Size(100, 20);
            this.heire_arrive.TabIndex = 12;
            this.heire_arrive.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(447, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "modifier";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "rechercher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_destination
            // 
            this.txt_destination.Location = new System.Drawing.Point(347, 26);
            this.txt_destination.Name = "txt_destination";
            this.txt_destination.Size = new System.Drawing.Size(100, 20);
            this.txt_destination.TabIndex = 7;
            // 
            // heure_depart
            // 
            this.heure_depart.Location = new System.Drawing.Point(109, 106);
            this.heure_depart.Name = "heure_depart";
            this.heure_depart.Size = new System.Drawing.Size(100, 20);
            this.heure_depart.TabIndex = 6;
            this.heure_depart.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_numvol
            // 
            this.txt_numvol.Location = new System.Drawing.Point(109, 30);
            this.txt_numvol.Name = "txt_numvol";
            this.txt_numvol.Size = new System.Drawing.Size(100, 20);
            this.txt_numvol.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "date depart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "heure_depart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "date arrive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "destinatiion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "numero";
            // 
            // txt_rech_vol
            // 
            this.txt_rech_vol.Location = new System.Drawing.Point(38, 141);
            this.txt_rech_vol.Name = "txt_rech_vol";
            this.txt_rech_vol.Size = new System.Drawing.Size(143, 20);
            this.txt_rech_vol.TabIndex = 16;
            this.txt_rech_vol.Visible = false;
            // 
            // ok_bt
            // 
            this.ok_bt.Location = new System.Drawing.Point(201, 137);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(30, 23);
            this.ok_bt.TabIndex = 17;
            this.ok_bt.Text = "ok";
            this.ok_bt.UseVisualStyleBackColor = true;
            this.ok_bt.Visible = false;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            // 
            // frm_liste_vol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_liste_vol";
            this.Text = "frm_liste_vol";
            this.Load += new System.EventHandler(this.frm_liste_vol_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_destination;
        private System.Windows.Forms.TextBox heure_depart;
        private System.Windows.Forms.TextBox txt_numvol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date_arrivee;
        private System.Windows.Forms.DateTimePicker dateç_depart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox heire_arrive;
        private System.Windows.Forms.TextBox txt_rech_vol;
        private System.Windows.Forms.Button ok_bt;

    }
}