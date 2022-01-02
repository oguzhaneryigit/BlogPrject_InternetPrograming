using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class OperationClaim:IEntity
    {
        [Key]
        public int  ClaimId { get; set; }
        public string ClaimName { get; set; }
    }
}
