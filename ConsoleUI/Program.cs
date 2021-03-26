using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarDetailsTest();
            //CarGetAllTest();
            //ColorGetAllTest();
            //BrandGetAllTest();
            //CarGetById();
            //ColorGetById();
            //BrandGetById();
            //CarCrudTest();
            //ColorCrudTest();
            //BrandCrudTest();

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetCustomerDetails();

            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.FirstName + " " + customer.LastName + ", " + customer.Email + ", " + customer.CompanyName);
                }
            }
        }

        private static void BrandCrudTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 4, BrandName = "Tofaş" });
            brandManager.Delete(new Brand { BrandId = 4 });
            brandManager.Update(new Brand { BrandId = 2, BrandName = "Fiat" });
            BrandGetAllTest();
        }

        private static void ColorCrudTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorId = 3, ColorName = "Red" });
            colorManager.Delete(new Color { ColorId = 3 });
            colorManager.Update(new Color { ColorId = 1, ColorName = "Grey" });
            ColorGetAllTest();
        }

        private static void CarCrudTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarId = 7, BrandId = 2, ColorId = 2, ModelYear = "2016", DailyPrice = 500, Description = "Sports Car" });
            carManager.Delete(new Car { CarId = 7 });
            carManager.Update(new Car { CarId = 1, Description = "Automobile" });
            CarGetAllTest();
        }

        private static void BrandGetById()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetById(1);

            if (result.Success)
            {
                Console.WriteLine(result.Data.BrandName);
            }
        }

        private static void ColorGetById()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetById(1);

            if (result.Success)
            {
                Console.WriteLine(result.Data.ColorName);
            }
        }

        private static void CarGetById()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetById(2);


            if (result.Success)
            {
                Console.WriteLine(result.Data.Description);
            }
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();

            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
        }

        private static void ColorGetAllTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetAll();

            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description);
                }
            }
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " - " + car.ColorName + " - " + car.BrandName + " - " + car.DailyPrice);
                }
            }


        }
    }
}
