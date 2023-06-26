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
        }
        public DbSet<User> User { get; set; }
        public DbSet<Building> Building { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Classroom> Classroom { get; set; }
        public DbSet<Calendar> Calendar { get; set; }
    }
}
