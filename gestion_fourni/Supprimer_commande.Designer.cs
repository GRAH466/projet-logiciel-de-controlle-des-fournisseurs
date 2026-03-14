namespace gestion_fourni
{
    partial class Supprimer_commande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.idsupcmd = new System.Windows.Forms.ComboBox();
            this.annuler = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.afficher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID commande :";
            // 
            // idsupcmd
            // 
            this.idsupcmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idsupcmd.FormattingEnabled = true;
            this.idsupcmd.Location = new System.Drawing.Point(296, 99);
            this.idsupcmd.Name = "idsupcmd";
            this.idsupcmd.Size = new System.Drawing.Size(156, 21);
            this.idsupcmd.TabIndex = 1;
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(82, 237);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(101, 33);
            this.annuler.TabIndex = 2;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(359, 237);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(93, 33);
            this.fermer.TabIndex = 3;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // afficher
            // 
            this.afficher.Location = new System.Drawing.Point(296, 161);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(75, 23);
            this.afficher.TabIndex = 4;
            this.afficher.Text = "Afficher ";
            this.afficher.UseVisualStyleBackColor = true;
            this.afficher.Click += new System.EventHandler(this.afficher_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ANNULATION COMMANDE";
            // 
            // Supprimer_commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.afficher);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.idsupcmd);
            this.Controls.Add(this.label1);
            this.Name = "Supprimer_commande";
            this.Text = "Annuler_commande";
            this.Load += new System.EventHandler(this.Supprimer_commande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox idsupcmd;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button afficher;
        private System.Windows.Forms.Label label2;
    }
}