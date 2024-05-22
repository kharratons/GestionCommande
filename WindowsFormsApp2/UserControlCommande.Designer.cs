namespace WindowsFormsApp2
{
    partial class UserControlCommande
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label quantiteLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label adresseLivLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label adresseLabel;
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligneDeCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.quantiteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleComboBox = new System.Windows.Forms.ComboBox();
            this.adresseLivTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.adresseTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantiteLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            adresseLivLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            adresseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneDeCommandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // quantiteLabel
            // 
            quantiteLabel.AutoSize = true;
            quantiteLabel.Location = new System.Drawing.Point(27, 391);
            quantiteLabel.Name = "quantiteLabel";
            quantiteLabel.Size = new System.Drawing.Size(57, 16);
            quantiteLabel.TabIndex = 8;
            quantiteLabel.Text = "quantite:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 346);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 16);
            label1.TabIndex = 10;
            label1.Text = "Client";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 313);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 16);
            label2.TabIndex = 11;
            label2.Text = "Article";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // adresseLivLabel
            // 
            adresseLivLabel.AutoSize = true;
            adresseLivLabel.Location = new System.Drawing.Point(20, 136);
            adresseLivLabel.Name = "adresseLivLabel";
            adresseLivLabel.Size = new System.Drawing.Size(80, 16);
            adresseLivLabel.TabIndex = 12;
            adresseLivLabel.Text = "adresse Liv:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(20, 165);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(37, 16);
            dateLabel.TabIndex = 14;
            dateLabel.Text = "date:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(20, 192);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(55, 16);
            numeroLabel.TabIndex = 16;
            numeroLabel.Text = "numero:";
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Location = new System.Drawing.Point(20, 254);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(61, 16);
            adresseLabel.TabIndex = 18;
            adresseLabel.Text = "Adresse:";
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnNouveau.FlatAppearance.BorderSize = 0;
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNouveau.Location = new System.Drawing.Point(694, 91);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(312, 64);
            this.btnNouveau.TabIndex = 4;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouter.Image = global::WindowsFormsApp2.Properties.Resources.Actions_list_add_icon;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(694, 170);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(312, 64);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataSource = typeof(MODEL1.Commande);
            // 
            // ligneDeCommandeBindingSource
            // 
            this.ligneDeCommandeBindingSource.DataSource = typeof(MODEL1.LigneDeCommande);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(MODEL1.Client);
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.clientBindingSource;
            this.clientComboBox.DisplayMember = "Prenom";
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(106, 343);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(300, 24);
            this.clientComboBox.TabIndex = 8;
            this.clientComboBox.ValueMember = "CodeClient";
            // 
            // quantiteNumericUpDown
            // 
            this.quantiteNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ligneDeCommandeBindingSource, "quantite", true));
            this.quantiteNumericUpDown.Location = new System.Drawing.Point(106, 385);
            this.quantiteNumericUpDown.Name = "quantiteNumericUpDown";
            this.quantiteNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.quantiteNumericUpDown.TabIndex = 9;
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(MODEL1.Article);
            // 
            // articleComboBox
            // 
            this.articleComboBox.DataSource = this.articleBindingSource;
            this.articleComboBox.DisplayMember = "Disgnation";
            this.articleComboBox.FormattingEnabled = true;
            this.articleComboBox.Location = new System.Drawing.Point(106, 313);
            this.articleComboBox.Name = "articleComboBox";
            this.articleComboBox.Size = new System.Drawing.Size(300, 24);
            this.articleComboBox.TabIndex = 10;
            this.articleComboBox.ValueMember = "CodeArticle";
            // 
            // adresseLivTextBox
            // 
            this.adresseLivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commandeBindingSource, "adresseLiv", true));
            this.adresseLivTextBox.Location = new System.Drawing.Point(106, 133);
            this.adresseLivTextBox.Name = "adresseLivTextBox";
            this.adresseLivTextBox.Size = new System.Drawing.Size(200, 22);
            this.adresseLivTextBox.TabIndex = 13;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.commandeBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(106, 161);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateDateTimePicker.TabIndex = 15;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commandeBindingSource, "numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(106, 189);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(200, 22);
            this.numeroTextBox.TabIndex = 17;
            // 
            // adresseTextBox
            // 
            this.adresseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commandeBindingSource, "codeclt.Adresse", true));
            this.adresseTextBox.Location = new System.Drawing.Point(105, 251);
            this.adresseTextBox.Name = "adresseTextBox";
            this.adresseTextBox.Size = new System.Drawing.Size(100, 22);
            this.adresseTextBox.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeArticle,
            this.descriptionArticle,
            this.quantite});
            this.dataGridView1.Location = new System.Drawing.Point(30, 502);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 150);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codeArticle
            // 
            this.codeArticle.HeaderText = "code article";
            this.codeArticle.MinimumWidth = 6;
            this.codeArticle.Name = "codeArticle";
            this.codeArticle.Width = 125;
            // 
            // descriptionArticle
            // 
            this.descriptionArticle.HeaderText = "description article";
            this.descriptionArticle.MinimumWidth = 6;
            this.descriptionArticle.Name = "descriptionArticle";
            this.descriptionArticle.Width = 125;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "quantite";
            this.quantite.MinimumWidth = 6;
            this.quantite.Name = "quantite";
            this.quantite.Width = 125;
            // 
            // UserControlCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(adresseLabel);
            this.Controls.Add(this.adresseTextBox);
            this.Controls.Add(adresseLivLabel);
            this.Controls.Add(this.adresseLivTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.articleComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(quantiteLabel);
            this.Controls.Add(this.quantiteNumericUpDown);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnNouveau);
            this.Name = "UserControlCommande";
            this.Size = new System.Drawing.Size(1163, 735);
            this.Load += new System.EventHandler(this.UserControlCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneDeCommandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private System.Windows.Forms.BindingSource ligneDeCommandeBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.NumericUpDown quantiteNumericUpDown;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private System.Windows.Forms.ComboBox articleComboBox;
        private System.Windows.Forms.TextBox adresseLivTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox adresseTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
    }
}
