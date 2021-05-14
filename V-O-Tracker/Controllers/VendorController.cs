using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult VendorIndex()
    {
      List<Vendor> allVendor = Vendor.GetAll();
      return View(allVendor);
    }
  }
}