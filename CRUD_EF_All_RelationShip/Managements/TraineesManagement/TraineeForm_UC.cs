using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_EF_All_RelationShip.Entitys;
using CRUD_EF_All_RelationShip.Managements.GroupsManagement;

namespace CRUD_EF_All_RelationShip.Managements.TraineesManagement
{
    public partial class TraineeForm_UC : UserControl
    {
        public GroupsServices gs { get; set; }
        public TraineeForm_UC()
        {
            InitializeComponent();
        }
        public event EventHandler SaveClick;
        public event EventHandler CancelClick;
        public Trainee Trainee { get; set; }
        public void InitTrainee()
        {
            txt_FirstName.Text = Trainee.firstName;
            txt_LastName.Text = Trainee.lastName;

            if (Trainee.Group != null) CB_Group.SelectedItem = Trainee.Group;
        }
        public void InitCB_Groups()
        {
            CB_Group.DataSource = null;
            CB_Group.DataSource = gs.GroupsList();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Trainee == null) Trainee = new Trainee();
            Trainee.firstName = txt_FirstName.Text;
            Trainee.lastName = txt_LastName.Text;
            if (CB_Group.SelectedItem != null)
            {
                Group g = gs.FindById((int)CB_Group.SelectedValue);
                Trainee.Group = g; //(Group)CB_Group.SelectedItem; not working!!
            }
            SaveClick(this, e);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            CancelClick(this, e);
        }
    }
}
