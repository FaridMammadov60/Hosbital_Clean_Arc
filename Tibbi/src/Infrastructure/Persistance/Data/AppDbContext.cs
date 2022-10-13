using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistance.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Registration> Registrations { get; set; }
        public DbSet<RegistrationInfo> RegistrationInfos { get; set; }
        public DbSet<MedicalWorker> MedicalWorkers { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CallResult> CallResults { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car() { Id = 1, Brand = "Mercedes", InsertDate = DateTime.Parse("6/15/2008 "), LicensePlate = "10-MM-100" },
                new Car() { Id = 2, Brand = "Ford", InsertDate = DateTime.Parse("6/15/2008 "), LicensePlate = "10-FF-100" },
                new Car() { Id = 3, Brand = "BMW", InsertDate = DateTime.Parse("6/15/2009 "), LicensePlate = "10-TT-100" });


            modelBuilder.Entity<MedicalWorker>().HasData(
                new MedicalWorker() { Id = 1, Fullname = "Elekber Teymurov", InsertDate = DateTime.Parse("6/15/2008 ") },
                new MedicalWorker() { Id = 2, Fullname = "Mirqasim Abbasov", InsertDate = DateTime.Parse("6/15/2008 ") });


            modelBuilder.Entity<Diagnosis>().HasData(
                new Diagnosis() { Id = 1, Diagnos = "Infarkt", InsertDate = DateTime.Parse("6/15/2008 ") },
                new Diagnosis() { Id = 2, Diagnos = "Kelle-beyin travmasi", InsertDate = DateTime.Parse("6/15/2008 ") });


            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, Username = "admin", InsertDate = DateTime.Parse("6/15/2008 ") },
                new User() { Id = 2, Username = "user", InsertDate = DateTime.Parse("6/15/2008 ") });

            modelBuilder.Entity<CallResult>().HasData(
                new CallResult() { Id = 1, Result = "result-1", InsertDate = DateTime.Parse("6/15/2008 ") },
                new CallResult() { Id = 2, Result = "result-2", InsertDate = DateTime.Parse("6/15/2008 ") });

            modelBuilder.Entity<Registration>().HasData(
               new Registration()
               {
                   Id = 1,
                   IsActive = 1,
                   Birth = DateTime.Parse("6/15/2008 "),
                   CarId = 1,
                   DiagnosId = 1,
                   InsertDate = DateTime.Parse("6/15/2008 "),
                   MedicalWorkerId = 1,
                   Name = "Ramil",
                   Surname = "Sheydayev",
                   Pin = "12345678",
                   Protocol = "123456789102",
                   UpdateDate = null,
                   InsertUser = "admin",
                   UpdateUser = "user",

               });


            modelBuilder.Entity<RegistrationInfo>().HasData(
                new RegistrationInfo()
                {
                    Id = 1,
                    CallResultId = 1,
                    InsertDate = DateTime.Parse("6/15/2008 "),
                    IsHospitalization = true,
                    photo = "adasdad/asdadsasd/asdasdasd",
                    RegistrationId = 1,

                });

        }

    }
}
