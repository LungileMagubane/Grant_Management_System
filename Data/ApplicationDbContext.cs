using Grant_Management_System.Models;
using Grant_Management_System.Models.DropdownMenus;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Grant_Management_System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Grant> grants { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Duration> durations { get; set; }
        public DbSet<Faculty> faculties { get; set; }
        public DbSet<FundingProgramme> fundingProgrammes { get; set; }
        public DbSet<Gender> genders { get; set; }
        public DbSet<Race> races { get; set; }
        public DbSet<Title> titles { get; set; }
        public DbSet<StatusOfGrant> statusOfGrants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Grant>().ToTable("Grant");
            builder.Entity<Department>().ToTable("Department");
            builder.Entity<Duration>().ToTable("Duration");
            builder.Entity<Faculty>().ToTable("Faculty");
            builder.Entity<FundingProgramme>().ToTable("FundingProgramme");
            builder.Entity<Gender>().ToTable("Gender");
            builder.Entity<Race>().ToTable("Race");
            builder.Entity<Title>().ToTable("Title");
            builder.Entity<StatusOfGrant>().ToTable("StatusOfGrant");

        } 


    }
}
