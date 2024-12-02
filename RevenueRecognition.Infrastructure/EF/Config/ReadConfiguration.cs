using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Infrastructure.EF.Models;

namespace RevenueRecognition.Infrastructure.EF.Config;

internal sealed class ReadConfiguration : IEntityTypeConfiguration<CustomerReadModel>, IEntityTypeConfiguration<IndividualCustomerReadModel>, IEntityTypeConfiguration<CompanyCustomerReadModel>
{
    public void Configure(EntityTypeBuilder<CustomerReadModel> builder)
    {
        builder.ToTable("Customers");
        builder.HasKey(c => c.CustomerId);
    }
    
    public void Configure(EntityTypeBuilder<IndividualCustomerReadModel> builder)
    {
        builder.ToTable("IndividualCustomers");
        builder.HasKey(ic => ic.CustomerId);
        
        //builder.HasMany(ic => ic.Contracts).WithOne(c => c.Customer)
    }

    public void Configure(EntityTypeBuilder<CompanyCustomerReadModel> builder)
    {
        builder.ToTable("CompanyCustomers");
        builder.HasKey(ic => ic.CustomerId);
    }

    
}