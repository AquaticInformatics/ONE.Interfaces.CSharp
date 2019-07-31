using System;
using AutoBogus;
using Claros.Common.Gis;
using Claros.Instrument;
using Claros.Instrument.Event;
using Claros.Instrument.Measurement;
using Newtonsoft.Json;

namespace CsProto2Json
{
    public static class InstrumentDataJson
    {

        public static string Generate()
        {
            AutoFaker.Configure(builder =>
            {
                builder.WithLocale("en")
                    .WithRecursiveDepth(4)
                    .WithRepeatCount(2);
            });

            var instrumentdataFaker = new AutoFaker<InstrumentData>()
                .RuleFor(prop => prop.tenantId, Guid.NewGuid().ToString());

            var instrumentData = instrumentdataFaker.Generate();

            instrumentData.Events.Calibrations.AddRange(new AutoFaker<EventDataCalibration>()
                .RuleFor(x => x.Id, Guid.NewGuid().ToString)
                .RuleFor(x => x.userID, Guid.NewGuid().ToString()).Generate(2));
            instrumentData.Events.Calibrations.ForEach(x =>
            {
                x.calibrationStandards.AddRange(new AutoFaker<EventDataCalibrationStandard>().Generate(2));
                x.calibrationStandards.ForEach(s =>
                    s.secondaryValues.AddRange(new AutoFaker<EventDataCalibrationValue>().Generate(2)));
            });

            instrumentData.Events.Errors.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
            instrumentData.Events.Infoes.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
            instrumentData.Events.Limits.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
            instrumentData.Events.Reminders.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
            instrumentData.Events.Warnings.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
            instrumentData.Events.Prognosys.AddRange(new AutoFaker<EventDataPrognosys>().Generate(2));


            instrumentData.Measurements.AddRange(new AutoFaker<InstrumentMeasurementData>().Generate(2));
            instrumentData.Measurements.ForEach(d =>
            {
                d.Gis.MultiPoint2d.Points.AddRange(new AutoFaker<Point2D>().Generate(2));
                d.Gis.MultiPoint3d.Points.AddRange(new AutoFaker<Point3D>().Generate(2));
                d.measurementEvent.Calibrations.AddRange(new AutoFaker<EventDataCalibration>()
                    .RuleFor(x => x.Id, Guid.NewGuid().ToString)
                    .RuleFor(x => x.userID, Guid.NewGuid().ToString()).Generate(2));
                d.measurementEvent.Calibrations.ForEach(x =>
                {
                    x.calibrationStandards.AddRange(new AutoFaker<EventDataCalibrationStandard>().Generate(2));
                    x.calibrationStandards.ForEach(s =>
                        s.secondaryValues.AddRange(new AutoFaker<EventDataCalibrationValue>().Generate(2)));
                });

                d.measurementEvent.Errors.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
                d.measurementEvent.Infoes.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
                d.measurementEvent.Limits.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
                d.measurementEvent.Reminders.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
                d.measurementEvent.Warnings.AddRange(new AutoFaker<EventDataMetaData>().Generate(2));
                d.measurementEvent.Prognosys.AddRange(new AutoFaker<EventDataPrognosys>().Generate(2));
            });


            instrumentData.Settings.Add(AutoFaker.Generate<string>(), AutoFaker.Generate<string>());
            instrumentData.Settings.Add(AutoFaker.Generate<string>(), AutoFaker.Generate<string>());
            instrumentData.States.Add(AutoFaker.Generate<string>(), AutoFaker.Generate<string>());
            instrumentData.States.Add(AutoFaker.Generate<string>(), AutoFaker.Generate<string>());


            var result = JsonConvert.SerializeObject(instrumentData);
            return result;
        }
    }
}
