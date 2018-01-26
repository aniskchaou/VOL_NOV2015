namespace gestion_reservation_vol.forms
{
    partial class frm_nv_vol
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_num_vol = new System.Windows.Forms.TextBox();
            this.txt_dest_vol = new System.Windows.Forms.TextBox();
            this.date_dep = new System.Windows.Forms.DateTimePicker();
            this.date_arr = new System.Windows.Forms.DateTimePicker();
            this.txt_heure_arr = new System.Windows.Forms.TextBox();
            this.txt_heure_dep = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "date depart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "heure depart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "heure arrive";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "date arrive";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "destination";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_heure_dep);
            this.groupBox1.Controls.Add(this.txt_heure_arr);
            this.groupBox1.Controls.Add(this.date_arr);
            this.groupBox1.Controls.Add(this.date_dep);
            this.groupBox1.Controls.Add(this.txt_dest_vol);
            this.groupBox1.Controls.Add(this.txt_num_vol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(91, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 356);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txt_num_vol
            // 
            this.txt_num_vol.Location = new System.Drawing.Point(105, 70);
            this.txt_num_vol.Name = "txt_num_vol";
            this.txt_num_vol.Size = new System.Drawing.Size(100, 20);
            this.txt_num_vol.TabIndex = 6;
            // 
            // txt_dest_vol
            // 
            this.txt_dest_vol.Location = new System.Drawing.Point(413, 70);
            this.txt_dest_vol.Name = "txt_dest_vol";
            this.txt_dest_vol.Size = new System.Drawing.Size(100, 20);
            this.txt_dest_vol.TabIndex = 7;
            // 
            // date_dep
            // 
            this.date_dep.Location = new System.Drawing.Point(105, 115);
            this.date_dep.Name = "date_dep";
            this.date_dep.Size = new System.Drawing.Size(200, 20);
            this.date_dep.TabIndex = 8;
            this.date_dep.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // date_arr
            // 
            this.date_arr.Location = new System.Drawing.Point(413, 115);
            this.date_arr.Name = "date_arr";
            this.date_arr.Size = new System.Drawing.Size(200, 20);
            this.date_arr.TabIndex = 9;
            this.date_arr.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txt_heure_arr
            // 
            this.txt_heure_arr.Location = new System.Drawing.Point(417, 168);
            this.txt_heure_arr.Name = "txt_heure_arr";
            this.txt_heure_arr.Size = new System.Drawing.Size(100, 20);
            this.txt_heure_arr.TabIndex = 10;
            // 
            // txt_heure_dep
            // 
            this.txt_heure_dep.Location = new System.Drawing.Point(105, 168);
            this.txt_heure_dep.Name = "txt_heure_dep";
            this.txt_heure_dep.Size = new System.Drawing.Size(100, 20);
            this.txt_heure_dep.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "quitter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frm_nv_vol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 423);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_nv_vol";
            this.Text = "frm_nv_vol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_dest_vol;
        private System.Windows.Forms.TextBox txt_num_vol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_heure_dep;
        private System.Windows.Forms.TextBox txt_heure_arr;
        private System.Windows.Forms.DateTimePicker date_arr;
        private System.Windows.Forms.DateTimePicker date_dep;
    }
}