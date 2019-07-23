using System;
using System.Net.Http;
using AutoBogus;
using claros.protogen.common.configuration;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Privileges = claros.protoc.Common.Configuration.Privileges;

namespace Protobuf_Demo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class ConfigurationController : ControllerBase
    {
        private readonly ILogger logger;

        public ConfigurationController(ILogger<SampleController> logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        [HttpGet]
        public IActionResult Get()
        {
            logger.LogInformation("{controllerName} - {verb} called", nameof(SampleController), nameof(HttpMethod.Get));

            var result = new AutoFaker<Configuration>().Generate();

            result.Privileges.Add(Guid.NewGuid().ToString(), new Rights
            {
                Create = true, Delete = true, Edit = false, View = true 
            });

            return Ok(result);
        }
    }
}
