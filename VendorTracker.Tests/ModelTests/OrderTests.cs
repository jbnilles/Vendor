using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
namespace VendorTracker.Tests.ModelTests
{
    
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            VendorTracker.Models.Order newOrder = new Order("title","desc",2.2,DateTime.Now, Order.getOrders().Count, "bob", 0, true);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void AddOrder_AddOrderToInstanceOfOrders_Void()
        {
        
            Order.addOrder(new Order("title","desc",2.2,DateTime.Now, Order.getOrders().Count, "bob", 0, true));
            Assert.AreEqual(Order.getOrders().Count,1);
        }
        [TestMethod]
        public void GetOrders_GetsOrderFromOrders_ListOrders()
        {
            Order.addOrder(new Order("title","desc",2.2,DateTime.Now, Order.getOrders().Count, "bob", 0, true));
            CollectionAssert.AllItemsAreInstancesOfType(Order.getOrders(), typeof(Order));
        }
        [TestMethod]
        public void getOrdersCount_getCountOfOrdersForOrders_int()
        {
            Order.deleteAllOrders();
            Order.addOrder(new Order("title","desc",2.2,DateTime.Now, Order.getOrders().Count, "bob", 0, true));
        
        Assert.AreEqual(Order.getOrderCount(),1);
        }
        [TestMethod]
        public void GetOrdersByVendorId_GetsOrdersFromOrders_ListOrders()
        {
            Order.addOrder(new Order("title","desc",2.2,DateTime.Now, Order.getOrders().Count, "bob", 0, true));
            CollectionAssert.AllItemsAreInstancesOfType(Order.getOrderByVendorId(0), typeof(Order));
        }
        [TestMethod]
        public void DeleteOrder_RevmoveAnOrder_Void()
        {
            Order.deleteAllOrders();

            Order.addOrder(new Order("title","desc",2.2,DateTime.Now, Order.getOrders().Count, "bob", 0, true));
            Order.deleteOrder(0);
            Assert.AreEqual(Order.getOrders().Count, 0);
        }
        [TestMethod]
        public void DeleteAllOrders_RemoveAllOrders_Void()
        {
            Order.addOrder(new Order("title","desc",2.2,DateTime.Now, Order.getOrders().Count, "bob", 0, true));
            Order.deleteAllOrders();
            Assert.AreEqual(Order.getOrders().Count, 0);
        }

    }
}




        
       
       