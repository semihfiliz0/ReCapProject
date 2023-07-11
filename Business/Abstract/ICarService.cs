using Core2.Utilities;
using Core2.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramewrok;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetAllByCarId(int id);

        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(Car car);
    }
}
