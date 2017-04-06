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
    public partial class ModelsForm_UC : UserControl
    {
        public ModelsForm_UC()
        {
            InitializeComponent();
        }
        public event EventHandler SaveClick;
        public event EventHandler CancelClick;
        public Models Model { get; set; }
        public ModelsServices ms = new ModelsServices();
        public void InitModel()
        {
            Name.Text = Model.name;
            Descr.Text = Model.Description;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (Model == null) Model = new Models();
            Model.name = Name.Text;
            Model.Description = Descr.Text;
            
            SaveClick(this, e);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CancelClick(this, e);
        }
    }
}
