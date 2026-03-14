using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace gestion_fourni
{
    public partial class Fournisseur : Form
    {
        public Fournisseur()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            // Vérifie si la connexion est établie au début
            if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
            {
                // Affiche un message si la connexion est fermée
                MessageBox.Show("Vous n'êtes pas connecté à la base de données. Veuillez vous connecter d'abord.");

                // Ouvre le formulaire de connexion
                Connexion connexionForm = new Connexion();
                connexionForm.ShowDialog();

                // Vérifie de nouveau l'état de la connexion après la tentative de connexion
                if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Connexion à la base de données échouée. Ajout annulé.");
                    return; // Arrête l'exécution si la connexion échoue
                }
            }

            // Si la connexion est établie, exécute le code pour ajouter le fournisseur
            string query = "INSERT INTO Fournisseur (Nom, Adresse) VALUES (@Nom, @Adresse)";

            using (MySqlCommand command = new MySqlCommand(query, Parametres.laconnexion))
            {
                command.Parameters.AddWithValue("@Nom", Nom.Text);
                command.Parameters.AddWithValue("@Adresse", Adresse.Text);

                try
                {
                    // Assure que la connexion est ouverte si ce n'est pas déjà le cas
                    if (Parametres.laconnexion.State == ConnectionState.Closed)
                    {
                        Parametres.laconnexion.Open();
                    }

                    // Exécute la commande pour ajouter le fournisseur
                    command.ExecuteNonQuery();
                    MessageBox.Show("Fournisseur ajouté avec succès.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout du fournisseur : " + ex.Message);
                }
                // Ne ferme pas la connexion ici, elle restera ouverte pour d'autres actions
            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fournisseur_Load(object sender, EventArgs e)
        {
            // Cette méthode est vide, elle peut être utilisée si nécessaire pour initialiser des données ou des paramètres au chargement du formulaire
        }
    }
}
