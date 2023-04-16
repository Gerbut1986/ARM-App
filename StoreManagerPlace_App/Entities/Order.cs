namespace StoreManagerPlace_App.Entities
{
    using System;

    public class Order
    {
        public int Id { get; set; }
        public string ListOfProducts { get; set; }
        public string UserName { get; set; }
        public double TotalPrice { get; set; }
        public int UserId { get; set; }
        public Guid OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
