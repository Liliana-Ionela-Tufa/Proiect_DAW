using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proiect_Asp.Entities;
using Proiect_Asp.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Asp.Data
{
    public class ProiectContext : IdentityDbContext<User, Role, int,
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public ProiectContext(DbContextOptions<ProiectContext> options) : base(options){}

        public DbSet<Pacient>Pacienti { get; set; }

        public DbSet<Programare> Programari { get; set; }

        public DbSet<Doctor> Doctori { get; set; }
        public DbSet<ProgramareDoctor> ProgramariDoctori { get; set; }

        public DbSet<SessionToken> SessionTokens { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to many
            modelBuilder.Entity<Pacient>().HasMany(pacient => pacient.Programari).WithOne(programare => programare.Pacient);
            base.OnModelCreating(modelBuilder);

            //one to one
            modelBuilder.Entity<Pacient>().HasOne(pacient => pacient.Adresa).WithOne(adresa => adresa.Pacient);

            //many to many
            modelBuilder.Entity<ProgramareDoctor>().HasKey(pd => new { pd.DoctorId, pd.ProgramareId });

            modelBuilder.Entity<ProgramareDoctor>().HasOne(dp => dp.Doctor).WithMany(dp => dp.ProgramariDoctor)
                .HasForeignKey(dp => dp.DoctorId);

            modelBuilder.Entity<ProgramareDoctor>().HasOne(dp => dp.Programare).WithMany(dp => dp.ProgramariDoctor)
                .HasForeignKey(dp => dp.ProgramareId);

            modelBuilder.Entity<UserRole>(ur =>
            {
                ur.HasKey(ur => new { ur.UserId, ur.RoleId });

                ur.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId);
                ur.HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(ur => ur.UserId);
            });
        }
    }
}
