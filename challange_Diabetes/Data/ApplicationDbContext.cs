using challange_Diabetes.Model;
using challenge_Diabetes.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace challenge_Diabetes.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().ToTable("Users");
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection");
            }

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Measuring_Sugar> measuring_Sugars { get; set; }
        public DbSet<Measuring_pressure> measuring_Pressures { get; set; }
        public DbSet<Measuring_weight> measuring_Weights { get; set; }
        public DbSet<Community> Community { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Observer> Observers { get; set; }
        public DbSet<Sport> sports { get; set; }
        public DbSet<Medicine> medicines { get; set; }



    }
}

