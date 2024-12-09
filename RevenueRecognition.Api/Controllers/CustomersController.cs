using Microsoft.AspNetCore.Mvc;
using RevenueRecognition.Application.Commands;
using RevenueRecognition.Application.Commands.CompanyCustomerCommands;
using RevenueRecognition.Application.Commands.IndividualCustomerCommands;
using RevenueRecognition.Application.DTOs;
using RevenueRecognition.Application.Queries;
using RevenueRecognition.Shared.Abstractions.Commands;
using RevenueRecognition.Shared.Abstractions.Queries;

namespace RevenueRecognition.Api.Controllers;


public class CustomersController : BaseController
{
    private readonly IQueryDispatcher _queryDispatcher;
    private readonly ICommandDispatcher _commandDispatcher;

    public CustomersController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
    {
        _queryDispatcher = queryDispatcher;
        _commandDispatcher = commandDispatcher;
    }

    [HttpGet("individual/{Email}")]
    public async Task<ActionResult<IndividualCustomerDTO>> GetIndividual([FromRoute] GetIndividualCustomer query)
    {
        var result = await _queryDispatcher.QueryAsync(query);

        return OkOrNotFound(result);
    }
    
    [HttpGet("company/{Email}")]
    public async Task<ActionResult<CompanyCustomerDTO>> GetCompany([FromRoute] GetCompanyCustomer query)
    {
        var result = await _queryDispatcher.QueryAsync(query);

        return OkOrNotFound(result);
    }

    [HttpPost("individual")]
    public async Task<IActionResult> PostIndividual([FromBody] CreateIndividualCustomer command)
    {
        await _commandDispatcher.DispatchAsync(command);
        return CreatedAtAction(nameof(GetIndividual), new {email = command.Email}, null);
    }
    
    [HttpPost("company")]
    public async Task<IActionResult> PostCompany([FromBody] CreateCompanyCustomer command)
    {
        await _commandDispatcher.DispatchAsync(command);
        return CreatedAtAction(nameof(GetCompany), new {email = command.Email}, null);
    }

    [HttpPut("individual/{Email}")]
    public async Task<IActionResult> PutIndividual([FromBody] UpdateIndividualCustomer command)
    {
        await _commandDispatcher.DispatchAsync(command);
        return Ok();
    }
    
    [HttpPut("company/{Email}")]
    public async Task<IActionResult> PutCompany([FromBody] UpdateCompanyCustomer command)
    {
        await _commandDispatcher.DispatchAsync(command);
        return Ok();
    }

    [HttpDelete("individual/{Email}")]
    public async Task<IActionResult> DeleteIndividual([FromRoute] DeleteIndividualCustomer command)
    {
        await _commandDispatcher.DispatchAsync(command);
        return Ok();
    }
}