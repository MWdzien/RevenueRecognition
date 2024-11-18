using RevenueRecognition.Application.DTOs;
using RevenueRecognition.Application.Queries;
using RevenueRecognition.Domain.Repositories;
using RevenueRecognition.Shared.Abstractions.Queries;

namespace RevenueRecognition.Infrastructure.Queries.Handlers;

public class GetCompanyCustomerHandler : IQueryHandler<GetCompanyCustomer, CompanyCustomerDTO>
{
    private readonly ICustomerRepository _customerRepository;

    public GetCompanyCustomerHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<CompanyCustomerDTO> HandleAsync(GetCompanyCustomer query)
    {
        var customer = await _customerRepository.GetAsync(query.Email);

        return null;
    }
}