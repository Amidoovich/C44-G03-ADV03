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
            //int X = StringFunctions.GetCountOfUpperCaseChar; // invalid

            //StringFuncDelegate stringFunc = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChar);

            StringFuncDelegate? stringFunc = StringFunctions.GetCountOfUpperCaseChar;

            stringFunc += StringFunctions.GetCountOfLowerCaseChar;
            stringFunc -= StringFunctions.GetCountOfLowerCaseChar;
            stringFunc -= StringFunctions.GetCountOfUpperCaseChar;


            int Result = stringFunc?.Invoke("RouTe") ?? 0;
            //Result = stringFunc("MostAfa HanY");
            Console.WriteLine(Result);
        }
    }
}
