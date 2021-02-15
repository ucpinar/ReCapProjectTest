using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal CarDal)
        {
            _carDal = CarDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int BrandId)
        {
            return _carDal.GetAll(c => c.BrandId == BrandId);
        }

        public List<Car> GetByDailyPrice(int DailyPrice)
        {
            return _carDal.GetAll(c => c.DailyPrace > 0);
        }
    }
}
