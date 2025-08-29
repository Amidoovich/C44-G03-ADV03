using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV03
{
    public delegate bool SortingTypesFuncDelegate(int a, int b);
    internal class SortingAlgorithms
    {
        public static void BubbleSort(int[] Arr ,SortingTypesFuncDelegate sortingTypes)
        {
            if(Arr?.Length > 0 && sortingTypes is not null)
                for(int i = 0; i < Arr.Length; i++)
                    for (int j = 0; j < Arr.Length - 1 - i; j++)
                        //if (Arr[j] > Arr[j + 1])
                        if (sortingTypes.Invoke(Arr[j], Arr[j+1]))
                            Swap(ref Arr[j], ref Arr[j + 1]);
        }
        //public static void BubbleSortDesc(int[] Arr)
        //{
        //    if(Arr?.Length > 0)
        //        for(int i = 0; i < Arr.Length; i++)
        //            for (int j = 0; j < Arr.Length - 1 - i; j++)
        //                if (Arr[j] < Arr[j + 1])
        //                    Swap(ref Arr[j], ref Arr[j + 1]);
        //}

        public static void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
