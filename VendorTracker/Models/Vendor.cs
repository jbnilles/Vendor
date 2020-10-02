using System.Collections.Generic;
namespace VendorTracker.Models
{
    public class Vendor
    {
        public string Name  {get;set;}
        public string Description {get;set;}
        public int Id {get;set;}

        private List<Order> orders = new List<Order>{};

        private static List<Vendor> _instances = new List<Vendor>{};

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            Id = _instances.Count;
            _instances.Add(this);
        }
        public static List<Vendor> getVendors()
        {
            return _instances;
        }
        public void addOrder(Order order)
        {
            orders.Add(order);
        }
        public List<Order> getOrders()
        {
            return orders;
        }
        public int getOrderCount()
        {
            return orders.Count;
        }
        public static Vendor getVendorById(int id)
        {
            foreach (Vendor item in _instances)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public Order getOrderById(int id)
        {
            foreach (Order item in orders)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}