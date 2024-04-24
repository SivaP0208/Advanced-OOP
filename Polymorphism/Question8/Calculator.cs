using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question8
{
    public class Calculator
    {
        public double Subject1Mark { get; set; }
        public double Subject2Mark { get; set; }
        public double Subject3Mark { get; set; }
        public double Subject4Mark { get; set; }
        public double Subject5Mark { get; set; }
        public double Subject6Mark { get; set; }
        private double _totalMark;
        public double TotalMark { get{return _totalMark;} }
        private double _percentage;
        public double Percentage { get{return _percentage;} }

        public Calculator(double subject1Mark,double subject2Mark,double subject3Mark,double subject4Mark,double subject5Mark,double subject6Mark)
        {
            Subject1Mark=subject1Mark;
            Subject2Mark=subject2Mark;
            Subject3Mark=subject3Mark;
            Subject4Mark=subject4Mark;
            Subject5Mark=subject5Mark;
            Subject6Mark=subject6Mark;
        }

        public void Calculate()
        {
            _totalMark=Subject1Mark+Subject2Mark+Subject3Mark+Subject4Mark+Subject5Mark+Subject6Mark;
            _percentage=_totalMark*100/600.0;
        }

        public static Calculator operator + (Calculator sem1,Calculator sem2)
        {
            Calculator calculator=new Calculator(0,0,0,0,0,0);
            calculator.Subject1Mark=sem1.Subject1Mark+sem2.Subject1Mark;
            calculator.Subject2Mark=sem1.Subject2Mark+sem2.Subject2Mark;
            calculator.Subject3Mark=sem1.Subject3Mark+sem2.Subject3Mark;
            calculator.Subject4Mark=sem1.Subject4Mark+sem2.Subject4Mark;
            calculator.Subject5Mark=sem1.Subject5Mark+sem2.Subject5Mark;
            calculator.Subject6Mark=sem1.Subject6Mark+sem2.Subject6Mark;

            return calculator;
        }
    }
}