using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV03
{
    internal static class LibraryEngine
    {
        public static void ProcessBooks (List<Book> bList , StringFuncDelegate<Book,string> fPtr)
        {
            foreach (Book B in bList)
                Console.WriteLine(fPtr(B));
        }
        public static void ProcessBooks (List<Book> bList , Func<Book,string> fPtr)
        {
            foreach (Book B in bList)
                Console.WriteLine(fPtr(B));
        }


    }
}
