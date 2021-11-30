﻿using EstudoDDD.Domain.DTO;
using EstudoDDD.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace EstudoDDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        public async Task<object> Login([FromBody] LoginDTO loginDTO, [FromServices] ILoginService service)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (loginDTO == null)
                return BadRequest();

            try
            {
                var result = await service.FindByLogin(loginDTO);
                if (result != null)
                    return Ok(result);

                else
                    return NotFound();
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
