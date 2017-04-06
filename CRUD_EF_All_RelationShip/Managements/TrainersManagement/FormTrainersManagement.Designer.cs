namespace CRUD_EF_All_RelationShip.Managements.TrainersManagement
{
    partial class FormTrainersManagement
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
            this.tabControlTrainers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.trainersGrid_UC1 = new CRUD_EF_All_RelationShip.Managements.TrainersManagement.TrainersGrid_UC();
            this.btn_AddTrainer = new System.Windows.Forms.Button();
            this.tabControlTrainers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTrainers
            // 
            this.tabControlTrainers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlTrainers.Controls.Add(this.tabPage1);
            this.tabControlTrainers.Location = new System.Drawing.Point(12, 125);
            this.tabControlTrainers.Name = "tabControlTrainers";
            this.tabControlTrainers.SelectedIndex = 0;
            this.tabControlTrainers.Size = new System.Drawing.Size(606, 258);
            this.tabControlTrainers.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.trainersGrid_UC1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(598, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trainers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // trainersGrid_UC1
            // 
            this.trainersGrid_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainersGrid_UC1.Location = new System.Drawing.Point(3, 3);
            this.trainersGrid_UC1.MaximumSize = new System.Drawing.Size(500, 500);
            this.trainersGrid_UC1.MinimumSize = new System.Drawing.Size(489, 186);
            this.trainersGrid_UC1.Name = "trainersGrid_UC1";
            this.trainersGrid_UC1.Size = new System.Drawing.Size(500, 226);
            this.trainersGrid_UC1.TabIndex = 0;
            this.trainersGrid_UC1.ts = null;
            // 
            // btn_AddTrainer
            // 
            this.btn_AddTrainer.Location = new System.Drawing.Point(444, 46);
            this.btn_AddTrainer.Name = "btn_AddTrainer";
            this.btn_AddTrainer.Size = new System.Drawing.Size(174, 59);
            this.btn_AddTrainer.TabIndex = 1;
            this.btn_AddTrainer.Text = "Add Trainer";
            this.btn_AddTrainer.UseVisualStyleBackColor = true;
            this.btn_AddTrainer.Click += new System.EventHandler(this.btn_AddTrainer_Click);
            // 
            // FormTrainersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 412);
            this.Controls.Add(this.btn_AddTrainer);
            this.Controls.Add(this.tabControlTrainers);
            this.Name = "FormTrainersManagement";
            this.Text = "FormTrainersManagement";
            this.Load += new System.EventHandler(this.FormTrainersManagement_Load);
            this.tabControlTrainers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTrainers;
        private System.Windows.Forms.TabPage tabPage1;
        private TrainersGrid_UC trainersGrid_UC1;
        private System.Windows.Forms.Button btn_AddTrainer;
    }
}