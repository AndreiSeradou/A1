using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnauthorizedDeliveriesTask3WebApi.Models;

namespace UnauthorizedDeliveriesTask3WebApi.Interfaces.Services
{
    public interface ICsvServices
    {
        Task<List<Response>> GetByDateTimeAsync(Request model);
        Task<List<Response>> GetByDateTimeAndAuthorizedAsync(Request model);
    }
}
