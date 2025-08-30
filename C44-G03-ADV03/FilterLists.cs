using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV03
{
    public delegate bool FilterFucDelegate<T>(T a);
    internal static class FilterLists
    {
        public static List<T> FindElements<T>(List<T> numbers,Predicate<T> filter)
        {
            List<T> result = new List<T>();
            if(numbers?.Count > 0 && filter is not null)
                for(int i = 0; i < numbers.Count; i++)
                    if (filter(numbers[i]))
                        result.Add(numbers[i]);
            return result;
        }
    }
}
