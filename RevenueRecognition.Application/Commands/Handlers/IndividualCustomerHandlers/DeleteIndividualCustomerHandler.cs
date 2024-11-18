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
        var email = command.Email;
        
        var customer = await _customerRepository.GetAsync(email);

        if (customer is null)
            throw new CustomerNotFoundException(email);

        if (customer is not IndividualCustomer individualCustomer)
            throw new WrongCustomerTypeException(CustomerType.IndividualCustomer, email);
        
        individualCustomer.MarkAsDeleted();
        
        await _customerRepository.DeleteIndividualAsync(individualCustomer);
    }
}