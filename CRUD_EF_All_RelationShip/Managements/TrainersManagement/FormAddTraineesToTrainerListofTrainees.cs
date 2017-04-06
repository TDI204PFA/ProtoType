using CRUD_EF_All_RelationShip.Entitys;
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

namespace CRUD_EF_All_RelationShip.Managements.TrainersManagement
{
    public partial class FormAddTraineesToTrainerListofTrainees : Form
    {
        public TrainersServices trs = new TrainersServices();
        public TraineesServices tes = new TraineesServices();
        public Model_TraineesManagement dbHome { get; set; }
        public Trainer Trainer { get; set; }
        public FormAddTraineesToTrainerListofTrainees()
        {
            InitializeComponent();
        }

        private void FormAddTraineesToTrainerListofTrainees_Load(object sender, EventArgs e)
        {//1
            TrainerTraineesList_UC ttl_uc = new TrainerTraineesList_UC();
            ttl_uc.Name = "trainerTraineesList";
            ttl_uc.dbHome = dbHome;
            ttl_uc.Trainer = Trainer;
            ttl_uc.AddClick += ttl_uc_AddClick;
            ttl_uc.DeleteClick += ttl_uc_DeleteClick;
            this.Controls.Add(ttl_uc);
        }

        private void ttl_uc_DeleteClick(object sender, EventArgs e)
        {
            TrainerTraineesList_UC ttl_uc = (TrainerTraineesList_UC)this.Controls.Find("trainerTraineesList", false).First();
            if (trs.TraineesList(Trainer).Contains(ttl_uc.Current()))
            {
                Trainer.TraineesList.Remove(ttl_uc.Current());
                MessageBox.Show("trainee "+ttl_uc.Current().ToString()+" was unassined from trainer " + Trainer.firstName + " " + Trainer.lastName + "..!");
            }
            else
            {
                MessageBox.Show("trainee " + ttl_uc.Current().ToString() + " does not existe in trainer " + Trainer.firstName + " " + Trainer.lastName + " trainees list..!");
            }
            ttl_uc.Refresh();
        }

        private void ttl_uc_AddClick(object sender, EventArgs e)
        {
            TrainerTraineesList_UC ttl_uc = (TrainerTraineesList_UC)this.Controls.Find("trainerTraineesList", false).First();
            if (trs.TraineesList(Trainer).Contains(ttl_uc.Current()))
            {
                MessageBox.Show("trainee " + ttl_uc.Current().ToString() + " is already assined to trainer " + Trainer.firstName+" "+Trainer.lastName+"..!");
            }
            else
            {
                Trainer.TraineesList.Add(ttl_uc.Current());
                MessageBox.Show("trainee " + ttl_uc.Current().ToString() + " is being assined to trainer " + Trainer.firstName + " " + Trainer.lastName + "..!");
            }
            ttl_uc.Refresh();
        }
    }
}
