using Dk.Entities.Abstract;
using Dk.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dk.DataAccess.Abstract
{
    
    //BURDA GENERİC BİR TİPLE ÇALIŞARAK HER TABLOMUZ İÇİN BU VERİ İŞLEMLERİNİ TEK TEK YAZMADAN KULLANA BİLİCEZ.
    //REPOSİTORY İMPLEMENTASYONU YAPIYORUZ.

    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);  //LİNQ MİMARİSİ UYGULUYORUZ FİLTRELEME YAPIYORUZ.İSTERSEK VERİDİĞİMİZ BİR FİLTREYİ LİSTELİYORUZ İSTERSEK DE BOŞ GEÇİP HEPSİNİ LİSTELİYORUZ.
        T Get(Expression<Func<T, bool>> filter );             //BURDADA Bİ ÜRÜN GETİRİCEZ AMA HANGİSİNİ GETİRİCEZ ONUN FİLTRELEMESİNİ YAPIYORUZ.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
