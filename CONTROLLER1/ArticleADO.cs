
using MODEL1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLLER1
{
    public class ArticleADO
    {
        public void SaveArticle(Article article)
        {
     
                Connexion CNX = new Connexion();
                CNX.Connecter();
                SqlCommand requete = new SqlCommand();

            SqlParameter disg = new SqlParameter("@disgnation", SqlDbType.VarChar);
            SqlParameter prix = new SqlParameter("@prix", SqlDbType.Float);
            SqlParameter codecatg = new SqlParameter("@codecateg", SqlDbType.Int);

            requete.CommandText = "INSERT INTO Article (disgnation,prix,codecateg) VALUES (@disgnation,@prix,@codecateg)";
                requete.CommandType = CommandType.Text;
            disg.Value = article.Disgnation;
                prix.Value = article.Prix;
                codecatg.Value = article.Codecateg.CodeCategorie;
                requete.Parameters.Add(disg);
                requete.Parameters.Add(prix);
                requete.Parameters.Add(codecatg);

                CNX.ExecuteCommand(requete);
                Console.WriteLine("article ajouter");
                CNX.Deconnecter();
            
           
        }

        public void DeleteArticle(int codeArticle)
        {
            Connexion CNX = new Connexion();
            CNX.Connecter();
            SqlCommand requete = new SqlCommand();

            requete.CommandText = "DELETE FROM Article WHERE codeArticle = @codeArticle";
            requete.CommandType = CommandType.Text;

            requete.Parameters.AddWithValue("@codeArticle", codeArticle);

            CNX.ExecuteCommand(requete);
            CNX.Deconnecter();
        }

        public void UpdateArticle(Article article)
        {
            Connexion CNX = new Connexion();
            CNX.Connecter();
            SqlCommand requete = new SqlCommand();

            requete.CommandText = "UPDATE Article SET disgnation = @disgnation, prix = @prix, codecateg = @codecateg WHERE codeArticle = @codeArticle";
            requete.CommandType = CommandType.Text;

            requete.Parameters.AddWithValue("@disgnation", article.Disgnation);
            requete.Parameters.AddWithValue("@prix", article.Prix);
            requete.Parameters.AddWithValue("@codecateg", article.Codecateg.CodeCategorie);
            requete.Parameters.AddWithValue("@codeArticle", article.CodeArticle);

            CNX.ExecuteCommand(requete);
            CNX.Deconnecter();
        }

        public List<Article> articles = new List<Article>();
        public void ListArticles()
        {
            CategorieADO catADO = new CategorieADO();
            catADO.ListCategories();

            Connexion CNX = new Connexion();
            CNX.Connecter();
            SqlCommand command = new SqlCommand("SELECT * FROM Article", Connexion.conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Article article = new Article();
                
                article.CodeArticle = (int)reader.GetValue(0);
                article.Disgnation = (string)reader.GetValue(1);
                article.Prix = reader.GetDouble(2); 
                article.Codecateg=(Categorie)catADO.Getccategorie_ById((int)reader["codecateg"]);
                articles.Add(article);

            }

            reader.Close();

            CNX.Deconnecter();
        }

    }
}