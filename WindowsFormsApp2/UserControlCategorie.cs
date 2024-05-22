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
    public partial class UserControlCategorie : UserControl
    {
        private static UserControlCategorie UserCategorie;
        public static UserControlCategorie Instance
        {
            get
            {
                {
                    if (UserCategorie == null)
                    { UserCategorie = new UserControlCategorie(); }
                }
                return UserCategorie;
            }
        }
        public UserControlCategorie()
        {
            InitializeComponent();
        }

        private void UserControlCategorie_Load(object sender, EventArgs e)
        {
            CategorieADO ad = new CategorieADO();
            ad.ListCategories();
            categorieBindingSource.DataSource = ad.categories;
            categorieDataGridView.Refresh();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Categorie categorie = (Categorie)categorieBindingSource.Current;
            CategorieADO categorieADO = new CategorieADO();
            // Mettre à jour la catégorie
            categorieADO.UpdateCategorie(categorie);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Categorie categorie = (Categorie)categorieBindingSource.Current;
            CategorieADO categorieADO = new CategorieADO();
            categorieADO.DeleteCategorie(categorie.CodeCategorie);
            categorieBindingSource.Remove(categorie);
            categorieDataGridView.Refresh();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            categorieBindingSource.AddNew();
        }
    }
}
