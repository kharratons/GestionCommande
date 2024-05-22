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
    public partial class UserControlClient : UserControl
    {
        private static UserControlClient    UserClient;
        public static UserControlClient Instance {
            get { 
            { if (UserClient == null) 
                { UserClient = new UserControlClient(); } 
            }
                return UserClient; }
        }
        public UserControlClient()
        {
            InitializeComponent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Client client = (Client)clientBindingSource.Current;
            ClientADO clientADO = new ClientADO();
            clientADO.DeleteClient(client.CodeClient);
            clientBindingSource.Remove(client);
            clientDataGridView.Refresh();
        }

        private void UserControlClient_Load(object sender, EventArgs e)
        {
            ClientADO ad = new ClientADO();
            ad.Listclient();
            clientBindingSource.DataSource = ad.Listeclt;
        }

        private void clientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Client client = (Client)clientBindingSource.Current;
            if (client != null)
            {
                ClientADO ad = new ClientADO();
                ad.SaveClient(client);

                MessageBox.Show("Client enregistré avec succès !");
            }
            else
            {
                MessageBox.Show("Aucun client n'est sélectionné.");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Client client = (Client)clientBindingSource.Current;
            ClientADO clientADO = new ClientADO();

            clientADO.UpdateClient(client);
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
        }
    }
}
