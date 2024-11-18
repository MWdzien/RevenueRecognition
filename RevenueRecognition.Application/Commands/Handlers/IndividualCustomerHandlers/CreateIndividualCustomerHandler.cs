using RevenueRecognition.Application.Exceptions;
using RevenueRecognition.Application.Services;
using RevenueRecognition.Domain.Factories;
using RevenueRecognition.Domain.Repositories;
using RevenueRecognition.Shared.Abstractions.Commands;

namespace RevenueRecognition.Application.Commands.Handlers.IndividualCustomerHandlers;

public class CreateIndividualCustomerHandler : ICommandHandler<CreateIndividualCustomer>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly ICustomerFactory _customerFactory;
    private readonly ICustomerReadService _customerReadService;

    public CreateIndividualCustomerHandler(ICustomerRepository customerRepository, ICustomerFactory customerFactory, ICustomerReadService customerReadService)
    {
        _customerRepository = customerRepository;
        _customerFactory = customerFactory;
        _customerReadService = customerReadService;
    }

    public async Task HandleAsync(CreateIndividualCustomer command)
    {
        var (email, address, phoneNumber, firstName, lastName, pesel) = command;
        
        if (await _customerReadService.ExistsByEmailAsync(email))
            throw new CustomerAlreadyExistsException("email", email);

        if (await _customerReadService.ExistsByPeselAsync(pesel))
            throw new CustomerAlreadyExistsException("pesel", pesel);

        var customer =
            _customerFactory.CreateIndividualCustomer(email, address, phoneNumber, firstName, lastName, pesel);

        await _customerRepository.AddIndividualAsync(customer);
    }
}