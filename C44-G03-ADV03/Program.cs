namespace C44_G03_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Book> Books = new List<Book>()
            {
                new Book("1234", "FullStack .Net & Angular", ["Ahmed Samy", "Amr Elattar"], DateTime.Now, 20000M),
                new Book("1234", "C# Programming Language", ["Ahmed Samy", "Mohamed Tarek"], DateTime.Now, 10000M),
                new Book("1234", "JS Programming Language", ["Amr Elattar", "Mohamed ELsaied"], DateTime.Now, 10000M)
            };


            StringFuncDelegate<Book, string> stringFuncDelegate = BookFunctions.GetISBN();
            
            
            
            LibraryEngine.ProcessBooks();


        }
    }
}
