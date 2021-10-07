using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using UnauthorizedDeliveriesTask3WebApi.table.Class;

namespace UnauthorizedDeliveriesTask3WebApi.table.TableEditor
{
    static class TableEditorPostings
    {
        static public List<Postings> EditingPostings()
        {
            List<Postings> records;

            string pathCsvFile = "C:\\Users\\Макс\\Desktop\\A1\\postings.csv";

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
                Delimiter = ";",
            };

            using (var reader = new StreamReader(pathCsvFile))
            using (var csv = new CsvReader(reader, config))
            {
                records = csv.GetRecords<Postings>().ToList();
                records.RemoveAt(0);
                foreach (var el in records)
                {
                    el.MatDoc = el.MatDoc.Trim();
                    el.Item = el.Item.Trim();
                    el.DocDate = el.DocDate.Trim();
                    el.PstngDate = el.PstngDate.Trim();
                    el.MaterialDescription = el.MaterialDescription.Trim();
                    el.Quantity = el.Quantity.Trim();
                    el.BUn = el.BUn.Trim();
                    el.AmountLC = el.AmountLC.Trim();
                    el.Crcy = el.Crcy.Trim();
                    el.UserName = el.UserName.Trim();
                }
            }

            using (var writer = new StreamWriter(pathCsvFile))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }

            return records;
        }
    }
}
