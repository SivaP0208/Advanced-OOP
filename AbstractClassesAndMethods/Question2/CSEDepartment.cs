using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class CSEDepartment:Library
    {
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override DateTime Year { get; set; }

        public CSEDepartment(string authorName,string bookName,string publisherName,DateTime year)
        {
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
        }

        public CSEDepartment()
        {

        }

        public override void SetBookInfo(string authorName,string bookName,string publisherName,DateTime year)
        {
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Serial Number : {SerialNumber}");
            Console.WriteLine($"Author Name : {AuthorName}");
            Console.WriteLine($"Book Name : {BookName}");
            Console.WriteLine($"Publisher Name : {PublisherName}");
            Console.WriteLine($"Year : {Year.ToString("dd/MM/yyyy")}");
        }
    }
}