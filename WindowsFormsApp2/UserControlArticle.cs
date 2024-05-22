using CONTROLLER1;
using MODEL1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UserControlArticle : UserControl
    {
        private static UserControlArticle UserArticle;
        public static UserControlArticle Instance
        {
            get
            {
                {
                    if (UserArticle == null)
                    { UserArticle = new UserControlArticle(); }
                }
                return UserArticle;
            }
        }
        public UserControlArticle()
        {
            InitializeComponent();
        }

        private void UserControlArticle_Load(object sender, EventArgs e)
        {
            ArticleADO ad = new ArticleADO();
            CategorieADO categorie = new CategorieADO();
            categorie.ListCategories();
            ad.ListArticles();
            articleBindingSource.DataSource = ad.articles;
            codecategComboBox.DataSource = categorie.categories;

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Article article = (Article)articleBindingSource.Current;
            ArticleADO articleADO = new ArticleADO();
            articleADO.DeleteArticle(article.CodeArticle);
            articleBindingSource.Remove(article);
            articleDataGridView.Refresh();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Article article = (Article)articleBindingSource.Current;
            article.Codecateg = (Categorie)codecategComboBox.SelectedItem;
            ArticleADO articleADO = new ArticleADO();

            articleADO.UpdateArticle(article);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            Console.WriteLine("testtt2");

            articleBindingSource.AddNew();
            
        }

        private void categorieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void codecategComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            
           Article article = new Article();
          //  article.Codecateg= (Categorie)categorieBindingSource.Current;
            article=(Article)articleBindingSource.Current;


                ArticleADO ad = new ArticleADO();
                ad.SaveArticle(article);
        }

        private void articleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
