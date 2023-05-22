using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDto
{
    public class TaiKhoanDangNhapInput
    {
        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }
    }

    public class TaiKhoanDangNhapOutput
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        

        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string AccessTimeoutUtc { get; set; }
        public string RefreshTimeoutUtc { get; set; }
    }

    public class TaiKhoanDoiMatKhauInput
    {
        [Required]
        [StringLength(50)]
        public string MatKhauMoi { get; set; }
    }



    public class TaiKhoanDangKyInput
    {
        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string SoDienThoai { get; set; }

        [StringLength(50)]
        [Required]
        public string HoTen { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }
    }
}
