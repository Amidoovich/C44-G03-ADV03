using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV03
{
    internal static class TestBuiltInDelegate
    {
        public static bool CheckPositive(int number)
        {
            return number >= 0;
        }

        public static string Caasting(int number)
        {
            return number.ToString();
        }

        public static void Print()
        {
            Console.WriteLine("Hello Route");
        }

        public static void Print(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }

}
