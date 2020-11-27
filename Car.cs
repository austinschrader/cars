using System;

using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public bool WorthBuying(int maxPrice)
  {
    return (Price <= maxPrice);
  }
}

public class Program
{

  public static void Main()
  {
    Car bmw = new Car();
    bmw.MakeModel = "2020 X5";
    bmw.Price = 50000;
    bmw.Miles = 10;

    Car yugo = new Car();
    yugo.MakeModel = "1980 Yugo Koral";
    yugo.Price = 5000;
    yugo.Miles = 56000;

    Car ford = new Car();
    ford.MakeModel = "1972 Ford Ram";
    ford.Price = 1400;
    ford.Miles = 230000;

    Car amc = new Car();
    amc.MakeModel = "1976 AMC Pacer";
    amc.Price = 400;
    amc.Miles = 198000;

    List<Car> Cars = new List<Car>() { bmw, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
      }

    }

    foreach (Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }

  }
}