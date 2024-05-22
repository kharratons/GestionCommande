using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLLER1;
using MODEL1;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientADO ad=new ClientADO();
            ad.Listclient();
            clientBindingSource.DataSource = ad.Listeclt;
        }
        //enregister
        private void button1_Click(object sender, EventArgs e)
        {
            Client client = (Client)clientBindingSource.Current ;
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
        //nouveau
        private void button2_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
        }

        private void clientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adresseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codeClientLabel_Click(object sender, EventArgs e)
        {

        }

        private void codeClientTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenomLabel_Click(object sender, EventArgs e)
        {

        }

        private void prenomTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void téléphoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void téléphoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            Client client = (Client)clientBindingSource.Current;
            ClientADO clientADO = new ClientADO();
            clientADO.DeleteClient(client.CodeClient);
            clientBindingSource.Remove(client);                             
            clientDataGridView.Refresh();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            Client client = (Client)clientBindingSource.Current;
            ClientADO clientADO = new ClientADO();
           
            clientADO.UpdateClient(client);
        }

        private void adresseLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
