using System.IO;
using System.Linq;
using Claros.Common.Core;
using Google.Protobuf;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Claros.Interfaces.CSharp.Utilities
{
    public static class ApiExceptionHandler
    {
        public static void UseClarosApiExceptionHandling(this IApplicationBuilder app, ILogger logger)
        {
            app.UseExceptionHandler(h =>
            {
                h.Run(async context =>
                {
                    context.Response.StatusCode = 500;
                    var accept = context.Request.Headers["Accept"];
                    var isProtobuf = accept.Any(x => x.Contains("protobuf"));
                    var exceptionHandler = context.Features.Get<IExceptionHandlerFeature>();

                    if (isProtobuf)
                        context.Response.ContentType = accept;
                    else
                        context.Response.ContentType = "application/json";

                    if (exceptionHandler != null)
                    {
                        logger.LogError(exceptionHandler.Error, "An error occurred on the server: {exceptionMessage}", exceptionHandler.Error.Message);

                        var response = new ApiResponse();
                        response.Errors.Add(new ApiError { Code = "ERR-500", Detail = exceptionHandler.Error.Message, StatusCode = 500 });

                        if (isProtobuf)
                        {
                            using (var ms = new MemoryStream(response.ToByteArray()))
                            {
                                await ms.CopyToAsync(context.Response.Body);
                            }
                        }
                        else
                        {
                            await context.Response.WriteAsync(JsonConvert.SerializeObject(response));
                        }
                    }
                });
            });
        }
    }
}
