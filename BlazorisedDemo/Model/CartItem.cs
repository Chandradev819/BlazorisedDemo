using System.ComponentModel.DataAnnotations;

namespace BlazorisedDemo.Model
{
    public class CartItem
    {
        public Guid Id { get; set; }
        public string TestType { get; set; }
        public long TestsPerBatch { get; set; }
        public long TotalTests { get; set; }
        public long TypeId { get; set; }
        public long PriceId { get; set; }
        public int NoOfBatches { get; set; }
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ItemPrice { get; set; }
        public string Stripepricingid { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Total { get; set; }
        public string Region { get; set; }
    }
}
