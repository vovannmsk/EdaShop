using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sportmaster.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Article { get; set; }
        public Category CategoryId { get; set; }
    }
}
