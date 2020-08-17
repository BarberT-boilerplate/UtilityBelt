using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace UtilityBeltCore
{
    public static class CleanData
    {
        public static decimal GetCleanDollar(string Dollar)
        {
            decimal CleanedDollar = 0m;

            if (string.IsNullOrEmpty(Dollar))
            {
                return CleanedDollar;
            }

            CleanedDollar = Convert.ToDecimal(Regex.Replace(Dollar, "[^0-9.]", ""));

            return CleanedDollar;
        }

        public static string GetCleanPhone(string Phone)
        {
            string CleanedPhone = string.Empty;

            if (string.IsNullOrEmpty(Phone))
            {
                return CleanedPhone;
            }

            CleanedPhone = Regex.Replace(Phone, "[^0-9]", "");

            return CleanedPhone;
        }

        public static string GetCleanSSN(string SSN)
        {
            Regex regExSSN = new Regex(@"^(?:.*)(\d{3})[\-\s]?(\d{2})[\-\s]?(\d{4})(?:.*)$", RegexOptions.Singleline);
            string ssnSubst = "$1$2$3";

            string CleanedSSN = string.Empty;

            if (regExSSN.IsMatch(SSN))
            {
                CleanedSSN = regExSSN.Replace(SSN, ssnSubst);
            }

            return CleanedSSN;
        }
        
        public static bool GetBoolValue(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            input = input.ToLower();
            if (input == "t") return true;
            if (input == "true") return true;
            if (input == "1") return true;
            if (input == "y") return true;
            if (input == "yes") return true;
            if (input == "f") return false;
            if (input == "false") return false;
            if (input == "0") return false;
            if (input == "n") return false;
            if (input == "no") return false;

            return false;
        }

        public static string GetPayFrequency(string Freq)
        {
            switch (Freq.ToUpper())
            {
                case "WEEKLY":
                    return "w";
                case "BI WEEKLY":
                    return "bi";
                case "MONTHLY":
                    return "m";
                default:
                    return "sm";
            }
        }

        public static bool IsCardNumberValid(string cardNumber, bool allowSpaces = false)
        {
            if (allowSpaces)
            {
                cardNumber = cardNumber.Replace(" ", "");
            }

            if (cardNumber.Any(c => !Char.IsDigit(c)))
            {
                return false;
            }

            int checksum = cardNumber
               .Select((c, i) => (c - '0') << ((cardNumber.Length - i - 1) & 1))
               .Sum(n => n > 9 ? n - 9 : n);

            return (checksum % 10) == 0 && checksum > 0;
        }
    }
}
