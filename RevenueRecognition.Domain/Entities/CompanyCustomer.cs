using RevenueRecognition.Domain.Exceptions;
using RevenueRecognition.Domain.ValueObjects;

namespace RevenueRecognition.Domain.Entities;

public class CompanyCustomer : Customer
{
    private CustomerName _companyName;
    private CustomerKrs _krs;

    internal CompanyCustomer(CustomerEmail email, CustomerAddress address, CustomerPhoneNumber phoneNumber, CustomerName companyName, CustomerKrs krs)
    {
        Email = email;
        Address = address;
        PhoneNumber = phoneNumber;
        _companyName = companyName;
        _krs = krs;
    }

    private CompanyCustomer()
    {
    }

    public void Update(CustomerAddress address, CustomerPhoneNumber phoneNumber, CustomerName companyName)
    {
        _companyName = companyName;
        Address = address;
        PhoneNumber = phoneNumber;
    }

    public override void MarkAsDeleted()
    {
        throw new CantDeleteCompanyCustomerException();
    }
}