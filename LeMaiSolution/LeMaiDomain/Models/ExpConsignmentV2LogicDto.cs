using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeMaiDomain.Models
{
    public class ExpConsignmentV2LogicInputDto
    {
        [Required(ErrorMessage = "MaDonHang Not Empty")]
        public String MaDonHang { get; set; }
        [Required(ErrorMessage = "TenHang Not Empty")]
        public String TenHang { get; set; }
        [Required(ErrorMessage = "SoLuong Not Empty")]
        public Int32 SoLuong { get; set; }
        [Required(ErrorMessage = "TrongLuongGram Not Empty")]
        public Int32 TrongLuongGram { get; set; }
        public Int32 GiaTriTienHang { get; set; }
        [Required(ErrorMessage = "FK_YeuCauKhiGiao Not Empty")]
        public String FK_YeuCauKhiGiao { get; set; }
        public String YeuCauKhac { get; set; }
        [Required(ErrorMessage = "FK_NguoiGui Not Empty")]
        public String FK_NguoiGui { get; set; }
        [Required(ErrorMessage = "FK_NguoiNhan Not Empty")]
        public String FK_NguoiNhan { get; set; }
        [Required(ErrorMessage = "FK_LoaiMatHang Not Empty")]
        public String FK_LoaiMatHang { get; set; }
        [Required(ErrorMessage = "FK_ExpProvider Not Empty")]
        public String FK_ExpProvider { get; set; }
        [Required(ErrorMessage = "FK_CachVanChuyen Not Empty")]
        public String FK_CachVanChuyen { get; set; }
        [Required(ErrorMessage = "FK_CachGiaoHang Not Empty")]
        public String FK_CachGiaoHang { get; set; }
        [Required(ErrorMessage = "FK_CachThanhToan Not Empty")]
        public String FK_CachThanhToan { get; set; }
        [Required(ErrorMessage = "FK_CaLamViec Not Empty")]
        public String FK_CaLamViec { get; set; }
        [Required(ErrorMessage = "FK_NguoiThuHang Not Empty")]
        public String FK_NguoiThuHang { get; set; }
        [Required(ErrorMessage = "FK_ExpPostFrom Not Empty")]
        public String FK_ExpPostFrom { get; set; }
        [Required(ErrorMessage = "FK_ExpPostTo Not Empty")]
        public String FK_ExpPostTo { get; set; }
        [Required(ErrorMessage = "CreateBy Not Empty")]
        public String CreateBy { get; set; }
        [Required(ErrorMessage = "CuocPhiChinh Not Empty")]
        public Int32 CuocPhiChinh { get; set; }
        [Required(ErrorMessage = "CuocCongThem Not Empty")]
        public Int32 CuocCongThem { get; set; }
        [Required(ErrorMessage = "PhuPhi Not Empty")]
        public Int32 PhuPhi { get; set; }
        [Required(ErrorMessage = "ThuHo Not Empty")]
        public Int32 ThuHo { get; set; }
        [Required(ErrorMessage = "TongCuoc Not Empty")]
        public Int32 TongCuoc { get; set; }
        public String FK_NhanVienPhat { get; set; }
        public String HoTenNguoiKyNhan { get; set; }
        [Required(ErrorMessage = "NguoiGui Not Empty")]
        public String NguoiGui { get; set; }
        [Required(ErrorMessage = "SoDienThoaiNguoiGui Not Empty")]
        public String SoDienThoaiNguoiGui { get; set; }
        [Required(ErrorMessage = "FK_DVHCNguoiGui Not Empty")]
        public String FK_DVHCNguoiGui { get; set; }
        [Required(ErrorMessage = "SoNhaNguoiGui Not Empty")]
        public String SoNhaNguoiGui { get; set; }
        [Required(ErrorMessage = "DiaChiNguoiGui Not Empty")]
        public String DiaChiNguoiGui { get; set; }
        [Required(ErrorMessage = "NguoiNhan Not Empty")]
        public String NguoiNhan { get; set; }
        [Required(ErrorMessage = "SoDienThoaiNguoiNhan Not Empty")]
        public String SoDienThoaiNguoiNhan { get; set; }
        [Required(ErrorMessage = "FK_DVHCNguoiNhan Not Empty")]
        public String FK_DVHCNguoiNhan { get; set; }
        [Required(ErrorMessage = "SoNhaNguoiNhan Not Empty")]
        public String SoNhaNguoiNhan { get; set; }
        [Required(ErrorMessage = "DiaChiNguoiNhan Not Empty")]
        public String DiaChiNguoiNhan { get; set; }
        [Required(ErrorMessage = "PrintNumber Not Empty")]
        public Int32 PrintNumber { get; set; }
    }
    public class ExpConsignmentV2LogicOutputDto : view_ExpConsignment
    {
    }
}

