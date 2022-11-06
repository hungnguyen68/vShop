using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vShop.Data.Entities.Enum;

namespace vShop.Data.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public Guid? CategoryId { get; set; }
        public Status Status { get; set; }
        public virtual Category? Category { get; set; }

    }
}
