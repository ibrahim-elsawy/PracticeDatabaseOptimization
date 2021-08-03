using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDatabaseOptimization.Models
{
    public class TestModel : DbContext 
    {
        public DbSet<DataRow> DataRows { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=TestDB;trusted_connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataRow>().HasData(new DataRow { RowId = 1, DateTime = DateTime.Now, VarCol1 = "Test1", VarCol2 = "Test2", VarCol3 = "Test3" }); ;
            
        }
    }
}
