using System.Collections.Generic;
using System.Threading.Tasks;
using UnauthorizedDeliveriesTask3WebApi.Interfaces.Repository;
using UnauthorizedDeliveriesTask3WebApi.Interfaces.Services;
using UnauthorizedDeliveriesTask3WebApi.Models;
using UnauthorizedDeliveriesTask3WebApi.table.CompletingTask;
using UnauthorizedDeliveriesTask3WebApi.table.TableEditor;

namespace UnauthorizedDeliveriesTask3WebApi.Services
{
    public class CsvServices : ICsvServices
    {
        private readonly IRepository  _repository;

        public  CsvServices(IRepository  repository)
        {
            _repository = repository;
            AddToBase.AddToDataBase(_repository, CompletingTask3.AddingAFieldAndCompletingATask(TableEditorPostings.EditingPostings(), TableEditorLogins.EditingLogins()), TableEditorLogins.EditingLogins());
        }

        public async Task<List<Response>> GetByDateTimeAndAuthorizedAsync(Request model)
        {
            var mod = await _repository.GetByDateTimeAndAuthorizedAsync(model.AuthorizedDelivery, true).ConfigureAwait(false);
            var responce = new List<Response>();
            foreach (var el in mod)
            {
                responce.Add(new Response
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
            return responce;
        }

        public async Task<List<Response>> GetByDateTimeAsync(Request model)
        {
            var mod = await _repository.GetByDateTimeAndAuthorizedAsync(model.AuthorizedDelivery, true).ConfigureAwait(false);
            var responce = new List<Response>();
            foreach(var el in mod)
            {
                responce.Add(new Response
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
            return responce;
        }
    }
}
