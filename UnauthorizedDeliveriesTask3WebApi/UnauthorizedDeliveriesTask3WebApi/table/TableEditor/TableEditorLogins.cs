using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using UnauthorizedDeliveriesTask3WebApi.table.Class;

namespace UnauthorizedDeliveriesTask3WebApi.table.TableEditor
{
    static class TableEditorLogins
    {

        static public List<Logins> EditingLogins()
        {
            List<Logins> records;

            string pathCsvFile = "C:\\Users\\Макс\\Desktop\\A1\\logins.csv";

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
                Delimiter = ",",
            };

            using (var reader = new StreamReader(pathCsvFile))
            using (var csv = new CsvReader(reader, config))
            {
                records = csv.GetRecords<Logins>().ToList();
                records.RemoveAt(0);
                foreach (var el in records)
                {
                    el.Application = el.Application.Trim();
                    el.AppAccountName = el.AppAccountName.Trim();
                    el.IsActive = el.IsActive.Trim();
                    el.JobTitle = el.JobTitle.Trim();
                    el.Department = el.Department.Trim();
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
