namespace CRUD_EF_All_RelationShip
{
    using Entitys;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model_TraineesManagement : DbContext
    {
        // Your context has been configured to use a 'Model_TraineesManagement' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CRUD_EF_All_RelationShip.Model_TraineesManagement' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model_TraineesManagement' 
        // connection string in the application configuration file.
        public Model_TraineesManagement()
            : base("name=Model_TraineesManagement")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Models> Models { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}