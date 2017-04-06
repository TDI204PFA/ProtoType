using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EF_All_RelationShip.Entitys
{
    public class Models
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public virtual List<Trainer> TrainerList { get; set; }
        public override string ToString()
        {
            return this.name;
        }


    }
}
