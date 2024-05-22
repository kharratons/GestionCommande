using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Commande
    {
    
        public int numero { get; set; }
        public Client codeclt { get; set; }
        public DateTime date { get; set; }
        public string adresseLiv { get; set; }
        public List<LigneDeCommande> LignesDeCommande { get; set; }
        // Constructeur
        public Commande(int numero, Client codeclt, DateTime date, string adresseLiv)
        {
            numero = numero;
            codeclt = codeclt;
            date = date;
            adresseLiv = adresseLiv;
            LignesDeCommande = new List<LigneDeCommande>();
        }
   

        // Méthode pour ajouter une ligne de commande
        public void AjouterLigneDeCommande(LigneDeCommande ligneDeCommande)
        {
            LignesDeCommande.Add(ligneDeCommande);
        }


    }

}
