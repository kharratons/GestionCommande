namespace WindowsFormsApp2
{
    partial class UserControlClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label codeClientLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label téléphoneLabel;
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseTextBox = new System.Windows.Forms.TextBox();
            this.codeClientTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.téléphoneTextBox = new System.Windows.Forms.TextBox();
            adresseLabel = new System.Windows.Forms.Label();
            codeClientLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            téléphoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.btnAjouter.Location = new System.Drawing.Point(844, 119);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(312, 64);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
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
            this.btnModifier.Location = new System.Drawing.Point(844, 198);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(312, 64);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
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
            this.btnSupprimer.Location = new System.Drawing.Point(844, 277);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(312, 64);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
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
            this.btnNouveau.Location = new System.Drawing.Point(844, 39);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(312, 64);
            this.btnNouveau.TabIndex = 3;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(MODEL1.Client);
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.clientDataGridView.DataSource = this.clientBindingSource;
            this.clientDataGridView.EnableHeadersVisualStyles = false;
            this.clientDataGridView.Location = new System.Drawing.Point(3, 368);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.RowHeadersWidth = 51;
            this.clientDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.clientDataGridView.RowTemplate.Height = 24;
            this.clientDataGridView.Size = new System.Drawing.Size(1157, 276);
            this.clientDataGridView.TabIndex = 5;
            this.clientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodeClient";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodeClient";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Adresse";
            this.dataGridViewTextBoxColumn4.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Téléphone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Téléphone";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adresseLabel.Location = new System.Drawing.Point(77, 103);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(84, 20);
            adresseLabel.TabIndex = 6;
            adresseLabel.Text = "Adresse:";
            // 
            // adresseTextBox
            // 
            this.adresseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Adresse", true));
            this.adresseTextBox.Location = new System.Drawing.Point(243, 101);
            this.adresseTextBox.Name = "adresseTextBox";
            this.adresseTextBox.Size = new System.Drawing.Size(330, 22);
            this.adresseTextBox.TabIndex = 7;
            // 
            // codeClientLabel
            // 
            codeClientLabel.AutoSize = true;
            codeClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codeClientLabel.Location = new System.Drawing.Point(77, 131);
            codeClientLabel.Name = "codeClientLabel";
            codeClientLabel.Size = new System.Drawing.Size(113, 20);
            codeClientLabel.TabIndex = 8;
            codeClientLabel.Text = "Code Client:";
            // 
            // codeClientTextBox
            // 
            this.codeClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CodeClient", true));
            this.codeClientTextBox.Location = new System.Drawing.Point(243, 131);
            this.codeClientTextBox.Name = "codeClientTextBox";
            this.codeClientTextBox.Size = new System.Drawing.Size(330, 22);
            this.codeClientTextBox.TabIndex = 9;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(77, 159);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(62, 20);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(243, 159);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(330, 22);
            this.emailTextBox.TabIndex = 11;
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.Location = new System.Drawing.Point(77, 187);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(53, 20);
            nomLabel.TabIndex = 12;
            nomLabel.Text = "Nom:";
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(243, 187);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(330, 22);
            this.nomTextBox.TabIndex = 13;
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.Location = new System.Drawing.Point(77, 215);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(79, 20);
            prenomLabel.TabIndex = 14;
            prenomLabel.Text = "Prenom:";
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(243, 213);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(330, 22);
            this.prenomTextBox.TabIndex = 15;
            // 
            // téléphoneLabel
            // 
            téléphoneLabel.AutoSize = true;
            téléphoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            téléphoneLabel.Location = new System.Drawing.Point(77, 243);
            téléphoneLabel.Name = "téléphoneLabel";
            téléphoneLabel.Size = new System.Drawing.Size(101, 20);
            téléphoneLabel.TabIndex = 16;
            téléphoneLabel.Text = "Téléphone:";
            // 
            // téléphoneTextBox
            // 
            this.téléphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Téléphone", true));
            this.téléphoneTextBox.Location = new System.Drawing.Point(243, 240);
            this.téléphoneTextBox.Name = "téléphoneTextBox";
            this.téléphoneTextBox.Size = new System.Drawing.Size(330, 22);
            this.téléphoneTextBox.TabIndex = 17;
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(adresseLabel);
            this.Controls.Add(this.adresseTextBox);
            this.Controls.Add(codeClientLabel);
            this.Controls.Add(this.codeClientTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(téléphoneLabel);
            this.Controls.Add(this.téléphoneTextBox);
            this.Controls.Add(this.clientDataGridView);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(1163, 720);
            this.Load += new System.EventHandler(this.UserControlClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox adresseTextBox;
        private System.Windows.Forms.TextBox codeClientTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox téléphoneTextBox;
    }
}
