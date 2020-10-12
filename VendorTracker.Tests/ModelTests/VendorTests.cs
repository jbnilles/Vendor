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
    public void GetVendorsById_getsAVendors_Vendor()
    {
     Vendor v = new Vendor("bob", "");
      Assert.IsInstanceOfType(Vendor.getVendorById(0), typeof(Vendor));
    }
    [TestMethod]
    public void DeleteVendor_RevmoveAVendors_Void()
    {
     Vendor.deleteAllVendors();

     Vendor v = new Vendor("bob", "");
     v.deleteVendor();
      Assert.AreEqual(Vendor.getVendors().Count, 0);
    }
    [TestMethod]
    public void DeleteAllVendors_RemoveAllVendors_Void()
    {
     Vendor v = new Vendor("bob", "");
     Vendor.deleteAllVendors();
      Assert.AreEqual(Vendor.getVendors().Count, 0);
    }
    
    

  }
}


      
      
        
        
        
        
      