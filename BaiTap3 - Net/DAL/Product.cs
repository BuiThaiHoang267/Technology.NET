using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3___Net.DAL
{
    [Table("SANPHAM")]
    public class Product
    {
        [Key]
        [Column("MASP")]
        public int MaSP { get; set; }
        
        [Column("TENSP")]
        public string TenSP { get; set; } = default!;

        [Column("SOLUONG")]
        public int SoLuong { get; set; }

        [Column("DONGIA")]
        public decimal DonGia { get; set; }

        [Column("XUATXU")]
        public string XuatXu { get; set; } = default!;

        [Column("NGAYHETHAN")]
        public DateTime NgayHetHan { get; set; }
    }
}
