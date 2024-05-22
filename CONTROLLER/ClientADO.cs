using MODEL;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLLER
{
    public class ClientADO
    {
        // Vos méthodes existantes pour ajouter, supprimer, etc.
        public List<Client> Listclient()
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

                    clients.Add(clie);
                }


                return clients;
         
        }
      
    }
}
