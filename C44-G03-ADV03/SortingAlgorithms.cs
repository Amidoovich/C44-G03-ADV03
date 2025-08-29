using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV03
{
    public delegate Tout SortingTypesFuncDelegate<in T1,in T2,out Tout>(T1 a, T2 b);
    internal class SortingAlgorithms<T>
    {
        public static void BubbleSort(T[] Arr ,SortingTypesFuncDelegate<T,T,bool> sortingTypes)
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

        public static void Swap(ref T x,ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
