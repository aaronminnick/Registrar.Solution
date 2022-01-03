using Microsoft.AspNetCore.Mvc;

namespace Registrar.Controllers
{
  public class RegistrarController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}