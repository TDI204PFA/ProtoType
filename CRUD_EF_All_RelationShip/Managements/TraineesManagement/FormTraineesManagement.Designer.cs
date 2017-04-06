namespace CRUD_EF_All_RelationShip.Managements.TraineesManagement
{
    partial class FormTraineesManagement
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
            this.btn_AddTrainee = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.traineesGrid_UC = new CRUD_EF_All_RelationShip.Managements.TraineesManagement.TraineesGrid_UC();
            this.tabControlTrainees = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabControlTrainees.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddTrainee
            // 
            this.btn_AddTrainee.Location = new System.Drawing.Point(758, 37);
            this.btn_AddTrainee.Name = "btn_AddTrainee";
            this.btn_AddTrainee.Size = new System.Drawing.Size(173, 36);
            this.btn_AddTrainee.TabIndex = 1;
            this.btn_AddTrainee.Text = "Add Trainee";
            this.btn_AddTrainee.UseVisualStyleBackColor = true;
            this.btn_AddTrainee.Click += new System.EventHandler(this.btn_AddTrainee_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.traineesGrid_UC);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(10);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(916, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trainee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // traineesGrid_UC
            // 
            this.traineesGrid_UC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.traineesGrid_UC.Location = new System.Drawing.Point(3, 3);
            this.traineesGrid_UC.Name = "traineesGrid_UC";
            this.traineesGrid_UC.Size = new System.Drawing.Size(910, 328);
            this.traineesGrid_UC.TabIndex = 0;
            // 
            // tabControlTrainees
            // 
            this.tabControlTrainees.Controls.Add(this.tabPage1);
            this.tabControlTrainees.Location = new System.Drawing.Point(7, 79);
            this.tabControlTrainees.Name = "tabControlTrainees";
            this.tabControlTrainees.SelectedIndex = 0;
            this.tabControlTrainees.Size = new System.Drawing.Size(924, 360);
            this.tabControlTrainees.TabIndex = 0;
            // 
            // FormTraineesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 460);
            this.Controls.Add(this.btn_AddTrainee);
            this.Controls.Add(this.tabControlTrainees);
            this.Name = "FormTraineesManagement";
            this.Text = "FormTraineesManagement";
            this.Load += new System.EventHandler(this.FormTraineesManagement_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabControlTrainees.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddTrainee;
        private System.Windows.Forms.TabPage tabPage1;
        private TraineesGrid_UC traineesGrid_UC;
        private System.Windows.Forms.TabControl tabControlTrainees;
    }
}