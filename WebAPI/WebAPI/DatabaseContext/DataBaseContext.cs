using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.DatabaseContext
{
    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
        }
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Employee>? Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Emp_NO);
                entity.ToTable("EMPLOYEE");
                entity.Property(e => e.Emp_Name).HasMaxLength(100).IsUnicode(true);
                entity.Property(e => e.Emp_Add).HasMaxLength(255).IsUnicode(true);
                entity.Property(e => e.Emp_Phone).HasMaxLength(15).IsUnicode(true);
                entity.Property(e => e.Dept_No).HasMaxLength(10).IsUnicode(true);
                entity.Property(e => e.Dept_Name).HasMaxLength(100).IsUnicode(true);
                entity.Property(e => e.Salary).HasMaxLength(10).IsUnicode(true);
                OnModelCreatingPartial(modelBuilder);
            });
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
