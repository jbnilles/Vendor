
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {
    public ActionResult Create(int id){
      Vendor v =  Vendor.getVendorById(id);
      return View(v);
    }
    [HttpPost]
    public ActionResult Create(string title, string description, double price, DateTime orderDate, bool paid, int id){
      Vendor v =  Vendor.getVendorById(id);
      Order.addOrder(new Order(title,description,price,orderDate, Order.getOrderCount(),v.Name, v.Id, paid ));
      return RedirectToAction("Details");
    }
    public ActionResult Details(int id)
    {
      
      Order o = Order.getOrderById(id);
      return View(o);
    }
    public ActionResult Delete(int id){
     
      Order.deleteOrder(id);
      return RedirectToAction("Details");
    }
    public ActionResult DeleteAll(int id){
      
      Order.deleteAllOrders();;
      return RedirectToAction("Index", "Vendors");
    }
    public ActionResult Edit(int id){
      
      Order o = Order.getOrderById(id);
      return View(o);
    }
    [HttpPost]
    public ActionResult Edit(int id, int oid, string title, string description, double price, DateTime orderDate, bool paid){
      Vendor v = Vendor.getVendorById(id);
      Order o = Order.getOrderById(oid);
      o.Title = title;
      o.Description = description;
      o.Price = price;
      o.OrderDate = orderDate;
      o.Paid = paid; 
     return RedirectToAction("Details");
    }
  }
}