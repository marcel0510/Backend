using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Model
{
    public class ScheduleContext: DbContext
    {
        public ScheduleContext(DbContextOptions<ScheduleContext> options): base(options) { }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
