using System;
using System.Collections.Generic;
using AutoBogus;
using Claros.Common;
using Claros.Common.Computation;
using Claros.Common.Core;
using Claros.Common.Form;
using Claros.Instrument.Measurement;
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
                        column.reportableQualifierDefinitions.AddRange(new AutoFaker<ReportableQualifierDefinition>()
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
                        cell.cellDatas.Add(new AutoFaker<CellData>().Generate());
                        cell.Notes.AddRange(new AutoFaker<Note>()
                                                .RuleFor(prop => prop.Id, Guid.NewGuid().ToString)
                                                .RuleFor(prop => prop.userId, Guid.NewGuid().ToString)
                                                .Generate(2));
                        cell.cellDatas.ForEach(cd =>
                        {
                            cd.cellDataBindings.Add(new CellDataBinding { computationBinding = new ComputationBinding { computationId = Guid.NewGuid().ToString() } });
                            cd.cellDataBindings.Add(new CellDataBinding
                            {
                                fieldInstrumentMeasurementBinding = new InstrumentMeasurementFieldBinding
                                {
                                    Timestamp = new AutoFaker<ClarosDateTime>().Generate(),
                                    instrumentMeasurementId = Guid.NewGuid().ToString(),
                                    unitId = uint.MaxValue
                                }
                            });
                            cd.cellDataBindings.Add(new CellDataBinding
                            {
                                formBinding = new FormBinding
                                {
                                    formFieldId = Guid.NewGuid().ToString(),
                                    formId = Guid.NewGuid().ToString(),
                                    userId = Guid.NewGuid().ToString()
                                }
                            });
                            cd.cellDataBindings.Add(new CellDataBinding
                            {
                                instrumentMeasurementBinding = new InstrumentMeasurementBinding
                                {
                                    unitId = 1,
                                    instrumentMeasurementId = Guid.NewGuid().ToString(),
                                    enumAggregate = EnumAggregate.AggregateAverage
                                }
                            });
                            cd.cellDataBindings.Add(new CellDataBinding
                            {
                                spreadsheetBinding = new SpreadsheetBinding
                                {
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
