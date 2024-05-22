using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class LigneDeCommande
    {
        public int codeLignedeCommande{ get; set; }
        public Article codearticle { get; set; }
        public Commande codecommande { get; set; }
        public string quantite { get; set; }

        // Constructeur
        public LigneDeCommande(int codeLigneCommande, Article codearticle,Commande codecommande, string quantite)
        {
            codeLignedeCommande = codeLignedeCommande;
            codearticle = codearticle;
            codecommande = codecommande;
            quantite = quantite;
        }
    }
}
