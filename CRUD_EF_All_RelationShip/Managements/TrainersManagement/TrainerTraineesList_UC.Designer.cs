namespace CRUD_EF_All_RelationShip.Managements.TrainersManagement
{
    partial class TrainerTraineesList_UC
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.traineeAll_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.traineeAll_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.traineeAll_BindingSource;
            this.listBox1.DisplayMember = "firstName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 290);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "id";
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.traineeBindingSource;
            this.listBox2.DisplayMember = "firstName";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(324, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(204, 290);
            this.listBox2.TabIndex = 1;
            this.listBox2.ValueMember = "id";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(243, 127);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(243, 86);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // traineeAll_BindingSource
            // 
            this.traineeAll_BindingSource.DataSource = typeof(CRUD_EF_All_RelationShip.Entitys.Trainee);
            // 
            // traineeBindingSource
            // 
            this.traineeBindingSource.DataSource = typeof(CRUD_EF_All_RelationShip.Entitys.Trainee);
            // 
            // TrainerTraineesList_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "TrainerTraineesList_UC";
            this.Size = new System.Drawing.Size(533, 295);
            this.Load += new System.EventHandler(this.TrainerTraineesList_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.traineeAll_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.BindingSource traineeAll_BindingSource;
        private System.Windows.Forms.BindingSource traineeBindingSource;
    }
}
