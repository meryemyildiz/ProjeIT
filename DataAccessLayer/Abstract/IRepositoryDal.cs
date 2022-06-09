﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IRepositoryDal<T>
    {
        List<T> List();
        T Get(Expression<Func<T, bool>> filter); //id ye göre listeleme(1 adet)
        void Insert(T p);
        void Update(T p);
        void Delete(T p);

        List<T> List(Expression<Func<T, bool>> filter);  //şartlı listeleme
    }
}
