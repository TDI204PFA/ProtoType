using CRUD_EF_All_RelationShip.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EF_All_RelationShip.Managements.TrainersManagement
{
    public class TrainersServices
    {
        public Model_TraineesManagement db { get; set; }
        public bool Add(Trainer t)
        {
            db.Trainers.Add(t);
            return db.SaveChanges() > 0;
        }
        public bool Update(Trainer t)
        {
            Trainer Original = db.Trainers.Find(t.id);
            if (Original != null)
            {
                db.Entry(Original).CurrentValues.SetValues(t);
                return db.SaveChanges() > 0;
            }
            return false;
        }
        public List<Trainer> TrainersList()
        {
            var query = from t in db.Trainers select t;
            return query.ToList<Trainer>();
        }
        public List<Trainee> TraineesList(Trainer t)
        {
            return  (t.TraineesList!=null)?t.TraineesList.ToList<Trainee>():null;
        }

        public Trainer FindById(int id)
        {
            Trainer tr = db.Trainers.Find(id);
            //change the found group state..:
            db.Entry(tr).State = System.Data.Entity.EntityState.Modified;
            return tr;
        }
    }
}
