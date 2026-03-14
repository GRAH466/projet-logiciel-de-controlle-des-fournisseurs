using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace gestion_fourni
{
    public partial class Supprimer_produit : Form
    {
        public Supprimer_produit()
        {
            InitializeComponent();
        }

        private void Supprimer_produit_Load(object sender, EventArgs e)
        {
            // Vérifie si la connexion est ouverte dès l'ouverture du formulaire
            if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
            {
                Connexion connexionForm = new Connexion();
                connexionForm.ShowDialog();

                if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Connexion échouée. Chargement annulé.");
                    this.Close(); // Ferme le formulaire si la connexion échoue
                    return;
                }
            }

            try
            {
                string query = "SELECT Designation FROM Produit"; // Sélectionne les produits
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, Parametres.laconnexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Configure le ComboBox pour afficher la désignation du produit
                prod_supp.DisplayMember = "Designation";
                prod_supp.ValueMember = "Designation";
                prod_supp.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des produits : " + ex.Message);
            }
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme le formulaire
        }

        private void valider_Click(object sender, EventArgs e)
        {
            // Vérifie si la connexion est établie avant de commencer l'opération
            if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
            {
                MessageBox.Show("Vous n'êtes pas connecté à la base de données. Veuillez vous connecter d'abord.");

                Connexion connexionForm = new Connexion();
                connexionForm.ShowDialog();

                if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Connexion à la base de données échouée. Opération annulée.");
                    return;
                }
            }

            // Vérifie si un produit est sélectionné
            if (prod_supp.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un produit à supprimer.");
                return;
            }

            // Récupère la désignation du produit sélectionné
            string nomProduit = prod_supp.SelectedValue.ToString();

            // Requête SQL pour supprimer le produit
            string query = "DELETE FROM Produit WHERE Designation = @NomProduit";

            try
            {
                MySqlCommand command = new MySqlCommand(query, Parametres.laconnexion);
                command.Parameters.AddWithValue("@NomProduit", nomProduit); // Utilise le bon paramètre

                // Assure-toi que la connexion est ouverte avant d'exécuter la commande
                if (Parametres.laconnexion.State == ConnectionState.Closed)
                {
                    Parametres.laconnexion.Open();
                }

                int rowsAffected = command.ExecuteNonQuery(); // Exécute la commande

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Aucun produit trouvé avec cette désignation. Vérifiez l'orthographe ou les espaces.");
                }
                else
                {
                    MessageBox.Show("Produit supprimé avec succès.");
                }
                // Pas de fermeture de la connexion ici, elle restera ouverte jusqu'à la fin de la session
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du produit : " + ex.Message);
            }
        }
    }
}
