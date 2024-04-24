using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Marksheet:TheoryExamMarks,ICalculate
    {
        private static int s_marksheetNumber=2000;
        public string MarksheetNumber { get; }
        public DateTime DateOfIssue { get; set; }
        public double TotalMarks { get; set; }
        public double Percentage { get; set; }
        public double ProjectMark { get; set; }

        public Marksheet(string registrationNumber,string name,string fatherName,long phone,DateTime dob,string gender,double[] sem1,double[] sem2,double[] sem3,double[] sem4,double projectMark,DateTime dateOfIssue):base(registrationNumber,name,fatherName,phone,dob,gender,sem1,sem2,sem3,sem4)
        {
            MarksheetNumber="MID"+(++s_marksheetNumber);
            DateOfIssue=dateOfIssue;
            ProjectMark=projectMark;
        }

        public void CalculateTotal()
        {
            List<double[]> marks=new List<double[]>();
            marks.Add(Sem1);
            marks.Add(Sem2);
            marks.Add(Sem3);
            marks.Add(Sem4);
            foreach(double[] mark in marks)
            {
                for(int j=0;j<mark.Length;j++)
                {
                    TotalMarks+=mark[j];
                }
            }
            TotalMarks+=ProjectMark;
        }

        public void CalculatePercentage()
        {
            Percentage=Math.Round(TotalMarks*100/(600*4),2);
        }

        public void ShowUGMarkSheet()
        {
            Console.WriteLine("\n\t\"UG Marksheet\"");
            Console.WriteLine($"Marksheet Number : {MarksheetNumber}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Dateof Birth : {DOB.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Total Marks : {TotalMarks}");
            Console.WriteLine($"Percentage : {Percentage}");
        }       
    }
}