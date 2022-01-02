using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class UserOperationClaim:IEntity
    {
        [Key]
        public int OpClaimsId { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
