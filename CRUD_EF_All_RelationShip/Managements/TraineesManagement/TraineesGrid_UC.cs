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

namespace CRUD_EF_All_RelationShip.Managements.TraineesManagement
{
    public partial class TraineesGrid_UC : UserControl
    {
        public TraineesGrid_UC()
        {
            InitializeComponent();
        }
        //Creation of the Edit event
        public event EventHandler EditeTraineeEvent;
        public TraineesServices ts { get; set; }
        /// <summary>
        /// Get the selected Trainee
        /// </summary>
        public Trainee Current
        {
            get { return (Trainee)traineeBindingSource.Current; }
        }
        public void Refresh()
        {
            traineeBindingSource.Clear();
            traineeBindingSource.DataSource = ts.TraineesList();
        }

        private void dataGridViewTrainees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Delete
            if (e.ColumnIndex == dataGridViewTrainees.Columns["Delete"].Index && e.RowIndex > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Are You sure..!", "Deleting Trainee", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Trainee t = (Trainee)traineeBindingSource.Current;
                    ts.Delete(t.id);
                    this.Refresh();
                }

            }
            //Edite
            if (e.ColumnIndex == dataGridViewTrainees.Columns["Edite"].Index && e.RowIndex > 0)
            {
                EditeTraineeEvent(sender, e);
            }
        }
    }
}
