namespace CRUD_EF_All_RelationShip.Managements.TrainersManagement
{
    partial class TrainersGrid_UC
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
            this.DGV_Trainers = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LB_Trainees = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Trainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Trainers
            // 
            this.DGV_Trainers.AllowUserToAddRows = false;
            this.DGV_Trainers.AllowUserToDeleteRows = false;
            this.DGV_Trainers.AutoGenerateColumns = false;
            this.DGV_Trainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Trainers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.DGV_Trainers.DataSource = this.trainerBindingSource;
            this.DGV_Trainers.Dock = System.Windows.Forms.DockStyle.Left;
            this.DGV_Trainers.Location = new System.Drawing.Point(0, 0);
            this.DGV_Trainers.Name = "DGV_Trainers";
            this.DGV_Trainers.ReadOnly = true;
            this.DGV_Trainers.Size = new System.Drawing.Size(246, 250);
            this.DGV_Trainers.TabIndex = 0;
            this.DGV_Trainers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Trainers_CellClick);
            this.DGV_Trainers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Trainers_CellDoubleClick);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trainerBindingSource
            // 
            this.trainerBindingSource.DataSource = typeof(CRUD_EF_All_RelationShip.Entitys.Trainer);
            // 
            // traineeBindingSource
            // 
            this.traineeBindingSource.DataSource = typeof(CRUD_EF_All_RelationShip.Entitys.Trainee);
            // 
            // LB_Trainees
            // 
            this.LB_Trainees.DataSource = this.traineeBindingSource;
            this.LB_Trainees.DisplayMember = "firstName";
            this.LB_Trainees.Dock = System.Windows.Forms.DockStyle.Right;
            this.LB_Trainees.FormattingEnabled = true;
            this.LB_Trainees.Location = new System.Drawing.Point(258, 0);
            this.LB_Trainees.Name = "LB_Trainees";
            this.LB_Trainees.Size = new System.Drawing.Size(242, 250);
            this.LB_Trainees.TabIndex = 1;
            this.LB_Trainees.ValueMember = "id";
            this.LB_Trainees.DoubleClick += new System.EventHandler(this.LB_Trainees_DoubleClick);
            // 
            // TrainersGrid_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LB_Trainees);
            this.Controls.Add(this.DGV_Trainers);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(489, 186);
            this.Name = "TrainersGrid_UC";
            this.Size = new System.Drawing.Size(500, 250);
            this.Load += new System.EventHandler(this.TrainersGrid_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Trainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Trainers;
        private System.Windows.Forms.BindingSource traineeBindingSource;
        private System.Windows.Forms.BindingSource trainerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox LB_Trainees;
    }
}
