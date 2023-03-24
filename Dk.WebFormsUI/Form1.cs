using Dk.Business.Abstract;
using Dk.Business.Concrete;
using Dk.DataAccess.Concrete;
using Dk.DataAccess.Concrete.EntityFramework;
using Dk.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dk.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService=new ProductManager(new EfProductDal());
        }

        private IProductService _productService;  
        private void Form1_Load(object sender, EventArgs e)
        {
            //NOT: BURADA DATAACESS SINIFINI ÇAĞIRMAK YASAKTIR İŞLEMLERİMİZ BUSİNESS SINIFINDAN  ÇAĞIRILARAK YAPILIR.
            //EF ARAYÜZEDE EKLİYORUZ.
            //ENTİTİESEDE REFERANS VERİYORUZ.
            
            
            //DkContext context = new DkContext();
            //context.Database.Create();

            //ProductManager productManager = new ProductManager(new EfProductDal());    //BURDA NEWLEYEREK HEM EF HEM HİBERNATE İLE ÇALIŞABİLİYORUZ.
                                                                                         //Daha DÜNGÜN KULLANIMINI IproductServiceden yapıyoruz.
            
            
            dataGridView1.DataSource = _productService.GetAll();
        }

        //İSME GÖRE LİSTELEME İŞLEMİ.
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtProductName.Text == null)
            {
               dataGridView1.DataSource=_productService.GetAll();
            }
            else
            {
                dataGridView1.DataSource = _productService.UrunArama(txtProductName.Text);
            }
            
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                ProductName = txtUrunEkle.Text,
                CategoryId = txtKategoriEkle.Text,
                UnitPrice = Convert.ToInt16(txtFiyatEkle.Text),
                Stock = Convert.ToInt16(txtStokEkle.Text)
            });
            MessageBox.Show("Ürün eklendi");
            dataGridView1.DataSource = _productService.GetAll();  //Listeye yansıtması için.
        }
    }
}
