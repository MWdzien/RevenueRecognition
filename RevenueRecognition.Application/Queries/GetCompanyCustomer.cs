using RevenueRecognition.Application.DTOs;
using RevenueRecognition.Shared.Abstractions.Queries;

namespace RevenueRecognition.Application.Queries;

public class GetCompanyCustomer : IQuery<CompanyCustomerDTO>
{
    public string Email { get; set; }
}