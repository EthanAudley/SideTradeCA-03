namespace SideTradeCA.WebApi.Entities
{
    public class Product
    {
        public decimal ProductId { get; set;}
        public string ProductName { get; set; }

        public decimal CostPrice { get; set; }
        public string ProductDescription { get; set; }

    }
}