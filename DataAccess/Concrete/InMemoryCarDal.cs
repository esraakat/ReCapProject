﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() {
                new Car{Id = 1, BrandId = 1, ColorId = 3, ModelYear = "2015", DailyPrice = 3000, Description = "Car1"},
                new Car{Id = 2, BrandId = 3, ColorId = 1, ModelYear = "2017", DailyPrice = 4000, Description = "Car2"},
                new Car{Id = 3, BrandId = 2, ColorId = 1, ModelYear = "2018", DailyPrice = 5000, Description = "Car3"},
                new Car{Id = 4, BrandId = 1, ColorId = 2, ModelYear = "2013", DailyPrice = 3500, Description = "Car4"},
                new Car{Id = 1, BrandId = 1, ColorId = 3, ModelYear = "2015", DailyPrice = 3000, Description = "Car5"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carUpdated = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdated.BrandId = car.BrandId;
            carUpdated.ColorId = car.ColorId;
            carUpdated.ModelYear = car.ModelYear;
            carUpdated.DailyPrice = car.DailyPrice;
            carUpdated.Description = car.Description;
        }
    }
}
