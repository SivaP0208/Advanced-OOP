using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        Calculator sem1=new Calculator(67,87,58,68,79,80);
        sem1.Calculate();

        Calculator sem2=new Calculator(87,59,97,78,55,77);
        sem2.Calculate();

        Calculator sem3=new Calculator(56,79,86,93,89,81);
        sem3.Calculate();

        Calculator sem4=new Calculator(67,76,90,39,52,61);
        sem4.Calculate();

        Calculator totalMarksAndPercentage=sem1+sem2+sem3+sem4;
        totalMarksAndPercentage.Calculate();

        Console.WriteLine($"Total Marks : {totalMarksAndPercentage.TotalMark}\nPercentage : {totalMarksAndPercentage.Percentage}");
    }
}