using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market.Domain
{
    internal class Sale
    {
        public int Id { get; set; }
        public double Total { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }

        public int CostimerId { get; set; }
        public Customer Customer { get; set; }
    }
}
