using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.ValueObjects;

namespace RevenueRecognition.Domain.Factories;

public sealed class CustomerFactory : ICustomerFactory
{
    public IndividualCustomer CreateIndividualCustomer(CustomerEmail email, CustomerAddress address,
        CustomerPhoneNumber phoneNumber, CustomerName firstName, CustomerName lastName, CustomerPesel pesel) 
        => new(email, address, phoneNumber, firstName, lastName, pesel);


    public CompanyCustomer CreateCompanyCustomer(CustomerEmail email, CustomerAddress address,
        CustomerPhoneNumber phoneNumber,
        CustomerName companyName, CustomerKrs krs) 
        => new(email, address, phoneNumber, companyName, krs);
}