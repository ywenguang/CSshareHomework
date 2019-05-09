namespace TodoApi.Models
{
    public class TodoItems
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price{get;set;}
        public string Client{get;set;}
        public TodoItems(){}
        public TodoItems(long id,string name,double price,string client)
        {
            Id = id;
            Name = name;
            Price = price;
            client = client;
        }
    }
}