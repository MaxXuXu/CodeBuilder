﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeBuilder.Util
{
    public static class StringExtension
    {
        public static string StandardizeName(this string str)
        {
            if (String.IsNullOrEmpty(str)) return str;
            string[] words = Regex.Split(str, "[_\\-\\. ]");
            return string.Join("", words.Select(FirstCharToUpper));
        }

        public static string FirstCharToLower(this string str)
        {
            if (String.IsNullOrEmpty(str) || str.Length == 0)
                return str;
            if (str.Length == 1) return str.ToLower();
            return str.Substring(0,1).ToLower() + str.Substring(1);
        }

        public static string FirstCharToUpper(string str)
        {
            if (String.IsNullOrEmpty(str) || str.Length == 0)
                return str;
            if (str.Length == 1) return str.ToUpper();
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }
    }
}
