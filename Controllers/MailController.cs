using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TantawanMVC.Models;
using TantawanMVC.Services;

namespace TantawanMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly ILogger<MailController> _logger;
        private readonly IMailService mailService;

        public MailController(ILogger<MailController> logger, IMailService mailService)
        {
            _logger = logger;
            this.mailService = mailService;
        }

        [HttpPost]
        [Route("Send")]
        public async Task<IActionResult> SendMail([FromForm] MailRequest request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}