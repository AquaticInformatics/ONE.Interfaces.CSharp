using System;
using System.Collections.Generic;
using System.Text;
using AutoBogus;
using Claros.Instrument;
using Claros.Instrument.Event;
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


            var result = JsonConvert.SerializeObject(instrumentData);
            return result;
        }
    }
}
