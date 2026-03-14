namespace gestion_fourni
{
    partial class Ajout_produit
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.designation = new System.Windows.Forms.TextBox();
            this.reference = new System.Windows.Forms.TextBox();
            this.quantite = new System.Windows.Forms.NumericUpDown();
            this.ajouter = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AJOUTER DES PRODUITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reference :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantite :";
            // 
            // designation
            // 
            this.designation.Location = new System.Drawing.Point(288, 94);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(148, 20);
            this.designation.TabIndex = 4;
            // 
            // reference
            // 
            this.reference.Location = new System.Drawing.Point(288, 168);
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(148, 20);
            this.reference.TabIndex = 5;
            // 
            // quantite
            // 
            this.quantite.Location = new System.Drawing.Point(288, 239);
            this.quantite.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(148, 20);
            this.quantite.TabIndex = 6;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(76, 384);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(90, 32);
            this.ajouter.TabIndex = 7;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(319, 384);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(79, 32);
            this.fermer.TabIndex = 8;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prix :";
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(288, 320);
            this.prix.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(151, 20);
            this.prix.TabIndex = 11;
            // 
            // Ajout_produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 461);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.quantite);
            this.Controls.Add(this.reference);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ajout_produit";
            this.Text = "Ajout_produit";
            this.Load += new System.EventHandler(this.Ajout_produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.TextBox reference;
        private System.Windows.Forms.NumericUpDown quantite;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown prix;
    }
}