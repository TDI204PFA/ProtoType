using CRUD_EF_All_RelationShip.Managements.TraineesManagement;
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

namespace CRUD_EF_All_RelationShip.Managements.TrainersManagement
{
    public partial class FormTrainersManagement : Form
    {
        public Model_TraineesManagement dbHome { get; set; }
        public TrainersServices trs = new TrainersServices();
        public TraineesServices tes = new TraineesServices();
        public FormTrainersManagement()
        {
            InitializeComponent();
        }

        private void FormTrainersManagement_Load(object sender, EventArgs e)
        {
            trs.db = dbHome;
            trainersGrid_UC1.ts = trs;
            trainersGrid_UC1.Refresh();
            trainersGrid_UC1.EditeListTraineesDClick += TrainersGrid_UC1_EditeListTraineesDClick;
            trainersGrid_UC1.EditeDGV_TrainerDClick += TrainersGrid_UC1_EditeDGV_TrainerDClick; ;
        }

        private void TrainersGrid_UC1_EditeListTraineesDClick(object sender, EventArgs e)
        {
            FormAddTraineesToTrainerListofTrainees f = new FormAddTraineesToTrainerListofTrainees();
            f.dbHome = dbHome;
            f.Trainer = trainersGrid_UC1.Current();
            f.ShowDialog();
            trainersGrid_UC1.Refresh();
        }
        #region Edite
        private void TrainersGrid_UC1_EditeDGV_TrainerDClick(object sender, EventArgs e)
        {
            Trainer Trainer = trainersGrid_UC1.Current();
            string TabName = "TabEdite-" + Trainer.id;
            if (tabControlTrainers.TabPages.IndexOfKey(TabName) == -1)
            {
                //Creating a new tabpage to edite the current/selected trainer..:
                TabPage TabEdite = new TabPage();
                TabEdite.Text = "Edite a new trainer";
                TabEdite.Name = "TabEdite-"+Trainer.id;
                tabControlTrainers.TabPages.Add(TabEdite);
                tabControlTrainers.SelectedTab = TabEdite;
                //adding a user control to the tabAdd controls list...:
                TrainersForm_UC tf_uc = new TrainersForm_UC();
                tf_uc.Name = "trainerForm";
                tf_uc.Trainer = Trainer;
                tf_uc.InitTrainer();
                TabEdite.Controls.Add(tf_uc);
                tf_uc.SaveClick += Tf_uc_SaveClick1; ;
                tf_uc.CancelClick += Tf_uc_CancelClick1; ;
            }
        }

        private void Tf_uc_CancelClick1(object sender, EventArgs e)
        {
            TrainersForm_UC tf_uc = (TrainersForm_UC)sender;
            string TabName = "TabEdite-" + tf_uc.Trainer.id;
            TabPage TabEdite = tabControlTrainers.TabPages[TabName];
            tabControlTrainers.TabPages.Remove(TabEdite);
        }

        private void Tf_uc_SaveClick1(object sender, EventArgs e)
        {
            TrainersForm_UC tf_uc = (TrainersForm_UC)sender;
            Trainer Trainer = tf_uc.Trainer;
            string TabName = "TabEdite-" + Trainer.id;
            TabPage TabEdite = tabControlTrainers.TabPages[TabName];
            if (trs.Update(Trainer))
            {
                MessageBox.Show("Trainer "+Trainer.ToString()+"was saved correctly..!");
            }
            else
            {
                MessageBox.Show("Trainer "+Trainer.ToString()+" was not saved..!");
            }
            tabControlTrainers.TabPages.Remove(TabEdite);
        }
        #endregion
        //****************************************************************************
        #region Add
        private void btn_AddTrainer_Click(object sender, EventArgs e)
        {
            if (tabControlTrainers.TabPages.IndexOfKey("TabAdd") == -1)
            {
                //Creating a new tab to add a new trainer..:
                TabPage TabAdd = new TabPage();
                TabAdd.Text = "Add a new trainer";
                TabAdd.Name = "TabAdd";
                tabControlTrainers.TabPages.Add(TabAdd);
                tabControlTrainers.SelectedTab = TabAdd;
                //adding a user control to the tabAdd controls list...:
                TrainersForm_UC tf_uc = new TrainersForm_UC();
                tf_uc.Name = "trainerForm";
                TabAdd.Controls.Add(tf_uc);
                tf_uc.SaveClick += Tf_uc_SaveClick;
                tf_uc.CancelClick += Tf_uc_CancelClick;
            }
        }
        private void Tf_uc_CancelClick(object sender, EventArgs e)
        {
            TabPage TabAdd = tabControlTrainers.TabPages["TabAdd"];
            tabControlTrainers.TabPages.Remove(TabAdd);
        }

        private void Tf_uc_SaveClick(object sender, EventArgs e)
        {
            TabPage TabAdd = tabControlTrainers.TabPages["TabAdd"];
            TrainersForm_UC tf_uc = (TrainersForm_UC)tabControlTrainers.Controls.Find("trainerForm", true).First();
            if (trs.Add(tf_uc.Trainer))
            {
                MessageBox.Show("Trainer " + tf_uc.Trainer.ToString() + " was added correctly..!");
            }
            else
            {
                MessageBox.Show("Trainer " + tf_uc.Trainer.ToString() + " was not added correctly..!");
            }
            tabControlTrainers.TabPages.Remove(TabAdd);
            this.trainersGrid_UC1.Refresh();
        }

        #endregion


    }
}

