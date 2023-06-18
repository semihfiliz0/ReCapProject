using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());


foreach (var car in carManager.GetAll())
    Console.WriteLine(car.Id + " " + car.CarName + " " + car.ModelYear);

