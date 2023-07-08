using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramewrok
{
    public class EfCarDal : IEntityRepository<Car>,ICarDal
    {
        public void Add(Car entity)
        {
            using (VehicleContext Context = new VehicleContext())
            {
                var addedEntity = Context.Entry(entity);
                addedEntity.State = EntityState.Added;
                Context.SaveChanges();  
            }
        }

        public void Delete(Car entity)
        {
            using (VehicleContext Context = new VehicleContext())
            {
                var deletedEntity = Context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                Context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (VehicleContext Context = new VehicleContext())
            {
                return Context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (VehicleContext Context = new VehicleContext())
            {
                return filter == null
                    ? Context.Set<Car>().ToList()
                    : Context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (VehicleContext Context = new VehicleContext())
            {
                var updated = Context.Entry(entity);
                updated.State = EntityState.Modified;
                Context.SaveChanges();
            }
        }
    }
}
