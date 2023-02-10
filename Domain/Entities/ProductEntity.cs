using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Weight { get; set; }
        public string? Description { get; set; }
        public virtual UserEntity? User { get; set; }
        public long? UserId { get; set; }
        public virtual List<OrderEntity> Orders { get; set; }
    }
}
