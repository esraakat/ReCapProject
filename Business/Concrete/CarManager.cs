using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        //bağımlılığı constructor injection ile minimize ediyorum
        public CarManager(ICarDal carDal) 
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))] //carValidator'U kullanarak add metodunu doğrula 
        
        [SecuredOperation("car.add, admin")]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.ProductAdded);


            //if (car.Description.Length >= 2 && car.DailyPrice > 0)
            //{
            //    _carDal.Add(car);
            //    return new SuccessResult(Messages.ProductAdded);
            //}else
            //{
            //    return new ErrorResult(Messages.ProductNameInvalid);
            //}
        }

        public IResult AddTransactionalTest(Car car)
        {
            Add(car); //bunu yaptıktan sonra hata alırsan bu işlemi de iptal

            if (car.ModelYear == "2010")
            {
                throw new Exception();
            }
            Add(car);
            return null;
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.ProductRemoved);
        }

        //[CacheAspect] //key, value ile tutuyoruz
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.ProductsListed);
        }

        //[CacheAspect]
        [PerformanceAspect(5)] //metodun çalışması 5 saniyeyi geçerse beni uyar
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Id == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Id == colorId));
        }

        [CacheRemoveAspect("ICarService.Get")] //bellekte içerisinde get olan tüm key'leri iptal et
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
        }
    }
}