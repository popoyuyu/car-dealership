using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class HomeController : Controller
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
    Car yugo = new Car("1980 Yugo Koral", 700, 56000);
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
    Car amc = new Car("1976 AMC Pacer", 400, 198000);

    [HttpGet("/")]
    public ActionResult Index()
    {
      Car.ClearAll();
      return View();
    }

    [HttpPost("/CarList")]
    public ActionResult CarList(int budget)
    {
      List<Car> budgetCars = Car.BudgetList(budget);
      return View(budgetCars);
    }
  }
}