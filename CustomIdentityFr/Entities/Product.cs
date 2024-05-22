using CustomIdentityFr.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.Entities
{
    public  class Product:BaseEntity<int>
    {
        public int CategoryId { get; set; }
        public int StockOfUnit { get; set; }
        public decimal  Price  { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProductCountry>  MedeInCountries { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
