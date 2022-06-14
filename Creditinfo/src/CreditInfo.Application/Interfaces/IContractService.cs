using CreditInfo.Domain.Entities;

namespace CreditInfo.Application.Interfaces;

public interface IContractService
{
    Task<IEnumerable<Contract>> GetUserSignedContractsByNationalId(Guid nationalId);
}