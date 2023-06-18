using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {

                new Car{Id=1,BrandId=1,ColorId=7,CarName="Mercedes",DailyPrice=250,Description=3,ModelYear=2016},
                new Car{Id=2,BrandId=3,ColorId=3,CarName="TOGG",DailyPrice=2500,Description=8,ModelYear=2023},
                new Car{Id=3,BrandId=4,ColorId=2,CarName="Audi",DailyPrice=1000,Description=2,ModelYear=2005},
                new Car{Id=4,BrandId=8,ColorId=1,CarName="Toyota",DailyPrice=500,Description=9,ModelYear=2010},
                new Car{Id=5,BrandId=11,ColorId=7,CarName="BMW",DailyPrice=750,Description=1,ModelYear=2015},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault<Car>(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault<Car>(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
