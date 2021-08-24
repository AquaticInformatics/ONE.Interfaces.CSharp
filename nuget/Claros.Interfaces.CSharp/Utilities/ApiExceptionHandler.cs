using System;
using System.IO;
using System.Linq;
using Claros.Common.Core;
using Claros.Interfaces.CSharp.Core;
using Google.Protobuf;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Claros.Interfaces.CSharp.Utilities
{
    [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
    public static class ApiExceptionHandler
    {
        [Obsolete("This code has been moved to the Hach.Fusion.Shared.Core package", false)]
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

                    if (exceptionHandler?.Error != null)
                    {
                        var error = SharedErrors.UnexpectedError(context.Request.Query["requestId"]);
                        logger.LogError(exceptionHandler.Error, "Message: {message}", error.Detail);

                        var response = new ApiResponse();
                        response.Errors.Add(error);

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
