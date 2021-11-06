using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car {CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 89, Descriiption = "Seat", ModelYear = "2019"},
                new Car {CarId = 2, BrandId = 1, ColorId = 1, DailyPrice = 119, Descriiption = "VW", ModelYear = "2019"},
                new Car {CarId = 3, BrandId = 3, ColorId = 2, DailyPrice = 189, Descriiption = "Audi", ModelYear = "2021"},
                new Car {CarId = 4, BrandId = 2, ColorId = 3, DailyPrice = 129, Descriiption = "BMW", ModelYear = "2020"},
                new Car {CarId = 5, BrandId = 2, ColorId = 3, DailyPrice = 59, Descriiption = "Fiat", ModelYear = "2020"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(c => c.CarId == car.CarId));
        }

        public List<Car> GetAll()
        {
            return _cars;
        } 
        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return null;
        }

        public Car GetCarById(int carId)
        {
            return _cars.SingleOrDefault(c => c.CarId == carId);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriiption = car.Descriiption;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
