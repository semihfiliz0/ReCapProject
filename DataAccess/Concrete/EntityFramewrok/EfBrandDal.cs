using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Core2.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core2.DataAccess;
using Core2.DataAcces.EntityFramework;

namespace DataAccess.Concrete.EntityFramewrok
{
    public class EfBrandDal : EfEntitiyRepositoryBase<Brand,VehicleContext>,IBrandDal
    {
    }
}
