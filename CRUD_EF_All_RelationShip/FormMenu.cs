using CRUD_EF_All_RelationShip.Managements.TraineesManagement;
using CRUD_EF_All_RelationShip.Managements.TrainersManagement;
using CRUD_EF_All_RelationShip.Managements.ModelsManagement;
using CRUD_EF_All_RelationShip.Managements.GroupsManagement;
using CRUD_EF_All_RelationShip.Managements.TrainersModelsManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_EF_All_RelationShip
{
    public partial class FormMenu : Form
    {
        Model_TraineesManagement dbHome;
        public FormMenu()
        {
            InitializeComponent();
            dbHome = new Model_TraineesManagement();
        }
        /// <summary>
        /// Shows a TraineesManagement Form inside The Menu Form:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void traineesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FormTraineesManagement f = new FormTraineesManagement();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.dbHome = dbHome;
            f.Show();
            Cursor.Current = Cursors.Default;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void traineesBindingSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FormBindingSource f = new FormBindingSource();
            f.dbHome = dbHome;
            f.Show();
            Cursor = Cursors.Default;
        }

        private void trainersManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FormTrainersManagement f = new FormTrainersManagement();
            f.dbHome = dbHome;
            f.Show();
            Cursor = Cursors.Default;
        }

        private void modelsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FormModelsManagement f = new FormModelsManagement();
            f.dbHome = dbHome;
            f.Show();
            Cursor = Cursors.Default;
        }

        private void affectationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AffectationModelFormateur f = new AffectationModelFormateur();
            f.dbHome = dbHome;
            f.Show();
            Cursor = Cursors.Default;
        }

        private void groupsManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
