namespace RevenueRecognition.Infrastructure.EF.Models;

public class CustomerReadModel
{
    public Guid CustomerId { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}