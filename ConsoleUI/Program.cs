using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramewrok;
using Entities.Concrete;
using Entities.DTOs;

static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    var result = carManager.GetCarDetails();

    if (result.Success)
    {
        foreach (var car in result.Data)
        {
            Console.WriteLine(car.BrandName + " - " + car.CarName + " : " + car.CarPrice + "TL");
        }
    }

    else
    {
        Console.WriteLine(result.Message);
    }

}

//CarTest();

//UserTest();

static void UserTest()
{
    UserManager userManager = new UserManager(new EfUserDal());
    var result = userManager.GetUserDetails();

    if (result.Success)
    {
        foreach (var user in result.Data)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " : " + user.Email + " " + user.Companyname + " " + user.RentDate);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}

RentalTest();

static void RentalTest()
{
    RentalManager rentalManager = new RentalManager(new EfRentalDal());
    Rental rental = new Rental();

    rental.Id = 11;
    rental.CarId = 11;
    rental.CustomerId = 11;
    rental.RentDate = "2023-03-22";
    rental.ReturnDate = "";

    var result = rentalManager.Add(rental);

    if (result.Success)
    {
        Console.WriteLine(result.Message);
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}
