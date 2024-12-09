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
        Console.WriteLine(query);
        return await _individualCustomers
            //.Include() - load contracts
            .Where(c => c.Email == query.Email && !c.IsDeleted)
            .Select(c =>
                new
                    IndividualCustomerDTO() //I might reuse that part of a code - optional: implement AsDto() method in extensions class
                    {
                        Email = c.Email,
                        Address = c.Address,
                        PhoneNumber = c.PhoneNumber,
                        FirstName = c.FirstName,
                        LastName = c.LastName,
                        Pesel = c.Pesel
                    })
            .AsNoTracking() //no need for tracking when I don't update the data
            .SingleOrDefaultAsync();
    }
}