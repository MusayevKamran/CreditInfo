using CreditInfo.Domain.Entities;
using CreditInfo.Persistance.Data;
using CreditInfo.Persistance.Repository.Interfaces;

namespace CreditInfo.Persistance.Repository;

public class ContractRepository : Repository<Contract>, IContractRepository
{
    public ContractRepository(CreditInfoDbContext context) : base(context)  { }
}