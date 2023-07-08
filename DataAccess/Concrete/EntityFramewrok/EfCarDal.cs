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
            using (VehicleContext context = new VehicleContext())
            {
                if (entity.BrandName.Length < 2)
                {
                    Console.WriteLine("Uyarı! İsim en az 2 Harfden oluşmalıdır.");
                }
                if (entity.CarDailyPrice < 0)
                {
                    Console.WriteLine("Uyarı! Günlük fiyat 0'dan fazla olmalıdır.");
                }

                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();  
            }
        }

        public void Delete(Car entity)
        {
            using (VehicleContext context = new VehicleContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (VehicleContext context = new VehicleContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (VehicleContext context = new VehicleContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (VehicleContext context = new VehicleContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
