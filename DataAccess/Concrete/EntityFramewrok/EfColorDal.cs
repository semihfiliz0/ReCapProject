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

namespace DataAccess.Concrete.EntityFramewrok
{
    public class EfColorDal : IEntityRepository<Color>
    {
        public void Add(Color entity)
        {
            using (VehicleContext context = new VehicleContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (VehicleContext context = new VehicleContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (VehicleContext context = new VehicleContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (VehicleContext context = new VehicleContext())
            {
                return filter == null
                  ? context.Set<Color>().ToList()
                  : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
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
