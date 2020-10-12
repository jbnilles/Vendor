
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class VendorsController : Controller
  {
    public ActionResult Index()
    {
      List<Vendor> vendors = Vendor.getVendors();
      return View(vendors);
    }
    [HttpPost]
    public ActionResult Create(string name, string description)
    {
      new Vendor(name, description);
      List<Vendor> vendors = Vendor.getVendors();
      return RedirectToAction("Index",vendors);
    }
    public ActionResult Create(){
      return View();
    }

    
    public ActionResult Details(int id){
      Vendor v =  Vendor.getVendorById(id);
      ViewBag.Orders = Order.getOrderByVendorId(id);
      return View(v);
    }

    
    
    public ActionResult Delete(int id){
      Vendor v =  Vendor.getVendorById(id);
      v.deleteVendor();
      return RedirectToAction("Index");
    }

   
    public ActionResult DeleteAllVendors(int id){
      Vendor.deleteAllVendors();
      return RedirectToAction("Index");
    }

   
    public ActionResult Edit(int id){
      Vendor v = Vendor.getVendorById(id);
      return View(v);
    }

    [HttpPost]
    public ActionResult Edit(int id, string name, string description){
      Vendor v = Vendor.getVendorById(id);
      v.Name = name;
      v.Description = description;
      foreach (Order o in Order.getOrders())
      {
          o.VendorName = name;
      }
     return RedirectToAction("Details");
    }

    
  }
}