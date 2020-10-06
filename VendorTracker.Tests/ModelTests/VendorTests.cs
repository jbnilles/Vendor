using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      VendorTracker.Models.Vendor newVendor = new Vendor("name", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendors_getsListOfVendors_ListVendor()
    {
     
      CollectionAssert.AllItemsAreInstancesOfType(Vendor.getVendors(), typeof(Vendor));
    }
    [TestMethod]
    public void AddOrder_AddOrderToInstanceOfVendor_Void()
    {
      VendorTracker.Models.Vendor newVendor = new Vendor("name", "description");
      newVendor.addOrder(new Order("title","desc",2.2,DateTime.Now, newVendor.getOrders().Count, newVendor.Name, newVendor.Id, true));
      Assert.AreEqual(newVendor.getOrders().Count,1);
    }
    [TestMethod]
    public void GetOrders_GetsOrderFromInstanceOfVendor_ListOrders()
    {
      VendorTracker.Models.Vendor newVendor = new Vendor("name", "description");
      CollectionAssert.AllItemsAreInstancesOfType(newVendor.getOrders(), typeof(Order));
    }
    [TestMethod]
    public void getOrdersCount_getCountOfOrdersForTheInstance_int()
    {
      VendorTracker.Models.Vendor newVendor = new Vendor("name", "description");
      newVendor.addOrder(new Order("title","desc",2.2,DateTime.Now, newVendor.getOrders().Count, newVendor.Name, newVendor.Id, true));
      Assert.AreEqual(newVendor.getOrderCount(),1);
    }


  }
}


      
      