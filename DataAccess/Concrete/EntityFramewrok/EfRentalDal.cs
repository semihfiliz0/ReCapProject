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
    public class EfRentalDal : EfEntitiyRepositoryBase<Rental, VehicleContext>, IRentalDal
    {
        //Değişebilir!
        public List<RentalDetailDetail> GetRentalDetails()
        {
            throw new NotImplementedException();
        }
    }
}
