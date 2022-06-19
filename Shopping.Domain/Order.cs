using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain
{
    public class Order
    {
        public Product[] Products { get; set; }

        public double Total { get; set; }
    }
}
