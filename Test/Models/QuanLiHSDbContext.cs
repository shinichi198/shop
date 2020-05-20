using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
   public class QuanLiHSDbContext:DbContext
    {
        public QuanLiHSDbContext():base("HocSinhConnectionString")
        {
           
        }
        public DbSet<HocSinh> HocSinhs { get; set; }
        public DbSet<Lop> Lops { get; set; }
    }
}
