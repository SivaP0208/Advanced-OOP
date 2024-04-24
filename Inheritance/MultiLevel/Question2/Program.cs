using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        // Creating Departments Object
        DepartmentDetails departmentDetails=new DepartmentDetails("ECE","B.E");
        DepartmentDetails departmentDetails1=new DepartmentDetails("CSE","B.E");

        // Creating Racks with the help of Departments
        RackInfo rackInfo=new RackInfo(departmentDetails.DepartmentID,departmentDetails.DepartmentName,departmentDetails.Degree,6,7);
        RackInfo rackInfo1=new RackInfo(departmentDetails1.DepartmentID,departmentDetails1.DepartmentName,departmentDetails1.Degree,5,3);
    
        // Storing books in the Racks
        BookInfo bookInfo=new BookInfo("Embedded System","Human Being",499,rackInfo.RackNumber,rackInfo.ColumnNumber,rackInfo.DepartmentID,rackInfo.DepartmentName,rackInfo.Degree);
        BookInfo bookInfo1=new BookInfo("Java","James Gosling",799,rackInfo1.RackNumber,rackInfo1.ColumnNumber,rackInfo1.DepartmentID,rackInfo1.DepartmentName,rackInfo1.Degree);
        BookInfo bookInfo2=new BookInfo("Python","Guido Van Rossum",999,rackInfo1.RackNumber,rackInfo1.ColumnNumber,rackInfo1.DepartmentID,rackInfo1.DepartmentName,rackInfo1.Degree);
    
        bookInfo.DisplayBookInfo();
        bookInfo1.DisplayBookInfo();
        bookInfo2.DisplayBookInfo();
    }
}