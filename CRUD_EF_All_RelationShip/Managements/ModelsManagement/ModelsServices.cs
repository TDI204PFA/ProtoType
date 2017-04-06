using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_EF_All_RelationShip.Entitys;

namespace CRUD_EF_All_RelationShip.Managements.ModelsManagement
{
    public class ModelsServices
    {
        public Model_TraineesManagement db { get; set; }

        public bool Add(Models m)
        {
            db.Models.Add(m);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            db.Models.Remove(db.Models.Find(id));
            return db.SaveChanges() > 0;
        }
        public bool Update(Models t)
        {
            var Original = db.Models.Find(t.id);
            if (Original != null)
            {
                db.Entry(Original).CurrentValues.SetValues(t);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Models> ModelsList()
        {
            var query = from m in db.Models select m;
            return query.ToList<Models>();
        }

        public List<Models> ModelsListByTrainer(int idTrainer)
        {
            
            var query = from m in db.Models from t in m.TrainerList where (t.id == idTrainer) select m  ;
            return query.ToList<Models>();
            

        }
        public Models FindById(int id)
        {
            Models m = db.Models.Find(id);
            //change the found group state..:
            db.Entry(m).State = System.Data.Entity.EntityState.Modified;
            return m;
        }
        public void Validate()
        {
            db.SaveChanges();
        }
    }
}
