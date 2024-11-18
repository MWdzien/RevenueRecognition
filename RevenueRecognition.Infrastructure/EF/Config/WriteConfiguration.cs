using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevenueRecognition.Domain.Entities;

namespace RevenueRecognition.Infrastructure.EF.Config;

internal sealed class WriteConfiguration : IEntityTypeConfiguration<Customer>, IEntityTypeConfiguration<IndividualCustomer>, IEntityTypeConfiguration<CompanyCustomer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        //builder.HasKey(c => c.Email);
    }

    public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
    {
        throw new NotImplementedException();
    }

    public void Configure(EntityTypeBuilder<CompanyCustomer> builder)
    {
        throw new NotImplementedException();
    }
}