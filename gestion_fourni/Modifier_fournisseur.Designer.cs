namespace gestion_fourni
{
    partial class Modifier_fournisseur
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
            this.valider = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nom_modifier = new System.Windows.Forms.ComboBox();
            this.nouveau_nom = new System.Windows.Forms.TextBox();
            this.nouvel_add = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(125, 300);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(86, 31);
            this.valider.TabIndex = 0;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // Annuler
            // 
            this.Annuler.Location = new System.Drawing.Point(357, 300);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(81, 31);
            this.Annuler.TabIndex = 1;
            this.Annuler.Text = "Fermer";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom a modifier :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nouveau nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nouvelle adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "MODIFIER LES INFOS FOURNISSEUR";
            // 
            // nom_modifier
            // 
            this.nom_modifier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nom_modifier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nom_modifier.DropDownWidth = 166;
            this.nom_modifier.FormattingEnabled = true;
            this.nom_modifier.Location = new System.Drawing.Point(340, 71);
            this.nom_modifier.Name = "nom_modifier";
            this.nom_modifier.Size = new System.Drawing.Size(166, 21);
            this.nom_modifier.TabIndex = 7;
            // 
            // nouveau_nom
            // 
            this.nouveau_nom.Location = new System.Drawing.Point(340, 124);
            this.nouveau_nom.Name = "nouveau_nom";
            this.nouveau_nom.Size = new System.Drawing.Size(166, 20);
            this.nouveau_nom.TabIndex = 9;
            // 
            // nouvel_add
            // 
            this.nouvel_add.Location = new System.Drawing.Point(340, 183);
            this.nouvel_add.Name = "nouvel_add";
            this.nouvel_add.Size = new System.Drawing.Size(166, 20);
            this.nouvel_add.TabIndex = 10;
            // 
            // Modifier_fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 461);
            this.Controls.Add(this.nouvel_add);
            this.Controls.Add(this.nouveau_nom);
            this.Controls.Add(this.nom_modifier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.valider);
            this.Name = "Modifier_fournisseur";
            this.Text = "Modifier_fournisseur";
            this.Load += new System.EventHandler(this.Modifier_fournisseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox nom_modifier;
        private System.Windows.Forms.TextBox nouveau_nom;
        private System.Windows.Forms.TextBox nouvel_add;
    }
}