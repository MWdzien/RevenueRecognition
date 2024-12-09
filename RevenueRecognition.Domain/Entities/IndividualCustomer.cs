using RevenueRecognition.Domain.ValueObjects;

namespace RevenueRecognition.Domain.Entities;

public class IndividualCustomer : Customer
{
    private CustomerName _firstName;
    private CustomerName _lastName;
    private CustomerPesel _pesel;
    public bool IsDeleted { get; private set;  }

    internal IndividualCustomer(CustomerEmail email, CustomerAddress address, CustomerPhoneNumber phoneNumber, CustomerName firstName, CustomerName lastName, CustomerPesel pesel)
    {
        Email = email;
        Address = address;
        PhoneNumber = phoneNumber;
        _firstName = firstName;
        _lastName = lastName;
        _pesel = pesel;
        IsDeleted = false;
    }

    private IndividualCustomer()
    {
    }

    public void Update(CustomerAddress address, CustomerPhoneNumber phoneNumber, CustomerName firstName, CustomerName lastName)
    {
        Address = address;
        PhoneNumber = phoneNumber;
        _firstName = firstName;
        _lastName = lastName;
    }

    // soft delete 
    public override void MarkAsDeleted()
    {
        IsDeleted = true;
    }
}