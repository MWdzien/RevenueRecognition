using RevenueRecognition.Shared.Abstractions.Commands;

namespace RevenueRecognition.Application.Commands;

public record UpdateIndividualCustomer(string Email, string Address, string PhoneNumber, string FirstName, string LastName) : ICommand;