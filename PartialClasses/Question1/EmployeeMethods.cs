using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public partial class EmployeeInfo
    {
        public void UpdateMobile(long mobile)
        {
            Mobile=mobile;
            Console.WriteLine("\nMobile Number Updated Successfully");
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n\tEmployee Details");
            Console.WriteLine($"Employee ID   : {EmployeeID}");
            Console.WriteLine($"Name          : {Name}");
            Console.WriteLine($"Gender        : {Gender}");
            Console.WriteLine($"Date of Birth : {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Mobile Number : {Mobile}\n");
        }
    }
}