using Assignment.Model;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Data
{
    public class EF_DbContext : DbContext
    {
        public EF_DbContext(DbContextOptions<EF_DbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();

            modelBuilder.Entity<Teacher>()
                .HasKey(i => i.Teacher_Id);
            modelBuilder.Entity<Teacher>()
              .Property(i => i.Teacher_Id).
              ValueGeneratedOnAdd();

            modelBuilder.Entity<Course>()
               .HasKey(i => i.Course_Id);
            modelBuilder.Entity<Course>()
              .Property(i => i.Course_Id).
              ValueGeneratedOnAdd();

        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}