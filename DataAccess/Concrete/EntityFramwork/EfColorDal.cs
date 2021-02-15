using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filtre)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filtre = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
