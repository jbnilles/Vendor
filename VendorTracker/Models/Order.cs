using System;
namespace VendorTracker.Models
{
    public class Order
    {
        public string Title {get;set;}
        public string Description {get;set;}
        public double Price {get;set;}
        public int Id {get;set;}
        public int VendorId {get;set;}
        public string VendorName{get;set;}
        public DateTime Date {get;set;}
        public Order(string title, string description, double price, DateTime date, int id, string vendorName, int vendorId)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = date;
            Id = id;
            VendorId = vendorId;
            VendorName = vendorName;
        }
        
        
    }
}