using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Model.Seeding;
using System.Reflection;

namespace Model
{
    public class ScheduleDbContext: DbContext
    {
        public ScheduleDbContext(DbContextOptions<ScheduleDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            var allEntites = modelBuilder.Model.GetEntityTypes();
            ScheduleSeeding.Seed(modelBuilder);
            foreach (var model in allEntites)
            {
                model.AddProperty("isDeleted", typeof(bool)).SetDefaultValue(false);
                model.AddProperty("createdById", typeof(int?)).SetDefaultValue(1);
                model.AddProperty("createdDate", typeof(DateTime?)).SetDefaultValue(DateTime.Now);
                model.AddProperty("updatedById", typeof(int?));
                model.AddProperty("updatedDate", typeof(DateTime?));
                model.AddProperty("deletedById", typeof(int?));
                model.AddProperty("deletedDate", typeof(DateTime?));
            }
        }
        public DbSet<User> User { get; set; }
        public DbSet<Building> Building { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Classroom> Classroom { get; set; }




    }
}
