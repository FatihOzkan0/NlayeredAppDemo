using Dk.DataAccess.Abstract;
using Dk.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dk.DataAccess.Concrete.NHibernate
{
    public class NHProductDal : IProductDal      //IProductDal INTERFACE Nİ OLUŞTURDUĞUMUZ İÇİN TEKRAR ÜRÜN KODLARINI YAZMADAN YENİ ALANLARA EKLİYEBİLİYORUZ.
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
