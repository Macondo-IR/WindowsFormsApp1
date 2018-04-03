using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public static class Num2Text
    {




        public static string ToFarsi(long n)
        {
            long num = n;
            if (num == 0L)
                return "";
            if (num >= 1L && num <= 19L)
                return new string[19]
                {
          "یک",
          "دو",
          "سه",
          "چهار",
          "پنج",
          "شش",
          "هفت",
          "هشت",
          "نه",
          "ده",
          "یازده",
          "دوازده",
          "سیزده",
          "چهارده",
          "پانزده",
          "شانزده",
          "هفده",
          "هجده",
          "نوزده"
                }[checked((int)n - 1)];
            if (num >= 20L && num <= 99L)
                return Conversions.ToString(Operators.AddObject(Operators.AddObject((object)new string[8]
                {
          "بیست",
          "سی",
          "چهل",
          "پنجاه",
          "شصت",
          "هفتاد",
          "هشتاد",
          "نود"
                }[checked((int)unchecked(n / 10L) - 2)], Interaction.IIf(Operators.CompareString(Num2Text.ToFarsi(n % 10L), (string)null, false) == 0, (object)"", (object)" و ")), (object)Num2Text.ToFarsi(n % 10L)));
            if (num >= 100L && num <= 999L)
                return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(n / 100L == 2L, (object)"دویست", (object)""), Interaction.IIf(n / 100L == 3L, (object)"سیصد", (object)"")), Interaction.IIf(n / 100L == 5L, (object)"پانصد", (object)"")), Interaction.IIf(n / 100L != 2L & n / 100L != 3L & n / 100L != 5L, (object)(Num2Text.ToFarsi(n / 100L) + "صد"), (object)"")), Interaction.IIf(Operators.CompareString(Num2Text.ToFarsi(n % 100L), (string)null, false) == 0, (object)"", (object)" و ")), (object)Num2Text.ToFarsi(n % 100L)));
            if (num >= 1000L && num <= 999999L)
                return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Num2Text.ToFarsi(n / 1000L) + " هزار"), Interaction.IIf(Operators.CompareString(Num2Text.ToFarsi(n % 1000L), (string)null, false) == 0, (object)"", (object)" و ")), (object)Num2Text.ToFarsi(n % 1000L)));
            if (num >= 1000000L && num <= 999999999L)
                return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Num2Text.ToFarsi(n / 1000000L) + " میلیون"), Interaction.IIf(Operators.CompareString(Num2Text.ToFarsi(n % 1000000L), (string)null, false) == 0, (object)"", (object)" و ")), (object)Num2Text.ToFarsi(n % 1000000L)));
            if (num >= 1000000000L && num <= 999999999999L)
                return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Num2Text.ToFarsi(n / 1000000000L) + " میلیارد"), Interaction.IIf(Operators.CompareString(Num2Text.ToFarsi(n % 1000000000L), (string)null, false) == 0, (object)"", (object)" و ")), (object)Num2Text.ToFarsi(n % 1000000000L)));
            if (num >= 1000000000000L && num <= 999999999999999L)
                return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Num2Text.ToFarsi(n / 1000000000000L) + " بیلیون"), Interaction.IIf(Operators.CompareString(Num2Text.ToFarsi(n % 1000000000000L), (string)null, false) == 0, (object)"", (object)" و ")), (object)Num2Text.ToFarsi(n % 1000000000000L)));
            if (num >= 1000000000000000L && num <= 999999999999999999L)

                return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Num2Text.ToFarsi(n / 1000000000000000L) + " بیلیارد"), Interaction.IIf(Operators.CompareString(Num2Text.ToFarsi(n % 1000000000000000L), (string)null, false) == 0, (object)"", (object)" و ")), (object)Num2Text.ToFarsi(n % 1000000000000000L)));
            return "عدد بسیار بزرگ است";
        }

        public static string ToEnglish(long n)
        {
            long num = n;
            if (num == 0L)
                return "";
            if (num >= 1L && num <= 19L)
                return new string[19]
                {
          "One",
          "Two",
          "Three",
          "Four",
          "Five",
          "Six",
          "Seven",
          "Eight",
          "Nine",
          "Ten",
          "Eleven",
          "Twelve",
          "Thirteen",
          "Fourteen",
          "Fifteen",
          "Sixteen",
          "Seventeen",
          "Eighteen",
          "Nineteen"
                }[checked((int)(n - 1L))] + " ";
            if (num >= 20L && num <= 99L)
                return new string[8]
                {
          "Twenty",
          "Thirty",
          "Forty",
          "Fifty",
          "Sixty",
          "Seventy",
          "Eighty",
          "Ninety"
                }[checked((int)(unchecked(n / 10L) - 2L))] + " " + Num2Text.ToEnglish(n % 10L);
            if (num >= 100L && num <= 199L)
                return "One Hundred " + Num2Text.ToEnglish(n % 100L);
            if (num >= 200L && num <= 999L)
                return Num2Text.ToEnglish(n / 100L) + "Hundreds " + Num2Text.ToEnglish(n % 100L);
            if (num >= 100L && num <= 1999L)
                return "One Thousand " + Num2Text.ToEnglish(n % 1000L);
            if (num >= 2000L && num <= 999999L)
                return Num2Text.ToEnglish(n / 1000L) + "Thousands " + Num2Text.ToEnglish(n % 1000L);
            if (num >= 1000000L && num <= 1999999L)
                return "One Million " + Num2Text.ToEnglish(n % 1000000L);
            if (num >= 1000000L && num <= 999999999L)
                return Num2Text.ToEnglish(n / 1000000L) + "Millions " + Num2Text.ToEnglish(n % 1000000L);
            if (num >= 1000000000L && num <= 1999999999L)
                return "One Billion " + Num2Text.ToEnglish(n % 1000000000L);
            return Num2Text.ToEnglish(n / 1000000000L) + "Billions " + Num2Text.ToEnglish(n % 1000000000L);
        }
    }

}
