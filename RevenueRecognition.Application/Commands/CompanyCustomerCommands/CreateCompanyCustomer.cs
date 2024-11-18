using RevenueRecognition.Shared.Abstractions.Commands;

namespace RevenueRecognition.Application.Commands.CompanyCustomerCommands;

public record CreateCompanyCustomer(string Email, string Address, string PhoneNumber, string CompanyName, string Krs) : ICommand;