namespace CRUD_EF_All_RelationShip
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.traineesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineesBindingSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affectationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traineesToolStripMenuItem,
            this.trainersToolStripMenuItem,
            this.modelsToolStripMenuItem,
            this.groupsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // traineesToolStripMenuItem
            // 
            this.traineesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traineesManagementToolStripMenuItem,
            this.traineesBindingSourceToolStripMenuItem});
            this.traineesToolStripMenuItem.Name = "traineesToolStripMenuItem";
            this.traineesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.traineesToolStripMenuItem.Text = "Trainees";
            // 
            // traineesManagementToolStripMenuItem
            // 
            this.traineesManagementToolStripMenuItem.Name = "traineesManagementToolStripMenuItem";
            this.traineesManagementToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.traineesManagementToolStripMenuItem.Text = "Trainees Management";
            this.traineesManagementToolStripMenuItem.Click += new System.EventHandler(this.traineesManagementToolStripMenuItem_Click);
            // 
            // traineesBindingSourceToolStripMenuItem
            // 
            this.traineesBindingSourceToolStripMenuItem.Name = "traineesBindingSourceToolStripMenuItem";
            this.traineesBindingSourceToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.traineesBindingSourceToolStripMenuItem.Text = "Trainees Binding Source";
            this.traineesBindingSourceToolStripMenuItem.Click += new System.EventHandler(this.traineesBindingSourceToolStripMenuItem_Click);
            // 
            // trainersToolStripMenuItem
            // 
            this.trainersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainersManagementToolStripMenuItem});
            this.trainersToolStripMenuItem.Name = "trainersToolStripMenuItem";
            this.trainersToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.trainersToolStripMenuItem.Text = "Trainers";
            // 
            // trainersManagementToolStripMenuItem
            // 
            this.trainersManagementToolStripMenuItem.Name = "trainersManagementToolStripMenuItem";
            this.trainersManagementToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.trainersManagementToolStripMenuItem.Text = "Trainers Management";
            this.trainersManagementToolStripMenuItem.Click += new System.EventHandler(this.trainersManagementToolStripMenuItem_Click);
            // 
            // modelsToolStripMenuItem
            // 
            this.modelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelsManagementToolStripMenuItem,
            this.affectationToolStripMenuItem});
            this.modelsToolStripMenuItem.Name = "modelsToolStripMenuItem";
            this.modelsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.modelsToolStripMenuItem.Text = "Models";
            // 
            // modelsManagementToolStripMenuItem
            // 
            this.modelsManagementToolStripMenuItem.Name = "modelsManagementToolStripMenuItem";
            this.modelsManagementToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.modelsManagementToolStripMenuItem.Text = "Models Management";
            this.modelsManagementToolStripMenuItem.Click += new System.EventHandler(this.modelsManagementToolStripMenuItem_Click);
            // 
            // affectationToolStripMenuItem
            // 
            this.affectationToolStripMenuItem.Name = "affectationToolStripMenuItem";
            this.affectationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.affectationToolStripMenuItem.Text = "Affectation";
            this.affectationToolStripMenuItem.Click += new System.EventHandler(this.affectationToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupsManagmentToolStripMenuItem});
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.groupsToolStripMenuItem.Text = "Groups";
            // 
            // groupsManagmentToolStripMenuItem
            // 
            this.groupsManagmentToolStripMenuItem.Name = "groupsManagmentToolStripMenuItem";
            this.groupsManagmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupsManagmentToolStripMenuItem.Text = "Groups Managment";
            this.groupsManagmentToolStripMenuItem.Click += new System.EventHandler(this.groupsManagmentToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 344);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainees Management Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem traineesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineesBindingSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainersManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affectationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsManagmentToolStripMenuItem;
    }
}

