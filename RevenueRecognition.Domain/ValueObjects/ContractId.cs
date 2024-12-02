using RevenueRecognition.Domain.Exceptions.ContractExceptions;

namespace RevenueRecognition.Domain.ValueObjects;

public class ContractId
{
    public Guid Value { get; }

    public ContractId(Guid value)
    {
        if (value == Guid.Empty)
            throw new EmptyContractAttributeException("");
        
        Value = value;
    }
}