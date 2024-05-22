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
    public partial class UserControlCommande : UserControl
    {
        private static UserControlCommande UserCommande;
        public static UserControlCommande Instance
        {
            get
            {
                {
                    if (UserCommande == null)
                    { UserCommande = new UserControlCommande(); }
                }
                return UserCommande;
            }
            }
        public UserControlCommande()
        {
            InitializeComponent();
        }

        public void LoadDataGridView()
        {

        }

        private void UserControlCommande_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ligneDeCommandeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
