using Dk.Business.Abstract;
using Dk.DataAccess.Abstract;
using Dk.DataAccess.Concrete;
using Dk.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dk.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;   //INTERFACE KULLANARAK KODUMUZU BAĞIMSIZ HALE GETİRİYORUZ. 
                                           //HEM EntityFramework , HEM Hibernate göre productDal İŞLEMLERİNİ YAPBİLİRİZ.

        public ProductManager(IProductDal productDal) 
        {
            _productDal= productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public List<Product> GetAll()    //DATAACCESS DE Kİ METHODLARLA BENZERLİK GÖSTEREBİLİR AMA ORDA SADECE VERİ İŞLEMLERİ YAPILIR.
                                         //BURADA İŞ KURALLARIMIZIDA KOYARIZ BU METHODU KİM KULLANABİLİR KİM LİSTELEYE BİLİR GİBİ.
        {
            //Business code
         
            return _productDal.GetAll(); 
        }

        public List<Product> UrunArama(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.Contains(productName));
        }
    }
}
