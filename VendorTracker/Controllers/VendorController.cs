using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> vendors = Vendor.getVendors();
      return View(vendors);
    }
    [HttpPost("/vendor")]
    public ActionResult Create(string name, string description)
    {
      new Vendor(name, description);
      List<Vendor> vendors = Vendor.getVendors();
      return RedirectToAction("Index",vendors);
    }
    [HttpGet("/vendor/new")]
    public ActionResult New(){
      return View();
    }
    [HttpGet("/vendor/{id}")]
    public ActionResult Details(int id){
      Vendor v =  Vendor.getVedorById(id);
      return View(v);
    }
    [HttpGet("/vendor/{id}/order/new")]
    public ActionResult NewOrder(int id){
      Vendor v =  Vendor.getVedorById(id);
      return View(v);
    }
    [HttpPost("/vendor/{id}/order/new")]
    public ActionResult CreateOrder(string title, string description, double price, DateTime date, int id){
      Vendor v =  Vendor.getVedorById(id);
      v.addOrder(new Order(title,description,price,date,v.getOrderCount()));
      return RedirectToAction("Details",v);
    }



  }
}