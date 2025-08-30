using System.Threading.Channels;

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

            //Func<string,int> stringFunc = StringFunctions.GetCountOfUpperCaseChar;
            //int Result = stringFunc("RouTe");
            //Console.WriteLine(Result);

            //stringFunc += StringFunctions.GetCountOfLowerCaseChar;
            //stringFunc -= StringFunctions.GetCountOfLowerCaseChar;
            //stringFunc -= StringFunctions.GetCountOfUpperCaseChar;


            //int Result = stringFunc?.Invoke("RouTe") ?? 0;
            ////Result = stringFunc("MostAfa HanY");
            //Console.WriteLine(Result); 
            #endregion
            #region Example 02

            //int[] Numbers = { 7, 5, 6, 3, 2, 1, 8, 9, 4 };

            //SortingAlgorithms.BubbleSort(Numbers);
            //SortingAlgorithms<int>.BubbleSort(Numbers, SortingTypes.SortAsc);

            //Func<int, int,bool> sortingTypes = SortingTypes.SortDesc;


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
            #region Example 03
            // Linq
            //List<int> Numbers = Enumerable.Range(1, 100).ToList();

            //List<int> OddNumbers = FilterLists.FindElements(Numbers, FilterOfList.CheckOdd);

            //FilterFucDelegate<int> filter = FilterOfList.CheckEven;

            //List<int> EvenNumbers = FilterLists.FindElements(Numbers,filter);

            //List<int> Divisable07Numbers =  FilterLists.FindElements(Numbers,FilterOfList.DivisableBy7);
            //foreach (int num in OddNumbers)
            //    Console.Write($"{num} ");

            //List<string> Names = new List<string>() { "Ahmed", "Aya", "Khaled", "Rawan", "Amr", "Heba" };

            //List<string> Names = ["Ahmed", "Aya", "Khaled", "Rawan", "Amr", "Heba"];

            //List<string> FilterName = FilterLists.FindElements(Names,FilterOfList.CheckLengthLessThan4);
            //List<string> FilterName02 = FilterLists.FindElements(Names,FilterOfList.CheckLengthMoreThan4);

            //foreach (string s in FilterName02)
            //    Console.WriteLine(s);

            #endregion
            #region Built in Delegate

            //Predicate<int> predicate = TestBuiltInDelegate.CheckPositive;

            //bool flag = predicate.Invoke(10);

            //flag = predicate(20);

            //Console.WriteLine(flag);

            //Func<int, string> func = TestBuiltInDelegate.Caasting;

            //string number = func(42);


            //Console.WriteLine(number);


            //Action action = TestBuiltInDelegate.Print;

            //action();

            //Action<string> action1 = TestBuiltInDelegate.Print;

            //action1("Samy");

            #endregion
            #region Anonymous Methods
            //Predicate<int> predicate = delegate (int number) { return number >= 0; };

            //bool flag = predicate.Invoke(10);

            //flag = predicate(20);

            //Console.WriteLine(flag);

            //Func<int, string> func = delegate(int number){ return number.ToString(); };


            //string number = func(42);


            //Console.WriteLine(number);


            //Action action = delegate () { Console.WriteLine("Hello Route"); };

            //action();

            //Action<string> action1 = delegate (string name) {Console.WriteLine($"Hello {name}"); };

            //action1("Samy");
            #endregion
            #region Lambda Expression

            //Predicate<int> predicate = number => number > 0;

            //bool flag = predicate.Invoke(10);

            //flag = predicate(20);

            //Console.WriteLine(flag);

            //Func<int, string> func = number => number.ToString();


            //string number = func(42);


            //Console.WriteLine(number);


            //Action action =  () => Console.WriteLine("Hello Route");

            //action();

            //Action<string> action1 = name => Console.WriteLine($"Hello {name}");

            //action1("Samy");

            #endregion
            #region List<T> Methods Take Function As Parameter

            //List<int> Numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];



            //bool flag = Numbers.Exists(number => number == 10);

            //int Element = Numbers.Find(X => X % 2 == 0);
            //Element = Numbers.FindLast(X => X % 2 == 0);

            //int index = Numbers.FindIndex(X => X % 2 == 0);
            //index = Numbers.FindLastIndex(X => X % 2 == 0);

            //List<int> oddNumbers = Numbers.FindAll(x => x % 2 != 0);

            //Numbers.ForEach(X => Console.WriteLine(++X));

            //foreach (int number in Numbers)
            //    Console.WriteLine(number);

            //bool flag = Numbers.TrueForAll(x => x % 2 == 0);
            //Console.WriteLine(flag);


            //Numbers.RemoveAll(x => x % 2 == 0);

            //foreach (int i in Numbers)
            //    Console.WriteLine(i);

            #endregion
            #region Function Can Return Other functions


            //Action action = FunctionReturnDelegate.DelegateAction(); // Do Nothing


            //action();
            //action.Invoke();

            //FunctionReturnDelegate.DelegateAction()();
            //FunctionReturnDelegate.DelegateAction().Invoke();


            //Predicate<int> predicate = FunctionReturnDelegate.DelegatePredicate();
            //bool flag = predicate(1);
            //Console.WriteLine(flag);

            //flag = FunctionReturnDelegate.DelegatePredicate().Invoke(1);

            //flag = FunctionReturnDelegate.DelegatePredicate()(1);
            //Console.WriteLine(flag);

            //string name = FunctionReturnDelegate.DelegateFunc()( ['R' , 'o' , 'u','t','e' ]);

            //Console.WriteLine(name);


            #endregion
        }
    }
}
