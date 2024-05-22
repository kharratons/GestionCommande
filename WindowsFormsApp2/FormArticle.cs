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
    public partial class FormArticle : Form
    {
        public FormArticle()
        {
            InitializeComponent();
        }

        private void disgnationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codeCategorieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codeArticleLabel_Click(object sender, EventArgs e)
        {

        }

        private void codeArticleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codeCategorieLabel_Click(object sender, EventArgs e)
        {

        }

        private void prixLabel_Click(object sender, EventArgs e)
        {

        }

        private void disgnationLabel_Click(object sender, EventArgs e)
        {

        }

        private void prixTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormArticle_Load(object sender, EventArgs e)
        {
           ArticleADO ad = new ArticleADO();
            CategorieADO categorie = new CategorieADO();
            categorie.ListCategories();
            ad.ListArticles();
            articleBindingSource.DataSource = ad.articles;
            categorieComboBox.DataSource=categorie.categories;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Article article = (Article)articleBindingSource.Current;
            ArticleADO articleADO = new ArticleADO();

            articleADO.UpdateArticle(article);
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            articleBindingSource.AddNew();
        }

        private void enregister_Click(object sender, EventArgs e)
        {
            Article article = (Article)articleBindingSource.Current;
            if (article != null)
            {
                ArticleADO ad = new ArticleADO();
                ad.SaveArticle(article);

                MessageBox.Show("article enregistré avec succès !");
            }
            else
            {
                MessageBox.Show("Aucun article n'est sélectionné.");
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            Article article = (Article)articleBindingSource.Current;
            ArticleADO articleADO = new ArticleADO();
            articleADO.DeleteArticle(article.CodeArticle);
            articleBindingSource.Remove(article);
            articleDataGridView.Refresh();
        }

        private void codeCategorieTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void codeCategorieLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void designationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void designationLabel_Click(object sender, EventArgs e)
        {

        }

        private void categorieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
