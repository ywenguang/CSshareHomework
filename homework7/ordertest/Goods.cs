using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {
  /// <summary>
  /// Goods class
  /// </summary>
 public class Goods {

    private float price;

    /// <summary>
    /// default constructor
    /// </summary>
    public Goods() { }

    /// <summary>
    /// Goods constuctor
    /// </summary>
    /// <param name="id">goods' id</param>
    /// <param name="name">goods' name</param>
    /// <param name="price">>goods' price</param>
    public Goods(uint id, string name, float price) {
      this.Id = id;
      this.Name = name;
      this.Price = price;
    }

    /// <summary>
    /// property : goods id
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// property : goods name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// property : goods value
    /// </summary>
    public float Price {
      get { return price; }
      set {
        if (value < 0)
          throw new ArgumentOutOfRangeException("value must >= 0!");
        price = value;
      }
    }

    public override bool Equals(object obj) {
      var goods = obj as Goods;
      return goods != null &&
             Id == goods.Id;
    }

    public override int GetHashCode() {
      return 2108858624 + Id.GetHashCode();
    }


    /// <summary>
    /// override ToString
    /// </summary>
    /// <returns>string:message of the Goods object</returns>
    public override string ToString() {
      return $"Id:{Id}, Name:{Name}, Value:{Price}";
    }
  }
}
