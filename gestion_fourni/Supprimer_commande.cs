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
    public partial class Supprimer_commande : Form
    {
        public Supprimer_commande()
        {
            InitializeComponent();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Supprimer_commande_Load(object sender, EventArgs e)
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
                string query = "SELECT Num_cmde FROM Commande"; // Sélectionne les produits
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, Parametres.laconnexion);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Configure le ComboBox pour afficher la désignation du produit
                idsupcmd.DisplayMember = "Num_cmde";
                idsupcmd.ValueMember = "Num_cmde";
                idsupcmd.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des produits : " + ex.Message);
            }
        }

        private void afficher_Click(object sender, EventArgs e)
        {
            // Vérifier si une commande a été sélectionnée dans le ComboBox
            if (idsupcmd.SelectedValue != null)
            {
                int commandeId = (int)idsupcmd.SelectedValue; // Récupère l'ID de la commande sélectionnée

                try
                {
                    // Requête pour récupérer les informations de la commande (fournisseur, produit, prix, quantité, montant)
                    string query = @"
                SELECT f.Nom AS FournisseurNom, f.Adresse AS FournisseurAdresse, 
                       p.Designation AS ProduitDesignation, 
                       c.Quantite AS QuantiteCommande, p.Prix AS PrixProduit, 
                       c.Montant AS MontantCommande,
                       c.Date_cmde AS Datecommande
                FROM commande c
                JOIN Fournisseur f ON c.NumF = f.NumF
                JOIN Produit p ON c.Code_prdt = p.Code_prdt
                WHERE c.Num_cmde = @CommandeId";  // Num_cmde est l'ID de la commande

                    // Préparer la commande SQL
                    MySqlCommand command = new MySqlCommand(query, Parametres.laconnexion);
                    command.Parameters.AddWithValue("@CommandeId", commandeId);

                    // Exécuter la commande pour obtenir les informations
                    MySqlDataReader reader = command.ExecuteReader();

                    // Vérifier si des données ont été récupérées
                    if (reader.Read())
                    {
                        string fournisseurNom = reader.GetString("FournisseurNom");
                        string fournisseurAdresse = reader.GetString("FournisseurAdresse");
                        string produitDesignation = reader.GetString("ProduitDesignation");
                        int quantite = reader.GetInt32("QuantiteCommande");
                        decimal prixProduit = reader.GetDecimal("PrixProduit");
                        decimal montantCommande = reader.GetDecimal("MontantCommande");
                        DateTime dateCommande = reader.GetDateTime("DateCommande");

                        // Formatage du message à afficher
                        string message = $"Informations de la commande :\n\n" +
                                         $"Fournisseur : {fournisseurNom}\n" +
                                         $"Adresse fournisseur : {fournisseurAdresse}\n" +
                                         $"Produit : {produitDesignation}\n" +
                                         $"Quantité commandée : {quantite}\n" +
                                         $"Date de la commande : {dateCommande.ToString("dd/MM/yyyy HH:mm:ss")}\n" +
                                         $"Prix unitaire : {prixProduit.ToString()}\n" + // Format monétaire
                                         $"Montant total : {montantCommande.ToString()}";  // Format monétaire

                        // Affichage du message dans un MessageBox
                        MessageBox.Show(message, "Détails de la commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Aucune commande trouvée pour cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Gestion des erreurs si la récupération des données échoue
                    MessageBox.Show("Erreur lors de la récupération des informations de la commande : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une commande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void annuler_Click(object sender, EventArgs e)
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

            // Vérifie si une commande est sélectionné
            if (idsupcmd.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner la commande a annulee.");
                return;
            }

            // Récupère l'ID de la commande sélectionné
            string nomProduit = idsupcmd.SelectedValue.ToString();

            // Requête SQL pour supprimer la commande
            string query = "DELETE FROM Commande WHERE Num_cmde = @Numcomde";

            try
            {
                MySqlCommand command = new MySqlCommand(query, Parametres.laconnexion);
                command.Parameters.AddWithValue("@Numcmde", nomProduit); // Utilise le bon paramètre

                // Assure-toi que la connexion est ouverte avant d'exécuter la commande
                if (Parametres.laconnexion.State == ConnectionState.Closed)
                {
                    Parametres.laconnexion.Open();
                }

                int rowsAffected = command.ExecuteNonQuery(); // Exécute la commande

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Aucune commande trouvé avec cet ID. ");
                }
                else
                {
                    MessageBox.Show("Commande annuler avec succès.");
                    this.Close(); return;
                }
                // Pas de fermeture de la connexion ici, elle restera ouverte jusqu'à la fin de la session
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression de la commande : " + ex.Message);
            }
        }
    }
    }

