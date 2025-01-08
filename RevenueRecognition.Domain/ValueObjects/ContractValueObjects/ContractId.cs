using RevenueRecognition.Domain.Exceptions;
using RevenueRecognition.Domain.Exceptions.ContractExceptions;

namespace RevenueRecognition.Domain.ValueObjects;

public record ContractId
{
    public Guid Value { get; }

    public ContractId(Guid value)
    {
        if (value == Guid.Empty)
            throw new EmptyAttributeException("Contract", nameof(ContractId));
        
        Value = value;
    }
    
    public static implicit operator Guid(ContractId id) => id.Value;
    public static implicit operator ContractId(Guid id) => new(id);
}