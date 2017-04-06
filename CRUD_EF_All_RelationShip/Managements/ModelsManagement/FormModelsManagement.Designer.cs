namespace CRUD_EF_All_RelationShip.Managements.ModelsManagement
{
    partial class FormModelsManagement
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
            this.tabControlModels = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.modelsGrid_UC1 = new CRUD_EF_All_RelationShip.Managements.ModelsManagement.ModelsGrid_UC();
            this.btn_AddModel = new System.Windows.Forms.Button();
            this.tabControlModels.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlModels
            // 
            this.tabControlModels.Controls.Add(this.tabPage1);
            this.tabControlModels.Location = new System.Drawing.Point(2, 215);
            this.tabControlModels.Name = "tabControlModels";
            this.tabControlModels.SelectedIndex = 0;
            this.tabControlModels.Size = new System.Drawing.Size(924, 360);
            this.tabControlModels.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.modelsGrid_UC1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(10);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(916, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Models";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // modelsGrid_UC1
            // 
            this.modelsGrid_UC1.Location = new System.Drawing.Point(0, 3);
            this.modelsGrid_UC1.ms = null;
            this.modelsGrid_UC1.Name = "modelsGrid_UC1";
            this.modelsGrid_UC1.Size = new System.Drawing.Size(913, 328);
            this.modelsGrid_UC1.TabIndex = 0;
            // 
            // btn_AddModel
            // 
            this.btn_AddModel.Location = new System.Drawing.Point(726, 105);
            this.btn_AddModel.Name = "btn_AddModel";
            this.btn_AddModel.Size = new System.Drawing.Size(173, 36);
            this.btn_AddModel.TabIndex = 2;
            this.btn_AddModel.Text = "Add Model";
            this.btn_AddModel.UseVisualStyleBackColor = true;
            this.btn_AddModel.Click += new System.EventHandler(this.btn_AddModel_Click);
            // 
            // FormModelsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 585);
            this.Controls.Add(this.btn_AddModel);
            this.Controls.Add(this.tabControlModels);
            this.Name = "FormModelsManagement";
            this.Text = "FormModelsManagement";
            this.Load += new System.EventHandler(this.FormModelsManagement_Load);
            this.tabControlModels.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlModels;
        private System.Windows.Forms.TabPage tabPage1;
        private ModelsGrid_UC modelsGrid_UC1;
        private System.Windows.Forms.Button btn_AddModel;
    }
}