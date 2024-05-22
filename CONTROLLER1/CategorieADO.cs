using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL1;
using System.Security.Cryptography.X509Certificates;

namespace CONTROLLER1
{
    public class CategorieADO
    {
        public List<Categorie> categories = new List<Categorie>();
        public Categorie Getccategorie_ById(int var)
        {
           

            foreach (Categorie Item in categories)
            {
                if (Item.CodeCategorie.Equals(var))
                {
                    return Item;
                }
            }

            return null; // Retourne null si aucun client correspondant n'est trouvé
        }

        public void ListCategories()
        {
   
            Connexion CNX = new Connexion();
            CNX.Connecter();
            SqlCommand command = new SqlCommand("SELECT * FROM Categorie", Connexion.conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Categorie cat = new Categorie();
                cat.CodeCategorie = (int)reader.GetValue(0);
                cat.Designation = (string)reader.GetValue(1);

                // Créer une instance de Categorie et l'ajouter à la liste
                categories.Add(cat);
            }

            // Fermer le reader et la connexion
            reader.Close();
            CNX.Deconnecter();

            // Retourner la liste des catégories récupérées depuis la base de données
        
        }

        public void SaveCategorie(Categorie categorie)
        {
            Connexion CNX = new Connexion();
            CNX.Connecter();
            SqlCommand requete = new SqlCommand();

            requete.CommandText = "INSERT INTO Categorie (designation) VALUES (@designation)";
            requete.CommandType = CommandType.Text;

           
            requete.Parameters.AddWithValue("@designation", categorie.Designation);

            CNX.ExecuteCommand(requete);
            CNX.Deconnecter();
        }

        public void DeleteCategorie(int codeCategorie)
        {

            Connexion CNX = new Connexion();
            CNX.Connecter();
            SqlConnection maConnexionSQL = Connexion.conn; // Obtenez la connexion à partir de l'instance CNX
            SqlCommand requete = new SqlCommand();
            requete.Connection = maConnexionSQL; // Utilisez la connexion obtenue
            requete.CommandText = "DELETE FROM Categorie WHERE codeCategorie = @codeCategorie";
            requete.CommandType = CommandType.Text;

            // Ajoutez le paramètre @clientId
            requete.Parameters.AddWithValue("@codeCategorie", codeCategorie);

            requete.ExecuteNonQuery(); // Exécutez la requête
            requete.Dispose();
            CNX.Deconnecter();
        }

        public void UpdateCategorie(Categorie categorie)
        {
            Connexion CNX = new Connexion();
            CNX.Connecter();
            SqlCommand requete = new SqlCommand();

            requete.CommandText = "UPDATE Categorie SET designation = @designation WHERE codeCategorie = @codeCategorie";
            requete.CommandType = CommandType.Text;

            requete.Parameters.AddWithValue("@designation", categorie.Designation);
            requete.Parameters.AddWithValue("@codeCategorie", categorie.CodeCategorie);

            CNX.ExecuteCommand(requete);
            CNX.Deconnecter();
        }
    }
 
}
