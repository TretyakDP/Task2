using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class IntExtensions
    {
        public static string ToWords(this int number)
        {
            string[] digitWords = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

            if (number < 0 || number > 9999)
            {
                return "Недопустимое значение. Допустимый диапазон: 0-9999";
            }

            string result = "";
            int thousands = number / 1000;
            int hundreds = (number % 1000) / 100;
            int tens = (number % 100) / 10;
            int units = number % 10;

            if (thousands > 0)
            {
                result += digitWords[thousands] + " тысяч ";
            }

            if (hundreds > 0)
            {
                result += digitWords[hundreds] + " сот ";
            }

            if (tens > 1)
            {
                result += digitWords[tens] + "десят ";
            }
            else if (tens == 1)
            {
                string[] teensWords = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
                result += teensWords[units] + " ";
            }

            if (tens != 1 && units > 0)
            {
                result += digitWords[units] + " ";
            }

            return result.Trim();
        }
    }
}
