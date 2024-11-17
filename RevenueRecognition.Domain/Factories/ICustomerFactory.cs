using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.ValueObjects;

namespace RevenueRecognition.Domain.Factories;

public interface ICustomerFactory
{
    IndividualCustomer CreateIndividualCustomer(CustomerEmail email, CustomerAddress address, CustomerPhoneNumber phoneNumber,
        CustomerName firstName, CustomerName lastName, CustomerPesel pesel);
    CompanyCustomer CreateCompanyCustomer(CustomerEmail email, CustomerAddress address, CustomerPhoneNumber phoneNumber,
        CustomerName companyName, CustomerKrs krs);
}