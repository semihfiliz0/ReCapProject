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
    public class EfUserDal : EfEntitiyRepositoryBase<User, VehicleContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using (VehicleContext context = new VehicleContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.Id equals c.UserId
                             join r in context.Rentals
                             on u.Id equals r.Id
                             select new UserDetailDto { Id = u.Id, FirstName = u.FirstName, LastName = u.LastName, Email = u.Email, Companyname = c.CompanyName, RentDate=r.RentDate };

                return result.ToList();
            }
        
        }

    }
}
