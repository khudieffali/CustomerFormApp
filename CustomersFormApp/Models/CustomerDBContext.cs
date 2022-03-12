using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CustomersFormApp.Models
{
    public partial class CustomerDBContext : DbContext
    {
        public CustomerDBContext()
        {
        }

        public CustomerDBContext(DbContextOptions<CustomerDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CustomToTask> CustomToTasks { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<MyTask> MyTask { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=HOME-PC; initial catalog=CustomerDB2;integrated security=true;");
            }
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
