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
        public InMemoryCarDal()  //constructor
        {
            _cars = new List<Car> { 
            new Car{Id = 1, BrandId = 1, ColorId = 4, DailyPrice = 500, ModelYear = 2008, Description = "toyota"},
            new Car{Id = 2, BrandId = 7, ColorId = 7, DailyPrice = 950, ModelYear = 2006, Description = "audi"},
            new Car{Id = 3, BrandId = 9, ColorId = 12, DailyPrice = 1850, ModelYear = 2010, Description = "bmw"},
            new Car{Id = 4, BrandId = 5, ColorId = 6, DailyPrice = 2500, ModelYear = 2000, Description = "limuzin"},
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

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
