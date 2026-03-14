using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace gestion_fourni
{
    public partial class Passer_commande : Form
    {
        public Passer_commande()
        {
            InitializeComponent();
        }

        // Méthode pour charger les fournisseurs et produits dans les ComboBox
        private void Passer_commande_Load(object sender, EventArgs e)
        {
            // Vérifier si la connexion est ouverte, sinon ouvrir la connexion
            if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
            {
                Connexion connexionForm = new Connexion();
                connexionForm.ShowDialog();

                if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Connexion échouée. Chargement annulé.");
                    this.Close();
                    return;
                }
            }

            // Chargement des fournisseurs dans le ComboBox
            try
            {
                string queryFournisseurs = "SELECT Nom, NumF FROM Fournisseur";
                MySqlDataAdapter dataAdapterFournisseurs = new MySqlDataAdapter(queryFournisseurs, Parametres.laconnexion);
                DataTable dataTableFournisseurs = new DataTable();
                dataAdapterFournisseurs.Fill(dataTableFournisseurs);

                // Remplir le ComboBox des fournisseurs avec les données récupérées
                nom_four_cmd.DisplayMember = "Nom";
                nom_four_cmd.ValueMember = "NumF";
                nom_four_cmd.DataSource = dataTableFournisseurs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des fournisseurs : " + ex.Message);
            }

            // Chargement des produits dans le ComboBox
            try
            {
                string queryProduits = "SELECT Designation, Code_prdt FROM Produit";
                MySqlDataAdapter dataAdapterProduits = new MySqlDataAdapter(queryProduits, Parametres.laconnexion);
                DataTable dataTableProduits = new DataTable();
                dataAdapterProduits.Fill(dataTableProduits);

                des_prod.DisplayMember = "Designation";
                des_prod.ValueMember = "Code_prdt";
                des_prod.DataSource = dataTableProduits;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des produits : " + ex.Message);
            }
        }

        // Méthode pour fermer le formulaire
        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Méthode pour récupérer le prix du produit
        private decimal GetProduitPrix(int produitId)
        {
            decimal prixProduit = 0;

            string query = "SELECT Prix FROM Produit WHERE Code_prdt = @ProduitId";
            MySqlCommand command = new MySqlCommand(query, Parametres.laconnexion);
            command.Parameters.AddWithValue("@ProduitId", produitId);

            try
            {
                if (Parametres.laconnexion.State == ConnectionState.Closed)
                {
                    Parametres.laconnexion.Open();
                }

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    prixProduit = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération du prix du produit : " + ex.Message);
            }
            
            return prixProduit;
        }

        // Méthode pour enregistrer la commande dans la base de données et afficher un message de confirmation
        private void commander_Click(object sender, EventArgs e)
        {
            // Vérification de la connexion
            if (Parametres.laconnexion == null || Parametres.laconnexion.State == ConnectionState.Closed)
            {
                Connexion connexionForm = new Connexion();
                connexionForm.ShowDialog();
            }

            // Récupérer les informations de la commande depuis les ComboBox et la quantité
            int fournisseurId = (int)nom_four_cmd.SelectedValue;
            int produitId = (int)des_prod.SelectedValue;
            int quantite = (int)quant_cmde.Value;

            // Vérifier que tous les champs sont remplis correctement
            if (fournisseurId <= 0 || produitId <= 0 || quantite <= 0)
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur, un produit et une quantité.");
                return;
            }

            // Calculer le montant de la commande
            decimal prixProduit = GetProduitPrix(produitId);
            decimal montant = prixProduit * quantite;

            // Requête pour insérer la commande dans la base de données
            string query = "INSERT INTO commande (NumF, Code_prdt, Quantite, Montant) VALUES (@NumF, @Code_prdt, @Quantite, @Montant)";

            try
            {
                MySqlCommand command = new MySqlCommand(query, Parametres.laconnexion);
                command.Parameters.AddWithValue("@NumF", fournisseurId);
                command.Parameters.AddWithValue("@Code_prdt", produitId);
                command.Parameters.AddWithValue("@Quantite", quantite);
                command.Parameters.AddWithValue("@Montant", montant);

                if (Parametres.laconnexion.State == ConnectionState.Closed)
                {
                    Parametres.laconnexion.Open();
                }

                command.ExecuteNonQuery();

                // Affichage d'un message détaillé avec les informations de la commande
                string fournisseurNom = (string)nom_four_cmd.Text;
                string produitDesignation = (string)des_prod.Text;
                string prixProduitStr = prixProduit.ToString("C");
                string message = $"Commande passée avec succès !\n\n" +
                                 $"Fournisseur : {fournisseurNom}\n" +
                                 $"Produit : {produitDesignation}\n" +
                                 $"Quantité : {quantite}\n" +
                                 $"Prix unitaire : {prixProduitStr}\n" +
                                 $"Montant total : {montant.ToString("C")}"; // Le montant est formaté en monnaie

                MessageBox.Show(message, "Confirmation de la commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la commande : " + ex.Message);
            }
            
        }
    }
}
