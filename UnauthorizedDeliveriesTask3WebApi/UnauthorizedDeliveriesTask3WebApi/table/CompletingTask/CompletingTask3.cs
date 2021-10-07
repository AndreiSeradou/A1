using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnauthorizedDeliveriesTask3WebApi.table.Class;

namespace UnauthorizedDeliveriesTask3WebApi.table.CompletingTask
{
    static class CompletingTask3
    {
        public static List<PostingsResult>  AddingAFieldAndCompletingATask(List<Postings> postings, List<Logins> logins)
        {
            List<PostingsResult> postingsResult = new List<PostingsResult>();
            for (int i = 0; i < postings.Count; i++)
            {
                postingsResult.Add(new PostingsResult
                {
                    MatDoc = postings[i].MatDoc,
                    Item = postings[i].Item,
                    DocDate = postings[i].DocDate,
                    PstngDate = postings[i].PstngDate,
                    MaterialDescription = postings[i].MaterialDescription,
                    BUn = postings[i].BUn,
                    AmountLC = postings[i].AmountLC,
                    Crcy = postings[i].Crcy,
                    UserName = postings[i].UserName,
                    Quantity = postings[i].Quantity,
                    AuthorizedDelivery = false
                });
            }


            foreach (var elPos in postingsResult)
            {
                foreach (var elLog in logins)
                {
                    if (elPos.UserName == elLog.AppAccountName && elLog.IsActive == "True")
                    {
                        elPos.AuthorizedDelivery = true;
                    }
                }
            }
            string pathCsvFile1 = "C:\\Users\\Макс\\Desktop\\A1\\postings.csv";
            using (var writer = new StreamWriter(pathCsvFile1))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(postingsResult);
            }
            return postingsResult;
        }
    }
}
