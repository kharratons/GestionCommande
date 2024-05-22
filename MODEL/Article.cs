using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Article
    {
     
        public int codeArticle { get; set; }
        public string disgnation { get; set; }
        public decimal prix { get; set; }
        public Categorie codecateg   { get; set; }


        public Article(int codeArticle, string designation, decimal prix, string codecateg)
        {
            codeArticle = codeArticle;
            disgnation = disgnation;
            prix = prix;
            codecateg = codecateg;
        }

       
    }

}
