using january_2024;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

   private static void Main(string[] args)
   {
        CarModule CarList1 = new CarModule() { CarId = 201, Name = "Honda", Price = 2000000, Model = 2002 };
        CarModule CarList2 = new CarModule() { CarId = 202, Name = "Suv", Price = 2500000, Model = 2005 };
        CarModule CarList3 = new CarModule() { CarId = 203, Name = "Camry", Price = 3200000, Model = 2012 };
        CarModule CarList4 = new CarModule() { CarId = 204, Name = "Toyota", Price = 1000000, Model = 2045 };
        CarModule CarList5 = new CarModule() { CarId = 205, Name = "Tesla", Price = 7420000, Model = 2022 };
        CarModule CarList6 = new CarModule() { CarId = 206, Name = "Bugatti", Price = 1200000, Model = 2010 };

        Dictionary<int,CarModule> Cardictionary = new Dictionary<int,CarModule>();
        Cardictionary.Add(1, CarList1 );
        Cardictionary.Add(CarList2.CarId, CarList2);
        Cardictionary.Add(CarList3.CarId, CarList3);
        Cardictionary.Add(CarList4.CarId, CarList4);
        Cardictionary.Add(CarList5.CarId, CarList5);
        Cardictionary.Add(CarList6.CarId, CarList6);

        foreach (var item in Cardictionary)
        {
            Console.WriteLine("Key"+" "+ item.Key);
           var car = item.Value;
            Console.WriteLine("Name = {0}, Price = {1}, Model = {2}",car.Name,car.Price, car.Model);
        }









    }







}