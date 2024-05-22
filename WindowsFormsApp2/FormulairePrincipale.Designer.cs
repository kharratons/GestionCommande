namespace WindowsFormsApp2
{
    partial class FormulairePrincipale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBut = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCommande = new System.Windows.Forms.Button();
            this.btnArticle = new System.Windows.Forms.Button();
            this.btnCategorie = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAfficher = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pnlBut);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnCommande);
            this.panel1.Controls.Add(this.btnArticle);
            this.panel1.Controls.Add(this.btnCategorie);
            this.panel1.Controls.Add(this.btnclient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 900);
            this.panel1.TabIndex = 0;
            // 
            // pnlBut
            // 
            this.pnlBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlBut.Location = new System.Drawing.Point(0, 186);
            this.pnlBut.Name = "pnlBut";
            this.pnlBut.Size = new System.Drawing.Size(16, 64);
            this.pnlBut.TabIndex = 4;
            this.pnlBut.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::WindowsFormsApp2.Properties.Resources.Menu_32;
            this.button3.Location = new System.Drawing.Point(183, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 39);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnCommande
            // 
            this.btnCommande.FlatAppearance.BorderSize = 0;
            this.btnCommande.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommande.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommande.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCommande.Image = global::WindowsFormsApp2.Properties.Resources.shopping_icon;
            this.btnCommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommande.Location = new System.Drawing.Point(12, 795);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(289, 51);
            this.btnCommande.TabIndex = 7;
            this.btnCommande.Text = "     Commande";
            this.btnCommande.UseVisualStyleBackColor = true;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            // 
            // btnArticle
            // 
            this.btnArticle.FlatAppearance.BorderSize = 0;
            this.btnArticle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnArticle.Image = global::WindowsFormsApp2.Properties.Resources.shop_cart_add_icon;
            this.btnArticle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticle.Location = new System.Drawing.Point(12, 612);
            this.btnArticle.Name = "btnArticle";
            this.btnArticle.Size = new System.Drawing.Size(289, 51);
            this.btnArticle.TabIndex = 6;
            this.btnArticle.Text = "     Article";
            this.btnArticle.UseVisualStyleBackColor = true;
            this.btnArticle.Click += new System.EventHandler(this.btnArticle_Click);
            // 
            // btnCategorie
            // 
            this.btnCategorie.FlatAppearance.BorderSize = 0;
            this.btnCategorie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorie.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCategorie.Image = global::WindowsFormsApp2.Properties.Resources.Categorie;
            this.btnCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorie.Location = new System.Drawing.Point(12, 384);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Size = new System.Drawing.Size(289, 51);
            this.btnCategorie.TabIndex = 5;
            this.btnCategorie.Text = "      Categorie";
            this.btnCategorie.UseVisualStyleBackColor = true;
            this.btnCategorie.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnclient
            // 
            this.btnclient.FlatAppearance.BorderSize = 0;
            this.btnclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclient.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclient.Image = global::WindowsFormsApp2.Properties.Resources.Office_Client_Male_Light_icon;
            this.btnclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclient.Location = new System.Drawing.Point(12, 193);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(289, 51);
            this.btnclient.TabIndex = 4;
            this.btnclient.Text = "     Client";
            this.btnclient.UseVisualStyleBackColor = true;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(229, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 16);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(229, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 62);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::WindowsFormsApp2.Properties.Resources.Subtract_32;
            this.button2.Location = new System.Drawing.Point(970, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 39);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp2.Properties.Resources.Shutdown_32;
            this.button1.Location = new System.Drawing.Point(1012, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 39);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelAfficher
            // 
            this.panelAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAfficher.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelAfficher.Location = new System.Drawing.Point(306, 77);
            this.panelAfficher.Name = "panelAfficher";
            this.panelAfficher.Size = new System.Drawing.Size(982, 823);
            this.panelAfficher.TabIndex = 2;
            this.panelAfficher.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // FormulairePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 900);
            this.Controls.Add(this.panelAfficher);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormulairePrincipale";
            this.Text = "FormulairePrincipale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormulairePrincipale_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Button btnCommande;
        private System.Windows.Forms.Button btnArticle;
        private System.Windows.Forms.Button btnCategorie;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlBut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelAfficher;
    }
}