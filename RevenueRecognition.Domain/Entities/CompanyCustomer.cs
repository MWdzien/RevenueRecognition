using RevenueRecognition.Domain.Exceptions;
using RevenueRecognition.Domain.ValueObjects;

namespace RevenueRecognition.Domain.Entities;

public class CompanyCustomer : Customer
{
    private CustomerName _companyName;
    private CustomerKrs _krs;

    internal CompanyCustomer(CustomerName companyName, CustomerKrs krs, CustomerAddress address, CustomerEmail email, CustomerPhoneNumber phoneNumber)
    {
        _companyName = companyName;
        _krs = krs;
        Address = address;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public override void MarkAsDeleted()
    {
        throw new CantDeleteCompanyCustomerException();
    }
}