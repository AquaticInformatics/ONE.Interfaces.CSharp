using System;
using System.Collections;
using System.Linq;
using System.Net;
using System.Reflection;
using Claros.Common.Core;
using Claros.Interfaces.CSharp.Utilities;
using FluentAssertions;
using Xunit;

namespace Claros.Interfaces.CSharp.Test.Unit
{
    public class ApiResponseHelperTests
    {
        [Fact]
        public void All_TypeHandlers_Implemented()
        {
            const string moduleName = "Claros.Interfaces.CSharp.dll";
            var clarosContentType = typeof(ClarosContent);

            foreach (var property in clarosContentType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(p => p.CanWrite))
            {
                var propType = property.PropertyType;
                var obj = Activator.CreateInstance(propType);
                var response = ApiResponseHelper.GetFacadeApiResponse(obj, HttpStatusCode.OK);

                response.Should().NotBeNull();
                response.StatusCode.Should().Be((int)HttpStatusCode.OK);
                response.ApiResponse.Content.Should().NotBeNull();

                foreach (var childProperty in property.PropertyType.GetProperties()
                    .Where(x => string.Equals(x.Module.Name, moduleName, StringComparison.OrdinalIgnoreCase)))
                {
                    var isList = childProperty.PropertyType.GetInterface("IList") != null;
                    var isDictionary = childProperty.PropertyType.GetInterface("IDictionary") != null;
                    if (!isList && !isDictionary)
                        continue;

                    var args = childProperty.PropertyType.GetGenericArguments();

                    if (isList)
                        obj = CreateInstance(args[0]);
                    else
                    {
                        var key = CreateInstance(args[0]);
                        var value = CreateInstance(args[1]);
                        obj = Activator.CreateInstance(typeof(DictionaryEntry), key, value);
                    }

                    response = ApiResponseHelper.GetFacadeApiResponse(obj, HttpStatusCode.OK);
                    response.Should().NotBeNull();
                    response.StatusCode.Should().Be((int)HttpStatusCode.OK);
                    response.ApiResponse.Content.Should().NotBeNull();
                }
            }
        }

        [Fact]
        public void Unsupported_Type_Throws_Exception()
        {
            Func<FacadeApiResponse> func = () => ApiResponseHelper.GetFacadeApiResponse(new object(), HttpStatusCode.OK);

            func.Should().Throw<ArgumentException>();
        }

        private static object CreateInstance(Type type)
        {
            if (type == typeof(string))
                return string.Empty;

            return Activator.CreateInstance(type);
        }
    }
}
