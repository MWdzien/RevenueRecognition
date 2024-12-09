using Microsoft.EntityFrameworkCore;
using RevenueRecognition.Application.DTOs;
using RevenueRecognition.Application.Queries;
using RevenueRecognition.Domain.Repositories;
using RevenueRecognition.Infrastructure.EF.Contexts;
using RevenueRecognition.Infrastructure.EF.Models;
using RevenueRecognition.Shared.Abstractions.Queries;

namespace RevenueRecognition.Infrastructure.Queries.Handlers;

internal sealed class GetCompanyCustomerHandler : IQueryHandler<GetCompanyCustomer, CompanyCustomerDTO>
{
    private readonly DbSet<CompanyCustomerReadModel> _companyCustomers;

    public GetCompanyCustomerHandler(ReadDbContext context) => _companyCustomers = context.CompanyCustomers;

    public async Task<CompanyCustomerDTO> HandleAsync(GetCompanyCustomer query)
    {
        Console.WriteLine(query.Email);
        Console.WriteLine(query.Email);
        return await _companyCustomers
            //.Include() - load contracts
            .Where(c => c.Email == query.Email)
            .Select(c =>
                new
                    CompanyCustomerDTO() //I might reuse that part of a code - optional: implement AsDto() method in extensions class
                    {
                        Email = c.Email,
                        Address = c.Address,
                        PhoneNumber = c.PhoneNumber,
                        CompanyName = c.CompanyName,
                        Krs = c.Krs
                    })
            .AsNoTracking() //no need for tracking when I don't update the data
            .SingleOrDefaultAsync();
    }
}