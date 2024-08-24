using System;
using System.Text.RegularExpressions;

namespace NUnit_46_LeVanTan
{
    public class NUnit46_Chuoi
    {
        private string str1, str2;
        public NUnit46_Chuoi(string str1, string str2)
        {
            this.str1 = str1;
            this.str2 = str2;
        }


        public string Execute_46_Tan(String CalSymbol)
        {
            //Phuong thuc dao nguoc chuoi
            string ReverseString(string input)
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

            string result = "";
            switch (CalSymbol)
            {
                case "Ghep":
                    result = this.str1 + this.str2;
                    break;
                case "Cat":
                    int length;
                    if (int.TryParse(str2, out length))
                    {
                        if (length > str1.Length)
                        {
                            return str1;
                        }
                        else
                        {
                            result = str1.Substring(0, length);
                        }
                    }
                    break;
                case "Thuong":
                    result = str1.ToLower();
                    break;
                case "Hoa":
                    result = str1.ToUpper();
                    break;
                case "KhoangTrang":
                    result = str1.Replace(" ", "");
                    break;
                case "LaySo":
                    result = Regex.Replace(str1, "[^0-9]", "");
                    break;
                case "DaoChuoi":
                    result = ReverseString(str1);
                    break;

            }
            return result;
        }

    }
}
