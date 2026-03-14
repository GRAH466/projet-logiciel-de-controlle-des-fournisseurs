using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gestion_fourni
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void seconnecter_Click(object sender, EventArgs e)
        {
            // Appeler la méthode Connecter en passant les informations de connexion depuis les TextBox
            Parametres.Connecter(db.Text, uID.Text, pwd.Text);

            // Vérifier si la connexion a réussi avant de fermer
            if (Parametres.laconnexion.State == ConnectionState.Open)
            {
                MessageBox.Show("Connexion réussie !");
                this.Close();  // Ferme le formulaire si la connexion est établie
            }
            else
            {
                MessageBox.Show("Échec de la connexion. Veuillez vérifier les informations.");
            }

        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
