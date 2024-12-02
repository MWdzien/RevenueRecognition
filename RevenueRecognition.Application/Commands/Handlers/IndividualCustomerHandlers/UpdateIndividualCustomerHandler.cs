using RevenueRecognition.Application.Exceptions;
using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.Repositories;
using RevenueRecognition.Shared.Abstractions.Commands;
using RevenueRecognition.Shared.Enums;

namespace RevenueRecognition.Application.Commands.Handlers.IndividualCustomerHandlers;

public class UpdateIndividualCustomerHandler : ICommandHandler<UpdateIndividualCustomer>
{
    private readonly ICustomerRepository _customerRepository;

    public UpdateIndividualCustomerHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task HandleAsync(UpdateIndividualCustomer command)
    {
        var (customerId, email, address, phoneNumber, firstName, lastName) = command;

        var customer = await _customerRepository.GetAsync(customerId);
        
        if (customer is null)
            throw new CustomerNotFoundException(customerId);
        
        if (customer is not IndividualCustomer individualCustomer)
            throw new WrongCustomerTypeException(CustomerType.IndividualCustomer, customerId);
        
        individualCustomer.Update(address, phoneNumber,firstName, lastName);
        
        await _customerRepository.UpdateIndividualAsync(individualCustomer);
    }
}