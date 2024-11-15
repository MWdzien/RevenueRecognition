using RevenueRecognition.Domain.ValueObjects;

namespace RevenueRecognition.Domain.Entities;

public class IndividualCustomer : Customer
{
    private CustomerName _firstName;
    private CustomerName _lastName;
    private CustomerPesel _pesel;
}