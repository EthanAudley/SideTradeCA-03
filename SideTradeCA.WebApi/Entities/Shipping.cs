namespace SideTradeCA.WebApi.Entities
{
    public class Shipping
    {
        public int ShippingId { get; set; }
        public string ShippingType { get; set; }

        public decimal ShippingPrice { get; set; }

    }
}