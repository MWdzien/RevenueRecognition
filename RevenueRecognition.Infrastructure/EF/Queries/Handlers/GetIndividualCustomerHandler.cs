using Microsoft.EntityFrameworkCore;
using RevenueRecognition.Application.DTOs;
using RevenueRecognition.Application.Queries;
using RevenueRecognition.Infrastructure.EF.Contexts;
using RevenueRecognition.Infrastructure.EF.Models;
using RevenueRecognition.Shared.Abstractions.Queries;

namespace RevenueRecognition.Infrastructure.EF.Queries.Handlers;

internal sealed class GetIndividualCustomerHandler : IQueryHandler<GetIndividualCustomer, IndividualCustomerDTO>
{
    private readonly DbSet<IndividualCustomerReadModel> _individualCustomers;

    public GetIndividualCustomerHandler(ReadDbContext context) => _individualCustomers = context.IndividualCustomers;

    public async Task<IndividualCustomerDTO> HandleAsync(GetIndividualCustomer query)
    {
        return await _individualCustomers
            //.Include() - load contracts
            .Where(cc => cc.CustomerId == query.CustomerId)
            .Select(ic =>
                new
                    IndividualCustomerDTO() //I might reuse that part of a code - optional: implement AsDto() method in extensions class
                    {
                        CustomerId = ic.CustomerId,
                        Email = ic.Email,
                        Address = ic.Address,
                        PhoneNumber = ic.PhoneNumber,
                        FirstName = ic.FirstName,
                        LastName = ic.LastName,
                        Pesel = ic.Pesel
                    })
            .AsNoTracking() //no need for tracking when I don't update the data
            .SingleOrDefaultAsync();
    }
}