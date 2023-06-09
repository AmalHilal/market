using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market.Domain
{
    internal class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public DateTime Year { get; set; }
        public string? Gear { get; set; }
        public double Km { get; set; }

        public List<Part> Parts { get; set; }

    }
}
