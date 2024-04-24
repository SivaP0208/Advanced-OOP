using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class HSCDetails:StudentInfo
    {
        private static int s_hscMarksheetNumber=3000;
        public string HSCMarksheetNumber { get; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int TotalMarks { get; set; }
        public double Percentage { get; set; }

        public HSCDetails(string registerNumber,int standard,string branch,int academicYear,string personalID,string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender,int physics,int chemistry,int maths):base(registerNumber,standard,branch,academicYear,personalID,name,fatherName,phoneNumber,mailID,dob,gender)
        {
            HSCMarksheetNumber="MID"+(++s_hscMarksheetNumber);
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        public void GetMarks()
        {
            Console.WriteLine($"\n\t{Name}'s Marks");
            Console.WriteLine($"Physics   : {Physics}");
            Console.WriteLine($"Chemistry : {Chemistry}");
            Console.WriteLine($"Maths     : {Maths}\n");
        }

        public void CalculateTotalAndPercentage()
        {
            TotalMarks=Physics+Chemistry+Maths;
            Percentage=TotalMarks/3.0;
            Console.WriteLine($"\nTotal Marks : {TotalMarks}\nPercentage  : {Percentage}");
        }

        public void ShowMarksheet()
        {
            Console.WriteLine($"\n\t{Name}'s Marksheet");
            Console.WriteLine($"Marksheet Number : {HSCMarksheetNumber}");
            Console.WriteLine($"Register Number  : {RegisterNumber}");
            Console.WriteLine($"Name             : {Name}");
            Console.WriteLine($"Date of Birth    : {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Physics          : {Physics}");
            Console.WriteLine($"Chemistry        : {Chemistry}");
            Console.WriteLine($"Maths            : {Maths}");
            Console.WriteLine($"Total Marks      : {TotalMarks}");
            Console.WriteLine($"Percentage       : {Percentage}\n");
        }
    }
}