using Microsoft.EntityFrameworkCore;
using RevenueRecognition.Application.Services;
using RevenueRecognition.Infrastructure.EF.Models;

namespace RevenueRecognition.Infrastructure.EF.Services;

internal sealed class PostgresCustomerReadService : ICustomerReadService
{
    private readonly DbSet<CustomerReadModel> _customers;
    private readonly DbSet<IndividualCustomerReadModel> _individualCustomers;
    private readonly DbSet<CompanyCustomerReadModel> _companyCustomers;

    public Task<bool> ExistsByEmailAsync(string email)
        => _customers.AnyAsync(c => c.Email == email);

    public Task<bool> ExistsByPeselAsync(string pesel)
        => _individualCustomers.AnyAsync(ic => ic.Pesel == pesel);

    public Task<bool> ExistsByKrsAsync(string krs)
        => _companyCustomers.AnyAsync(cc => cc.Krs == krs);
}