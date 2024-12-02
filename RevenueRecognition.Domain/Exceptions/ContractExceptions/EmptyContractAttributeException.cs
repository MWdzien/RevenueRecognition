using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Domain.Exceptions.ContractExceptions;

public class EmptyContractAttributeException(string attribute) : RevenueRecognitionException($"Contracts '{attribute}' can not be empty");