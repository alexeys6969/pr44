using Microsoft.EntityFrameworkCore;
using praktika.Classes.Database;
using praktika.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace praktika.Context
{
    public class StudentsContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
        public StudentsContext()
        {
            Database.EnsureCreated();
            Students.Load();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql(Config.connection, Config.version);
    }
}
