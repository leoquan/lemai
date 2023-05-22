using System.Text;
using System.Text.RegularExpressions;

namespace LeMaiApi.Models;

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

