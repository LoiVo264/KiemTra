using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySinhVien.Model
{
    public class Lop
    {   [Key]
        [StringLength(10)]
        public string maLop { get; set; }
        [Required]
        [StringLength(50)]
        public string tenLop { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
