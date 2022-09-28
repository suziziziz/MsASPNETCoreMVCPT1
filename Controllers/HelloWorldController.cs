using Microsoft.AspNetCore.Mvc;

using System.Text.Encodings.Web;

namespace MsASPNETCoreMVCPT1.Controllers {
  // [Route("[controller]")]
  public class HelloWorldController : Controller {
    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(ILogger<HelloWorldController> logger) {
      _logger = logger;
    }

    public string Index() {
      return "Hello World!";
    }

    public string Welcome(string name, int numTimes = 1) {
      return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
      return View("Error!");
    }
  }
}