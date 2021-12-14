using System;
using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    private static List<Car> _instances = new List<Car> { };

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(this);
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }
    public static string MakeSound(string sound)
    {
      return "Our cars sound like" + sound;
    }
    public string GetMakeModel()
    {
      return MakeModel;
    }
    public int GetPrice()
    {
      return Price;
    }
    public int GetMiles()
    {
      return Miles;
    }
    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Car> BudgetList(int maxPrice)
    {
      List<Car> affordableCars = new List<Car> { };
      foreach (Car car in _instances)
      {
        if (car.WorthBuying(maxPrice))
        {
          affordableCars.Add(car);
        }
      }
      return affordableCars;
    }
  }
}

