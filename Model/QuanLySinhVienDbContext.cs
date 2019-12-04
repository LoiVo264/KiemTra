using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace QuanLySinhVien.Model
{
    public class QuanLySinhVienDbContext: DbContext
    {
        public QuanLySinhVienDbContext(): base("QuanLySinhVienConnectionString")
        {

        }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<Diem> Diems { get; set; }
    }
}
