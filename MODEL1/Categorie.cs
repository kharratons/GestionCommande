using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL1
{
    public class Categorie
    {

        private int codeCategorie;
        private string designation;

        public Categorie()
        {
        }

        public Categorie(int codeCategorie, string designation)
        {
            codeCategorie = codeCategorie;
            designation = designation;
        }

        public string Designation { get => designation; set => designation = value; }
        public int CodeCategorie { get => codeCategorie; set => codeCategorie = value; }
        public override string ToString()
        {
            return ""+CodeCategorie;
        }
    }
    
}
