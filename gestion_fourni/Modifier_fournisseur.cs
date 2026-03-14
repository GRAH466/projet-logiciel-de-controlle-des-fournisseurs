using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace gestion_fourni
{
    public partial class Modifier_fournisseur : Form
    {
        public Modifier_fournisseur()
        {
            InitializeComponent();
        }

        private void valider_Click(object sender, EventArgs e)
        {
            // Vérifie si la connexion est établie avant l'exécution
            if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
            {
                MessageBox.Show("Vous n'êtes pas connecté à la base de données. Veuillez vous connecter d'abord.");

                // Ouvre le formulaire de connexion si nécessaire
                Connexion connexionForm = new Connexion();
                connexionForm.ShowDialog();

                // Vérifie si la connexion a bien été établie après l'authentification
                if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Connexion à la base de données échouée. Opération annulée.");
                    return;
                }
            }

            // Vérifie si un fournisseur est sélectionné
            if (nom_modifier.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur à modifier.");
                return;
            }

            // Récupère le nom du fournisseur sélectionné depuis SelectedValue
            string nomFournisseur = nom_modifier.SelectedValue.ToString();
            string nouveauNom = nouveau_nom.Text.Trim();
            string nouvelleAdresse = nouvel_add.Text.Trim();

            if (string.IsNullOrWhiteSpace(nouveauNom) || string.IsNullOrWhiteSpace(nouvelleAdresse))
            {
                MessageBox.Show("Veuillez remplir les champs pour le nouveau nom et la nouvelle adresse.");
                return;
            }

            // Debugging: Afficher le nom du fournisseur sélectionné
            MessageBox.Show("Nom du fournisseur sélectionné : " + nomFournisseur);

            // Requête SQL pour mise à jour avec LIKE
            string query = "UPDATE Fournisseur SET Nom = @NouveauNom, Adresse = @NouvelleAdresse WHERE Nom = @NomFournisseur";

            try
            {
                MySqlCommand command = new MySqlCommand(query, Parametres.laconnexion);
                command.Parameters.AddWithValue("@NouveauNom", nouveauNom);
                command.Parameters.AddWithValue("@NouvelleAdresse", nouvelleAdresse);
                command.Parameters.AddWithValue("@NomFournisseur", nomFournisseur);

                if (Parametres.laconnexion.State == ConnectionState.Closed)
                {
                    Parametres.laconnexion.Open();
                }

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Aucun fournisseur trouvé avec ce nom. Vérifiez l'orthographe ou les espaces.");
                }
                else
                {
                    MessageBox.Show("Fournisseur modifié avec succès.");
                }
                // La connexion ne doit pas être fermée ici
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour du fournisseur : " + ex.Message);
            }
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme uniquement ce formulaire
        }

        private void Modifier_fournisseur_Load(object sender, EventArgs e)
        {
            // Vérification de la connexion une seule fois au chargement du formulaire
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
                string query = "SELECT Nom FROM Fournisseur";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, Parametres.laconnexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                nom_modifier.DisplayMember = "Nom";
                nom_modifier.ValueMember = "Nom";
                nom_modifier.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des fournisseurs : " + ex.Message);
            }
        }
    }
}
