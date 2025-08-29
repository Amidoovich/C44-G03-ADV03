using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV03
{
    internal static class FilterOfList
    {
        public static bool CheckOdd(int number)
        {
            return number % 2 != 0;
        }
        public static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }
        public static bool DivisableBy7(int number)
        {
            return number % 7 == 0;
        }
        public static bool DivisableBy10(int number)
        {
            return number % 10 == 0;
        }

        public static bool CheckLengthLessThan4(string name)
        {
            return name?.Length < 4;
        }
        public static bool CheckLengthMoreThan4(string name)
        {
            return name?.Length > 4;
        }
    }
}
