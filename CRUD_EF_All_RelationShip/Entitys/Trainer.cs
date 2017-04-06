using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EF_All_RelationShip.Entitys
{
    public class Trainer
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public virtual List<Trainee> TraineesList { get; set; }
        public virtual List<Models> ModelsList { get; set; }
        public Trainer() { }
        public Trainer(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
