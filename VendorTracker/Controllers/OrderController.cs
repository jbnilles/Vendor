using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class OrderController : Controller
  {

    [HttpGet("/order")]
    public ActionResult Index()
    {
      List<Vendor> vendors = Vendor.getVendors();
      return View(vendors);
    }
    
    



  }
}