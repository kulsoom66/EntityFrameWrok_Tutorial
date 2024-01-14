namespace Entityframework_tutorial.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }

        public int CustomerId { get; set; }

        public Customers Customers { get; set; } = null!;

        public ICollection<OrderDetail> Orders { get; set; } = null!;
    }
}