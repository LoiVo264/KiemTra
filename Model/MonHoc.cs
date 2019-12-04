using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QuanLySinhVien.Model
{
    public class MonHoc
    {
        [Key]
        [StringLength(10)]
        public string maMonHoc { get; set; }
        [StringLength(50)]
        [Required]
        public string tenMonHoc { get; set; }
    }
}
