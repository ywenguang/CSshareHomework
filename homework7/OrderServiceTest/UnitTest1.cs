using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ordertest;

namespace OrderServiceTest
{
    [TestClass]
    public class OrderServiceTest
    {
        
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void AddTest()
        {

            OrderService orderService = new OrderService();
            Customer customer1 = new Customer(001, "janny");
            Order order1 = new Order(0011, customer1);
            Goods goods1 = new Goods(00001, "iphone", 4124);
            OrderDetail detail1 = new OrderDetail(goods1,12);
            order1.AddDetails(detail1);
            orderService.AddOrder(order1);
            Assert.IsNotNull(orderService.QueryAll());
         
        }

        [TestMethod]
        public void UpdateTest()
        {
            OrderService orderService = new OrderService();
            Customer customer2 = new Customer(002, "tom");
            Order order2= new Order(0012, customer2);
            Goods goods2 = new Goods(00002, "apple", 1424);
            OrderDetail detail1 = new OrderDetail(goods2,34);
            order2.AddDetails(detail1);
            orderService.Update(order2);
            Assert.IsNotNull(orderService.QueryAll());

        }
        [TestMethod]
        public void GetByIdTest()
        {
            OrderService orderService = new OrderService();
            Customer customer1 = new Customer(001, "janny");
            Order order1 = new Order(0011, customer1);
            Goods goods1 = new Goods(00001, "iphone", 4124);
            OrderDetail detail1 = new OrderDetail(goods1, 12);
            order1.AddDetails(detail1);
            orderService.AddOrder(order1);
            Order od=orderService.GetById(0011);
            Assert.AreEqual(order1, od);
            
        }

        [TestMethod]
        public void RemoveOrderTest()
        {
            OrderService orderService1 = new OrderService();
            Customer customer1 = new Customer(001, "janny");
            Order order1 = new Order(0011, customer1);
            Goods goods1 = new Goods(00001, "iphone", 4124);
            OrderDetail detail1 = new OrderDetail(goods1, 12);
            order1.AddDetails(detail1);
            orderService1.AddOrder(order1);


            OrderService orderService2 = new OrderService();
            Customer customer2 = new Customer(001, "janny");
            Order order2 = new Order(0011, customer1);
            Goods goods2 = new Goods(00001, "iphone", 4124);
            OrderDetail detail2 = new OrderDetail(goods2, 12);
            order2.AddDetails(detail2);
            orderService2.AddOrder(order2);


            Assert.IsNotNull(orderService1.QueryAll());
            orderService2.RemoveOrder(0011);
            Assert.AreNotEqual(orderService1, orderService2);
                
                
                
        }

        [TestMethod]
        public void QueryByGoodsNameTest()
        {
            OrderService orderService = new OrderService();
            Customer customer1 = new Customer(001, "janny");
            Order order1 = new Order(0011, customer1);
            Goods goods1 = new Goods(00001, "iphone", 4124);
            OrderDetail detail1 = new OrderDetail(goods1, 12);
            order1.AddDetails(detail1);
            orderService.AddOrder(order1);
            Assert.IsNotNull(orderService.QueryAll());
            List<Order> list = orderService.QueryByGoodsName("iphone");
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void QueryByCustomerNameTest()
        {
            OrderService orderService = new OrderService();
            Customer customer1 = new Customer(001, "janny");
            Order order1 = new Order(0011, customer1);
            Goods goods1 = new Goods(00001, "iphone", 4124);
            OrderDetail detail1 = new OrderDetail(goods1, 12);
            order1.AddDetails(detail1);
            orderService.AddOrder(order1);
            Assert.IsNotNull(orderService.QueryAll());
            List<Order> list = orderService.QueryByCustomerName("janny");
            Assert.IsNotNull(list);

        }

    }
}
