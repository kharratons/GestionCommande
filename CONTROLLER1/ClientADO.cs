using MODEL1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLLER1
{
    public class ClientADO
    {

        public List<Client> Listeclt = new List<Client>();
        // Vos méthodes existantes pour ajouter, supprimer, etc.
        public void Listclient()
        {
            List<Client> clients = new List<Client>();
            Connexion CNX = new Connexion();
            CNX.Connecter();
            SqlDataReader reader = CNX.Rdd("SELECT * FROM Client");
            while (reader.Read())
            {
                Client clie = new Client();

                clie.CodeClient = (int)reader["codeClient"];
                clie.Nom = (string)reader["nom"];
                clie.Prenom = (string)reader["prenom"];
                clie.Adresse = (string)reader["adresse"];
                clie.Téléphone = (string)reader["telephone"];
                clie.Email = (string)reader["email"];

                Listeclt.Add(clie);
            }
            CNX.Deconnecter();
        }
        public void SaveClient(Client clie)
        {
            Connexion CNX = new Connexion();
            CNX.Connecter();
            SqlCommand requete = new SqlCommand();

            SqlParameter p_nom_client = new SqlParameter("@nom_client", SqlDbType.VarChar);
            SqlParameter p_prenom_client = new SqlParameter("@prenom_client", SqlDbType.VarChar);
            SqlParameter p_adresse_client = new SqlParameter("@adresse_client", SqlDbType.VarChar);
            SqlParameter p_telephone_client = new SqlParameter("@telephone_client", SqlDbType.VarChar);
            SqlParameter p_email_client = new SqlParameter("@email_client", SqlDbType.VarChar);

            requete.CommandText = "INSERT INTO Client( nom, prenom, adresse, telephone, email) VALUES(@nom_client, @prenom_client, @adresse_client, @telephone_client, @email_client)";
            requete.CommandType = CommandType.Text;


            p_nom_client.Value = clie.Nom;
            p_prenom_client.Value = clie.Prenom;
            p_adresse_client.Value = clie.Adresse;
            p_telephone_client.Value = clie.Téléphone;
            p_email_client.Value = clie.Email;

            requete.Parameters.Add(p_nom_client);
            requete.Parameters.Add(p_prenom_client);
            requete.Parameters.Add(p_adresse_client);
            requete.Parameters.Add(p_telephone_client);
            requete.Parameters.Add(p_email_client);

            CNX.ExecuteCommand(requete);
            CNX.Deconnecter();

        }
        public void DeleteClient(int clientId)
        {
            Connexion CNX = new Connexion();
            CNX.Connecter();
            SqlConnection maConnexionSQL = Connexion.conn; // Obtenez la connexion à partir de l'instance CNX
            SqlCommand requete = new SqlCommand();
            requete.Connection = maConnexionSQL; // Utilisez la connexion obtenue
            requete.CommandText = "DELETE FROM Client WHERE codeClient = @clientId";
            requete.CommandType = CommandType.Text;

            // Ajoutez le paramètre @clientId
            requete.Parameters.AddWithValue("@clientId", clientId);

            requete.ExecuteNonQuery(); // Exécutez la requête
            requete.Dispose();
            CNX.Deconnecter();
        }
        public void UpdateClient(Client clie)
        {
            Connexion CNX = new Connexion();
            CNX.Connecter();
            SqlCommand requete = new SqlCommand();

            requete.CommandText = "UPDATE Client SET Nom = @nom_client, Prenom = @prenom_client, adresse = @adresse_client, telephone = @telephone_client, email = @email_client WHERE CodeClient = @code";
            requete.CommandType = CommandType.Text;

            requete.Parameters.AddWithValue("@nom_client", clie.Nom);
            requete.Parameters.AddWithValue("@prenom_client", clie.Prenom);
            requete.Parameters.AddWithValue("@adresse_client", clie.Adresse);
            requete.Parameters.AddWithValue("@telephone_client", clie.Téléphone);
            requete.Parameters.AddWithValue("@email_client", clie.Email);
            requete.Parameters.AddWithValue("@code", clie.CodeClient);

            CNX.ExecuteCommand(requete);
            CNX.Deconnecter();
        }

    }
}
