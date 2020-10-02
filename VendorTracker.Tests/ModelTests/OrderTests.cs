using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title","desc",2.2,DateTime.Now, 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    
    
   
   


  }
}

