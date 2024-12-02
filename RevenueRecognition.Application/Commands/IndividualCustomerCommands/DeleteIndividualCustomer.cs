using RevenueRecognition.Shared.Abstractions.Commands;

namespace RevenueRecognition.Application.Commands;

public record DeleteIndividualCustomer(Guid CustomerId) : ICommand;