using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV03
{
    public delegate bool FilterFucDelegate(int a);
    internal static class FilterLists
    {
        public static List<int> FindElements(List<int> numbers,FilterFucDelegate filter)
        {
            List<int> result = new List<int>();
            if(numbers?.Count > 0 && filter is not null)
                for(int i = 0; i < numbers.Count; i++)
                    if (filter(numbers[i]))
                        result.Add(numbers[i]);
            return result;
        }
    }
}
