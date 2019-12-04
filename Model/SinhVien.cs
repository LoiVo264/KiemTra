using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QuanLySinhVien.Model
{
    public class SinhVien
    {
        [Key]
        [StringLength(10)]
        public string masv { get; set; }

        [StringLength(50)]
        [Required]
        public string name { get; set; }

        public DateTime dateOfBirth { get; set; }

        public bool gender { get; set; }
        
        public string maLop { get; set; }

        public virtual Lop Lop { get; set; }

        public virtual ICollection<Diem> Diems { get; set; }
    }
    
}

