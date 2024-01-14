using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework_tutorial.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Adress { get; set; }
        public string? Phone { get; set; }
        public ICollection<Order> Orders { get; set; } = null!;  //navigation property

    }
}
