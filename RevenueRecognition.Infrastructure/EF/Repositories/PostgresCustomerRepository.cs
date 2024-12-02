using Microsoft.EntityFrameworkCore;
using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.Repositories;
using RevenueRecognition.Domain.ValueObjects;
using RevenueRecognition.Infrastructure.EF.Contexts;

namespace RevenueRecognition.Infrastructure.EF.Repositories;

internal sealed class PostgresCustomerRepository : ICustomerRepository
{
    private readonly DbSet<IndividualCustomer> _individualCustomers;
    private readonly DbSet<CompanyCustomer> _companyCustomers;
    private readonly DbSet<Customer> _customers;
    private readonly WriteDbContext _writeDbContext;

    public PostgresCustomerRepository(WriteDbContext writeDbContext)
    {
        _individualCustomers = writeDbContext.IndividualCustomers;
        _companyCustomers = writeDbContext.CompanyCustomers;
        _customers = writeDbContext.Customers;
        _writeDbContext = writeDbContext;
    }

    public Task<Customer> GetAsync(CustomerId customerId)
        => _customers
            //.Include("_contracts")
            .SingleOrDefaultAsync(c => c.CustomerId == customerId);

    public async Task AddIndividualAsync(IndividualCustomer customer)
    {
        await _individualCustomers.AddAsync(customer);
        await _writeDbContext.SaveChangesAsync();
    }

    public async Task AddCompanyAsync(CompanyCustomer customer)
    {
        await _companyCustomers.AddAsync(customer);
        await _writeDbContext.SaveChangesAsync();
    }

    public async Task UpdateIndividualAsync(IndividualCustomer customer)
    {
        _individualCustomers.Update(customer);
        await _writeDbContext.SaveChangesAsync();
    }

    public async Task UpdateCompanyAsync(CompanyCustomer customer)
    {
        _companyCustomers.Update(customer);
        await _writeDbContext.SaveChangesAsync();
    }

    public async Task DeleteIndividualAsync(IndividualCustomer customer)
    {
        _individualCustomers.Update(customer);
        await _writeDbContext.SaveChangesAsync();
    }
}