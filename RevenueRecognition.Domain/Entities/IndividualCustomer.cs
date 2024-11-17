using RevenueRecognition.Domain.ValueObjects;

namespace RevenueRecognition.Domain.Entities;

public class IndividualCustomer : Customer
{
    private CustomerName _firstName;
    private CustomerName _lastName;
    private CustomerPesel _pesel;

    internal IndividualCustomer(CustomerName firstName, CustomerName lastName, CustomerPesel pesel, CustomerAddress address, CustomerEmail email, CustomerPhoneNumber phoneNumber)
    {
        _firstName = firstName;
        _lastName = lastName;
        _pesel = pesel;
        Address = address;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    // soft delete 
    public override void MarkAsDeleted()
    {
        IsDeleted = true;
        _firstName = "[deleted]";
        _lastName = "[deleted]";
        _pesel = "[deleted]";
        Address = "[deleted]";
        Email = "[deleted]";
        PhoneNumber = "[deleted]";
    }
}