using Dk.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dk.DataAccess.Concrete.EntityFramework
{
    public class DkContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categoris { get;set; }
    }
}
