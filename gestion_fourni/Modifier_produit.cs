using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace gestion_fourni
{
    public partial class Modifier_produit : Form
    {
        public Modifier_produit()
        {
            InitializeComponent();
        }

        private void Modifier_produit_Load(object sender, EventArgs e)
        {
            // Vérifie si la connexion est ouverte dès le début
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
                string query = "SELECT Designation FROM Produit";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, Parametres.laconnexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                produit_modif.DisplayMember = "Designation";
                produit_modif.ValueMember = "Designation";
                produit_modif.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des produits : " + ex.Message);
            }
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (produit_modif.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un produit à modifier.");
                return;
            }

            string nomProduit = produit_modif.SelectedValue.ToString();
            string nvldesi = nvldes.Text.Trim();
            string nvlrefe = nvlref.Text.Trim();
            int nvlqtte = (int)nvlqtt.Value;
            int nvlprix = (int)nvprix.Value;

            // Vérifie si les champs sont valides
            if (string.IsNullOrWhiteSpace(nvldesi) || string.IsNullOrWhiteSpace(nvlrefe) || nvlqtte <= 0 || nvlprix <= 0)
            {
                MessageBox.Show("Veuillez remplir les champs pour la nouvelle désignation, la référence, la quantité et le prix.");
                return;
            }

            // Requête SQL pour mettre à jour le produit
            string query = "UPDATE Produit SET Designation = @Designation_nv, Reference = @Reference_nv, Quantite = @Quantite_nv , Prix = @Prix_nv WHERE Designation = @NmDesignation";

            try
            {
                MySqlCommand command = new MySqlCommand(query, Parametres.laconnexion);
                command.Parameters.AddWithValue("@Designation_nv", nvldesi);
                command.Parameters.AddWithValue("@Reference_nv", nvlrefe);
                command.Parameters.AddWithValue("@Quantite_nv", nvlqtte);
                command.Parameters.AddWithValue("@Prix_nv", nvlprix);
                command.Parameters.AddWithValue("@NmDesignation", nomProduit);

                // Assure-toi que la connexion est ouverte avant d'exécuter la requête
                if (Parametres.laconnexion.State == ConnectionState.Closed)
                {
                    Parametres.laconnexion.Open();
                }

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Aucun produit trouvé avec cette désignation. Vérifiez l'orthographe ou les espaces.");
                }
                else
                {
                    MessageBox.Show("Produit modifié avec succès.");
                }

                // Pas de fermeture de connexion ici, la connexion reste ouverte
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour du produit : " + ex.Message);
            }
        }
    }
}
