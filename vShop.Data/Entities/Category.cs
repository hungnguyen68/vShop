using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vShop.Data.Entities.Enum;

namespace vShop.Data.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int SortOrder { get; set; }
        public bool IsShownOnHome { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
