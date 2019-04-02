using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {
    /// <summary>
    /// OrderService:provide ordering service,
    /// like add order, remove order, query order and so on
    /// 实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询)
    /// </summary>
    /// 
    interface IComparable
    {
        // 接口成员
        void SortedById(List<Order> order);
    }


    class OrderService :IComparable{

    private List<Order> orderList;
    /// <summary>
    /// OrderService constructor
    /// </summary>
    public OrderService() {
      orderList = new List<Order>();
    }

    /// <summary>
    /// add new order
    /// </summary>
    /// <param name="order">the order will be added</param>
    public void AddOrder(Order order) {
      foreach (Order o in orderList) {
        if (o.Id.Equals(order.Id)) {
          throw new Exception($"order-{order.Id} is already existed!");
        }
      }
      orderList.Add(order);
    
    }

    /// <summary>
    /// query by orderId
    /// </summary>
    /// <param name="orderId">id of the order to find</param>
    /// <returns>List<Order></returns> 
   /* public Order GetById(uint orderId) {
      foreach (Order o in orderList) {
        if (o.Id == orderId) {
          return o;
        }
      }
      return null;
    }
  */
  public Order GetById(uint orderId)
  {
    var query =form order in orderList
        where order.Id==orderId 
        select ord;
    if(query)
      return query.ToList();
    else
      return null;
  }




    /// <summary>
    /// remove order
    /// </summary>
    /// <param name="orderId">id of the order which will be removed</param> 
    public void RemoveOrder(uint orderId) {
      Order order = GetById(orderId);
      if (order == null) return;
      orderList.Remove(order);
    }

    /// <summary>
    /// query all orders
    /// </summary>
    /// <returns>List<Order>:all the orders</returns> 
    public List<Order> QueryAllOrders() {
      return orderList;
    }

  /*  
    /// <summary>
    /// query by goodsName
    /// </summary>
    /// <param name="goodsName">the name of goods in order's orderDetail</param>
    /// <returns></returns> 
    public List<Order> QueryByGoodsName(string goodsName) {
      List<Order> result = new List<Order>();
      foreach (Order order in orderList) {
        foreach (OrderDetail detail in order.Details) {
          if (detail.Goods.Name == goodsName) {
            result.Add(order);
            break;
          }
        }
      }
      return result;
    }
 */
    public List<Order> QueryByGoodsName(string goodsName) {
      
      var order = from ord in orderList where ord.detail.Goods.Name== goodsName
      select ord;
      if (order)
        return order.ToList();
      else
        return null;  
  
    }    
    /// <summary>
    /// query by customerName
    /// </summary>
    /// <param name="customerName">customer name</param>
    /// <returns></returns> 
    public List<Order> QueryByCustomerName(string customerName) {
      var query = orderList
          .Where(order => order.Customer.Name == customerName);
      return query.ToList();
    }


    public void SortedById(List<Order> order)
        {
            var sorted = order.OrderBy(o => o.Id);
        }

    }

  /// <summary>
        /// 序列化类到xml文档
        /// </summary>
        /// <typeparam name="T">类</typeparam>
        /// <param name="obj">类的对象</param>
        /// <param name="filePath">xml文档路径（包含文件名）</param>
        /// <returns>成功：true，失败：false</returns>
  
  public bool Export<Order>(Order obj,string filePath)
  {
      XmlWriter writer = null;    //声明一个xml编写器
      XmlWriterSettings writerSetting = new XmlWriterSettings //声明编写器设置
          {
              Indent=true,//定义xml格式，自动创建新的行
              Encoding= UTF8Encoding.UTF8,//编码格式
          };

      try
      {
          //创建一个保存数据到xml文档的流
          writer = XmlWriter.Create(filePath, writerSetting);
      }
      catch (Exception ex)
      {
          _logServ.Error(string.Format("创建xml文档失败：{0}",ex.Message));
          return false;
      }

      XmlSerializer xser = new XmlSerializer(typeof(T));  //实例化序列化对象

      try
      {
          xser.Serialize(writer, obj);  //序列化对象到xml文档
      }
      catch (Exception ex)
      {
          _logServ.Error(string.Format("创建xml文档失败：{0}", ex.Message));
          return false;
      }
      finally
      {
          writer.Close();
      }
      return true;
  }

/// <summary>
        /// 从 XML 文档中反序列化为对象
        /// </summary>
        /// <param name="filePath">文档路径（包含文档名）</param>
        /// <param name="type">对象的类型</param>
        /// <returns>返回object类型</returns>
        public static object Import(string filePath, Type type)
        {
            string xmlString = File.ReadAllText(filePath);
 
            if (string.IsNullOrEmpty(xmlString))
            {
                return null;
            }
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(xmlString)))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                try
                {
                    return serializer.Deserialize(stream);
                }
                catch
                {
                    return null;
                }
            }
 
        }

}
