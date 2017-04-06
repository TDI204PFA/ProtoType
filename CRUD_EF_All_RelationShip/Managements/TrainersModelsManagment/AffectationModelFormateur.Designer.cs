namespace CRUD_EF_All_RelationShip.Managements.TrainersModelsManagment
{
    partial class AffectationModelFormateur
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
            this.cbTrainers = new System.Windows.Forms.ComboBox();
            this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.traineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listModels = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTrainers
            // 
            this.cbTrainers.DataSource = this.trainerBindingSource;
            this.cbTrainers.DisplayMember = "lastName";
            this.cbTrainers.FormattingEnabled = true;
            this.cbTrainers.Location = new System.Drawing.Point(184, 33);
            this.cbTrainers.Name = "cbTrainers";
            this.cbTrainers.Size = new System.Drawing.Size(121, 21);
            this.cbTrainers.TabIndex = 0;
            this.cbTrainers.ValueMember = "id";
            this.cbTrainers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // trainerBindingSource
            // 
            this.trainerBindingSource.DataSource = typeof(CRUD_EF_All_RelationShip.Entitys.Trainer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trainer";
            // 
            // traineeBindingSource
            // 
            this.traineeBindingSource.DataSource = typeof(CRUD_EF_All_RelationShip.Entitys.Trainee);
            // 
            // listModels
            // 
            this.listModels.AllowUserToAddRows = false;
            this.listModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name,
            this.Description,
            this.Check});
            this.listModels.Location = new System.Drawing.Point(12, 112);
            this.listModels.Name = "listModels";
            this.listModels.Size = new System.Drawing.Size(673, 259);
            this.listModels.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Check
            // 
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataSource = typeof(CRUD_EF_All_RelationShip.Entitys.Models);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(586, 40);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // AffectationModelFormateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 427);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.listModels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTrainers);
            this.Text = "AffectationModelFormateur";
            this.Load += new System.EventHandler(this.AffectationModelFormateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTrainers;
        private System.Windows.Forms.BindingSource traineeBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listModels;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private System.Windows.Forms.BindingSource trainerBindingSource;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
    }
}