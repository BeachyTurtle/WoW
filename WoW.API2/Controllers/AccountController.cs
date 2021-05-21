using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoW.API2.Models.RequestModels;
using WoW.Core.Services;

namespace WoW.API2.Controllers
{
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        [AllowAnonymous]        
        [Route("api/[controller]/authenticate")]
        public async Task<IActionResult> Authenticate(AuthenticationRequestModel model)
        {
            try
            {
                var authenticationResult = await _accountService.Authenticate(model.Email, model.Password);

                if (authenticationResult == null)
                    return BadRequest(new { message = "Failed to Authenticate" });

                return Ok(authenticationResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/[controller]/ping")]
        public IActionResult Get()
        {
            return Ok("Ping!");
        }
    }
}
