using Dk.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dk.Entities.Concrete
{
    //CLASSLARI BÖYLE ÇIPLAK INHERİTANCE SIZ OLMASI DOĞRU DEĞİLDİR. EN AZINDAN BİR İMZASI OLMASI GEREKİR
    //O YÜZDEN IEntity DEN INHERİTANCE YAPICAZ VE BİR VERİ TABANI NESNESİ OLDUĞUNU BELİRTMİŞ OLUCAZ.    
    public class Product:IEntity
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryId { get; set; }
        public int UnitPrice { get; set; }
        public int Stock { get; set; }

    }
}
