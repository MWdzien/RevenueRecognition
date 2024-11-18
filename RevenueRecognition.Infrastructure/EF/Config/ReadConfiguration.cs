using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevenueRecognition.Infrastructure.EF.Models;

namespace RevenueRecognition.Infrastructure.EF.Config;

internal sealed class ReadConfiguration : IEntityTypeConfiguration<CustomerReadModel>, IEntityTypeConfiguration<IndividualCustomerReadModel>, IEntityTypeConfiguration<CompanyCustomerReadModel>
{
    public void Configure(EntityTypeBuilder<CustomerReadModel> builder)
    {
        builder.ToTable("Customers");
        builder.HasKey(c => c.Id);
        
        
    }

    public void Configure(EntityTypeBuilder<IndividualCustomerReadModel> builder)
    {
        builder.ToTable("IndividualCustomers");
    }

    public void Configure(EntityTypeBuilder<CompanyCustomerReadModel> builder)
    {
        builder.ToTable("CompanyCustomers");
    }
}