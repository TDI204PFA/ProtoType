using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EF_All_RelationShip.Entitys
{
    public class Group
    {
        public int id { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return this.name;
        }
    }
}
