using RevenueRecognition.Application.Commands.CompanyCustomerCommands;
using RevenueRecognition.Application.Exceptions;
using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.Repositories;
using RevenueRecognition.Shared.Abstractions.Commands;
using RevenueRecognition.Shared.Enums;

namespace RevenueRecognition.Application.Commands.Handlers.CompanyCustomerHandlers;

public class UpdateCompanyCustomerHandler : ICommandHandler<UpdateCompanyCustomer>
{
    private readonly ICustomerRepository _customerRepository;

    public UpdateCompanyCustomerHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task HandleAsync(UpdateCompanyCustomer command)
    {
        var (email, address, phoneNumber, companyName) = command;

        var customer = await _customerRepository.GetAsync(email);

        if (customer is null)
            throw new CustomerNotFoundException(email);

        if (customer is not CompanyCustomer companyCustomer)
            throw new WrongCustomerTypeException(CustomerType.CompanyCustomer, email);

        companyCustomer.Update(address, phoneNumber, companyName);

        await _customerRepository.UpdateCompanyAsync(companyCustomer);
    }
}