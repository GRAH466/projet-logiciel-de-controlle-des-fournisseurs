namespace gestion_fourni
{
    partial class Modifier_produit
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
            this.produit_modif = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nvldes = new System.Windows.Forms.TextBox();
            this.nvlref = new System.Windows.Forms.TextBox();
            this.valider = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.nvlqtt = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nvprix = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nvlqtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvprix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODIFIER UN PRODUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choississez le produit :";
            // 
            // produit_modif
            // 
            this.produit_modif.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.produit_modif.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.produit_modif.FormattingEnabled = true;
            this.produit_modif.Location = new System.Drawing.Point(252, 90);
            this.produit_modif.Name = "produit_modif";
            this.produit_modif.Size = new System.Drawing.Size(162, 21);
            this.produit_modif.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nouvelle designation :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nouvelle reference :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nouvelle quantite :";
            // 
            // nvldes
            // 
            this.nvldes.Location = new System.Drawing.Point(252, 151);
            this.nvldes.Name = "nvldes";
            this.nvldes.Size = new System.Drawing.Size(162, 20);
            this.nvldes.TabIndex = 6;
            // 
            // nvlref
            // 
            this.nvlref.Location = new System.Drawing.Point(252, 206);
            this.nvlref.Name = "nvlref";
            this.nvlref.Size = new System.Drawing.Size(162, 20);
            this.nvlref.TabIndex = 7;
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(104, 399);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 9;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(339, 399);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 10;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // nvlqtt
            // 
            this.nvlqtt.Location = new System.Drawing.Point(252, 267);
            this.nvlqtt.Name = "nvlqtt";
            this.nvlqtt.Size = new System.Drawing.Size(162, 20);
            this.nvlqtt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nouveau prix :";
            // 
            // nvprix
            // 
            this.nvprix.Location = new System.Drawing.Point(252, 323);
            this.nvprix.Name = "nvprix";
            this.nvprix.Size = new System.Drawing.Size(162, 20);
            this.nvprix.TabIndex = 13;
            // 
            // Modifier_produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 461);
            this.Controls.Add(this.nvprix);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nvlqtt);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.nvlref);
            this.Controls.Add(this.nvldes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.produit_modif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modifier_produit";
            this.Text = "Modifier_produit";
            this.Load += new System.EventHandler(this.Modifier_produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nvlqtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvprix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox produit_modif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nvldes;
        private System.Windows.Forms.TextBox nvlref;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.NumericUpDown nvlqtt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nvprix;
    }
}