using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

  /// <summary>
  /// Customer class
  /// </summary>
  public class Customer {

    /// <summary>
    /// customer's Id
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// customer's name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// default constructor
    /// </summary>
    public Customer() { }

    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="id">customer id</param>
    /// <param name="name">customer name </param>
    public Customer(uint id, string name) {
      this.Id = id;
      this.Name = name;
    }

    
    public override string ToString() {
      return $"customerId:{Id}, CustomerName:{Name}";
    }

    public override bool Equals(object obj) {
      var customer = obj as Customer;
      return customer != null &&
             Id == customer.Id;
    }

    public override int GetHashCode() {
      return 2108858624 + Id.GetHashCode();
    }
  }
}
