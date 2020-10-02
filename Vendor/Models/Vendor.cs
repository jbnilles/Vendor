using System.Collections.Generic;
namespace Vendor.Models
{
    public class Vendor
    {
        public string Name  {get;set;}
        public string Descripion {get;set;}
        public int id {get;set;}
        public List<Order> orders = new List<Order>{};

        public static List<Vendor> vendors = new List<Vendor>{};

        public Vendor(string name, string descripion)
        {
            Name = name;
            Descripion = descripion;
            id = vendors.Count;
            vendors.Add(this);
        }
    }
}