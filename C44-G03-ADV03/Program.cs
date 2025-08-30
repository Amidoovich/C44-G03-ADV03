using System.Runtime.InteropServices;

namespace C44_G03_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Book> Books = new List<Book>()
            {
                new Book("1234", "FullStack .Net & Angular", ["Ahmed Samy", "Amr Elattar"], DateTime.Now, 20000M),
                new Book("1235", "C# Programming Language", ["Ahmed Samy", "Mohamed Tarek"], DateTime.Now, 10000M),
                new Book("1236", "JS Programming Language", ["Amr Elattar", "Mohamed ELsaeed"], DateTime.Now, 10000M)
            };

            StringFuncDelegate<Book, string> stringFuncDelegate;
            Func<Book, string> func;

            #region GetISBN()
            //stringFuncDelegate = BookFunctions.GetISBN();
            //LibraryEngine.ProcessBooks(Books, stringFuncDelegate);
            //Console.WriteLine();
            //func = BookFunctions.GetISBNBuiltInDelegate();
            //LibraryEngine.ProcessBooks(Books, func);
            #endregion

            #region GetTitle()
            //stringFuncDelegate = BookFunctions.GetTitle;
            //LibraryEngine.ProcessBooks(Books, stringFuncDelegate);
            //Console.WriteLine();
            //func = BookFunctions.GetTitle;
            //LibraryEngine.ProcessBooks(Books, func);

            #endregion

            #region GetAuthors()

            //stringFuncDelegate = BookFunctions.GetAuthors;
            //LibraryEngine.ProcessBooks(Books,stringFuncDelegate);
            //Console.WriteLine();
            //func = BookFunctions.GetAuthors;
            //LibraryEngine.ProcessBooks(Books, func);

            #endregion

            #region GetPrice()

            //stringFuncDelegate = BookFunctions.GetPrice;
            //LibraryEngine.ProcessBooks(Books, stringFuncDelegate);
            //Console.WriteLine();
            //func = BookFunctions.GetPrice;
            //LibraryEngine.ProcessBooks(Books, func);

            #endregion

            #region GetPublicationDate()

            //stringFuncDelegate = BookFunctions.GetPublicationDate();
            //LibraryEngine.ProcessBooks(Books,stringFuncDelegate);
            //Console.WriteLine();
            //func = BookFunctions.GetPublicationDateBuiltInDelegate();
            //LibraryEngine.ProcessBooks(Books, func);


            #endregion






        }
    }
}
