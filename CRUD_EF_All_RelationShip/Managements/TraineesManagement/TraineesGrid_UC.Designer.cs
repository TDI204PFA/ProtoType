namespace CRUD_EF_All_RelationShip.Managements.TraineesManagement
{
    partial class TraineesGrid_UC
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
            this.dataGridViewTrainees = new System.Windows.Forms.DataGridView();
            this.Edite = new System.Windows.Forms.DataGridViewImageColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.traineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrainees
            // 
            this.dataGridViewTrainees.AllowUserToAddRows = false;
            this.dataGridViewTrainees.AllowUserToDeleteRows = false;
            this.dataGridViewTrainees.AutoGenerateColumns = false;
            this.dataGridViewTrainees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edite,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.Delete});
            this.dataGridViewTrainees.DataSource = this.traineeBindingSource;
            this.dataGridViewTrainees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrainees.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTrainees.Name = "dataGridViewTrainees";
            this.dataGridViewTrainees.ReadOnly = true;
            this.dataGridViewTrainees.Size = new System.Drawing.Size(833, 398);
            this.dataGridViewTrainees.TabIndex = 0;
            this.dataGridViewTrainees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrainees_CellClick);
            // 
            // Edite
            // 
            this.Edite.HeaderText = "";
            this.Edite.Image = global::CRUD_EF_All_RelationShip.Properties.Resources.edit_bleu;
            this.Edite.Name = "Edite";
            this.Edite.ReadOnly = true;
            this.Edite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edite.Width = 20;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::CRUD_EF_All_RelationShip.Properties.Resources.delete;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 20;
            // 
            // traineeBindingSource
            // 
            this.traineeBindingSource.DataSource = typeof(CRUD_EF_All_RelationShip.Entitys.Trainee);
            // 
            // TraineesGrid_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewTrainees);
            this.Name = "TraineesGrid_UC";
            this.Size = new System.Drawing.Size(833, 398);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrainees;
        private System.Windows.Forms.BindingSource traineeBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn Edite;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
