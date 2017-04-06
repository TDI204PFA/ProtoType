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

namespace CRUD_EF_All_RelationShip.Managements.TrainersManagement
{
    public partial class TrainersGrid_UC : UserControl
    {
        public TrainersGrid_UC()
        {
            InitializeComponent();
        }
        public TrainersServices ts { get; set; }
        //Edites the trainer info..:
        public event EventHandler EditeDGV_TrainerDClick;
        //Edites the trainer list of trainees..:
        public event EventHandler EditeListTraineesDClick;
        public Trainer Current()
        {
            return (Trainer)trainerBindingSource.Current;
        }
        public void Refresh()
        {
            //DGV_Trainers.DataSource = null;
            //DGV_Trainers.DataSource = ts.TrainersList();
            trainerBindingSource.Clear();
            trainerBindingSource.DataSource = ts.TrainersList();

            //traineeBindingSource.Clear();
            //var query = from te in new Model_TraineesManagement().Trainees select te;
            //traineeBindingSource.DataSource = query.ToList<Trainee>();
        }
        private void DGV_Trainers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
                Trainer tr = (Trainer)trainerBindingSource.Current;
                traineeBindingSource.Clear();
                traineeBindingSource.DataSource = ts.TraineesList(tr);
            this.Cursor = Cursors.Default;
        }
        
        private void TrainersGrid_UC_Load(object sender, EventArgs e)
        {

        }

        private void DGV_Trainers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditeDGV_TrainerDClick(sender, e);
        }

        private void LB_Trainees_DoubleClick(object sender, EventArgs e)
        {
            EditeListTraineesDClick(sender, e);
        }
    }
}
