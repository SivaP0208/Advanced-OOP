using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class MultipleMethods
    {
        public void Method(int number)
        {
            Console.WriteLine($"Square of Given Number : {number*number}");
        }

        public void Method(int number1,int number2)
        {
            Console.WriteLine($"Addition of Given Two Numbers : {number1+number2}");
        }

        public void Method(string value1,string value2,string value3)
        {
            Console.WriteLine($"{value1} {value2} {value3}");
        }

        public void Method(int year,string value2)
        {
            Console.WriteLine($"{value2} : {year}");
        }

        public void Method(int number1,double number2,char oper)
        {
            Console.WriteLine($"{number1} {oper} {number2}");
        }
    }
}