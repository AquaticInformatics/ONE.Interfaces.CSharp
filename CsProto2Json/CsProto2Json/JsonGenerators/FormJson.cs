using System;
using System.Collections.Generic;
using AutoBogus;
using Claros.Common.Configuration;
using Claros.Common.Core;
using Claros.Common.Form;
using Claros.Common.Gis;
using Claros.Instrument;
using Claros.Instrument.Event;
using Claros.Instrument.Measurement;
using Claros.Operations.Spreadsheet;
using Newtonsoft.Json;

namespace CsProto2Json.JsonGenerators
{
    public static class FormJson
    {

        public static string Generate()
        {
            var obj = new AutoFaker<Form>().Generate();

            var rightsFaker = new AutoFaker<Rights>();
            obj.formTemplate.Privileges.Add(Guid.NewGuid().ToString(), rightsFaker.Generate());
            obj.formTemplate.Privileges.Add(Guid.NewGuid().ToString(), rightsFaker.Generate());

            // formLayout

            obj.formTemplate.formTemplateConfiguration.formLayout = new AutoFaker<FormLayout>().Generate();
            obj.formTemplate.formTemplateConfiguration.formLayout.Sections.AddRange(new AutoFaker<FormSection>().Generate(2));
            obj.formTemplate.formTemplateConfiguration.formLayout.Sections.ForEach(x =>
            {
                x.Columns.AddRange(new AutoFaker<FormColumn>().Generate(2));
                x.Columns.ForEach(c => c.formFieldIds.AddRange(new AutoFaker<string>().Generate(2)));
            });


            // formFieldDefinintions []
            obj.formTemplate.formTemplateConfiguration.formFieldDefinitions.AddRange(new AutoFaker<FormFieldDefinition>().Generate(2));
            obj.formTemplate.formTemplateConfiguration.formFieldDefinitions.ForEach(x =>
            {
                x.textRepeated.formFieldTextRepeateds.AddRange(new AutoFaker<FormFieldText>().Generate(2));

            });

            obj.adHocFormFieldDefinitions.AddRange(new AutoFaker<FormFieldDefinition>().Generate(2));
            obj.adHocFormFieldDefinitions.ForEach(x =>
            {
                x.textRepeated.formFieldTextRepeateds.AddRange(new AutoFaker<FormFieldText>().Generate(2));
            });

            // templateFormFields
            obj.templateFormFields.AddRange(new AutoFaker<FormField>().Generate(2));
            obj.templateFormFields.ForEach(x =>
            {
                x.Cell.Notes.AddRange(new AutoFaker<Note>().Generate(2));
                x.Cell.cellDatas.AddRange(new AutoFaker<CellData>().Generate(2));
                x.Cell.cellDatas.ForEach(d =>
                {
                    d.cellDataBindings.AddRange(new AutoFaker<CellDataBinding>().Generate(2));
                });
                x.instrumentDatas.AddRange(new AutoFaker<InstrumentData>().Generate(2));
                x.instrumentDatas.ForEach(inst =>
                {
                    inst.Events.Calibrations.AddRange(new AutoFaker<EventDataCalibration>().Generate(2));
                    inst.Events.Errors.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
                    inst.Events.Infoes.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
                    inst.Events.Limits.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
                    inst.Events.Prognosys.AddRange(new AutoFaker<EventDataPrognosys>().Generate(2));
                    inst.Events.Reminders.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
                    inst.Events.Warnings.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));

                    inst.Measurements.AddRange(new AutoFaker<InstrumentMeasurementData>().Generate(2));
                    inst.Measurements.ForEach(m =>
                    {
                        m.Gis.MultiPoint2d.Points.AddRange(new AutoFaker<Point2D>().Generate(2));
                        m.Gis.MultiPoint3d.Points.AddRange(new AutoFaker<Point3D>().Generate(2));
                    });

                    inst.Settings.Add(AutoFaker.Generate<string>(), AutoFaker.Generate<string>());
                    inst.Settings.Add(AutoFaker.Generate<string>(), AutoFaker.Generate<string>());

                    inst.States.Add(AutoFaker.Generate<string>(), AutoFaker.Generate<string>());
                    inst.States.Add(AutoFaker.Generate<string>(), AutoFaker.Generate<string>());
                });
            });

            obj.adhocFormFields.AddRange(new AutoFaker<FormField>().Generate(2));

            obj.Notes.AddRange(new AutoFaker<Note>().Generate(2));

            obj.auditEvents.AddRange(new AutoFaker<AuditEvent>().Generate(2));

            var result = JsonConvert.SerializeObject(obj);

            return result;
        }
    }
}
