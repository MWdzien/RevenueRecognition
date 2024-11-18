using RevenueRecognition.Application.DTOs;
using RevenueRecognition.Shared.Abstractions.Queries;

namespace RevenueRecognition.Application.Queries;

public class GetIndividualCustomer : IQuery<IndividualCustomerDTO>
{
    public string Email { get; set; }
}