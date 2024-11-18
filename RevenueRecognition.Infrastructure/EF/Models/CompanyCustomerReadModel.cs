namespace RevenueRecognition.Infrastructure.EF.Models;

internal class CompanyCustomerReadModel : CustomerReadModel
{
    public string CompanyName { get; set; }
    public string Krs { get; set; }
}