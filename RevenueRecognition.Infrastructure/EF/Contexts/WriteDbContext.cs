using Microsoft.EntityFrameworkCore;
using RevenueRecognition.Domain.Entities;

namespace RevenueRecognition.Infrastructure.EF.Contexts;

internal sealed class WriteDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
    public DbSet<CompanyCustomer> CompanyCustomers { get; set; }

    public WriteDbContext()
    {
    }

    public WriteDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("default");
        base.OnModelCreating(modelBuilder);
    }
}