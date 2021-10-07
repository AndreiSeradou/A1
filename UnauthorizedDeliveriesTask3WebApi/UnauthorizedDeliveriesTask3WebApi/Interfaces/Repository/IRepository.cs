using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnauthorizedDeliveriesTask3WebApi.DAL.Entities;

namespace UnauthorizedDeliveriesTask3WebApi.Interfaces.Repository
{
    public interface IRepository
    {
        Task<CsvEntity> AddAsync(CsvEntity csvEntity);
        Task<CsvEntity1> AddAsync(CsvEntity1 csvEntity);
        Task<List<CsvEntity1>> GetByDateTimeAsync(string dateTime);
        Task<List<CsvEntity1>> GetByDateTimeAndAuthorizedAsync(string dateTime, bool isActive);
    }
}
