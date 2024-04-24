using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public partial class StudentInfo
    {
        public void CalculateTotalAndPercentage()
        {
            double totalMarks=PhysicsMark+ChemistryMark+MathsMark;
            double percentage=(totalMarks/300)*100;
            Console.WriteLine("\nCalculation of Total Marks and Percentage");
            Console.WriteLine($"\nTotal Marks : {totalMarks}\nPercentage : {percentage}");
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n\tStudent Details");
            Console.WriteLine($"Student ID     : {StudentID}");
            Console.WriteLine($"Name           : {Name}");
            Console.WriteLine($"Gender         : {Gender}");
            Console.WriteLine($"Date of Birth  : {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Mobile Number  : {Mobile}");
            Console.WriteLine($"Physics Mark   : {PhysicsMark}");
            Console.WriteLine($"Chemistry Mark : {ChemistryMark}");
            Console.WriteLine($"Maths Mark     : {MathsMark}");
            Console.WriteLine($"Total Marks    : {PhysicsMark+ChemistryMark+MathsMark}");
            Console.WriteLine($"Percentage     : {(PhysicsMark+ChemistryMark+MathsMark)*100/300}");
        }
    }
}