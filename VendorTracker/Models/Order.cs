using System;
namespace VendorTracker.Models
{
    public class Order
    {
        public string Title {get;set;}
        public string Description {get;set;}
        public double Price {get;set;}
        public int id {get;set;}
        public DateTime Date {get;set;}
        public Order(string title, string description, double price, DateTime date, int Id)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = date;
            Id = id;
        }
    }
}