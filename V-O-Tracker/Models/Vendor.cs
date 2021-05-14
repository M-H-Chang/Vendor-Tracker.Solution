using System.Collections.Generic;

namespace VendorOrderTracker
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public int Id { get; set; }
    public List<Orders> Orders { get; set; }
    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Item = new List<Order> { };
    }

  }
}