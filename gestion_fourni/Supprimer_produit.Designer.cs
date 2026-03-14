namespace gestion_fourni
{
    partial class Supprimer_produit
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
            this.label2 = new System.Windows.Forms.Label();
            this.prod_supp = new System.Windows.Forms.ComboBox();
            this.valider = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUPPRIMER UN PRODUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choississez le produit :";
            // 
            // prod_supp
            // 
            this.prod_supp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.prod_supp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.prod_supp.FormattingEnabled = true;
            this.prod_supp.Location = new System.Drawing.Point(265, 106);
            this.prod_supp.Name = "prod_supp";
            this.prod_supp.Size = new System.Drawing.Size(165, 21);
            this.prod_supp.TabIndex = 2;
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(85, 219);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 3;
            this.valider.Text = "Supprimer";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(308, 219);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 4;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // Supprimer_produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 461);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.prod_supp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Supprimer_produit";
            this.Text = "Supprimer_produit";
            this.Load += new System.EventHandler(this.Supprimer_produit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox prod_supp;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button fermer;
    }
}