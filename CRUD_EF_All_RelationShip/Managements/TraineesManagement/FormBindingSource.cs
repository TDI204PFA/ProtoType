using CRUD_EF_All_RelationShip.Entitys;
using CRUD_EF_All_RelationShip.Managements.GroupsManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_EF_All_RelationShip.Managements.TraineesManagement
{
    public partial class FormBindingSource : Form
    {
        TraineesServices ts = new TraineesServices();
        GroupsServices gs = new GroupsServices();
        public Model_TraineesManagement dbHome { get; set; }
        public FormBindingSource()
        {
            InitializeComponent();
        }

        private void traineeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ts.Validate();
        }

        private void FormBindingSource_Load(object sender, EventArgs e)
        {
            ts.db = dbHome;
            gs.db = dbHome;
            traineeBindingSource.DataSource = ts.TraineesList();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Trainee t = (Trainee)traineeBindingSource.Current;
            ts.Delete(t.id);
        }
    }
}
