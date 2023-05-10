using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Model
{
    public class ScheduleDbContext: DbContext
    {
        public ScheduleDbContext(DbContextOptions<ScheduleDbContext> options): base(options) { }

        public DbSet<Building> Building { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Classroom> Classroom { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


    }
}
