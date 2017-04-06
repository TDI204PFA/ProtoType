using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_EF_All_RelationShip.Managements.TraineesManagement;
using CRUD_EF_All_RelationShip.Entitys;

namespace CRUD_EF_All_RelationShip.Managements.TrainersManagement
{
    public partial class TrainerTraineesList_UC : UserControl
    {
        public TrainerTraineesList_UC()
        {
            InitializeComponent();
        }
        public event EventHandler AddClick;
        public event EventHandler DeleteClick;
        public TrainersServices trs = new TrainersServices();
        public TraineesServices tes = new TraineesServices();
        public Model_TraineesManagement dbHome { get; set; }
        public Trainer Trainer { get; set; }
        public Trainee Current()
        {
            return (Trainee)traineeAll_BindingSource.Current;
        }
        private void TrainerTraineesList_UC_Load(object sender, EventArgs e)
        {//101
            if (!DesignMode)
            {
                tes.db = dbHome;
                trs.db = dbHome;
                Refresh();
            }
        }
        public void Refresh()
        {
            traineeAll_BindingSource.Clear();
            traineeAll_BindingSource.DataSource = tes.TraineesList();

            traineeBindingSource.Clear();
            traineeBindingSource.DataSource = trs.TraineesList(Trainer);
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {


            AddClick(sender, e);
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Trainee t = (Trainee)traineeBindingSource.Current;
            Trainer.TraineesList.Remove(t);
            DeleteClick(sender,e);
        }
    }
}
