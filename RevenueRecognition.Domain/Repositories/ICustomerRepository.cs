using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.ValueObjects;

namespace RevenueRecognition.Domain.Repositories;

public interface ICustomerRepository
{
    Task<Customer> GetAsync(CustomerId customerId);
    Task AddIndividualAsync(IndividualCustomer customer);
    Task AddCompanyAsync(CompanyCustomer customer);
    Task UpdateIndividualAsync(IndividualCustomer customer);
    Task UpdateCompanyAsync(CompanyCustomer customer);
    Task DeleteIndividualAsync(IndividualCustomer customer);
}