using Core2.DataAccess;
using Core2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Core2.DataAcces.EntityFramework
{
    public class EfEntitiyRepositoryBase<Tentity, Tcontext> : IEntityRepository<Tentity>
        where Tentity : class, IEntity, new()
        where Tcontext : DbContext, new()
    {

        public void Add(Tentity entity)
        {
            //IDisposable pattern implementation of C#
            using (Tcontext context = new Tcontext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Tentity Get(Expression<Func<Tentity, bool>> filter)
        {
            using (Tcontext context = new Tcontext())
            {
                return context.Set<Tentity>().SingleOrDefault(filter);
            }
        }

        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (Tcontext context = new Tcontext())
            {
                return filter == null
                    ? context.Set<Tentity>().ToList() //null ise
                    : context.Set<Tentity>().Where(filter).ToList();//null değil ise
            }

        }

        public void Update(Tentity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }


    }
}
