namespace RevenueRecognition.Infrastructure.EF.Models;

internal class CompanyCustomerReadModel
{
    public Guid CustomerId { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string CompanyName { get; set; }
    public string Krs { get; set; }
}