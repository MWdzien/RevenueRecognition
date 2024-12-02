using RevenueRecognition.Application.Exceptions;
using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.Repositories;
using RevenueRecognition.Shared.Abstractions.Commands;
using RevenueRecognition.Shared.Enums;

namespace RevenueRecognition.Application.Commands.Handlers.IndividualCustomerHandlers;

public class DeleteIndividualCustomerHandler : ICommandHandler<DeleteIndividualCustomer>
{
    private readonly ICustomerRepository _customerRepository;

    public DeleteIndividualCustomerHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task HandleAsync(DeleteIndividualCustomer command)
    {
        var customerId = command.CustomerId;
        
        var customer = await _customerRepository.GetAsync(customerId);

        if (customer is null)
            throw new CustomerNotFoundException(customerId);

        if (customer is not IndividualCustomer individualCustomer)
            throw new WrongCustomerTypeException(CustomerType.IndividualCustomer, customerId);
        
        individualCustomer.MarkAsDeleted();
        
        await _customerRepository.DeleteIndividualAsync(individualCustomer);
    }
}