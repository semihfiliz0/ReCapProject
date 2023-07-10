using Core2.DataAcces.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramewrok
{
    public class EfCarDal : EfEntitiyRepositoryBase<Car, VehicleContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (VehicleContext context = new VehicleContext())
            {
                var result = from c in context.Cars
                             join b in context.brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto { CarId = c.CarId, CarPrice = c.CarPrice, CarYear = c.CarYear, BrandName = b.BrandName, CarName=c.CarName };
                
                return result.ToList();
            }
          

        }

    }
}
