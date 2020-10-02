
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
      Vendor v =  Vendor.getVendorById(id);
      return View(v);
    }
    [HttpGet("/vendor/{id}/order/new")]
    public ActionResult NewOrder(int id){
      Vendor v =  Vendor.getVendorById(id);
      return View(v);
    }
    [HttpPost("/vendor/{id}/order/new")]
    public ActionResult CreateOrder(string title, string description, double price, DateTime orderDate, bool paid, int id){
      Vendor v =  Vendor.getVendorById(id);
      // bool isPaid = true;
      // if(paid != "true")
      // {
      //   isPaid = false;
      // }
      v.addOrder(new Order(title,description,price,orderDate,v.getOrderCount(),v.Name, v.Id, paid ));
      return RedirectToAction("Details");
    }
    [HttpGet("/vendor/{id}/order/{oid}")]
    public ActionResult ShowOrder(int id, int oid){
      Vendor v =  Vendor.getVendorById(id);
      Order o = v.getOrderById(oid);
      return View(o);
    }
    [HttpGet("/vendor/{id}/order/{oid}/delete")]
    public ActionResult DeleteOrder(int id, int oid){
      Vendor v =  Vendor.getVendorById(id);
      v.deleteOrder(oid);
      
      return RedirectToAction("Details");
    }
    [HttpGet("/vendor/{id}/order/deleteAll")]
    public ActionResult DeleteAllOrders(int id){
      Vendor v =  Vendor.getVendorById(id);
      v.deleteAllOrders();;
      return RedirectToAction("Details");
    }


    [HttpGet("/vendor/{id}/delete")]
    public ActionResult DeleteVendor(int id){
      Vendor v =  Vendor.getVendorById(id);
      v.deleteVendor();
      return RedirectToAction("Index");
    }
    [HttpGet("/vendor/deleteAll")]
    public ActionResult DeleteAllVendors(int id){
      Vendor.deleteAllVendors();
      return RedirectToAction("Index");
    }
    [HttpGet("/vendor/{id}/edit")]
    public ActionResult EditVendor(int id){
      Vendor v = Vendor.getVendorById(id);
      return View(v);
    }
    [HttpPost("/vendor/{id}/edit")]
    public ActionResult EditVendor(int id, string name, string description){
      Vendor v = Vendor.getVendorById(id);
      v.Name = name;
      v.Description = description;
      foreach (Order o in v.getOrders())
      {
          o.VendorName = name;
      }
     return RedirectToAction("Details");
    }
    [HttpGet("/vendor/{id}/order/{oid}/edit")]
    public ActionResult EditOrder(int id, int oid){
      Vendor v = Vendor.getVendorById(id);
      Order o = v.getOrderById(oid);
      return View(o);
    }
    [HttpPost("/vendor/{id}/order/{oid}/edit")]
    public ActionResult EditOrder(int id, int oid, string title, string description, double price, DateTime orderDate, bool paid){
      Vendor v = Vendor.getVendorById(id);
      Order o = v.getOrderById(oid);
      o.Title = title;
      o.Description = description;
      o.Price = price;
      o.OrderDate = orderDate;
      o.Paid = paid; 
     return RedirectToAction("ShowOrder");
    }



  }
}