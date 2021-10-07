using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnauthorizedDeliveriesTask3WebApi.DAL.Entities;
using UnauthorizedDeliveriesTask3WebApi.DAL.Repository;
using UnauthorizedDeliveriesTask3WebApi.Interfaces.Repository;
using UnauthorizedDeliveriesTask3WebApi.table.Class;

namespace UnauthorizedDeliveriesTask3WebApi
{
    static class AddToBase
    {
        static async public void AddToDataBase(IRepository repository, List<PostingsResult> postings, List<Logins> logins)
        {
            foreach (var el in logins) 
            {
                await repository.AddAsync(new CsvEntity
                {
                    AppAccountName = el.AppAccountName,
                    Application = el.Application,
                    Department = el.Department,
                    IsActive = el.IsActive,
                    JobTitle = el.JobTitle
                });
            }

            foreach (var el in postings)
            {
                await repository.AddAsync(new CsvEntity1
                {
                    AmountLC = el.AmountLC,
                    AuthorizedDelivery = el.AuthorizedDelivery,
                    BUn = el.BUn,
                    Crcy = el.Crcy,
                    DocDate = el.DocDate,
                    Item = el.Item,
                    MatDoc = el.MatDoc,
                    MaterialDescription = el.MaterialDescription,
                    PstngDate = el.PstngDate,
                    Quantity = el.Quantity,
                    UserName = el.UserName,
                });
            }
        }
    }
}
