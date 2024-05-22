namespace WindowsFormsApp2
{
    partial class UserControlCategorie
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
            System.Windows.Forms.Label designationLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            designationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            designationLabel.Location = new System.Drawing.Point(67, 118);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new System.Drawing.Size(159, 29);
            designationLabel.TabIndex = 14;
            designationLabel.Text = "Designation:";
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
            this.btnNouveau.Location = new System.Drawing.Point(769, 69);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(312, 64);
            this.btnNouveau.TabIndex = 11;
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
            this.btnSupprimer.Location = new System.Drawing.Point(769, 307);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(312, 64);
            this.btnSupprimer.TabIndex = 10;
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
            this.btnModifier.Location = new System.Drawing.Point(769, 228);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(312, 64);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
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
            this.btnAjouter.Location = new System.Drawing.Point(769, 149);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(312, 64);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataSource = typeof(MODEL1.Categorie);
            // 
            // categorieDataGridView
            // 
            this.categorieDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categorieDataGridView.AutoGenerateColumns = false;
            this.categorieDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categorieDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categorieDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categorieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.categorieDataGridView.DataSource = this.categorieBindingSource;
            this.categorieDataGridView.Location = new System.Drawing.Point(0, 412);
            this.categorieDataGridView.Name = "categorieDataGridView";
            this.categorieDataGridView.RowHeadersWidth = 51;
            this.categorieDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.categorieDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.categorieDataGridView.RowTemplate.Height = 24;
            this.categorieDataGridView.Size = new System.Drawing.Size(1157, 276);
            this.categorieDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Designation";
            this.dataGridViewTextBoxColumn1.HeaderText = "Designation";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodeCategorie";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodeCategorie";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // designationTextBox
            // 
            this.designationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categorieBindingSource, "Designation", true));
            this.designationTextBox.Location = new System.Drawing.Point(249, 125);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(400, 22);
            this.designationTextBox.TabIndex = 15;
            // 
            // UserControlCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(designationLabel);
            this.Controls.Add(this.designationTextBox);
            this.Controls.Add(this.categorieDataGridView);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Name = "UserControlCategorie";
            this.Size = new System.Drawing.Size(1163, 720);
            this.Load += new System.EventHandler(this.UserControlCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.DataGridView categorieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox designationTextBox;
    }
}
