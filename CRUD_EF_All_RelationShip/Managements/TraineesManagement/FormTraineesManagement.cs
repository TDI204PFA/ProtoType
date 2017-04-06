using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_EF_All_RelationShip.Entitys;
using CRUD_EF_All_RelationShip.Managements.GroupsManagement;

namespace CRUD_EF_All_RelationShip.Managements.TraineesManagement
{
    public partial class FormTraineesManagement : Form
    {
        TraineesServices ts = new TraineesServices();
        GroupsServices gs = new GroupsServices();
        public Model_TraineesManagement dbHome { get; set; }
        public FormTraineesManagement()
        {
            InitializeComponent();
        }
        private void FormTraineesManagement_Load(object sender, EventArgs e)
        {
            //Initalisation of the databases..:
            ts.db = dbHome;
            gs.db = dbHome;

            traineesGrid_UC.ts = ts;
            //Refresh the Trainees List:
            traineesGrid_UC.Refresh();

            //Adding the edite event to the traineesGrid_UC..:
            traineesGrid_UC.EditeTraineeEvent += TraineesGrid_UC_EditeTraineeEvent;

        }


        #region Edite
        private void TraineesGrid_UC_EditeTraineeEvent(object sender, EventArgs e)
        {
            Trainee Trainee = traineesGrid_UC.Current;
            string TabEditerName = "TabEditer-" + Trainee.id;
            if (tabControlTrainees.TabPages.IndexOfKey(TabEditerName) == -1)
            {
                //Tab Creation:
                TabPage TabEditerPage = new TabPage();
                TabEditerPage.Text = Trainee.firstName + " " + Trainee.lastName;
                TabEditerPage.Name =  TabEditerName;
                tabControlTrainees.TabPages.Add(TabEditerPage);
                tabControlTrainees.SelectedTab = TabEditerPage;

                //Uc Insertion:
                TraineeForm_UC tf_uc = new TraineeForm_UC();
                tf_uc.Name = "trainee_uc";
                tf_uc.Trainee = Trainee;
                tf_uc.gs = gs;
                tf_uc.InitTrainee();
                tf_uc.InitCB_Groups();
                tabControlTrainees.TabPages[TabEditerName].Controls.Add(tf_uc);
                tf_uc.SaveClick += Tf_uc_SaveClick;
                tf_uc.CancelClick += Tf_uc_CancelClick;
            }
        }
        private void Tf_uc_SaveClick(object sender, EventArgs e)
        {
            TraineeForm_UC tf_uc = (TraineeForm_UC)sender;
            Trainee Trainee = tf_uc.Trainee;
            string TabEditeName = "TabEditer-" + Trainee.id;
            TabPage TabEditePage = tabControlTrainees.TabPages[TabEditeName];
            if (ts.Update(Trainee))
            {
                MessageBox.Show("the trainee " + Trainee.ToString() + " was saved correctely");
            }
            else
            {
                MessageBox.Show("the trainee " + Trainee.ToString() + " was not saved because there is no changes to save..!");
            }
            tabControlTrainees.TabPages.Remove(TabEditePage);
            this.traineesGrid_UC.Refresh();
        }
        private void Tf_uc_CancelClick(object sender, EventArgs e)
        {
            TraineeForm_UC tf_uc = (TraineeForm_UC)sender;
            string TabEditerName = "TabEditer-" + tf_uc.Trainee.id;
            TabPage TabeEditerPage = tabControlTrainees.TabPages[TabEditerName];
            tabControlTrainees.TabPages.Remove(TabeEditerPage);
        }
        #endregion
        //*****************************************************************************************
        #region Add
        private void btn_AddTrainee_Click(object sender, EventArgs e)
        {
            if (tabControlTrainees.TabPages.IndexOfKey("TabAdd") == -1)
            {
                //TabPage Creation + adding it to the tabControl..: 
                TabPage TabAdd = new TabPage();
                TabAdd.Text = "Add a Trainee";
                TabAdd.Name = "TabAdd";
                tabControlTrainees.TabPages.Add(TabAdd);
                tabControlTrainees.SelectedTab = TabAdd;

                //TraineeForm_UC creation and adding to the TabAdd TabPage..:
                TraineeForm_UC tf_uc = new TraineeForm_UC();
                tf_uc.Name = "traineeForm";
                tf_uc.gs = gs;
                tf_uc.InitCB_Groups();
                this.tabControlTrainees.TabPages["TabAdd"].Controls.Add(tf_uc);
                tf_uc.SaveClick += Tf_uc_SaveClick1;
                tf_uc.CancelClick += Tf_uc_CancelClick1;
            }
        }
        private void Tf_uc_SaveClick1(object sender, EventArgs e)
        {
            TabPage TabAdd = this.tabControlTrainees.TabPages["TabAdd"];
            TraineeForm_UC tf_uc = (TraineeForm_UC)TabAdd.Controls.Find("traineeForm", false).First();
            if (ts.Add(tf_uc.Trainee))
            {
                MessageBox.Show("the trainee " + tf_uc.Trainee.ToString() + " was Added Correctely");
            }
            else
            {
                MessageBox.Show("the trainee " + tf_uc.Trainee.ToString() + " was not added..!");
            }
            this.tabControlTrainees.TabPages.Remove(TabAdd);
            this.traineesGrid_UC.Refresh();
        }
        private void Tf_uc_CancelClick1(object sender, EventArgs e)
        {
            TabPage TabAdd = this.tabControlTrainees.TabPages["TabAdd"];
            tabControlTrainees.TabPages.Remove(TabAdd);
        }
        #endregion

    }
}
