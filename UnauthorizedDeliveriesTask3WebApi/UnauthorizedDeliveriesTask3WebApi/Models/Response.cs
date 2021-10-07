using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnauthorizedDeliveriesTask3WebApi.Models
{
    public class Response
    {
        public string MatDoc { get; set; }
       
        public string Item { get; set; }
       
        public string DocDate { get; set; }
      
        public string PstngDate { get; set; }
       
        public string MaterialDescription { get; set; }
       
        public string Quantity { get; set; }
      
        public string BUn { get; set; }
       
        public string AmountLC { get; set; }
       
        public string Crcy { get; set; }
       
        public string UserName { get; set; }
       
        public bool AuthorizedDelivery { get; set; }
    }
}
