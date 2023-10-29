using ASP.NET_Task1.Entities;
using ASP.NET_Task1.Models;
//using ASP.NET_Task1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Task1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id=1,
                    Name="Coca Cola",
                    Volume=0,
                    Amount=1.9
                },
                new Drink
                {
                    Id=2,
                    Name="Corona",
                    Volume=4.6,
                    Amount=4.8
                },
                new Drink
                {
                    Id=3,
                    Name="Pepsi",
                    Volume=0,
                    Amount=1.89
                },
                new Drink
                {
                    Id=4,
                    Name="Schweppes",
                    Volume=0,
                    Amount=2.4
                },
                new Drink
                {
                    Id=5,
                    Name="Dr Pepper",
                    Volume=0,
                    Amount=3.5
                },
                new Drink
                {
                    Id=5,
                    Name="Tequila",
                    Volume=35,
                    Amount=3.5
                }
            };
            var viewModel = new DrinkViewModel
            {
                Drinks = drinks
            };
            return View(viewModel);
        }


        public ViewResult FastFoods()
        {
            List<FastFood> fastfoods = new List<FastFood>
            {
                new FastFood
                {
                    Id=1,
                    Name="Burger",
                    Rating=2.9,
                    Amount=8.5
                },
                 new FastFood
                {
                    Id=1,
                    Name="Sandwich",
                    Rating=4.5,
                    Amount=3.2
                },
                new FastFood
                {
                    Id=1,
                    Name="Spicy McCrispy",
                    Rating=3.7,
                    Amount=6.5
                },
                new FastFood
                {
                    Id=1,
                    Name="McNuggets",
                    Rating=3,
                    Amount=4.6
                },
                 new FastFood
                {
                    Id=1,
                    Name="Burrito",
                    Rating=8.3,
                    Amount=8.6
                },
                new FastFood
                {
                    Id=1,
                    Name="McChicken",
                    Rating=7.6,
                    Amount=6.8
                }
            };
            var viewModel = new FastFoodViewModel
            {
                FastFoods = fastfoods
            };
            return View(viewModel);
        }


        public ViewResult HotMeals()
        {
            List<HotMeal> hotmeals = new List<HotMeal>
            {
                new HotMeal
                {
                    Id=1,
                    Name="Roasted Lamb",
                    Rating=2.9,
                    Amount=19.4
                },
                 new HotMeal
                {
                    Id=1,
                    Name="Chicken Roll",
                    Rating=4.5,
                    Amount=16.2
                },
                new HotMeal
                {
                    Id=1,
                    Name="Fisinjan Plov",
                    Rating=3.7,
                    Amount=13.9
                },
                new HotMeal
                {
                    Id=1,
                    Name="Jiz-Biz Meatballs",
                    Rating=3,
                    Amount=14.3
                },
                 new HotMeal
                {
                    Id=1,
                    Name="Beef Lokum",
                    Rating=8.3,
                    Amount=15.6
                },
                new HotMeal
                {
                    Id=1,
                    Name="Lamb kebap",
                    Rating=7.6,
                    Amount=20
                }
            };
            var viewModel = new HotMealViewModel
            {
                HotMeals = hotmeals
            };
            return View(viewModel);
        }

    }
}
