using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

  /// <summary>
  /// OrderDetail class : a entry of an order object
  /// to record the goods and its quantity
  /// </summary>
 public class OrderDetail {


    /// <summary>
    /// default constructor
    /// </summary>
    public OrderDetail() { }

    /// <summary>
    /// OrderDetail constructor
    /// </summary>
    /// <param name="Num">orderDetail's num</param>
    /// <param name="goods">orderDetail's goods</param>
    /// <param name="quantity">goods' quantity</param>
    public OrderDetail(Goods goods, uint quantity) {
      this.Goods = goods;
      this.Quantity = quantity;
    }


    /// <summary>
    /// orderDetail's goods
    /// </summary>
    public Goods Goods { get; set; }

    /// <summary>
    /// goods quantity
    /// </summary>
    public uint Quantity { get; set; }

    /// <summary>
    /// the price amount of the orderDetail
    /// </summary>
    public float Amount {
      get => Goods.Price * Quantity;
    }

    public override bool Equals(object obj) {
      var detail = obj as OrderDetail;
      return detail != null &&
             EqualityComparer<Goods>.Default.Equals(Goods, detail.Goods);
    }

    public override int GetHashCode() {
      return 785010553 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
    }





    /// <summary>
    /// override ToString
    /// </summary>
    /// <returns>string:message of the OrderDetail object</returns>
    public override string ToString() {
      return $"orderDetail:{Goods},{Quantity}";
    }


  }
}
