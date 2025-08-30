using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV03
{
    internal static class FunctionReturnDelegate
    {
        public static Action DelegateAction()
        {
            return delegate () { Console.WriteLine("Hello Route"); };
        }

        public static Predicate<int> DelegatePredicate()
        {
            return  x => x > 0; 
        }

        public static Func<char[], string> DelegateFunc()
        {
            //return delegate (char[] c) { return new string(c); };
            return c => new string(c);

        }

    }
}
