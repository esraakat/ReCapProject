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
            //CarManager carManager1 = new CarManager(new EfCarDal());

            //carManager1.Add(new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2015", DailyPrice = 300, Description = "Linea" });
            //carManager1.Add(new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear = "2017", DailyPrice = 400, Description = "Focus" });
            //carManager1.Add(new Car { Id = 3, BrandId = 3, ColorId = 3, ModelYear = "2018", DailyPrice = 500, Description = "A3" });

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { Id = 1, ColorName = "Red" });
            //colorManager.Add(new Color { Id = 2, ColorName = "Blue" });
            //colorManager.Add(new Color { Id = 3, ColorName = "Green" });

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { Id = 1, BrandName = "Fiat" });
            //brandManager.Add(new Brand { Id = 2, BrandName = "Ford" });
            //brandManager.Add(new Brand { Id = 3, BrandName = "Audi" });

            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer { Id = 1, CompanyName = "Fiat" });
            //customerManager.Add(new Customer { Id = 2, CompanyName = "Ford" });
            //customerManager.Add(new Customer { Id = 3, CompanyName = "Audi" });
            //customerManager.Add(new Customer { Id = 4, CompanyName = "BMW" });

            //CarTest();

            //foreach (var customer in customerManager.GetAll().Data)
            //{
            //    Console.WriteLine(customer.CompanyName);
            //}


            //foreach (var car in carManager1.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarName + " - " + car.ColorName + " - " + car.BrandName);
            //}

            //foreach (var car in carManager1.GetAll())
            //{
            //    Console.WriteLine(car.Description);

            //}
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);

            //}
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);

            //}

        }

        private static void CarTest()
        {
            //Car car1 = new Car() { Id = 1, Description = "E", DailyPrice = 100 };
            //CarManager carManager1 = new CarManager(new EfCarDal());
            //carManager1.Add(car1);

            CarManager carManager1 = new CarManager(new EfCarDal());
            var result = carManager1.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName );
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }




        }
    }
}