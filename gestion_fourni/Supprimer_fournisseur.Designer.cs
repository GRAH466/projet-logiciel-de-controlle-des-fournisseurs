namespace gestion_fourni
{
    partial class Supprimer_fournisseur
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
            this.fermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.asupprimer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(79, 218);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 0;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(306, 218);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 1;
            this.fermer.Text = "fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SUPPRIMER UN FOURNISSEUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A supprimer :";
            // 
            // asupprimer
            // 
            this.asupprimer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.asupprimer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.asupprimer.FormattingEnabled = true;
            this.asupprimer.Location = new System.Drawing.Point(251, 119);
            this.asupprimer.Name = "asupprimer";
            this.asupprimer.Size = new System.Drawing.Size(152, 21);
            this.asupprimer.TabIndex = 4;
            // 
            // Supprimer_fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 461);
            this.Controls.Add(this.asupprimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.valider);
            this.Name = "Supprimer_fournisseur";
            this.Text = "Supprimer_fournisseur";
            this.Load += new System.EventHandler(this.Supprimer_fournisseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox asupprimer;
    }
}