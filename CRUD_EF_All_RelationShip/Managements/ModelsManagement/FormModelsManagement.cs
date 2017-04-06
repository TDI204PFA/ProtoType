using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_EF_All_RelationShip.Managements;
using CRUD_EF_All_RelationShip.Entitys;

namespace CRUD_EF_All_RelationShip.Managements.ModelsManagement
{
    public partial class FormModelsManagement : Form
    {
        public FormModelsManagement()
        {
            InitializeComponent();
        }
        ModelsServices ms = new ModelsServices();
        public Model_TraineesManagement dbHome { get; set; }

        private void btn_AddModel_Click(object sender, EventArgs e)
        {
            if (tabControlModels.TabPages.IndexOfKey("TabAdd") == -1)
            {
                //TabPage Creation + adding it to the tabControl..: 
                TabPage TabAdd = new TabPage();
                TabAdd.Text = "Add a Model";
                TabAdd.Name = "TabAdd";
                tabControlModels.TabPages.Add(TabAdd);
                tabControlModels.SelectedTab = TabAdd;

                //TraineeForm_UC creation and adding to the TabAdd TabPage..:
                ModelsForm_UC mf_uc = new ModelsForm_UC();
                mf_uc.Name = "modelForm";
                this.tabControlModels.TabPages["TabAdd"].Controls.Add(mf_uc);
                mf_uc.SaveClick += Mf_uc_SaveClick1;
                mf_uc.CancelClick += Mf_uc_CancelClick1;
            }


        }
        private void Mf_uc_SaveClick1(object sender, EventArgs e)
        {
            TabPage TabAdd = this.tabControlModels.TabPages["TabAdd"];
            ModelsForm_UC mf_uc = (ModelsForm_UC)TabAdd.Controls.Find("modelForm", false).First();
            if (ms.Add(mf_uc.Model))
            {
                MessageBox.Show("the Model " + mf_uc.Model.ToString() + " was Added Correctely");
            }
            else
            {
                MessageBox.Show("the Model " + mf_uc.Model.ToString() + " was not added..!");
            }
            this.tabControlModels.TabPages.Remove(TabAdd);
            this.modelsGrid_UC1.Refresh();
        }
        private void Mf_uc_CancelClick1(object sender, EventArgs e)
        {
            TabPage TabAdd = this.tabControlModels.TabPages["TabAdd"];
            tabControlModels.TabPages.Remove(TabAdd);
        }

        private void FormModelsManagement_Load(object sender, EventArgs e)
        {
            //Initalisation of the databases..:
            ms.db = dbHome;

            modelsGrid_UC1.ms = ms;
            //Refresh the Trainees List:
            modelsGrid_UC1.Refresh();

            //Adding the edite event to the traineesGrid_UC..:
            modelsGrid_UC1.EditModel += ModelsGrid_UC_EditeTraineeEvent;
        }

        private void ModelsGrid_UC_EditeTraineeEvent(object sender, EventArgs e)
        {
            Models Model = modelsGrid_UC1.Current;
            string TabEditerName = "TabEditer-" + Model.id;
            if (tabControlModels.TabPages.IndexOfKey(TabEditerName) == -1)
            {
                //Tab Creation:
                TabPage TabEditerPage = new TabPage();
                TabEditerPage.Text = Model.name ;
                TabEditerPage.Name = TabEditerName;
                tabControlModels.TabPages.Add(TabEditerPage);
                tabControlModels.SelectedTab = TabEditerPage;

                //Uc Insertion:
                ModelsForm_UC mf_uc = new ModelsForm_UC();
                mf_uc.Name = "trainee_uc";
                mf_uc.Model = Model;
                mf_uc.ms = ms;
                mf_uc.InitModel();
                tabControlModels.TabPages[TabEditerName].Controls.Add(mf_uc);
                mf_uc.SaveClick += Mf_uc_SaveClick;
                mf_uc.CancelClick += Mf_uc_CancelClick;
            }
        }

        private void Mf_uc_SaveClick(object sender, EventArgs e)
        {
            ModelsForm_UC mf_uc = (ModelsForm_UC)sender;
            Models Model = mf_uc.Model;
            string TabEditeName = "TabEditer-" + Model.id;
            TabPage TabEditePage = tabControlModels.TabPages[TabEditeName];
            if (ms.Update(Model))
            {
                MessageBox.Show("the model " + Model.ToString() + " was saved correctely");
            }
            else
            {
                MessageBox.Show("the model " + Model.ToString() + " was not saved because there is no changes to save..!");
            }
            tabControlModels.TabPages.Remove(TabEditePage);
            this.modelsGrid_UC1.Refresh();
        }
        private void Mf_uc_CancelClick(object sender, EventArgs e)
        {
            ModelsForm_UC tf_uc = (ModelsForm_UC)sender;
            string TabEditerName = "TabEditer-" + tf_uc.Model.id;
            TabPage TabeEditerPage = tabControlModels.TabPages[TabEditerName];
            tabControlModels.TabPages.Remove(TabeEditerPage);
        }
    }
}
