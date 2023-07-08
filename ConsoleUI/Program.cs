using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramewrok;
using Entities.Concrete;

CarManager carmanager = new CarManager(new EfCarDal());

foreach (var car in carmanager.GetByUnitPrice(10000,40000))
{
    Console.WriteLine(car.BrandName+" "+car.CarDailyPrice);
}

Console.WriteLine("*********************");

foreach (var car in carmanager.GetCarsByBrandId(5))
{
    Console.WriteLine(car.BrandName + " " + car.CarDailyPrice);
}

Console.WriteLine("*********************");


foreach (var car in carmanager.GetCarsByColorId(7))
{
    Console.WriteLine(car.BrandName + " " + car.CarDailyPrice);
}

Console.WriteLine("*********************");
