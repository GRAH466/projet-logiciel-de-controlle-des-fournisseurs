using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_fourni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
            {
                Connexion maconnection = new Connexion();
                maconnection.MdiParent = this;
                maconnection.Show();
            }
            else
            {
                MessageBox.Show("Vous êtes déjà connecté à la base de données.");
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajouterproduitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ajout_produit ajout_Produit = new Ajout_produit();
            ajout_Produit.MdiParent = this;
            ajout_Produit.Show();
        }

        private void ajouterfournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fournisseur monfour = new Fournisseur();
            monfour.MdiParent = this;
            monfour.Show();
        }

        private void modifierfournisseurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modifier_fournisseur mdiffour = new Modifier_fournisseur();
            mdiffour.MdiParent = this;
            mdiffour.Show();
        }

        private void supprimerfournisseurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Supprimer_fournisseur suppfour = new Supprimer_fournisseur();
            suppfour.MdiParent = this;
            suppfour.Show();
        }

        private void modifierproduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier_produit modifier_Produit = new Modifier_produit();
            modifier_Produit.MdiParent= this;
            modifier_Produit.Show();
        }

        private void supprimerproduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer_produit supprd = new Supprimer_produit();
            supprd.MdiParent = this;
            supprd.Show();
        }

        private void sedeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifie si la connexion est ouverte avant de tenter de la fermer
                if (Parametres.laconnexion != null && Parametres.laconnexion.State == ConnectionState.Open)
                {
                    Parametres.laconnexion.Close();
                    MessageBox.Show("Déconnexion réussie.");
                }
                else
                {
                    MessageBox.Show("La connexion est déjà fermée.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la déconnexion : " + ex.Message);
            }
        }

        private void passerUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Passer_commande passcmde = new Passer_commande();
            passcmde.MdiParent = this;
            passcmde.Show();
        }

        private void annulercommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer_commande suppcmd = new Supprimer_commande();
            suppcmd.MdiParent = this;
            suppcmd.Show();
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help_me aide = new Help_me();
            aide.MdiParent = this;
            aide.Show();
        }
    }
}
