using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL1
{
public class Client
    
    {
        // Propriétés
        private int codeClient;
        private string nom;
        private string prenom;
        private string adresse;
        private string téléphone;
        private string email;

        public int CodeClient { get => codeClient; set => codeClient = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Téléphone { get => téléphone; set => téléphone = value; }
        public string Email { get => email; set => email = value; }

        public Client(int codeClient, string nom, string prenom, string adresse, string téléphone, string email)
        {
            this.codeClient = codeClient;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.téléphone = téléphone;
            this.email = email;
        }


        public Client()
        {
           
        }

    }

}
