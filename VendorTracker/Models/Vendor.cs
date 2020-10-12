using System.Collections.Generic;
namespace VendorTracker.Models
{
    public class Vendor
    {
        public string Name  {get;set;}
        public string Description {get;set;}
        public int Id {get;set;}

        

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
        
        public void deleteVendor()
        {
            _instances.Remove(this);
        }
        public static void deleteAllVendors()
        {
            _instances.Clear();
        }
        
    }
}