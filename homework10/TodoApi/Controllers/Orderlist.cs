using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;
using System;


namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Orderlist:IComparable<Orderlist>
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }

        public Orderlist()
        {

        }
        public Orderlist(int id,string client,double price,string name)
        {
            this.Id = id;
            this.Client = client;
            this.Price = price;
            this.Name = name;
        }

        public override bool Equals(object obj)
        {
            if(obj is Orderlist)
            {
                Orderlist order = (Orderlist)obj;
                return order.Id == this.Id;
            }
            return false;
        }
        public override string ToString()
        {
            return $"OrderlistId:{Id},Client:{Client},Price:{Price},Name:{Name}";
        }
        public int Compare(Orderlist obj)
        {
            return (int)(this.Id - obj.Id);
        }

        public int CompareTo(Orderlist other)
        {
            throw new NotImplementedException();
        }    
    }
}