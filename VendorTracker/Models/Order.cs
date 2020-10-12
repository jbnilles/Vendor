using System;
using System.Collections.Generic;
namespace VendorTracker.Models
{
    public class Order
    {
        public string Title {get;set;}
        public string Description {get;set;}
        public double Price {get;set;}
        public bool Paid {get;set;}
        public int Id {get;set;}
        public int VendorId {get;set;}
        public string VendorName{get;set;}
        public DateTime OrderDate {get;set;}
        private static List<Order> _instances = new List<Order>{};
        public Order(string title, string description, double price, DateTime date, int id, string vendorName, int vendorId, bool paid)
        {
            Title = title;
            Description = description;
            Price = price;
            OrderDate = date;
            Id = id;
            VendorId = vendorId;
            VendorName = vendorName;
            Paid = paid;
        }
        public static void addOrder(Order order)
        {
            _instances.Add(order);
        }
        public static void deleteOrder(int oId)
        {
            Order orderToBeDeleted = getOrderById(oId);
            _instances.Remove(orderToBeDeleted);
        }
        public static void deleteAllOrders()
        {
            _instances.Clear();
        }
        public static Order getOrderById(int id)
        {
            foreach (Order item in _instances)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public static List<Order> getOrders()
        {
            return _instances;
        }
        public static int getOrderCount()
        {
            return _instances.Count;
        }
        public static List<Order> getOrderByVendorId(int id)
        {
            List<Order> orders = new List<Order>();
            foreach (Order item in _instances)
            {
                if(item.VendorId == id)
                {
                    orders.Add(item);
                }
            }
            return orders;
        }
        
        
    }
}