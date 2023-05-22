namespace Common
{
    /// <summary>
    /// Lữu trữ những hằng số sử dụng định nghĩa cho chương trình
    /// </summary>
    public class PConstants
    {
        
        /// <summary>
        /// 
        /// </summary>
        public const string APPLICATION_NAME = "Le Mai Carry Version ";
        /// <summary>
        /// 
        /// </summary>
        public const string FILE_DATABASE_CONFIG = "Database.ini";
        /// <summary>
        /// Thư mục lưu tạm kết quả chẩn đoán hình ảnh.
        /// </summary>
        public const string TEMP_FOLDER = "CDHA";
        /// <summary>
        /// 
        /// </summary>
        public const string KEY_DE_EN_CRYPT = "navisoft@123";
        /// <summary>
        /// 
        /// </summary>
        public const string DEFAULT_LANGUAGE = "vi-VN";
        /// <summary>
        /// 
        /// </summary>
        public const string FOLDER_REPORT = "Reports";
        public const string FOLDER_SIGNATURE = "Sigs";
        /// <summary>
        /// Mode None
        /// </summary>
        public const int MODE_NONE = 0;
        /// <summary>
        /// Mode Add New
        /// </summary>
        public const int MODE_NEW = 1;
        /// <summary>
        /// Mode Update
        /// </summary>
        public const int MODE_UPDATE = 2;
        /// <summary>
        /// 
        /// </summary>
        public const int MODE_VIEW_PRINT = 3;

        /// <summary>
        /// Giá trị truy vấn trong bảng cấp mã vào viện
        /// </summary>
        public const int CAP_SO_VAO_VIEN = 2;
        /// <summary>
        /// Cấp số phiếu nhập kho
        /// </summary>
        public const int CAP_SO_PHIEU_NHAP_KHO = 3;
        /// <summary>
        /// Cấp số phiếu xuất kho
        /// </summary>
        public const int CAP_SO_PHIEU_XUAT_KHO = 4;
        /// <summary>
        /// Cấp số phiểu xuất khác
        /// </summary>
        public const int CAP_SO_PHIEU_XUAT_KHAC = 5;
        /// <summary>
        /// Load toa thuốc trên Xuất kho lấy mặc định chưa hoàn thành là false
        /// </summary>
        public const bool TOATHUOC_CHUA_HOAN_THANH = false;
        /// <summary>
        /// Mặc định trạng thái load lên cho bệnh nhân chờ khám
        /// </summary>
        public const int DEFAULT_TRANG_THAI_CHO_KHAM = 0;
        public const int DEFAULT_TRANG_THAI_DANG_KHAM = 1;
        public const int DEFAULT_TRANG_THAI_DA_KHAM = 2;
        /// <summary>
        /// Mặc định namespace cho formname để kết trong SQL frm46
        /// </summary>
        public static string NAMESPACESQL = "'HealthCheck.'";
        /// <summary>
        /// Mặc định trạng thái load lên cho xuất chuyển kho
        /// </summary>
        public const bool DEFAULT_TRANG_THAI_CHO_CHO_CHUYEN_KHO = false;
        public const bool DEFAULT_TRANG_THAI_CHO_CHUYEN_KHO_HOAN_THANH = true;
        /// <summary>
        /// Kỹ Thuật Viên
        /// </summary>
        public const string ID_KY_THUAT_VIEN = "1935cce2-5194-4249-b74c-78ff3d8724a9";
        /// <summary>
        /// Loại Viện Phí
        /// </summary>
        public const string ID_LOAI_VIEN_PHI_BAI_TAP = "4b807dcc-3e95-4408-91e6-c8dd03d55d9a";
        /// <summary>
        /// Nhân viên là bác sĩ
        /// </summary>
        public const string ID_LOAI_NHAN_VIEN_BAC_SI = "1935cce2-5194-4249-b74c-78ff3d8724a9";
        /// <summary>
        /// Nhân viên là bác sĩ thực hiện chụp ảnh
        /// </summary>
        public const string ID_LOAI_NHAN_VIEN_BAC_SI_CHAN_DOAN_HINH_ANH = "1935cce2-5194-4249-b74c-78ff3d8724a9";
        /// <summary>
        /// Mặc định trạng thái của chỉ định dịch vụ
        /// </summary>
        public const int DEFAULT_TRANG_THAI_CHI_DINH_CHO_THUC_HIEN = 0;
        public const int DEFAULT_TRANG_THAI_CHI_DINH_DA_THUC_HIEN = 1;
        public const int DEFAULT_TRANG_THAI_CHI_DINH_DA_HOAN_THANH_CHAN_DOAN = 2;
        /// <summary>
        /// Tên file cấu hình cục bộ tại từng máy con
        /// </summary>
        public const string FILE_OPTION = "Options.ini";
        /// <summary>
        /// Section mặc định của file cấu hình
        /// </summary>
        public const string SECTION_OPTION = "GENERAL";
        /// <summary>
        /// Mặc định của id_xuatkho trong form xuất kho GUID033
        /// </summary>
        public const string KHO_MAC_DINH_XUAT = "55687cda-ea05-4472-aee1-b4b62565b0fd";
        /// <summary>
        /// Mặ định số nút hàng ngang cua form 68
        /// </summary>
        public const int maxbutton = 4;
        /// <summary>
        /// Mặc đinh giá khám tổng quát
        /// </summary>
        public const string GIA_KHAM_TONG_QUAT = "45000";

        /// <summary>
        /// 
        /// </summary>
        public const string THONG_SO_XET_NGHIEM = "WBC, HGB, HCT, RBC, PLT, Glucose";
        /// <summary>
        /// tuan hoan
        /// </summary>
        public const string TUAN_HOAN = "tuanhoan";
        /// <summary>
        /// ho hấp
        /// </summary>
        public const string HO_HAP = "hohap";
        /// <summary>
        /// tieu hoá
        /// </summary>
        public const string TIEU_HOA = "tieuhoa";
        /// <summary>
        ///than-tietnieu
        /// </summary>
        public const string THAN_TN = "than-tietnieu";
        /// <summary>
        /// coxuong
        /// </summary>
        public const string CO_XUONG = "coxuong";
        /// <summary>
        /// thankinh
        /// </summary>
        public const string THAN_KINH = "thankinh";
        /// <summary>
        /// tamthan
        /// </summary>
        public const string TAM_THAN = "tamthan";
        /// <summary>
        ///ngoaikhoa
        /// </summary>
        public const string NGOAI_KHOA = "ngoaikhoa";
        /// <summary>
        /// sankhoa
        /// </summary>
        public const string SAN_KHOA = "sankhoa";
        /// <summary>
        /// mat
        /// </summary>
        public const string MAT = "mat";
        /// <summary>
        /// taimh
        /// </summary>
        public const string TAI_MUI_HONG = "taimh";
        /// <summary>
        ///ranghm
        /// </summary>
        public const string RANG_HAM_MAT = "ranghm";
        /// <summary>
        /// dalieu
        /// </summary>
        public const string DA_LIEU = "dalieu";
        /// <summary>
        /// ketluan
        /// </summary>
        public const string KET_LUAN = "ketluan";
        /// <summary>
        /// sieuam
        /// </summary>
        public const string SIEU_AM = "sieuam";
        /// <summary>
        ///xquang
        /// </summary>
        public const string XQUANG = "xquang";
        /// <summary>
        ///chuoi mac đinh id_maumota 
        /// </summary>
        public const string ID_MAU_MO_TA = "ID_MAUMOTA";
        public const string CHUOI_KHONG_XET = "mavv,mabn,chisobmi,hoten,manhanvien,tenkhoaphong,sttxetnghiem ,namsinh,gioitinh,phanloai,ketluan,ghichu";
        public const string RANG_HAM_MAT_BT = "ranghammat";
        /// <summary>
        ///ten folder mac dinh
        /// </summary>
        public const string FOLDER_MACDINH_SIEUAM = "SA";
        public const string FOLDER_MACDINH_NOISOI = "NS";
        public const string FOLDER_MACDINH_DIENTIM = "DT";
        public const string FOLDER_MACDINH_XQUANG = "XQ";

        /// <summary>
        ///ID nhom quan tri
        /// </summary>
        public const string ID_NHOM_QUAN_TRI = "c684875c-c818-4ff7-897e-1055c3c160fd";
        /// <summary>
        ///Mặc định thao tác mở form
        /// </summary>
        public const string OPEN_FORM = "Mở form ";

        public const decimal loaibn = 0;
        public const decimal id_kp = 90;
        
    }
}

