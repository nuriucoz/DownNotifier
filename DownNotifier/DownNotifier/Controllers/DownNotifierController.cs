using DownNotifier.Entities.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace DownNotifier.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DownNotifierController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<DownNotifierController> _logger;

        public DownNotifierController(ILogger<DownNotifierController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IEnumerable<Site> GetSite()
        {
            Site site = new Site();
            yield return site;
        }
    }
}
