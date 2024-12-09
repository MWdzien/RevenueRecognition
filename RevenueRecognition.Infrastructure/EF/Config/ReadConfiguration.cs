using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevenueRecognition.Infrastructure.EF.Models;

namespace RevenueRecognition.Infrastructure.EF.Config;

internal sealed class ReadConfiguration : IEntityTypeConfiguration<CustomerReadModel>, IEntityTypeConfiguration<IndividualCustomerReadModel>, IEntityTypeConfiguration<CompanyCustomerReadModel>
{
    public void Configure(EntityTypeBuilder<CustomerReadModel> builder)
    {
        builder.ToTable("Customers");
        builder.HasKey(c => c.Email);
        
        builder.Property(c => c.Email).HasColumnName("Email");
        builder.Property(c => c.Address).HasColumnName("Address");
        builder.Property(c => c.PhoneNumber).HasColumnName("PhoneNumber");
    }
    
    public void Configure(EntityTypeBuilder<IndividualCustomerReadModel> builder)
    {
        builder.ToTable("IndividualCustomers");
        builder.HasBaseType<CustomerReadModel>();

        builder.Property(c => c.FirstName).HasColumnName("FirstName");
        builder.Property(c => c.LastName).HasColumnName("LastName");
        builder.Property(c => c.Pesel).HasColumnName("Pesel");

        //builder.HasMany(ic => ic.Contracts).WithOne(c => c.Customer)
    }

    public void Configure(EntityTypeBuilder<CompanyCustomerReadModel> builder)
    {
        builder.ToTable("CompanyCustomers");
        builder.HasBaseType<CustomerReadModel>();
        builder.Property(c => c.CompanyName).HasColumnName("CompanyName");
        builder.Property(c => c.Krs).HasColumnName("Krs");
    }

    
}