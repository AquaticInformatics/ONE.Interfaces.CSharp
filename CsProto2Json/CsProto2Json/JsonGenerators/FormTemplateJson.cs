using System;
using AutoBogus;
using Claros.Common.Configuration;
using Claros.Common.Form;
using Newtonsoft.Json;

namespace CsProto2Json.JsonGenerators
{
    public static class FormTemplateJson
    {

        public static string Generate()
        {
            var obj = new AutoFaker<FormTemplate>().Generate();

            var rightsFaker = new AutoFaker<Rights>();
            obj.Privileges.Add(Guid.NewGuid().ToString(), rightsFaker.Generate());
            obj.Privileges.Add(Guid.NewGuid().ToString(), rightsFaker.Generate());

            // formLayout

            obj.formTemplateConfiguration.formLayout = new AutoFaker<FormLayout>().Generate();
            obj.formTemplateConfiguration.formLayout.Sections.AddRange(new AutoFaker<FormSection>().Generate(2));
            obj.formTemplateConfiguration.formLayout.Sections.ForEach(x=>
            {
                x.Columns.AddRange(new AutoFaker<FormColumn>().Generate(2));
                x.Columns.ForEach(c=> c.formFieldIds.AddRange(new AutoFaker<string>().Generate(2)));
            });


            // formFieldDefinintions []
            obj.formTemplateConfiguration.formFieldDefinitions.AddRange(new AutoFaker<FormFieldDefinition>().Generate(2));
            obj.formTemplateConfiguration.formFieldDefinitions.ForEach(x =>
            {
                x.textRepeated.formFieldTextRepeateds.AddRange(new AutoFaker<FormFieldText>().Generate(2));

            });



            var result = JsonConvert.SerializeObject(obj);

            return result;
        }
    }
}
