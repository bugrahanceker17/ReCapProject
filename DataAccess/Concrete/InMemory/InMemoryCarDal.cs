using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=3, ColorId=4, DailyPrice=16, ModelYear="2016", Description="Temiz kullanılmış" },
                new Car{Id=2, BrandId=7, ColorId=23, DailyPrice=10, ModelYear="2019", Description="0 gibi" },
                new Car{Id=3, BrandId=12, ColorId=15, DailyPrice=26, ModelYear="2011", Description="120.000 km, temiz." }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(deleteToCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car updateToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
        }
    }
}
