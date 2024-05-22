namespace WindowsFormsApp2
{
    partial class FormArtcile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArtcile));
            System.Windows.Forms.Label codeArticleLabel;
            System.Windows.Forms.Label disgnationLabel;
            System.Windows.Forms.Label prixLabel;
            System.Windows.Forms.Label codeCategorieLabel;
            System.Windows.Forms.Label designationLabel;
            this.articleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.articleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.articleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeArticleTextBox = new System.Windows.Forms.TextBox();
            this.disgnationTextBox = new System.Windows.Forms.TextBox();
            this.prixTextBox = new System.Windows.Forms.TextBox();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categorieComboBox = new System.Windows.Forms.ComboBox();
            codeArticleLabel = new System.Windows.Forms.Label();
            disgnationLabel = new System.Windows.Forms.Label();
            prixLabel = new System.Windows.Forms.Label();
            codeCategorieLabel = new System.Windows.Forms.Label();
            designationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingNavigator)).BeginInit();
            this.articleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // articleBindingNavigator
            // 
            this.articleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.articleBindingNavigator.BindingSource = this.articleBindingSource;
            this.articleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.articleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.articleBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.articleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.articleBindingNavigatorSaveItem});
            this.articleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.articleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.articleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.articleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.articleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.articleBindingNavigator.Name = "articleBindingNavigator";
            this.articleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.articleBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.articleBindingNavigator.TabIndex = 0;
            this.articleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // articleBindingNavigatorSaveItem
            // 
            this.articleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.articleBindingNavigatorSaveItem.Enabled = false;
            this.articleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("articleBindingNavigatorSaveItem.Image")));
            this.articleBindingNavigatorSaveItem.Name = "articleBindingNavigatorSaveItem";
            this.articleBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.articleBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // articleDataGridView
            // 
            this.articleDataGridView.AutoGenerateColumns = false;
            this.articleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.articleDataGridView.DataSource = this.articleBindingSource;
            this.articleDataGridView.Location = new System.Drawing.Point(198, 237);
            this.articleDataGridView.Name = "articleDataGridView";
            this.articleDataGridView.RowHeadersWidth = 51;
            this.articleDataGridView.RowTemplate.Height = 24;
            this.articleDataGridView.Size = new System.Drawing.Size(300, 220);
            this.articleDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codeArticle";
            this.dataGridViewTextBoxColumn1.HeaderText = "codeArticle";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "disgnation";
            this.dataGridViewTextBoxColumn2.HeaderText = "disgnation";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prix";
            this.dataGridViewTextBoxColumn3.HeaderText = "prix";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codecateg";
            this.dataGridViewTextBoxColumn4.HeaderText = "codecateg";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(MODEL1.Article);
            // 
            // codeArticleLabel
            // 
            codeArticleLabel.AutoSize = true;
            codeArticleLabel.Location = new System.Drawing.Point(19, 54);
            codeArticleLabel.Name = "codeArticleLabel";
            codeArticleLabel.Size = new System.Drawing.Size(81, 16);
            codeArticleLabel.TabIndex = 2;
            codeArticleLabel.Text = "code Article:";
            // 
            // codeArticleTextBox
            // 
            this.codeArticleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "codeArticle", true));
            this.codeArticleTextBox.Location = new System.Drawing.Point(106, 51);
            this.codeArticleTextBox.Name = "codeArticleTextBox";
            this.codeArticleTextBox.Size = new System.Drawing.Size(100, 22);
            this.codeArticleTextBox.TabIndex = 3;
            // 
            // disgnationLabel
            // 
            disgnationLabel.AutoSize = true;
            disgnationLabel.Location = new System.Drawing.Point(19, 82);
            disgnationLabel.Name = "disgnationLabel";
            disgnationLabel.Size = new System.Drawing.Size(72, 16);
            disgnationLabel.TabIndex = 4;
            disgnationLabel.Text = "disgnation:";
            // 
            // disgnationTextBox
            // 
            this.disgnationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "disgnation", true));
            this.disgnationTextBox.Location = new System.Drawing.Point(106, 79);
            this.disgnationTextBox.Name = "disgnationTextBox";
            this.disgnationTextBox.Size = new System.Drawing.Size(100, 22);
            this.disgnationTextBox.TabIndex = 5;
            // 
            // prixLabel
            // 
            prixLabel.AutoSize = true;
            prixLabel.Location = new System.Drawing.Point(19, 110);
            prixLabel.Name = "prixLabel";
            prixLabel.Size = new System.Drawing.Size(31, 16);
            prixLabel.TabIndex = 6;
            prixLabel.Text = "prix:";
            // 
            // prixTextBox
            // 
            this.prixTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "prix", true));
            this.prixTextBox.Location = new System.Drawing.Point(106, 107);
            this.prixTextBox.Name = "prixTextBox";
            this.prixTextBox.Size = new System.Drawing.Size(100, 22);
            this.prixTextBox.TabIndex = 7;
            // 
            // codeCategorieLabel
            // 
            codeCategorieLabel.AutoSize = true;
            codeCategorieLabel.Location = new System.Drawing.Point(12, 141);
            codeCategorieLabel.Name = "codeCategorieLabel";
            codeCategorieLabel.Size = new System.Drawing.Size(105, 16);
            codeCategorieLabel.TabIndex = 8;
            codeCategorieLabel.Text = "Code Categorie:";
            codeCategorieLabel.Click += new System.EventHandler(this.codeCategorieLabel_Click);
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Location = new System.Drawing.Point(18, 183);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new System.Drawing.Size(82, 16);
            designationLabel.TabIndex = 10;
            designationLabel.Text = "Designation:";
            // 
            // designationTextBox
            // 
            this.designationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "codecateg.Designation", true));
            this.designationTextBox.Location = new System.Drawing.Point(130, 168);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(100, 22);
            this.designationTextBox.TabIndex = 11;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataSource = typeof(MODEL1.Categorie);
            // 
            // categorieBindingSource1
            // 
            this.categorieBindingSource1.DataSource = typeof(MODEL1.Categorie);
            // 
            // categorieComboBox
            // 
            this.categorieComboBox.DataSource = this.categorieBindingSource1;
            this.categorieComboBox.DisplayMember = "Designation";
            this.categorieComboBox.FormattingEnabled = true;
            this.categorieComboBox.Location = new System.Drawing.Point(130, 138);
            this.categorieComboBox.Name = "categorieComboBox";
            this.categorieComboBox.Size = new System.Drawing.Size(300, 24);
            this.categorieComboBox.TabIndex = 12;
            this.categorieComboBox.ValueMember = "CodeCategorie";
            // 
            // FormArtcile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.categorieComboBox);
            this.Controls.Add(codeCategorieLabel);
            this.Controls.Add(designationLabel);
            this.Controls.Add(this.designationTextBox);
            this.Controls.Add(codeArticleLabel);
            this.Controls.Add(this.codeArticleTextBox);
            this.Controls.Add(disgnationLabel);
            this.Controls.Add(this.disgnationTextBox);
            this.Controls.Add(prixLabel);
            this.Controls.Add(this.prixTextBox);
            this.Controls.Add(this.articleDataGridView);
            this.Controls.Add(this.articleBindingNavigator);
            this.Name = "FormArtcile";
            this.Text = "FormArtcile";
            this.Load += new System.EventHandler(this.FormArtcile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingNavigator)).EndInit();
            this.articleBindingNavigator.ResumeLayout(false);
            this.articleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource articleBindingSource;
        private System.Windows.Forms.BindingNavigator articleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton articleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView articleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox codeArticleTextBox;
        private System.Windows.Forms.TextBox disgnationTextBox;
        private System.Windows.Forms.TextBox prixTextBox;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.BindingSource categorieBindingSource1;
        private System.Windows.Forms.ComboBox categorieComboBox;
    }
}