using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Car car1 = new Car() { Id = 1, Description = "E", DailyPrice = 100};

            CarManager carManager1 = new CarManager(new EfCarDal());
            carManager1.Add(car1);

        }
    }
}