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
            CarDetailsTest();
            CarGetAllTest();
            ColorGetAllTest();
            BrandGetAllTest();
            CarGetById();
            ColorGetById();
            BrandGetById();
            CarCrudTest();
            ColorCrudTest();
            BrandCrudTest();
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
            carManager.Add(new Car { Id = 7, BrandId = 2, ColorId = 2, ModelYear = "2016", DailyPrice = 500, Description = "Sports Car" });
            carManager.Delete(new Car { Id = 7 });
            carManager.Update(new Car { Id = 1, Description = "Automobile" });
            CarGetAllTest();
        }

        private static void BrandGetById()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetById(1).BrandName);
        }

        private static void ColorGetById()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine(colorManager.GetById(1).ColorName);
        }

        private static void CarGetById()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.GetById(2).Description);
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorGetAllTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " - " + car.ColorName + " - " + car.BrandName + " - " + car.DailyPrice);
            }
        }

    }
}
