using System;
using System.Text.RegularExpressions;

namespace UtilityBeltCore
{
    public static class ExtensionMethods
    {
        public static string ToOrdinal(this int num)
        {
            if (num <= 0) return num.ToString();

            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }

            switch (num % 10)
            {
                case 1:
                    return num + "st";
                case 2:
                    return num + "nd";
                case 3:
                    return num + "rd";
                default:
                    return num + "th";
            }
        }

        public static string ToDate(this string value)
        {
            DateTime date = DateTime.Now;
            DateTime.TryParse(value, out date);
            return date.ToShortDateString();
        }

        public static string ToDollar(this int value)
        {
            return ToDollar(Convert.ToDecimal(value));
        }

        public static string ToDollar(this double value)
        {
            return ToDollar(Convert.ToDecimal(value));
        }

        public static string ToDollar(this decimal value)
        {
            return value.ToString("c");
        }

        public static string ToPercent(this int value, int percentPrecision = 2)
        {
            return ToPercent(Convert.ToDecimal(value), percentPrecision);
        }

        public static string ToPercent(this double value, int percentPrecision = 2)
        {
            return ToPercent(Convert.ToDecimal(value), percentPrecision);
        }

        public static string ToPercent(this decimal value, int percentPrecision = 2)
        {
            return Math.Round(value, percentPrecision).ToString() + "%";
        }
        
        public static string ToDigitsOnly(this string val)
        {
            Regex digitsOnly = new Regex(@"[^\d]");
            return digitsOnly.Replace(val.ToString(), "");
        }

        public static string ToTitleCase(this string str)
        {
            if (str == null) return str;

            String[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0) continue;

                Char firstChar = Char.ToUpper(words[i][0]);
                String rest = "";
                if (words[i].Length > 1)
                {
                    rest = words[i].Substring(1).ToLower();
                }
                words[i] = firstChar + rest;
            }
            return String.Join(" ", words);
        }

    }
}
