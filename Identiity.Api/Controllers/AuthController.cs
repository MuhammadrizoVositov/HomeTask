﻿using Identity.Application.Domain.Identity.Models;
using Identity.Application.Domain.Settings;
using Microsoft.AspNetCore.Mvc;

namespace Identiity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly  IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationDetails registrationDetails)
        {
            // Request.Headers.Authorization

            var result = await _authService.RegisterAsync(registrationDetails);
            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDetails loginDetails)
        {
            var result = await _authService.LoginAsync(loginDetails);
            return Ok(result);
        }
    }
}
