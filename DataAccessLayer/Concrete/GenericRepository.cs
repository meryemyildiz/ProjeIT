﻿using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class GenericRepositoryDal<T>: IRepositoryDal<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepositoryDal()
        {
            _object = c.Set<T>();
        }

        public void Delete(T p)
        {
            var DeletedEntity = c.Entry(p);
            DeletedEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);

        }

        public void Insert(T p)
        {
            var AddedEntity = c.Entry(p);
            AddedEntity.State = EntityState.Added;
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var UpdatedEntity = c.Entry(p);
            UpdatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
