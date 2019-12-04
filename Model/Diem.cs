using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySinhVien.Model
{
    public class Diem
    {
        [Key]
        [Column(Order =1)]
        public string masv { get; set; }
        [Key]
        [Column(Order =2)]
        public string maMonHoc { get; set; }

        public float diem { get; set; }

        public virtual SinhVien SinhVien { get; set; }
        public virtual MonHoc MonHoc { get; set; }

    }
}
