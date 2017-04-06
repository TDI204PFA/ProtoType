using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EF_All_RelationShip.Entitys
{
    public class Trainee
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public virtual Group Group { get; set; }
        public virtual List<Trainer> TrainersList { get; set; }
        public Trainee(){}
        public Trainee(string firstName,string lastName)
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
