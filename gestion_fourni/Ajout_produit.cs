using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace gestion_fourni
{
    public partial class Ajout_produit : Form
    {
        public Ajout_produit()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            // Vérifie si la connexion est établie avant d'effectuer l'ajout
            if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
            {
                MessageBox.Show("Vous n'êtes pas connecté à la base de données. Veuillez vous connecter d'abord.");

                Connexion connexionForm = new Connexion();
                connexionForm.ShowDialog();

                if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Connexion à la base de données échouée. Ajout annulé.");
                    return;
                }
            }

            // Si la connexion est ouverte, ajoute le produit
            string query = "INSERT INTO Produit (Designation, Reference, Quantite, Prix) VALUES (@Designation, @Reference, @Quantite, @Prix)";

            using (MySqlCommand command = new MySqlCommand(query, Parametres.laconnexion))
            {
                command.Parameters.AddWithValue("@Designation", designation.Text);
                command.Parameters.AddWithValue("@Reference", reference.Text);
                command.Parameters.AddWithValue("@Quantite", quantite.Value);
                command.Parameters.AddWithValue("@Prix", prix.Value);

                try
                {
                    // Assure que la connexion est ouverte
                    if (Parametres.laconnexion.State == ConnectionState.Closed)
                    {
                        Parametres.laconnexion.Open();
                    }

                    // Exécute la commande pour ajouter le produit
                    command.ExecuteNonQuery();
                    MessageBox.Show("Le produit a été ajouté avec succès.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout du produit : " + ex.Message);
                }
            }
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme ce formulaire
        }

        private void Ajout_produit_Load(object sender, EventArgs e)
        {
            // Ici, tu peux mettre du code pour initialiser le formulaire si nécessaire
        }
    }
}
