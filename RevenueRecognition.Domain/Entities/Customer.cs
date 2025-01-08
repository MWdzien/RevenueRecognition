using RevenueRecognition.Domain.Enums;
using RevenueRecognition.Domain.Exceptions;
using RevenueRecognition.Domain.Exceptions.CustomerExceptions;
using RevenueRecognition.Domain.ValueObjects;
using RevenueRecognition.Shared.Abstractions.Domain;

namespace RevenueRecognition.Domain.Entities;

public abstract class Customer : AggregateRoot<CustomerEmail>
{
    
    
    public CustomerEmail Email { get; set; }
    protected CustomerAddress Address { get; set; }
    protected CustomerPhoneNumber PhoneNumber { get; set; }

    protected readonly List<Contract> _contracts = new();
    

    protected Customer()
    {
    }

    public abstract void MarkAsDeleted();

    public void AddContract(Contract contract)
    {
        var alreadyExists =
            _contracts.Any(c => c.Customer.Email == contract.Customer.Email 
                                && c.Software == contract.Software && c.ContractStatus != ContractStatus.Inactive);

        if (alreadyExists)
            throw new CustomerContractAlreadyExistsException(Email, contract.Software.Name);
        
        _contracts.Add(contract);
    }
    


}