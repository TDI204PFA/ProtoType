using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_EF_All_RelationShip.Entitys;

namespace CRUD_EF_All_RelationShip.Managements.GroupsManagement
{
    public class GroupsServices
    {
        public Model_TraineesManagement db { get; set; }
        public bool Ajouter(Group g)
        {
            db.Groups.Add(g);
            return db.SaveChanges() > 0;
        }   
        public bool Update(Group g)
        {
            Group Original = db.Groups.Find(g.id);
            if (Original != null)
            {
                db.Entry(Original).CurrentValues.SetValues(g);
                return db.SaveChanges() > 0;
            }
            return false;
        }
        /// <summary>
        /// Finds and changes the groups state to Unchanged than return that group..
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Group FindById(int id)
        {
            Group g = db.Groups.Find(id);
            //change the found group state..:
            db.Entry(g).State = System.Data.Entity.EntityState.Modified;
            return g;
        }
        public Group FindById2(int id)
        {
            Group g = db.Groups.Where(g0 => g0.id == id).SingleOrDefault();
            return g;
        }
        public List<Group> GroupsList()
        {
            var query = from g in db.Groups select g;
            return query.ToList<Group>();
        }
    }
}
