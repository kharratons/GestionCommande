using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL1
{
    public class Article
    {

        private int codeArticle;
        private string disgnation;
        private double prix;

        private Categorie codecateg;

        public Article(int codeArticle, string disgnation, double prix, Categorie codecateg)
        {
            this.codeArticle = codeArticle;
            this.disgnation = disgnation;
            this.prix = prix;
            this.codecateg = codecateg;
        }
        public Article()
        {
      
        }

        public int CodeArticle { get => codeArticle; set => codeArticle = value; }
        public string Disgnation { get => disgnation; set => disgnation = value; }
        public double Prix { get => prix; set => prix = value; }

        public Categorie Codecateg { get => codecateg; set => codecateg = value; }

       


    }
}
