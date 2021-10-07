using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnauthorizedDeliveriesTask3WebApi.DAL.Entities;
using UnauthorizedDeliveriesTask3WebApi.Interfaces.Repository;
using WebApi.Data.DbContext;

namespace UnauthorizedDeliveriesTask3WebApi.DAL.Repository
{
    public class Repository : IRepository
    {
        private readonly CsvDBContext _dbContext;

        public Repository(CsvDBContext dbContext)

        {
            _dbContext = dbContext;
        }

        public async Task<CsvEntity> AddAsync(CsvEntity csvEntity)
        {
            var entityEntry = await _dbContext.Csv.AddAsync(csvEntity).ConfigureAwait(false);
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);
            return entityEntry.Entity;
        }

        public async Task<CsvEntity1> AddAsync(CsvEntity1 csvEntity)
        {
            var entityEntry = await _dbContext.Csv1.AddAsync(csvEntity).ConfigureAwait(false);
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);
            return entityEntry.Entity;
        }

        public async Task<List<CsvEntity1>> GetByDateTimeAndAuthorizedAsync(string dateTime, bool isActive)
        {
            return await _dbContext.Csv1.Where(c => c.DocDate == dateTime && c.AuthorizedDelivery == true).ToListAsync().ConfigureAwait(false);
        }

        public async Task<List<CsvEntity1>> GetByDateTimeAsync(string dateTime)
        {
            return await _dbContext.Csv1.Where(c => c.DocDate == dateTime ).ToListAsync().ConfigureAwait(false);
        }
    }
}
