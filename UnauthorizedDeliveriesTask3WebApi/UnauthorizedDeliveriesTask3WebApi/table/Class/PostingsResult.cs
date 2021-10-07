using CsvHelper.Configuration.Attributes;

namespace UnauthorizedDeliveriesTask3WebApi.table.Class
{
    class PostingsResult
    {
        [Name("Mat. Doc.")]
        public string MatDoc { get; set; }
        [Name("Item")]
        public string Item { get; set; }
        [Name("Doc. Date")]
        public string DocDate { get; set; }
        [Name("Pstng Date")]
        public string PstngDate { get; set; }
        [Name("Material Description")]
        public string MaterialDescription { get; set; }
        [Name("Quantity")]
        public string Quantity { get; set; }
        [Name("BUn")]
        public string BUn { get; set; }
        [Name("Amount LC")]
        public string AmountLC { get; set; }
        [Name("Crcy")]
        public string Crcy { get; set; }
        [Name("User Name")]
        public string UserName { get; set; }
        [Name("Authorized Delivery")]
        public bool AuthorizedDelivery { get; set; }
    }
}
