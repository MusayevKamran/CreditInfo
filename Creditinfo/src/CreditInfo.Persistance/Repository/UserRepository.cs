using CreditInfo.Domain.Entities;
using CreditInfo.Persistance.Data;
using CreditInfo.Persistance.Repository.Interfaces;

namespace CreditInfo.Persistance.Repository;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(CreditInfoDbContext context) : base(context)  { }
}