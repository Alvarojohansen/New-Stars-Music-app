﻿using Merchanmusic.Data.Auth0;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Merchanmusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public SettingsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("auth")]
        public ActionResult<PublicAuthSettings> GetPublicAuthSettings()
        {
            try
            {
                var Auth0SettingsDto = new PublicAuthSettings()
                {
                    Domain = _configuration.GetValue<string>("Auth:Domain"),
                    ClientId = _configuration.GetValue<string>("Auth:ClientId")
                };
                return Auth0SettingsDto;
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
