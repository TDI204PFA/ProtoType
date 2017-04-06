using CRUD_EF_All_RelationShip.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EF_All_RelationShip.Managements.TraineesManagement
{
    public class TraineesServices
    {
        public Model_TraineesManagement db { get; set; }
        
        public bool Add(Trainee t)
        {
            db.Trainees.Add(t);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            db.Trainees.Remove(db.Trainees.Find(id));
            return db.SaveChanges() > 0;
        }
        public bool Update(Trainee t)
        {
            var Original = db.Trainees.Find(t.id);
            if (Original != null)
            {
                db.Entry(Original).CurrentValues.SetValues(t);
                return db.SaveChanges() > 0;
            }
            return false;
        }
        public List<Trainee> TraineesList()
        {
            var query = from t in db.Trainees select t;
            return query.ToList<Trainee>();
        }
        public void Validate()
        {
            db.SaveChanges();
        }

    }
}
