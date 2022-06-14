using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditInfo.Domain.Entities
{
    public class Contract : BaseEntity
    {
        public virtual string? Name { get; set; }
        public virtual bool IsSigned { get; set; }
        public virtual Guid UserId { get; set; }
    }
}
