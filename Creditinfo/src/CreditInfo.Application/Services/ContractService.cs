using CreditInfo.Application.Interfaces;
using CreditInfo.Domain.Entities;
using CreditInfo.Persistance.Repository.Interfaces;

namespace CreditInfo.Application.Services;

public class ContractService : IContractService
{
    private readonly IContractRepository _contractRepository;
    private readonly IUserService _userService;
    
    public ContractService(IContractRepository contractRepository, IUserService userService)
    {
        _contractRepository = contractRepository;
        _userService = userService;
    }
    public async Task<IEnumerable<Contract>> GetUserSignedContractsByNationalId(Guid id)
    {
        var user = await _userService.GetUserById(id);

        if (user == null) return new List<Contract>();
        
        var categories =  _contractRepository.GetAll().Where(filter => filter.IsSigned == true && filter.UserId == user.Id).AsEnumerable();
        
        return await Task.FromResult(categories);

    }
}