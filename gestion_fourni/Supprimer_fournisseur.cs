using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace gestion_fourni
{
    public partial class Supprimer_fournisseur : Form
    {
        public Supprimer_fournisseur()
        {
            InitializeComponent();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme uniquement ce formulaire
        }

        private void Supprimer_fournisseur_Load(object sender, EventArgs e)
        {
            // Vérification de la connexion une seule fois au début
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

            // Chargement des fournisseurs dans le comboBox
            try
            {
                string query = "SELECT Nom FROM Fournisseur";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, Parametres.laconnexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                asupprimer.DisplayMember = "Nom";
                asupprimer.ValueMember = "Nom";
                asupprimer.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des fournisseurs : " + ex.Message);
            }
        }

        private void valider_Click(object sender, EventArgs e)
        {
            // Vérifie si la connexion est établie avant d'effectuer l'opération
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
            if (asupprimer.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur à supprimer.");
                return;
            }

            // Récupère le nom du fournisseur sélectionné depuis SelectedValue
            string nomFournisseur = asupprimer.SelectedValue.ToString();

            // Requête SQL pour supprimer le fournisseur
            string query = "DELETE FROM Fournisseur WHERE Nom = @NomFournisseur";

            try
            {
                MySqlCommand command = new MySqlCommand(query, Parametres.laconnexion);
                command.Parameters.AddWithValue("@NomFournisseur", nomFournisseur);

                // Assure que la connexion est ouverte
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
                    MessageBox.Show("Fournisseur supprimé avec succès.");
                }

                // Connexion fermée uniquement si nécessaire
                // Parametres.laconnexion.Close();  // Optional: Close after all operations if needed
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du fournisseur : " + ex.Message);
            }
        }
    }
}
