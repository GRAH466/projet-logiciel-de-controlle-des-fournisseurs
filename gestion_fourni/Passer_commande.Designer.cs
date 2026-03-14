namespace gestion_fourni
{
    partial class Passer_commande
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
            this.nom_four_cmd = new System.Windows.Forms.ComboBox();
            this.des_prod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quant_cmde = new System.Windows.Forms.NumericUpDown();
            this.commander = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quant_cmde)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PASSER VOTRE COMMANDE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom du fournisseur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Designation du Produit :";
            // 
            // nom_four_cmd
            // 
            this.nom_four_cmd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nom_four_cmd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nom_four_cmd.FormattingEnabled = true;
            this.nom_four_cmd.Location = new System.Drawing.Point(293, 95);
            this.nom_four_cmd.Name = "nom_four_cmd";
            this.nom_four_cmd.Size = new System.Drawing.Size(171, 21);
            this.nom_four_cmd.TabIndex = 3;
            // 
            // des_prod
            // 
            this.des_prod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.des_prod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.des_prod.FormattingEnabled = true;
            this.des_prod.Location = new System.Drawing.Point(293, 163);
            this.des_prod.Name = "des_prod";
            this.des_prod.Size = new System.Drawing.Size(171, 21);
            this.des_prod.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantite du produit commandé :";
            // 
            // quant_cmde
            // 
            this.quant_cmde.Location = new System.Drawing.Point(293, 232);
            this.quant_cmde.Name = "quant_cmde";
            this.quant_cmde.Size = new System.Drawing.Size(171, 20);
            this.quant_cmde.TabIndex = 6;
            // 
            // commander
            // 
            this.commander.Location = new System.Drawing.Point(87, 351);
            this.commander.Name = "commander";
            this.commander.Size = new System.Drawing.Size(91, 32);
            this.commander.TabIndex = 7;
            this.commander.Text = "Commander";
            this.commander.UseVisualStyleBackColor = true;
            this.commander.Click += new System.EventHandler(this.commander_Click);
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(340, 351);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(82, 32);
            this.fermer.TabIndex = 8;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // Passer_commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 461);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.commander);
            this.Controls.Add(this.quant_cmde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.des_prod);
            this.Controls.Add(this.nom_four_cmd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Passer_commande";
            this.Text = "Passer_commande";
            this.Load += new System.EventHandler(this.Passer_commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quant_cmde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nom_four_cmd;
        private System.Windows.Forms.ComboBox des_prod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown quant_cmde;
        private System.Windows.Forms.Button commander;
        private System.Windows.Forms.Button fermer;
    }
}