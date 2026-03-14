namespace gestion_fourni
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
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seConnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterproduitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierproduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerproduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterfournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierfournisseurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerfournisseurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passerUneCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulercommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sedeconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.utilisateurToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seConnecterToolStripMenuItem,
            this.quitterToolStripMenuItem,
            this.sedeconnecterToolStripMenuItem});
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // seConnecterToolStripMenuItem
            // 
            this.seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            this.seConnecterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seConnecterToolStripMenuItem.Text = "Se_connecter";
            this.seConnecterToolStripMenuItem.Click += new System.EventHandler(this.seConnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterProduitToolStripMenuItem,
            this.fournisseurToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // ajouterProduitToolStripMenuItem
            // 
            this.ajouterProduitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterproduitToolStripMenuItem1,
            this.modifierproduitToolStripMenuItem,
            this.supprimerproduitToolStripMenuItem});
            this.ajouterProduitToolStripMenuItem.Name = "ajouterProduitToolStripMenuItem";
            this.ajouterProduitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.ajouterProduitToolStripMenuItem.Text = "Produit";
            // 
            // ajouterproduitToolStripMenuItem1
            // 
            this.ajouterproduitToolStripMenuItem1.Name = "ajouterproduitToolStripMenuItem1";
            this.ajouterproduitToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.ajouterproduitToolStripMenuItem1.Text = "Ajouter_produit";
            this.ajouterproduitToolStripMenuItem1.Click += new System.EventHandler(this.ajouterproduitToolStripMenuItem1_Click);
            // 
            // modifierproduitToolStripMenuItem
            // 
            this.modifierproduitToolStripMenuItem.Name = "modifierproduitToolStripMenuItem";
            this.modifierproduitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.modifierproduitToolStripMenuItem.Text = "Modifier_produit";
            this.modifierproduitToolStripMenuItem.Click += new System.EventHandler(this.modifierproduitToolStripMenuItem_Click);
            // 
            // supprimerproduitToolStripMenuItem
            // 
            this.supprimerproduitToolStripMenuItem.Name = "supprimerproduitToolStripMenuItem";
            this.supprimerproduitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.supprimerproduitToolStripMenuItem.Text = "Supprimer_produit";
            this.supprimerproduitToolStripMenuItem.Click += new System.EventHandler(this.supprimerproduitToolStripMenuItem_Click);
            // 
            // fournisseurToolStripMenuItem
            // 
            this.fournisseurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterfournisseurToolStripMenuItem,
            this.modifierfournisseurToolStripMenuItem1,
            this.supprimerfournisseurToolStripMenuItem1});
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.fournisseurToolStripMenuItem.Text = "Fournisseur";
            // 
            // ajouterfournisseurToolStripMenuItem
            // 
            this.ajouterfournisseurToolStripMenuItem.Name = "ajouterfournisseurToolStripMenuItem";
            this.ajouterfournisseurToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ajouterfournisseurToolStripMenuItem.Text = "Ajouter_fournisseur";
            this.ajouterfournisseurToolStripMenuItem.Click += new System.EventHandler(this.ajouterfournisseurToolStripMenuItem_Click);
            // 
            // modifierfournisseurToolStripMenuItem1
            // 
            this.modifierfournisseurToolStripMenuItem1.Name = "modifierfournisseurToolStripMenuItem1";
            this.modifierfournisseurToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.modifierfournisseurToolStripMenuItem1.Text = "Modifier_fournisseur";
            this.modifierfournisseurToolStripMenuItem1.Click += new System.EventHandler(this.modifierfournisseurToolStripMenuItem1_Click);
            // 
            // supprimerfournisseurToolStripMenuItem1
            // 
            this.supprimerfournisseurToolStripMenuItem1.Name = "supprimerfournisseurToolStripMenuItem1";
            this.supprimerfournisseurToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.supprimerfournisseurToolStripMenuItem1.Text = "Supprimer_fournisseur";
            this.supprimerfournisseurToolStripMenuItem1.Click += new System.EventHandler(this.supprimerfournisseurToolStripMenuItem1_Click);
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passerUneCommandeToolStripMenuItem,
            this.annulercommandeToolStripMenuItem});
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.utilisateurToolStripMenuItem.Text = "Commande";
            // 
            // passerUneCommandeToolStripMenuItem
            // 
            this.passerUneCommandeToolStripMenuItem.Name = "passerUneCommandeToolStripMenuItem";
            this.passerUneCommandeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.passerUneCommandeToolStripMenuItem.Text = "Passer_commande";
            this.passerUneCommandeToolStripMenuItem.Click += new System.EventHandler(this.passerUneCommandeToolStripMenuItem_Click);
            // 
            // annulercommandeToolStripMenuItem
            // 
            this.annulercommandeToolStripMenuItem.Name = "annulercommandeToolStripMenuItem";
            this.annulercommandeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.annulercommandeToolStripMenuItem.Text = "Annuler_commande";
            this.annulercommandeToolStripMenuItem.Click += new System.EventHandler(this.annulercommandeToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // sedeconnecterToolStripMenuItem
            // 
            this.sedeconnecterToolStripMenuItem.Name = "sedeconnecterToolStripMenuItem";
            this.sedeconnecterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sedeconnecterToolStripMenuItem.Text = "Se_deconnecter";
            this.sedeconnecterToolStripMenuItem.Click += new System.EventHandler(this.sedeconnecterToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 461);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestion_fournisseur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seConnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passerUneCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterproduitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierproduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerproduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterfournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierfournisseurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerfournisseurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem annulercommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sedeconnecterToolStripMenuItem;
    }
}

