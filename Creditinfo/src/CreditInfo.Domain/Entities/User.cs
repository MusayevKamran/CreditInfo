using CreditInfo.Domain.Enums;

namespace CreditInfo.Domain.Entities;

public class User : BaseEntity
{
    public virtual string? Surname { get; set; }
    public virtual string? Lastname { get; set; }
    public virtual DateTime DateOfBirth { get; set; }
    public virtual Gender Gender { get; set; }
    public virtual Guid NationalId { get; set; }
}