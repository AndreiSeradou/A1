using Microsoft.EntityFrameworkCore;
using UnauthorizedDeliveriesTask3WebApi.DAL.Entities;

namespace WebApi.Data.DbContext
{
    public class CsvDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<CsvEntity> Csv { get; set; }
        public DbSet<CsvEntity1> Csv1 { get; set; }
        public CsvDBContext(DbContextOptions<CsvDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
    
}