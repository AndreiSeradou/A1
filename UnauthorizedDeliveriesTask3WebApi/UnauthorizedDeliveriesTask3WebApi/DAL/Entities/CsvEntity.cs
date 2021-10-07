using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnauthorizedDeliveriesTask3WebApi.DAL.Entities
{
    public class CsvEntity 
    {
        public string Application { get; set; }

        public string AppAccountName { get; set; }

        public string IsActive { get; set; }

        public string JobTitle { get; set; }

        public string Department { get; set; }
    }
}
