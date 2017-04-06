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

namespace CRUD_EF_All_RelationShip.Managements.ModelsManagement
{
    public partial class ModelsGrid_UC : UserControl
    {
        public ModelsGrid_UC()
        {
            InitializeComponent();
        }
        public event EventHandler EditModel;
        public ModelsServices ms { get; set; }
        public Models Model { get; set; }

        public Models Current
        {
            get { return (Models)modelsBindingSource.Current; }
        }

        public void Refresh()
        {
            modelsBindingSource.Clear();
            modelsBindingSource.DataSource = ms.ModelsList();
        }

        private void datgridModel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Delete
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Are You sure..!", "Deleting Trainee", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Models t = (Models)modelsBindingSource.Current;
                    ms.Delete(t.id);
                    this.Refresh();
                }

            }
            //Edite
            if (e.ColumnIndex == dataGridView1.Columns["Edite"].Index && e.RowIndex > 0)
            {
                EditModel(sender, e);
            }
        }
    }
}
