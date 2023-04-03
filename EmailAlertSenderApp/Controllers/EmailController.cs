﻿using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace EmailAlertSenderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        public EmailController(IEmailService emailService)
        {
            _emailService= emailService;
        }
        [HttpPost]
        public IActionResult SendEmail(EmailDTO Request)
        {
            _emailService.SendEmail(Request);
            return Ok();
        }
    }
}