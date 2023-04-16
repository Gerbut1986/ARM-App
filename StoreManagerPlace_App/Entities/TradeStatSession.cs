namespace StoreManagerPlace_App.Entities
{
    using System;

    public class TradeStatSession
    {
        public int Id { get; set; }
        public string OrderProduct { get; set; }
        public double ItemPrice { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public Guid OrderNumber { get; set; }
    }
}
