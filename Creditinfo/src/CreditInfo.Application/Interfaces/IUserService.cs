using CreditInfo.Domain.Entities;

namespace CreditInfo.Application.Interfaces;

public interface IUserService
{
    Task<User?> GetUserById(Guid id);
}