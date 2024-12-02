using RevenueRecognition.Shared.Abstractions.Commands;

namespace RevenueRecognition.Application.Commands.CompanyCustomerCommands;

public record UpdateCompanyCustomer(Guid CustomerId, string Email, string Address, string PhoneNumber, string CompanyName) : ICommand;