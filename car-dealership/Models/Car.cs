using System;

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel {get; set;}
    public int Price { get; set }
    public int Miles { get; set; }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }
    
    //BELOW: LONG HAND VERSION OF AUTO-IMPLEMENTED PROPERTIES 

    public string MakeModel 
    {
      get 
      {
        return "That's a big secret. You'll have to visit Lonny's to find out about our special deals!";
      }
      set 
      {
        _makeModel = value;
      }
    }

    public static int Sale(int sale)
    {
     return Price = Price - 10%;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }
  }
}

