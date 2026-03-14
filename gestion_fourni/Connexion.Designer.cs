namespace gestion_fourni
{
    partial class Connexion
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
            this.annuler = new System.Windows.Forms.Button();
            this.seconnecter = new System.Windows.Forms.Button();
            this.uID = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.db = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Base de donnee :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONNECTION A LA BASE DE DONNEE";
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(326, 324);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(79, 30);
            this.annuler.TabIndex = 4;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // seconnecter
            // 
            this.seconnecter.Location = new System.Drawing.Point(98, 324);
            this.seconnecter.Name = "seconnecter";
            this.seconnecter.Size = new System.Drawing.Size(84, 30);
            this.seconnecter.TabIndex = 5;
            this.seconnecter.Text = "Se connecter";
            this.seconnecter.UseVisualStyleBackColor = true;
            this.seconnecter.Click += new System.EventHandler(this.seconnecter_Click);
            // 
            // uID
            // 
            this.uID.Location = new System.Drawing.Point(283, 88);
            this.uID.Name = "uID";
            this.uID.Size = new System.Drawing.Size(201, 20);
            this.uID.TabIndex = 6;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(283, 157);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(201, 20);
            this.pwd.TabIndex = 7;
            // 
            // db
            // 
            this.db.Location = new System.Drawing.Point(283, 219);
            this.db.Name = "db";
            this.db.Size = new System.Drawing.Size(201, 20);
            this.db.TabIndex = 8;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 461);
            this.Controls.Add(this.db);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uID);
            this.Controls.Add(this.seconnecter);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button seconnecter;
        private System.Windows.Forms.TextBox uID;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox db;
    }
}