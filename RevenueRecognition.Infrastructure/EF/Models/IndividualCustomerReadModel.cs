namespace RevenueRecognition.Infrastructure.EF.Models;

internal class IndividualCustomerReadModel : CustomerReadModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Pesel { get; set; }
    public bool IsDeleted { get; set; }
}