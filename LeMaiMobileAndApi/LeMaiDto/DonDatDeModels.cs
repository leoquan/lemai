using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LeMaiDto
{
    public class DonDatDanhSachOutput
    {
        public string Id { get; set; }

        public string OrderCode { get; set; }

        public string AcceptName { get; set; }

        public string AcceptPhone { get; set; }

        public string AcceptAddress { get; set; }

        public string GoodsName { get; set; }

        public decimal Cod { get; set; }

        //public int Weight { get; set; }

        //public bool IsShopPay { get; set; }

       // public string Note { get; set; }

        public DateTime CreateDate { get; set; }

        //public string FkCustomerId { get; set; }

        //public int StatusOrder { get; set; }

        //public string PickupUser { get; set; }

        //public DateTime? PickupDate { get; set; }

        //public string TransferCode { get; set; }

        public string StatusName { get; set; }

        public string StatusBackgroundColor { get; set; }

        public string StatusTextColor { get; set; }

        [JsonIgnore]
        public string AcceptManUpper { get; set; }
        [JsonIgnore]
        public string AcceptManNonUnicodeUpper { get; set; }

        [JsonIgnore]
        public bool IsEdit { get; set; }
        [JsonIgnore]
        public bool IsSave { get; set; }
    }

    public class DonDatEditInput
    {
        public string Id { get; set; }
        public string OrderCode { get; set; }
        public string AcceptName { get; set; }
        public string AcceptPhone { get; set; }
        public string AcceptAddress { get; set; }
        public string GoodsName { get; set; }
        public decimal Cod { get; set; }
        public int Weight { get; set; }
        public bool IsShopPay { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public string FkCustomerId { get; set; }
        public int StatusOrder { get; set; }
        public string PickupUser { get; set; }
        public DateTime? PickupDate { get; set; }
        public string TransferCode { get; set; }
        public int? ProvinceCode { get; set; }
        public int? DistrictCode { get; set; }
        public string DistrictWard { get; set; }
        public string FK_ShipperNot { get; set; }
        public string FreightStr { get; set; }
        public int? Freight { get; set; }
    }
    public class ProvineDanhSachOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class AcceptOutput
    {
        public bool IsFound { get; set; }
        public string AcceptPhone { get; set; }
        public string AcceptName { get; set; }
        public string AcceptAddress { get; set; }
        public int ProvineCode { get; set; }
        public int DistrictCode { get; set; }
        public string WardCode { get; set; }
        public List<DistrictDanhSachOutput> DanhSachHuyen { get; set; } = new List<DistrictDanhSachOutput>();
        public List<WardDanhSachOutput> DanhSachXa { get; set; } = new List<WardDanhSachOutput>();
    }
    public class DistrictDanhSachFeeOutput
    {
        public int Fee { get; set; }
        public List<DistrictDanhSachOutput> DanhSachHuyen { get; set; } = new List<DistrictDanhSachOutput>();
        public List<WardDanhSachOutput> DanhSachXa { get; set; } = new List<WardDanhSachOutput>();
    }
    public class DistrictDanhSachOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProvineId { get; set; }
    }
    public class WardDanhSachFeeOutput
    {
        public int Fee { get; set; }
        public List<WardDanhSachOutput> DanhSachXa { get; set; } = new List<WardDanhSachOutput>();
    }
    public class WardDanhSachOutput
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int DistrictId { get; set; }
    }
    public class LoaiKienDanhSachOutput
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public static class CommonHelper
    {
        #region Remove unicode

        private static readonly char[] _arrUnicodeLower = new char[] {
            'á', 'à', 'ả', 'ã', 'ạ', 'â', 'ấ', 'ầ', 'ẩ', 'ẫ', 'ậ', 'ă', 'ắ', 'ằ', 'ẳ', 'ẵ', 'ặ',
            'đ',
            'é','è','ẻ','ẽ','ẹ','ê','ế','ề','ể','ễ','ệ',
            'í','ì','ỉ','ĩ','ị',
            'ó','ò','ỏ','õ','ọ','ô','ố','ồ','ổ','ỗ','ộ','ơ','ớ','ờ','ở','ỡ','ợ',
            'ú','ù','ủ','ũ','ụ','ư','ứ','ừ','ử','ữ','ự',
            'ý','ỳ','ỷ','ỹ','ỵ',};
        private static readonly char[] _arrNonUnicodeLower = new char[] {
            'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a',
            'd',
            'e','e','e','e','e','e','e','e','e','e','e',
            'i','i','i','i','i',
            'o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o','o',
            'u','u','u','u','u','u','u','u','u','u','u',
            'y','y','y','y','y',};

        private static char[] _arrUnicodeUpper;
        private static char[] _arrNonUnicodeUpper;

        private static bool _isInit = false;
        public static void InitNonUnicode()
        {
            if (!_isInit)
            {
                _arrUnicodeUpper = new char[_arrUnicodeLower.Length];
                _arrNonUnicodeUpper = new char[_arrNonUnicodeLower.Length];

                for (int i = 0; i < _arrUnicodeLower.Length; i++)
                {
                    _arrUnicodeUpper[i] = _arrUnicodeLower[i].ToString().ToUpper()[0];
                    _arrNonUnicodeUpper[i] = _arrNonUnicodeLower[i].ToString().ToUpper()[0];
                }

                _isInit = true;
            }
        }


        public static string NonUnicode(this string? text)
        {
            InitNonUnicode();

            if (text == null)
            {
                return "";
            }
            if (string.IsNullOrWhiteSpace(text))
            {
                return "";
            }

            char cText;
            var cResult = new StringBuilder(text.Length);
            for (int j = 0; j < text.Length; j++)
            {
                cText = text[j];

                var flagBreak = false;
                for (int i = 0; i < _arrUnicodeLower.Length; i++)
                {

                    if (cText == _arrUnicodeLower[i])
                    {
                        cResult.Append(_arrNonUnicodeLower[i]);
                        flagBreak = true;
                        break;
                    }
                    else if (cText == _arrUnicodeUpper[i])
                    {
                        cResult.Append(_arrNonUnicodeUpper[i]);
                        flagBreak = true;
                        break;
                    }
                }

                if (flagBreak)
                {
                    continue;
                }

                cResult.Append(cText);
            }

            return cResult.ToString();
        }

        public static string NonUnicodeLower(this string? text)
        {
            InitNonUnicode();

            if (text == null)
            {
                return "";
            }
            if (string.IsNullOrWhiteSpace(text))
            {
                return "";
            }

            char cText;
            var cResult = new StringBuilder(text.Length);
            for (int j = 0; j < text.Length; j++)
            {
                cText = text[j];

                var flagBreak = false;
                for (int i = 0; i < _arrUnicodeLower.Length; i++)
                {

                    if (cText == _arrUnicodeLower[i])
                    {
                        cResult.Append(_arrNonUnicodeLower[i]);
                        flagBreak = true;
                        break;
                    }
                    else if (cText == _arrUnicodeUpper[i])
                    {
                        cResult.Append(_arrNonUnicodeLower[i]);
                        flagBreak = true;
                        break;
                    }
                }

                if (flagBreak)
                {
                    continue;
                }

                cResult.Append(cText.ToString().ToLower());
            }

            return cResult.ToString();
        }

        public static string NonUnicodeUpper(this string? text)
        {
            InitNonUnicode();

            if (text == null)
            {
                return "";
            }
            if (string.IsNullOrWhiteSpace(text))
            {
                return "";
            }

            char cText;
            var cResult = new StringBuilder(text.Length);
            for (int j = 0; j < text.Length; j++)
            {
                cText = text[j];

                var flagBreak = false;
                for (int i = 0; i < _arrUnicodeLower.Length; i++)
                {

                    if (cText == _arrUnicodeLower[i])
                    {
                        cResult.Append(_arrNonUnicodeUpper[i]);
                        flagBreak = true;
                        break;
                    }
                    else if (cText == _arrUnicodeUpper[i])
                    {
                        cResult.Append(_arrNonUnicodeUpper[i]);
                        flagBreak = true;
                        break;
                    }
                }

                if (flagBreak)
                {
                    continue;
                }

                cResult.Append(cText.ToString().ToUpper());
            }

            return cResult.ToString();
        }

        public static string NormlizeWhitespace(this string? str)
        {
            if (str == null)
            {
                return "";
            }

            return Regex.Replace(str, @"\s+", " ").Trim();
        }

        #endregion
    }


    public static class DonDatValidate
    {
        public static string ValidateAndNormalize(DonDatEditInput input, bool isEdit)
        {
            var validateError = new StringBuilder();

            if (isEdit)
            {
                if (string.IsNullOrWhiteSpace(input.Id))
                {
                    validateError.AppendLine("- ID đặt hàng chưa được nhập");
                }

                if (string.IsNullOrWhiteSpace(input.OrderCode))
                {
                    validateError.AppendLine("- Mã đặt hàng chưa được nhập");
                }
            }

            if (string.IsNullOrWhiteSpace(input.AcceptName))
            {
                validateError.AppendLine("- Người nhận chưa được nhập");
            }
            else if (input.AcceptName.Length > 50)
            {
                validateError.AppendLine("- Người nhận không được vượt quá 50 ký tự");
            }
            else
            {
                input.AcceptName = input.AcceptName.NormlizeWhitespace();
            }

            if (string.IsNullOrWhiteSpace(input.AcceptPhone))
            {
                validateError.AppendLine("- Số điện thoại được nhập");
            }
            else if (input.AcceptPhone.Length > 10)
            {
                validateError.AppendLine("- Số điện thoại vượt quá 10 ký tự");
            }
            else
            {
                input.AcceptPhone = input.AcceptPhone.Replace(" ", "");

                foreach (char c in input.AcceptPhone)
                {
                    if (!char.IsDigit(c))
                    {
                        validateError.AppendLine("- Số điện thoại không hợp lệ.");
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(input.AcceptAddress))
            {
                validateError.AppendLine("- Địa chỉ chưa được nhập");
            }
            else if (input.AcceptAddress.Length > 100)
            {
                validateError.AppendLine("- Địa chỉ không được vượt quá 100 ký tự");
            }
            else
            {
                input.AcceptAddress = input.AcceptAddress.Trim();
            }

            if (string.IsNullOrWhiteSpace(input.GoodsName))
            {
                validateError.AppendLine("- Tên hàng chưa được nhập");
            }
            else if (input.GoodsName.Length > 25)
            {
                validateError.AppendLine("- Tên hàng không được vượt quá 25 ký tự");
            }
            else
            {
                input.GoodsName = input.GoodsName.NormlizeWhitespace();
            }

            if (input.Cod < 0)
            {
                validateError.AppendLine("- Số tiền thu hộ không được âm");
            }
            else if (input.Cod > 20_000_000)
            {
                validateError.AppendLine("- Số tiền thu hộ không được vượt quá 20 triệu");
            }

            if (input.Weight < 0)
            {
                validateError.AppendLine("- Trọng lượng không được âm");
            }
            else if (input.Weight > 999_999_999)
            {
                validateError.AppendLine("- Trọng lượng không được vượt quá 999 tấn");
            }

            if (string.IsNullOrWhiteSpace(input.Note))
            {
                // do nothing
            }
            else
            {
                if (input.Note.Length > 150)
                {
                    validateError.AppendLine("- Ghi chú không được vượt quá 150 ký tự");
                }

                input.Note = input.Note.Trim();
            }

            return validateError.ToString();
        }
    }

    public class GexpOrderDto
    {
        public string Id { get; set; }

        public string OrderCode { get; set; }

        public string AcceptName { get; set; }

        public string AcceptPhone { get; set; }

        public string AcceptAddress { get; set; }

        public string GoodsName { get; set; }

        public decimal Cod { get; set; }

        public int Weight { get; set; }

        public bool IsShopPay { get; set; }

        public string Note { get; set; }

        public DateTime CreateDate { get; set; }

        public string FkCustomerId { get; set; }

        public int StatusOrder { get; set; }

        public string PickupUser { get; set; }

        public DateTime? PickupDate { get; set; }

        public string TransferCode { get; set; }
        public int ProvinceCode { get; set; }
        public int DistrictCode { get; set; }
        public string DistrictWard { get; set; }
        public string FkShipperNot { get; set; }
        public int Freight { get; set; }
        public List<ProvineDanhSachOutput> DanhSachProvine { get; set; } = new List<ProvineDanhSachOutput>();
        public List<DistrictDanhSachOutput> DanhSachDistrict { get; set; } = new List<DistrictDanhSachOutput>();
        public List<WardDanhSachOutput> DanhSachWard { get; set; } = new List<WardDanhSachOutput>();


    }
}
