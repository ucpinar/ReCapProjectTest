﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ICarTest context=new ICarTest())//referansı yakalama 
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ICarTest context = new ICarTest())//referansı yakalama 
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ICarTest context = new ICarTest())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
           
                using (ICarTest context = new ICarTest())
                {
                return filter == null
                 ? context.Set<Car>().ToList()
                 : context.Set<Car>().Where(filter).ToList();
                }
            
        }

        public void Update(Car entity)
        {
            using (ICarTest context = new ICarTest())//referansı yakalama 
            {
                var modyEntity = context.Entry(entity);
                modyEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
