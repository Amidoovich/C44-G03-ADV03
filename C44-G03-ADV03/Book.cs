using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV03
{
    internal class Book
    {

        #region Properties

        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string[]? Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        #endregion

        #region Constructor
        public Book(string? iSBN, string? title, string[]? authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }



        #endregion

        #region Methods

        public override string ToString()
        {
            return $"ISBN : {ISBN}\nTitle : {Title}\nAuthors :\n{string.Join("\n",Authors)}\nPublicationDate : {PublicationDate}\nPrice : {Price}";
        }

        #endregion
    }

}
