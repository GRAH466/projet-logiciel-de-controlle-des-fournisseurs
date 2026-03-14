using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gestion_fourni
{
    static class Parametres
    {
        public static string lachaine;
        public static MySqlConnection laconnexion;
        public static MySqlDataAdapter leDataAdapter;
        public static DataSet leDataSet;
        public static MySqlCommandBuilder leCommandBuilder;

        // Méthode pour se connecter à la base de données avec des paramètres
        public static void Connecter(string database, string userID, string password)
        {
            // Créer la chaîne de connexion avec les paramètres
            lachaine = $"server=localhost;database={database};uid={userID};pwd={password};";
            laconnexion = new MySqlConnection(lachaine);

            try
            {
                laconnexion.Open();
                MessageBox.Show("Connexion réussie parametres.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }
    }
}
