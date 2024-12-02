using Microsoft.EntityFrameworkCore;
using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Infrastructure.EF.Config;

namespace RevenueRecognition.Infrastructure.EF.Contexts;

internal sealed class WriteDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
    public DbSet<CompanyCustomer> CompanyCustomers { get; set; }

    public WriteDbContext()
    {
    }

    public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("default");
        
        var configuration = new WriteConfiguration();
        modelBuilder.ApplyConfiguration<Customer>(configuration);
        modelBuilder.ApplyConfiguration<IndividualCustomer>(configuration);
        modelBuilder.ApplyConfiguration<CompanyCustomer>(configuration);
    }
}