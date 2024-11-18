using RevenueRecognition.Application.DTOs;
using RevenueRecognition.Application.Queries;
using RevenueRecognition.Domain.Repositories;
using RevenueRecognition.Shared.Abstractions.Queries;

namespace RevenueRecognition.Infrastructure.Queries.Handlers;

public class GetIndividualCustomerHandler : IQueryHandler<GetIndividualCustomer, IndividualCustomerDTO>
{
    private readonly ICustomerRepository _customerRepository;

    public GetIndividualCustomerHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<IndividualCustomerDTO> HandleAsync(GetIndividualCustomer query)
    {
        var customer = await _customerRepository.GetAsync(query.Email);

        return null;
    }
}