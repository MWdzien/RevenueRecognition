using Microsoft.EntityFrameworkCore;
using RevenueRecognition.Infrastructure.EF.Config;
using RevenueRecognition.Infrastructure.EF.Models;

namespace RevenueRecognition.Infrastructure.EF.Contexts;

internal sealed class ReadDbContext : DbContext
{
    public DbSet<CustomerReadModel> Customers { get; set; }
    public DbSet<IndividualCustomerReadModel> IndividualCustomers { get; set; }
    public DbSet<CompanyCustomerReadModel> CompanyCustomers { get; set; }

    public ReadDbContext()
    {
    }

    public ReadDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("default");

        var configuration = new ReadConfiguration();
        modelBuilder.ApplyConfiguration<CustomerReadModel>(configuration);
        modelBuilder.ApplyConfiguration<IndividualCustomerReadModel>(configuration);
        modelBuilder.ApplyConfiguration<CompanyCustomerReadModel>(configuration);
        
    }
}