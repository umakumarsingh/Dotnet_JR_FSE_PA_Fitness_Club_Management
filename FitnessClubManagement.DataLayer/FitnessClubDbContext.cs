using FitnessClubManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace FitnessClubManagement.DataLayer
{
    public class FitnessClubDbContext : DbContext
    {
        public FitnessClubDbContext(DbContextOptions<FitnessClubDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
            //Database.Migrate();
        }
        /// <summary>
        /// Creating DbSet for Table
        /// </summary>
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<DietPlan> DietPlans { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Tools> Tools { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        /// <summary>
        /// While Model or Table creating Applaying Primary key to Table
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .HasKey(x => x.AppointmentId);
            modelBuilder.Entity<DietPlan>()
                .HasKey(x => x.DietplanId);
            modelBuilder.Entity<Instructor>()
                .HasKey(x => x.InstructorId);
            modelBuilder.Entity<Tools>()
                .HasKey(x => x.ToolsId);
            modelBuilder.Entity<Workout>()
                .HasKey(x => x.WorkoutId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
