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
    public partial class FormulairePrincipale : Form
    {
        public FormulairePrincipale()
        {
            InitializeComponent();
            panel1.Size = new Size(229, 450);
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            pnlBut.Top=btnCategorie.Top;
            if (!panelAfficher.Controls.Contains(UserControlCategorie.Instance))
            {
                panelAfficher.Controls.Add(UserControlCategorie.Instance);
                UserControlCategorie.Instance.Dock = DockStyle.Fill;
                UserControlCategorie.Instance.BringToFront();
            }
            else { UserControlCategorie.Instance.BringToFront(); }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(panel1.Width==229)
            { panel1.Size = new Size(72, 450); }
            else { panel1.Size = new Size(229, 450); }
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnCommande.Top;
            if (!panelAfficher.Controls.Contains(UserControlCommande.Instance))
            {
                panelAfficher.Controls.Add(UserControlCommande.Instance);
                UserControlCommande.Instance.Dock = DockStyle.Fill;
                UserControlCommande.Instance.BringToFront();
            }
            else { UserControlCommande.Instance.BringToFront(); }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnArticle.Top;
            if (!panelAfficher.Controls.Contains(UserControlArticle.Instance))
            {
                panelAfficher.Controls.Add(UserControlArticle.Instance);
                UserControlArticle.Instance.Dock = DockStyle.Fill;
                UserControlArticle.Instance.BringToFront();
            }
            else { UserControlArticle.Instance.BringToFront(); }

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclient_Click_1(object sender, EventArgs e)
        {
            pnlBut.Top = btnclient.Top;
            //affichier la formulaire client
          //  Form1 form1 = new Form1();
         //   form1.ShowDialog();
            if (!panelAfficher.Controls.Contains(UserControlClient.Instance))
            {
                panelAfficher.Controls.Add(UserControlClient.Instance);
                UserControlClient.Instance.Dock = DockStyle.Fill;
                UserControlClient.Instance.BringToFront();
            }
            else { UserControlClient.Instance.BringToFront(); }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormulairePrincipale_Load(object sender, EventArgs e)
        {

        }
    }
}
