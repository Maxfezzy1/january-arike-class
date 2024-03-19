
using january_2024;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

    private static void Main(string[] args)
    {
        var customer = new List<Customer>
        {
            new Customer {Id= 101, customerName= "Pedro", phoneNumber="09037887890"},
             new Customer {Id= 102, customerName= "Ifenna", phoneNumber="09037887111"},
              new Customer {Id= 103, customerName= "Chido", phoneNumber="090378878945"}
        };
        var Orders = new List<Order>
        {
            new Order {CustomerId = 101, OrderId = 1, ProductName = "Bag of rice", Productprice= 80000},
            new Order {CustomerId = 102, OrderId = 2, ProductName = "Bag of Beans", Productprice= 60000},
            new Order {CustomerId = 102, OrderId = 3, ProductName = "Bag of Flour", Productprice= 76000},
            new Order {CustomerId = 102, OrderId = 4, ProductName = "Bag of Spag", Productprice= 18000},
            new Order { OrderId = 5, ProductName = "Bag of semo", Productprice= 12000}
        };
        //inner Join or Join
        //method syntax
        var joinList = customer.Join(Orders,
                       x => x.Id, s => s.CustomerId,
                       (x, s) => new
                       {
                           customerName = x.customerName,
                           ItemName = s.ProductName,
                           Amount = s.Productprice
                       }).ToList();
        foreach (var item in joinList)
        {
            Console.WriteLine($"CustomerName: {item.customerName}, ItemName: {item.ItemName}, Amount: {item.Amount}");
        }

        //query syntax
        var queryjoinlist = (from c in customer
                             join o in Orders
                             on c.Id equals o.CustomerId
                             select new
                             {
                                 customerName = c.customerName,
                                 ItemName = o.ProductName,
                                 Amount = o.Productprice
                             }).ToList();
        foreach (var data in queryjoinlist)
        {
            Console.WriteLine($"CustomerName: {data.customerName}, ItemName: {data.ItemName}, Amount: {data.Amount}");
        }

        //LeftJoin
        //Query Syntax

        var queryleftjoin = from c in customer
                            join o in Orders
                            on c.Id equals o.CustomerId
                            into datagroup
                            from groupinfo in datagroup.DefaultIfEmpty()
                            select new
                            {
                                customerName = c.customerName,
                                ItemName = groupinfo?.ProductName,
                                Amount = groupinfo?.Productprice
                            };
        foreach (var data in queryleftjoin)
        {
            Console.WriteLine($"CustomerName: {data.customerName}, ItemName: {data.ItemName}, Amount: {data.Amount}");
        }

        //method syntax
        var methodleftjoin = customer.GroupJoin(Orders,
                              x => x.Id, s => s.CustomerId,
                              (x, s) => new { x, s }
                              ).SelectMany
                              (
                               x => x.s.DefaultIfEmpty(),
                               (cust, ord) => new
                               {
                                   CustomerName = cust.x.customerName,
                                   ItemName = ord == null ? "N/A" : ord.ProductName,
                                   Amount = ord == null ? 0 : ord.Productprice,
                               }).ToList();

        foreach (var data in methodleftjoin)
        {
            Console.WriteLine($"CustomerName: {data.CustomerName}, ItemName: {data?.ItemName}, Amount : {data.Amount}");
        }



        //Right join

        //query syntax

        var queryrightjoin = from c in Orders
                             join o in customer
                             on c.CustomerId equals o.Id
                             into datagroup
                             from groupinfo in datagroup.DefaultIfEmpty()
                             select new
                             {
                                 CustomerName = c.ProductName,
                                 ItemName = groupinfo?.customerName,
                                 Amount = c.Productprice
                             };



        foreach (var data in queryrightjoin)
        {
            Console.WriteLine($"CustomerName: {data.CustomerName}, ItemName: {data?.ItemName}, Amount : {data.Amount}");

        }










    }

}


    
