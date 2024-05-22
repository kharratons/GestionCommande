namespace WindowsFormsApp2
{
    partial class UserControlArticle
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
            System.Windows.Forms.Label disgnationLabel;
            System.Windows.Forms.Label prixLabel;
            System.Windows.Forms.Label codecategLabel;
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disgnationTextBox = new System.Windows.Forms.TextBox();
            this.prixTextBox = new System.Windows.Forms.TextBox();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codecategComboBox = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            disgnationLabel = new System.Windows.Forms.Label();
            prixLabel = new System.Windows.Forms.Label();
            codecategLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // disgnationLabel
            // 
            disgnationLabel.AutoSize = true;
            disgnationLabel.Location = new System.Drawing.Point(130, 164);
            disgnationLabel.Name = "disgnationLabel";
            disgnationLabel.Size = new System.Drawing.Size(74, 16);
            disgnationLabel.TabIndex = 10;
            disgnationLabel.Text = "Disgnation:";
            // 
            // prixLabel
            // 
            prixLabel.AutoSize = true;
            prixLabel.Location = new System.Drawing.Point(130, 192);
            prixLabel.Name = "prixLabel";
            prixLabel.Size = new System.Drawing.Size(32, 16);
            prixLabel.TabIndex = 12;
            prixLabel.Text = "Prix:";
            // 
            // codecategLabel
            // 
            codecategLabel.AutoSize = true;
            codecategLabel.Location = new System.Drawing.Point(116, 240);
            codecategLabel.Name = "codecategLabel";
            codecategLabel.Size = new System.Drawing.Size(77, 16);
            codecategLabel.TabIndex = 13;
            codecategLabel.Text = "Codecateg:";
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
            this.btnNouveau.Location = new System.Drawing.Point(744, 73);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(312, 64);
            this.btnNouveau.TabIndex = 7;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimer.Image = global::WindowsFormsApp2.Properties.Resources.Close_2_icon;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(744, 311);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(312, 64);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.Image = global::WindowsFormsApp2.Properties.Resources.Recycle_iconaaa;
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(744, 232);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(312, 64);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(MODEL1.Article);
            // 
            // articleDataGridView
            // 
            this.articleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articleDataGridView.AutoGenerateColumns = false;
            this.articleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.articleDataGridView.DataSource = this.articleBindingSource;
            this.articleDataGridView.Location = new System.Drawing.Point(3, 962);
            this.articleDataGridView.Name = "articleDataGridView";
            this.articleDataGridView.RowHeadersWidth = 51;
            this.articleDataGridView.RowTemplate.Height = 24;
            this.articleDataGridView.Size = new System.Drawing.Size(1186, 736);
            this.articleDataGridView.TabIndex = 8;
            this.articleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articleDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodeArticle";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodeArticle";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Disgnation";
            this.dataGridViewTextBoxColumn2.HeaderText = "Disgnation";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Codecateg";
            this.dataGridViewTextBoxColumn4.HeaderText = "Codecateg";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // disgnationTextBox
            // 
            this.disgnationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "Disgnation", true));
            this.disgnationTextBox.Location = new System.Drawing.Point(219, 161);
            this.disgnationTextBox.Name = "disgnationTextBox";
            this.disgnationTextBox.Size = new System.Drawing.Size(100, 22);
            this.disgnationTextBox.TabIndex = 11;
            // 
            // prixTextBox
            // 
            this.prixTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "Prix", true));
            this.prixTextBox.Location = new System.Drawing.Point(219, 189);
            this.prixTextBox.Name = "prixTextBox";
            this.prixTextBox.Size = new System.Drawing.Size(100, 22);
            this.prixTextBox.TabIndex = 13;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataSource = typeof(MODEL1.Categorie);
            // 
            // codecategComboBox
            // 
            this.codecategComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "Codecateg", true));
            this.codecategComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.articleBindingSource, "Codecateg", true));
            this.codecategComboBox.DataSource = this.categorieBindingSource;
            this.codecategComboBox.DisplayMember = "Designation";
            this.codecategComboBox.FormattingEnabled = true;
            this.codecategComboBox.Location = new System.Drawing.Point(219, 240);
            this.codecategComboBox.Name = "codecategComboBox";
            this.codecategComboBox.Size = new System.Drawing.Size(121, 24);
            this.codecategComboBox.TabIndex = 14;
            this.codecategComboBox.SelectedIndexChanged += new System.EventHandler(this.codecategComboBox_SelectedIndexChanged);
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
            this.btnAjouter.Location = new System.Drawing.Point(744, 147);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(312, 64);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // UserControlArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(codecategLabel);
            this.Controls.Add(this.codecategComboBox);
            this.Controls.Add(disgnationLabel);
            this.Controls.Add(this.disgnationTextBox);
            this.Controls.Add(prixLabel);
            this.Controls.Add(this.prixTextBox);
            this.Controls.Add(this.articleDataGridView);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Name = "UserControlArticle";
            this.Size = new System.Drawing.Size(1186, 1227);
            this.Load += new System.EventHandler(this.UserControlArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private System.Windows.Forms.DataGridView articleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox disgnationTextBox;
        private System.Windows.Forms.TextBox prixTextBox;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.ComboBox codecategComboBox;
        private System.Windows.Forms.Button btnAjouter;
    }
}
