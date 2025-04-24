
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineDentalClinic.Models;
//using System.Data.Entity;

namespace OnlineDentalClinic.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }



        //public DbSet<OnlineDentalClinic.Models.Patient> Patient { get; set; } = default!;
        public required DbSet<Patient> Patients { get; set; }
        public required DbSet<Appointment> Appointments { get; set; }
        //public required DbSet<Prescriptions> Prescs { get; set; }
        public required DbSet<Presciption> Prescriptions { get; set; }

        public required DbSet<Treatment> Treatments { get; set; }
        public required DbSet<Doctor> doctors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Appointment>().HasNoKey();
            modelBuilder.Entity<Presciption>()
        .HasKey(p => p.Id); // Specify the primary key
            //var appointment = new Appointment
            //{
            //    AppDate = DateTime.Now,
            //    Patient = "Doctor's appointment"
            //};

            // Add and save the entity
            //DbContext.Appointments.Add(appointment);
            //dbContext.SaveChanges();
            
        //{
        //    modelBuilder.Entity<Appointment>()
        //        .HasKey(a => a.AppointId);
        //}







            base.OnModelCreating(modelBuilder);

            //var userId = Guid.NewGuid().ToString();
            //var RollAdminID = Guid.NewGuid().ToString();

            //modelBuilder.Entity<IdentityRole>.HasData(
            //    new IdentityRole()
            //    {
            //        Id = Guid.NewGuid().ToString(),
            //        Name="Admin",
            //        NormalizedName="admin",
            //        ConcurrencyStamp= Guid.NewGuid().ToString(),

            //    });
            //base.OnModelCreating(modelBuilder);
            // Ensure IdentityUserLogin has a composite primary key
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.HasKey(login => new { login.LoginProvider, login.ProviderKey });
            });
            


        }

    }
}
