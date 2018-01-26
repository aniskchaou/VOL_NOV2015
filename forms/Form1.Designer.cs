namespace gestion_reservation_vol
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.passagersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDePassagersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDeVolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationDunVolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passagersToolStripMenuItem,
            this.volToolStripMenuItem,
            this.reservationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // passagersToolStripMenuItem
            // 
            this.passagersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.listeDePassagersToolStripMenuItem});
            this.passagersToolStripMenuItem.Name = "passagersToolStripMenuItem";
            this.passagersToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.passagersToolStripMenuItem.Text = "Passagers";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click_1);
            // 
            // listeDePassagersToolStripMenuItem
            // 
            this.listeDePassagersToolStripMenuItem.Name = "listeDePassagersToolStripMenuItem";
            this.listeDePassagersToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listeDePassagersToolStripMenuItem.Text = "Liste de Passagers";
            // 
            // volToolStripMenuItem
            // 
            this.volToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem1,
            this.listeDeVolToolStripMenuItem});
            this.volToolStripMenuItem.Name = "volToolStripMenuItem";
            this.volToolStripMenuItem.Size = new System.Drawing.Size(33, 20);
            this.volToolStripMenuItem.Text = "Vol";
            // 
            // nouveauToolStripMenuItem1
            // 
            this.nouveauToolStripMenuItem1.Name = "nouveauToolStripMenuItem1";
            this.nouveauToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.nouveauToolStripMenuItem1.Text = "Nouveau";
            // 
            // listeDeVolToolStripMenuItem
            // 
            this.listeDeVolToolStripMenuItem.Name = "listeDeVolToolStripMenuItem";
            this.listeDeVolToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.listeDeVolToolStripMenuItem.Text = "Liste de Vol";
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationDunVolToolStripMenuItem});
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.reservationToolStripMenuItem.Text = "Reservation";
            // 
            // reservationDunVolToolStripMenuItem
            // 
            this.reservationDunVolToolStripMenuItem.Name = "reservationDunVolToolStripMenuItem";
            this.reservationDunVolToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.reservationDunVolToolStripMenuItem.Text = "Reservation d\'un vol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 347);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem passagersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDePassagersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDeVolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationDunVolToolStripMenuItem;
    }
}

