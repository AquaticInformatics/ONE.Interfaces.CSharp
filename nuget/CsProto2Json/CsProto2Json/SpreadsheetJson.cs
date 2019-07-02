using System;
using System.Collections.Generic;
using AutoBogus;
using Claros.Common.Core;
using Newtonsoft.Json;

namespace CsProto2Json
{

    using Claros.Operations.Spreadsheet;

    public static class SpreadsheetJson
    {
        public static string Generate()
        {
            AutoFaker.Configure(builder =>
            {
                builder.WithLocale("en")
                    .WithRecursiveDepth(10)
                    .WithRepeatCount(3);
            });

            var spreadsheetFaker = new AutoFaker<Spreadsheet>()
                .RuleFor(prop => prop.locationId, Guid.NewGuid().ToString);
            var worksheetFaker = new AutoFaker<Worksheet>();

            var spreadsheetDefinitionFaker = new AutoFaker<SpreadsheetDefinition>();
            var spreadsheet = spreadsheetFaker.Generate();
            var wsdFaker = new AutoFaker<WorksheetDefinition>();
            var rowFaker = new AutoFaker<Row>();
            var columnFaker = new AutoFaker<Column>();
            var cellFaker = new AutoFaker<Cell>();

            spreadsheet.spreadsheetDefinitions.AddRange(spreadsheetDefinitionFaker.Generate(2));

            spreadsheet.Worksheets.AddRange(worksheetFaker.Generate(2));
            spreadsheet.Worksheets.ForEach(ws =>
            {
                var wsDefs = wsdFaker.Generate(2);
                wsDefs.ForEach(wsd =>
                {
                    wsd.Columns.AddRange(columnFaker.Generate(2));
                    wsd.Columns.ForEach(column =>
                    {
                        column.Limits.AddRange(new AutoFaker<Limit>().Generate(2));
                        column.reportableQualiferDefinitions.AddRange(new AutoFaker<ReportableQualifierDefinition>()
                            .Generate(2));
                    });
                });

                ws.worksheetDefinitions.AddRange(wsDefs);

                var rows = rowFaker.Generate(2);
                rows.ForEach(r =>
                {
                    r.Cells.AddRange(cellFaker.Generate(2));
                    r.Cells.ForEach(cell =>
                    {
                        cell.cellDatas.AddRange(new AutoFaker<CellData>().Generate(2));
                        cell.Notes.AddRange(new AutoFaker<Note>().Generate(2));
                        cell.cellDatas.ForEach(cd =>
                        {
                            cd.cellDataBindings.AddRange(new AutoFaker<CellDataBinding>().Generate(2));
                        });
                    });
                });
                ws.Rows.AddRange(rows);
            });
            
            var result = JsonConvert.SerializeObject(spreadsheet);

            return result;
        }
    }
}
