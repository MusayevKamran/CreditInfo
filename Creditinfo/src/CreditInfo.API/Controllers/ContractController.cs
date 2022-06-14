using CreditInfo.Application.Interfaces;
using CreditInfo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CreditInfo.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ContractController : ControllerBase
{
    private readonly IContractService _contractService;

    public ContractController(IContractService contractService)
    {
        _contractService = contractService;
    }

    [HttpGet(Name = "signedContractList")]
    public async Task<IEnumerable<Contract>> GetSignedContracts(Guid id)
    {
        return await _contractService.GetUserSignedContractsByNationalId(id);
    }
}