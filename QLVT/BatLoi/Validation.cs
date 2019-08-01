using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QLVT.BatLoi
{
    public static class Validation
    {
        public static string isNull(string text)
        {
            return (text == "") || (text == null) ? "Không được nhập rỗng" : "";
        }
        public static void removeUnuseSpace(ref String text)
        {
            text = Regex.Replace(text, @"\s+", " ");
            if (text[0] == ' ') text.Remove(0, 1);
            if (text.Last() == ' ') text.Remove(text.Length - 1, 1);
        }
        public static string validateNumber(String name, String text)
        {
            string isNullText = isNull(text);
            if (isNullText != "") return name + " " + isNullText;
            Regex rx = new Regex(@"/^[0-9]*$/");
            if (rx.IsMatch(text))
            {
                return name + " chỉ được nhập số";
            }
            return "";
        }
        public static string validateCode(String name, String text)
        {
            string isNullText = isNull(text);
            if (isNullText != "") return name + " " + isNullText;
            Regex rx = new Regex(@"[`~!@#$%^&*(),. <>\/?\\{}\[\]+=]");
            if (rx.IsMatch(text))
            {
                return name + " không được nhập khoảng trắng hoặc các ký tự đặc biệt ngoại trừ dấu '-', '_'";
            }
            return "";
        }
        public static string validateName(String name, String text)
        {
            string isNullText = isNull(text);
            if (isNullText != "") return name + " " + isNullText;
            removeUnuseSpace(ref text);
            Regex rx = new Regex(@"[\p{L}\s]");
            if (rx.Matches(text).Count != text.Length)
            {
                return name + " không được nhập các ký tự đặc biệt và số";
            }
            return "";
        }
        public static string validateCommonText(String name, String text)
        {
            string isNullText = isNull(text);
            if (isNullText != "") return name + " " + isNullText;
            removeUnuseSpace(ref text);
            Regex rx = new Regex(@"[`~!@#$%^&*()_\-+={}[\]<>,.?\/\|{. }]{2,}");
            if (rx.IsMatch(text))
            {
                string erm = "";
                foreach (Match match in rx.Matches(text))
                {
                    erm += $"'{match.Value}', ";
                }
                return $"'{name}' Sai chính tả tại {erm.PadRight(erm.Length - 2)}";
            }
            return "";
        }
    }
}
