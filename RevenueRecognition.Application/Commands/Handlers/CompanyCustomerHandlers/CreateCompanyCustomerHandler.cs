using RevenueRecognition.Application.Commands.CompanyCustomerCommands;
using RevenueRecognition.Application.Exceptions;
using RevenueRecognition.Application.Services;
using RevenueRecognition.Domain.Factories;
using RevenueRecognition.Domain.Repositories;
using RevenueRecognition.Shared.Abstractions.Commands;

namespace RevenueRecognition.Application.Commands.Handlers.CompanyCustomerHandlers;

public class CreateCompanyCustomerHandler : ICommandHandler<CreateCompanyCustomer>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly ICustomerReadService _customerReadService;
    private readonly ICustomerFactory _customerFactory;

    public CreateCompanyCustomerHandler(ICustomerRepository customerRepository, ICustomerReadService customerReadService, ICustomerFactory customerFactory)
    {
        _customerRepository = customerRepository;
        _customerReadService = customerReadService;
        _customerFactory = customerFactory;
    }

    public async Task HandleAsync(CreateCompanyCustomer command)
    {
        var (email, address, phoneNumber, companyName, krs) = command;
        
        if (await _customerReadService.ExistsByEmailAsync(email))
            throw new CustomerAlreadyExistsException("email", email);

        if (await _customerReadService.ExistsByKrsAsync(krs))
            throw new CustomerAlreadyExistsException("krs", krs);

        var customer =
            _customerFactory.CreateCompanyCustomer(email, address, phoneNumber, companyName, krs);

        await _customerRepository.AddCompanyAsync(customer);
    }
}