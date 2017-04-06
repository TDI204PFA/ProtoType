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
    public partial class TrainersForm_UC : UserControl
    {
        public TrainersForm_UC()
        {
            InitializeComponent();
        }
        public event EventHandler SaveClick;
        public event EventHandler CancelClick;
        public Trainer Trainer { get; set; }
        public void InitTrainer()
        {
            txt_FirstName.Text = Trainer.firstName;
            txt_LastName.Text = Trainer.lastName;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Trainer == null) Trainer = new Trainer();
            Trainer.firstName = txt_FirstName.Text;
            Trainer.lastName = txt_LastName.Text;
            SaveClick(sender, e);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            CancelClick(sender, e);
        }
    }
}
