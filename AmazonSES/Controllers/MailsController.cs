using AmazonSESTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmazonSESTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailsController : ControllerBase
    {
        private readonly MailService _mailService;
        public MailsController(MailService mailService)
        {
            this._mailService = mailService;
        }
        [HttpPost]
        public async Task<IActionResult> SendMail(MailRequest request)
        {
            await _mailService.SendEmailAsync(request);
            return Ok();
        }
    }
}
