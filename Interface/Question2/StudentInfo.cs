using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class StudentInfo:IDisplayInfo
    {
        private static int s_studentID=1000;
        public string StudentID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }

        public StudentInfo(string name,string fatherName,string mobile)
        {
            StudentID="SID"+(++s_studentID);
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
        }

        public void Display()
        {
            Console.WriteLine($"Student ID : {StudentID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Mobile : {Mobile}");
        }
    }
}