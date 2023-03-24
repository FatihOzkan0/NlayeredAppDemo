using Dk.DataAccess.Abstract;
using Dk.Entities.Abstract;
using Dk.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dk.DataAccess.Concrete.EntityFramework
{
   
    public class EfProductDal: EfEntityRepositoryBase<Product,DkContext>,IProductDal     //REPOSİTORY İMPLEMENTASYONU İLE İSTEDİĞİMİZ TABLOYA KODLARIMIZI YAZMADAN GEÇİRİYORUZ.
    {
       
      
        
    }
}
