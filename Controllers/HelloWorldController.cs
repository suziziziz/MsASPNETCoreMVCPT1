using Microsoft.AspNetCore.Mvc;

using System.Text.Encodings.Web;

namespace MsASPNETCoreMVCPT1.Controllers {
  // [Route("[controller]")]
  public class HelloWorldController : Controller {
    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(ILogger<HelloWorldController> logger) {
      _logger = logger;
    }

    public IActionResult Index() {
      return View();
    }

    public IActionResult Welcome(string name, int numTimes = 1) {
      ViewData["Message"] = $"Hello {name}";
      ViewData["NumTimes"] = numTimes;

      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
      return View("Error!");
    }
  }
}