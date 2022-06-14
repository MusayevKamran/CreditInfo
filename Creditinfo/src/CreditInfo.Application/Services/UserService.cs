using CreditInfo.Application.Interfaces;
using CreditInfo.Domain.Entities;
using CreditInfo.Persistance.Repository.Interfaces;

namespace CreditInfo.Application.Services;

public class UserService :IUserService
{
    private readonly IUserRepository _userRepository;
    
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<User?> GetUserById(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new NullReferenceException("Id Can not be null");
        }
        
        return await Task.FromResult(_userRepository.GetById(id));
    }
}