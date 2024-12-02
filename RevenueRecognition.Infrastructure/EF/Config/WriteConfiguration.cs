using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.ValueObjects;

namespace RevenueRecognition.Infrastructure.EF.Config;

internal sealed class WriteConfiguration : IEntityTypeConfiguration<Customer>, IEntityTypeConfiguration<IndividualCustomer>, IEntityTypeConfiguration<CompanyCustomer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.CustomerId);

        var customerEmailConverter = new ValueConverter<CustomerEmail, string>(
            e => e.ToString(),
            e => new CustomerEmail(e)
        );
        var customerAddressConverter = new ValueConverter<CustomerAddress, string>(
            a => a.ToString(),
            a => new CustomerAddress(a)
        );
        var customerPhoneNumberConverter = new ValueConverter<CustomerPhoneNumber, string>(
            p => p.ToString(),
            p => new CustomerPhoneNumber(p)
        );

        builder.Property(c => c.CustomerId)
            .HasConversion(
                id => id.Value,
                id => new CustomerId(id)
            );

        builder.Property(typeof(CustomerEmail), "Email")
            .HasConversion(customerEmailConverter)
            .HasColumnName("Email");
        
        builder.Property(typeof(CustomerAddress), "Address")
            .HasConversion(customerAddressConverter)
            .HasColumnName("Address");
        
        builder.Property(typeof(CustomerPhoneNumber), "PhoneNumber")
            .HasConversion(customerPhoneNumberConverter)
            .HasColumnName("PhoneNumber");
        
        //builder.HasMany(typeof())

        builder.ToTable("Customers");
    }

    public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
    {
        builder.HasBaseType<Customer>();

        var nameConverter = new ValueConverter<CustomerName, string>(
            n => n.ToString(),
            n => new CustomerName(n)
        );
        
        var peselConverter = new ValueConverter<CustomerPesel, string>(
            p => p.ToString(),
            p => new CustomerPesel(p)
        );

        builder.Property(typeof(CustomerName), "_firstName")
            .HasConversion(nameConverter)
            .HasColumnName("FirstName");
        
        builder.Property(typeof(CustomerName), "_lastName")
            .HasConversion(nameConverter)
            .HasColumnName("LastName");
        
        builder.Property(typeof(CustomerPesel), "_pesel")
            .HasConversion(peselConverter)
            .HasColumnName("Pesel");

        builder.ToTable("IndividualCustomer");
    }

    public void Configure(EntityTypeBuilder<CompanyCustomer> builder)
    {
        builder.HasBaseType<Customer>();

        var nameConverter = new ValueConverter<CustomerName, string>(
            n => n.ToString(),
            n => new CustomerName(n)
        );

        var krsConverter = new ValueConverter<CustomerKrs, string>(
            k => k.ToString(),
            k => new CustomerKrs(k)
        );
        
        builder.Property(typeof(CustomerName), "_companyName")
            .HasConversion(nameConverter)
            .HasColumnName("CompanyName");
        
        builder.Property(typeof(CustomerKrs), "_krs")
            .HasConversion(krsConverter)
            .HasColumnName("Krs");

        builder.ToTable("CompanyCustomers");
    }
}