using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_1721050537.Models
{
    public class NXSSanPham537
    {
        [Key]
        [Display(Name = "Mã Sản Phẩm")]
        [StringLength(20)]
        public string MaSanPham { get; set; }

        [Display(Name = "Tên Sản Phẩm")]
        [StringLength(50)]
        public string TenSanPham { get; set; }

        [Display(Name = "Mã Nhà Cung Cấp")]
        public int MaNhaCungCap { get; set; }
        [ForeignKey("MaNhaCungCap")]
        public virtual NhaCungCap537 NhaCungCap537s { get; set; }
    }
}