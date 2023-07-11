using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramewrok;
using Entities.Concrete;
using Entities.DTOs;


//CarByUnitPrice(carmanager);

//CarByBrandId(carmanager);

//CarByColorID(carmanager);
/*
static void CarByColorId(CarManager carmanager)
{
    foreach (var car in carmanager.GetCarsByColorId(7))
    {
        Console.WriteLine(car.CarName + " " + car.CarPrice);
    }

    Console.WriteLine("*********************");
}

static void CarByBrandId(CarManager carmanager)
{
    foreach (var car in carmanager.GetCarsByBrandId(5))
    {
        Console.WriteLine(car.CarName + " " + car.CarPrice);
    }

    Console.WriteLine("*********************");
}

    static void CarByUnitPrice(CarManager carmanager)
{
    foreach (var car in carmanager.GetByUnitPrice(10000, 40000))
    {
        Console.WriteLine(car.CarName + " " + car.CarPrice);
    }
}

*/

//CarDetails(carmanager);
/*
static void CarDetails()
{
    CarManager carmanager = new CarManager(new EfCarDal());

    foreach (var car in carmanager.GetAll())
    {
        Console.WriteLine();
        Console.WriteLine(car.carName);
    }
}*/
static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    var result = carManager.GetCarDetails();

    if (result.Success)
    {
        foreach (var car in result.Data)
        {
            Console.WriteLine(car.BrandName + " - " + car.CarName+" : "+car.CarPrice+"TL");
        }
    }

    else
    {
        Console.WriteLine(result.Message);
    }

}
CarTest();