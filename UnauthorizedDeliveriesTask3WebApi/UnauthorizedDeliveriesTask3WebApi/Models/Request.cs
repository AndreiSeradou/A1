using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnauthorizedDeliveriesTask3WebApi.Models
{
    public class Request
    {
        [Required]
        public string DocDate { get; set; }
        [Required]
        public string AuthorizedDelivery { get; set; }
    }
}
