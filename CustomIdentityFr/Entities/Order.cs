using CustomIdentityFr.CoreEntity;
using CustomIdentityFr.Entities.Identities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.Entities
{
    public  class Order:BaseEntity<int>
    {
        public int  AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public virtual  ICollection<OrderDetail> OrderDetails  { get; set; }

    }
}
