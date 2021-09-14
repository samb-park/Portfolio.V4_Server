using System.Threading.Tasks;
using Business.Repository.IRepository;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Webapi.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : Controller
    {
        private readonly IEmailSender _emailSender;

        public EmailController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost]
        public async Task<IActionResult> SendMail([FromBody] EmailDTO email)
        {
			try
            {
                await _emailSender.SendEmailAsync("","","");
                return Ok(email);
            }
			catch (System.Exception)
			{

                return BadRequest();
			}

        }
    }
}