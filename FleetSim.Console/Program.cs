using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects;

namespace  FeetSim.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

        var CarCollection = new List<Car>
            {
                new Car {VIN="A1", Mileage=0, Color="Green", LastServicedDate=0, LastServicedMileage=0, Year= 1993, Model="Saturn" },
                new Car {VIN="A2", Color="Blue", LastServicedDate = 0, LastServicedMileage=0, Year=1983, Model="Citation"},
                new Car {VIN="A3", Color = "Yellow", LastServicedDate=0, LastServicedMileage=0, Year = 1981, Model="Ford"},
                new Car {VIN="A4", Color = "Red", LastServicedDate=0, LastServicedMileage=0, Year=2017, Model="900"},
                new Car {VIN="A5", Color = "Black", LastServicedDate=0, LastServicedMileage=0, Year =1951, Model="Mars"}
            };

            foreach (Car Auto in CarCollection)
            {
                int miles = rnd.Next(1, 200000);
            }




        }
    }
}
