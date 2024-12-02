using RevenueRecognition.Application.DTOs;
using RevenueRecognition.Shared.Abstractions.Queries;

namespace RevenueRecognition.Application.Queries;

public class GetIndividualCustomer : IQuery<IndividualCustomerDTO>
{
    public Guid CustomerId { get; set; }
}