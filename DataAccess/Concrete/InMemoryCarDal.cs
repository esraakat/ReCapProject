using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; //database

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100, ModelYear = "2010", Description = "Sports car"},
                new Car {Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 200, ModelYear = "2011", Description = "Company Car"},
                new Car {Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 300, ModelYear = "2012", Description = "Convertible"},
                new Car {Id = 4, BrandId = 3, ColorId = 2, DailyPrice = 400, ModelYear = "2013", Description = "Coupe"},
                new Car {Id = 5, BrandId = 4, ColorId = 2, DailyPrice = 500, ModelYear = "2014", Description = "Sports Utility Vehicle"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }


        public void Delete(Car car)
        {
            Car CarDeleted = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(CarDeleted);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car CarUpdated = _cars.SingleOrDefault(c => c.Id == car.Id);
            CarUpdated.BrandId = car.BrandId;
            CarUpdated.ColorId = car.ColorId;
            CarUpdated.DailyPrice = car.DailyPrice;
            CarUpdated.ModelYear = car.ModelYear;
            CarUpdated.Description = car.Description;
        }

    }
}
