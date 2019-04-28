using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data.Entity;
using System.Collections;


namespace ordertest {
  /// <summary>
  /// OrderService
  /// </summary>
  public class OrderService {

    private List<Order> orderList;
    /// <summary>
    /// constructor
    /// </summary>
    public OrderService() {
      orderList = new List<Order>();
    }

    /// <summary>
    /// add new order
    /// </summary>
    /// <param name="order">the order to be added</param>
    /*public void AddOrder(Order order) {
      if (orderList.Contains(order)) {
        throw new ApplicationException($"the orderList contains an order with ID {order.Id} !");
      }
      orderList.Add(order);
    }
    */

    public void AddOrder(Order order)
        {
            using (var db=new OrderDB())
            {
                db.Entry(order).State = EntityState.Added;
                db.SaveChanges();
            }
        }




    /// <summary>
    /// update the order
    /// </summary>
    /// <param name="order">the order to be updated</param>
    /*public void Update(Order order) {
      RemoveOrder(order.Id);
      orderList.Add(order);
    }
    */
    public void updata(Order order,List<OrderDetail> removed,List<OrderDetail> newDetails)
        {
            using (var db = new OrderDB())
            {
                order.Details.AddRange(newDetails);
                foreach(OrderDetail Detail in order.Details)
                {
                    if (removed.Contains(Detail))
                        db.Entry(Detail).State = EntityState.Deleted;
                    else if (newDetails.Contains(Detail))
                    {
                        db.Entry(Detail).State = EntityState.Added;

                    }
                    else
                    {
                        db.Entry(Detail).State = EntityState.Modified;

                    }
                }
                db.SaveChanges();
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                
            }
        }
        

    /// <summary>
    /// query by orderId
    /// </summary>
    /// <param name="orderId">id of the order to find</param>
    /// <returns>List<Order></returns> 
 /*  public Order GetById(int orderId) {
      return orderList.FirstOrDefault(o => o.Id == orderId);
    }

    */
    
    public Order GetById(int orderId)
    {
        using (var db = new OrderDB())
        {
            return db.Order.Include("Details").SingleOrDefault(o => o.Id == orderId);
        }
    
    }
            
    /// <summary>
    /// remove order
    /// </summary>
    /// <param name="orderId">id of the order which will be removed</param> 
    /*public void RemoveOrder(int orderId) {
         orderList.RemoveAll(o => o.Id == orderId);
    }

   */
    public void RemoveOrder(int orderId)
    {
            using (var db = new OrderDB())
            {
                var order = db.Order.Include("Details").SingleOrDefault(o => o.Id == orderId);
                db.OrderDetail.RemoveRange(order.Details);
                db.Order.Remove(order);
                db.SaveChanges();

            }
    }
     



    /// <summary>
    /// query all orders
    /// </summary>
    /// <returns>List<Order>:all the orders</returns> 
    /*public List<Order> QueryAll() {
      return orderList;
    }*/
    public List<Order> QueryAll()
    {
        using (var db = new OrderDB())
        {
            return db.Order.Include("Details").ToList<Order>();

        }
    }





    /// <summary>
    /// query by goodsName
    /// </summary>
    /// <param name="goodsName">the name of goods in order's orderDetail</param>
    /// <returns></returns> 
    /*public List<Order> QueryByGoodsName(string goodsName) {
      var query = orderList.Where(
        o => o.Details.Exists(
          d => d.Goods.Name == goodsName));
      return query.ToList();
    }
    */
    public List<Order> QueryByGoodsName(string goodsName)
        {
            using (var db=new OrderDB())
            {
                var query = db.Order.Include("Details")
                    .Where(o => o.Details.Where(detail => detail.Goods.Equals(goodsName)).Count() > 0);
                return query.ToList<Order>();

            }
        }
   
    /// <summary>
    /// query orders whose totalAmount >= totalAmount
    /// </summary>
    /// <param name="totalAmount">the minimum totalAmount</param>
    /// <returns></returns> 
    /*    public List<Order> QueryByTotalAmount(float totalAmount) {
      var query = orderList.Where(o=>o.TotalAmount>=totalAmount);
      return query.ToList();
    }*/

    public List<Order> QueryByTotalAmount(float totalAmount)
    {
            using (var db = new OrderDB())
            {
                var query = db.Order.Include("Details")
                    .Where(o => o.Details.Where(detail => detail.Goods.Equals(totalAmount)).Count() > 0);
                return query.ToList<Order>();

            }
    }
        /// <summary>
        /// query by customerName
        /// </summary>
        /// <param name="customerName">customer name</param>
        /// <returns></returns> 
        /*public List<Order> QueryByCustomerName(string customerName) {
           var query = orderList
               .Where(o => o.Customer.Name == customerName);
           return query.ToList();
         }*/
        public List<Order> QueryByCustomerName(string customerName)
        {
           using (var db=new OrderDB())
            {
                return db.Order.Include("Details").Where(o => o.Customer.Equals(customerName)).ToList<Order>();
            }
        }


    public void Sort(Comparison<Order> comparison) {
      orderList.Sort(comparison);
    }

    /// <summary>
    /// Exprot the orders to an xml file.
    /// </summary>
    public void Export(String fileName) {
      if (Path.GetExtension(fileName) != ".xml")
        throw new ArgumentException("the exported file must be a xml file!");
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(fileName, FileMode.Create)) {
        xs.Serialize(fs, this.orderList);
      }
    }

    /// <summary>
    /// import from an xml file
    /// </summary>
    public List<Order> Import(string path) {
      if (Path.GetExtension(path) != ".xml")
        throw new ArgumentException($"{path} isn't a xml file!");
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      List<Order> result = new List<Order>();
      try {
        using (FileStream fs = new FileStream(path, FileMode.Open)) {
          return (List<Order>)xs.Deserialize(fs);
        }
      }catch(Exception e) {
        throw new ApplicationException("import error:" + e.Message);
      }
     
    }

  }
}
