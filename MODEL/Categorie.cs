using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Categorie
    {
        
        public int codeCategorie { get; set; }
        public string designation { get; set; }

    
        public Categorie(int codeCategorie, string designation)
        {
            codeCategorie = codeCategorie;
            designation = designation;
        }

    }

}
