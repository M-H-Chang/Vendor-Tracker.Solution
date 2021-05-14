
using Microsoft.AspNetCore.Mvc;

namespace VendorOrderTracker.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult HomeIndex()
    {
      return View();
    }

  }
}