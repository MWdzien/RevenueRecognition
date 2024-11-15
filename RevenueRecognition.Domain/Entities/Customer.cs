using RevenueRecognition.Domain.ValueObjects;

namespace RevenueRecognition.Domain.Entities;

public abstract class Customer
{
    public Guid ClientId { get; private set; }

    private CustomerAddress _address;
    private CustomerEmail _email;
    private CustomerPhoneNumber _phoneNumber;

}