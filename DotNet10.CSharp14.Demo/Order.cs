namespace DotNet10.CSharp14.Demo
{
    public class Order
    {
        public string? Status { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Customer? Customer { get; set; }
    }

    public class Customer
    {
        public string? Name { get; set; }
        public Address? ShippingAddress { get; set; }
    }

    public class Address
    {
        public string? City { get; set; }
    }
}