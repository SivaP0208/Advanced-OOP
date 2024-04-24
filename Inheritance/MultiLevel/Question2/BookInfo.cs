using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class BookInfo:RackInfo
    {
        private static int s_bookID=2000;
        public string BookID { get; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public BookInfo(string bookName,string authorName,double price,int rackNumber,int columnNumber,string departmentID,string departmentName,string degree):base(departmentID,departmentName,degree,rackNumber,columnNumber)
        {
            BookID="BID"+(++s_bookID);
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine("\n\t\tBook Details\n");
            Console.WriteLine($"Book ID         : {BookID}");
            Console.WriteLine($"Book Name       : {BookName}");
            Console.WriteLine($"Author Name     : {AuthorName}");
            Console.WriteLine($"Price           : {Price}");
            Console.WriteLine($"Rack Number     : {RackNumber}");
            Console.WriteLine($"Column Number   : {ColumnNumber}");
            Console.WriteLine($"Department ID   : {DepartmentID}");
            Console.WriteLine($"Department Name : {DepartmentName}");
            Console.WriteLine($"Degree          : {Degree}");
        }
    }
}