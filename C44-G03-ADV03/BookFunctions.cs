using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV03
{


    public delegate Tout StringFuncDelegate<in T,out Tout>(T B);

    internal static class BookFunctions
    {
        public static string GetTitle(Book? B)
        {
            if(B is not null)
                return $"Tilte : {B.Title}";  
            
            return "No Title Found";
        }

        public static string GetAuthors (Book? B)
        {
            if (B is not null)
                return $"Authors :\n{string.Join("\n",B.Authors)}\n";

            return "No Authors Found";    
        }

        public static string GetPrice(Book B)
        {
            if (B is not null)
                return $"Price : {B.Price:C}";

            return "No Price Found";
        }

        public static StringFuncDelegate<Book,string> GetISBN()
        {
            return delegate (Book B)
            {
                if (B is not null)
                    return $"ISBN : {B.ISBN}";

                return "No ISBN Found";
            };
        }
        public static Func<Book, string> GetISBNBuiltInDelegate()
        {
            return delegate (Book B)
            {
                if (B is not null)
                    return $"ISBN : {B.ISBN}";

                return "No ISBN Found";
            };
        }

        public static StringFuncDelegate<Book,string> GetPublicationDate()
        {
            return B => B is not null ? $"Publication Date : {B.PublicationDate}" : "No Publication Date"; 
        }
        public static Func<Book,string> GetPublicationDateBuiltInDelegate()
        {
            return B => B is not null ? $"Publication Date : {B.PublicationDate}" : "No Publication Date"; 
        }

         
    }
}
