using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework_tutorial.Models
{
     public class Product
    {
        [Key] //indicates that Id is primary key
        public int Id { get; set; }
        public string Name { get; set; } =  null!;

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
    }
}
