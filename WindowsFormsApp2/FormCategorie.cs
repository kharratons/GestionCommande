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
    public partial class FormCategorie : Form
    {
        public FormCategorie()
        {
            InitializeComponent();
        }
        //affichage
        private void FormCategorie_Load(object sender, EventArgs e)
        {
           
        }
        //enregister
        private void button1_Click(object sender, EventArgs e)
        {
            Categorie categorie = (Categorie)categorieBindingSource.Current;
            if (categorie != null)
            {
                CategorieADO categorieADO = new CategorieADO();
                categorieADO.SaveCategorie(categorie);
                MessageBox.Show("Catégorie enregistrée avec succès !");
            }
            else
            {
                MessageBox.Show("Aucune catégorie n'est sélectionnée.");
            }
        }

        private void categorieDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            
      
          
            Categorie categorie = (Categorie)categorieBindingSource.Current;
            CategorieADO categorieADO = new CategorieADO();
            categorieADO.DeleteCategorie(categorie.CodeCategorie);
            categorieBindingSource.Remove(categorie);
            categorieDataGridView.Refresh();
        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            Categorie categorie = (Categorie)categorieBindingSource.Current;
            CategorieADO categorieADO = new CategorieADO();
            // Mettre à jour la catégorie
            categorieADO.UpdateCategorie(categorie);
        }
        //nouveau
        private void button4_Click(object sender, EventArgs e)
        {
            categorieBindingSource.AddNew();
        }

        private void FormCategorie_Load_1(object sender, EventArgs e)
        {
            CategorieADO ad = new CategorieADO();
            ad.ListCategories();
            categorieBindingSource.DataSource = ad.categories;
        }
    }
}
