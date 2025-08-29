namespace C44_G03_ADV03
{
    public delegate int StringFuncDelegate(string s);
    // New Delegate [Class]
    // Ref From Delegate can Refer To Function or More [Pointer to function]
    // this function can be static Function [Class Member function]
    // this function can be non-static Function [Object Member function]
    // this function must be with same signature of delegate
    // Regardless Function Naming [Method name - Paramter Name]
    // Regardless Access Modifier
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Example 01
            ////int X = StringFunctions.GetCountOfUpperCaseChar; // invalid

            ////StringFuncDelegate stringFunc = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChar);

            //StringFuncDelegate? stringFunc = StringFunctions.GetCountOfUpperCaseChar;

            //stringFunc += StringFunctions.GetCountOfLowerCaseChar;
            //stringFunc -= StringFunctions.GetCountOfLowerCaseChar;
            //stringFunc -= StringFunctions.GetCountOfUpperCaseChar;


            //int Result = stringFunc?.Invoke("RouTe") ?? 0;
            ////Result = stringFunc("MostAfa HanY");
            //Console.WriteLine(Result); 
            #endregion
            #region Example 02

            //int[] Numbers = { 7, 5, 6, 3, 2, 1, 8, 9, 4 };

            ////SortingAlgorithms.BubbleSort(Numbers);
            //SortingAlgorithms<int>.BubbleSort(Numbers, SortingTypes.SortAsc);

            //SortingTypesFuncDelegate<int, int,bool> sortingTypes = SortingTypes.SortDesc;


            //SortingAlgorithms<int>.BubbleSort(Numbers, sortingTypes);

            //foreach (int i in Numbers)
            //    Console.WriteLine(i);

            //string[] Names = { "Omar", "Mohamed", "Amr", "Salma" };
            //SortingAlgorithms<string>.BubbleSort(Names, SortingTypes.SortAsc);

            //SortingTypesFuncDelegate<string, string,bool> sortingType = SortingTypes.SortDesc;

            //SortingAlgorithms<string>.BubbleSort(Names, sortingType);

            //foreach (string s in Names)
            //    Console.WriteLine(s);

            #endregion
        }
    }
}
