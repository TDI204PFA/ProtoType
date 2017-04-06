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
using CRUD_EF_All_RelationShip.Managements.ModelsManagement;
using CRUD_EF_All_RelationShip.Managements.TrainersManagement;

namespace CRUD_EF_All_RelationShip.Managements.TrainersModelsManagment
{
    public partial class AffectationModelFormateur : Form
    {
        public AffectationModelFormateur()
        {
            InitializeComponent();
            
        }
        ModelsServices ms = new ModelsServices();
        TrainersServices ts = new TrainersServices();
        public Model_TraineesManagement dbHome { get; set; }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refrech();
            
        }

        private void AffectationModelFormateur_Load(object sender, EventArgs e)
        {
            ts.db = dbHome;
            ms.db = dbHome;
            
            cbTrainers.DataSource = ts.TrainersList();
            cbTrainers.ValueMember = "id";
            cbTrainers.DisplayMember = "lastName";
            

        }

        public void Refrech()
        {
            listModels.Rows.Clear();
            List<Models> LM = ms.ModelsListByTrainer((int)cbTrainers.SelectedValue);
            List<Models> LMT = ms.ModelsList();
            bool verf = false;
            foreach (Models mod in LMT)
            {
                foreach (Models item in LM)
                {
                    if (item.id == mod.id)
                    {
                        verf = true;
                        break;
                    }

                }
                if (verf)
                {
                    listModels.Rows.Add(mod.id,mod.name, mod.Description, true);
                }
                else
                {
                    listModels.Rows.Add(mod.id,mod.name, mod.Description, false);
                }
                verf = false;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Trainer Tr = ts.FindById(Convert.ToInt32(cbTrainers.SelectedValue));
            foreach (DataGridViewRow row in listModels.Rows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                Models m = ms.FindById(id);
                if (Convert.ToBoolean(row.Cells["Check"].Value) == true)
                {
                    m.TrainerList.Add(Tr);
                    Tr.ModelsList.Add(m);
                }
                else
                {
                    m.TrainerList.Remove(Tr);
                    Tr.ModelsList.Remove(m);
                }
                
            }

            dbHome.SaveChanges();
            Refrech();
        }
    }
}
