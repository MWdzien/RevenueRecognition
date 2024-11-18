using RevenueRecognition.Shared.Abstractions.Commands;

namespace RevenueRecognition.Application.Commands;

public record CreateIndividualCustomer(string Email, string Address, string PhoneNumber, string FirstName, string LastName, string Pesel) : ICommand;

