using Microsoft.AspNetCore.Mvc;
using MonBackendVTC.Models;
using MonBackendVTC.Services;

namespace MonBackendVTC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DevisController : ControllerBase
    {
        private readonly EmailService _emailService;

        public DevisController(EmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult Envoyer([FromBody] DevisRequest devis)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _emailService.EnvoyerDevis(devis);
            return Ok(new { message = "Devis envoyé avec succès." });
        }
    }
}
