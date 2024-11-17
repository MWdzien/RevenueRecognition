using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.ValueObjects;

namespace RevenueRecognition.Domain.Factories;

internal class CutomerFactory : ICustomerFactory
{
    public IndividualCustomer CreateIndividualCustomer(CustomerEmail email, CustomerAddress address,
        CustomerPhoneNumber phoneNumber, CustomerName firstName, CustomerName lastName, CustomerPesel pesel) 
        => new(firstName, lastName, pesel, address, email, phoneNumber);


    public CompanyCustomer CreateCompanyCustomer(CustomerEmail email, CustomerAddress address,
        CustomerPhoneNumber phoneNumber,
        CustomerName companyName, CustomerKrs krs) 
        => new(companyName, krs, address, email, phoneNumber);
}