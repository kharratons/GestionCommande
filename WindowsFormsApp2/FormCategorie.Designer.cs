namespace WindowsFormsApp2
{
    partial class FormCategorie
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
            System.Windows.Forms.Label designationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorie));
            this.categorieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.categorieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.categorieDataGridView = new System.Windows.Forms.DataGridView();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            designationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingNavigator)).BeginInit();
            this.categorieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Location = new System.Drawing.Point(182, 133);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new System.Drawing.Size(80, 16);
            designationLabel.TabIndex = 4;
            designationLabel.Text = "designation:";
            // 
            // categorieBindingNavigator
            // 
            this.categorieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categorieBindingNavigator.BindingSource = this.categorieBindingSource;
            this.categorieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categorieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categorieBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.categorieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.categorieBindingNavigatorSaveItem});
            this.categorieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categorieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categorieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categorieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categorieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categorieBindingNavigator.Name = "categorieBindingNavigator";
            this.categorieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categorieBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.categorieBindingNavigator.TabIndex = 0;
            this.categorieBindingNavigator.Text = "bindingNavigator1";
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
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataSource = typeof(MODEL1.Categorie);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // categorieBindingNavigatorSaveItem
            // 
            this.categorieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categorieBindingNavigatorSaveItem.Enabled = false;
            this.categorieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categorieBindingNavigatorSaveItem.Image")));
            this.categorieBindingNavigatorSaveItem.Name = "categorieBindingNavigatorSaveItem";
            this.categorieBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.categorieBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // categorieDataGridView
            // 
            this.categorieDataGridView.AutoGenerateColumns = false;
            this.categorieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.designationDataGridViewTextBoxColumn,
            this.codeCategorieDataGridViewTextBoxColumn});
            this.categorieDataGridView.DataSource = this.categorieBindingSource;
            this.categorieDataGridView.Location = new System.Drawing.Point(165, 259);
            this.categorieDataGridView.Name = "categorieDataGridView";
            this.categorieDataGridView.RowHeadersWidth = 51;
            this.categorieDataGridView.RowTemplate.Height = 24;
            this.categorieDataGridView.Size = new System.Drawing.Size(403, 220);
            this.categorieDataGridView.TabIndex = 1;
            this.categorieDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categorieDataGridView_CellContentClick);
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeCategorieDataGridViewTextBoxColumn
            // 
            this.codeCategorieDataGridViewTextBoxColumn.DataPropertyName = "CodeCategorie";
            this.codeCategorieDataGridViewTextBoxColumn.HeaderText = "CodeCategorie";
            this.codeCategorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeCategorieDataGridViewTextBoxColumn.Name = "codeCategorieDataGridViewTextBoxColumn";
            this.codeCategorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // designationTextBox
            // 
            this.designationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categorieBindingSource, "designation", true));
            this.designationTextBox.Location = new System.Drawing.Point(268, 130);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(100, 22);
            this.designationTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "enregister";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(456, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(456, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "nouveau";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(designationLabel);
            this.Controls.Add(this.designationTextBox);
            this.Controls.Add(this.categorieDataGridView);
            this.Controls.Add(this.categorieBindingNavigator);
            this.Name = "FormCategorie";
            this.Text = "FormCategorie";
            this.Load += new System.EventHandler(this.FormCategorie_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingNavigator)).EndInit();
            this.categorieBindingNavigator.ResumeLayout(false);
            this.categorieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.BindingNavigator categorieBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton categorieBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView categorieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeCategorieDataGridViewTextBoxColumn;
    }
}