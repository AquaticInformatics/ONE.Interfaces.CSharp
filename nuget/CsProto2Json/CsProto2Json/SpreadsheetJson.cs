using System;
using System.Collections.Generic;
using AutoBogus;
using Claros.Common.Computation;
using Claros.Common.Core;
using Claros.Common.Form;
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
            var columnFaker = new AutoFaker<Column>()
                .RuleFor(prop => prop.locationId, Guid.NewGuid().ToString());

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
                        cell.Notes.AddRange(new AutoFaker<Note>()
                                                .RuleFor(prop => prop.Id, Guid.NewGuid().ToString)
                                                .Generate(2));
                        cell.cellDatas.ForEach(cd =>
                        {
                            cd.cellDataBindings.Add( new CellDataBinding{computationBinding = new ComputationBinding{computationId = Guid.NewGuid().ToString()}});
                            cd.cellDataBindings.Add( new CellDataBinding{fieldInstrumentMeasurementBinding =
                            {
                                Timestamp = new AutoFaker<ClarosDateTime>().Generate(),
                                instrumentMeasurementId = Guid.NewGuid().ToString(),
                                unitId = uint.MaxValue
                            }});
                            cd.cellDataBindings.Add( new CellDataBinding
                            {
                                formBinding = new FormBinding
                                {
                                    formFieldId = Guid.NewGuid().ToString(),
                                    formId = Guid.NewGuid().ToString(),
                                    userId = Guid.NewGuid().ToString()
                                }
                            });
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
