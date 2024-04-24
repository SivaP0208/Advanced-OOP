using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class TheoryExamMarks:PersonalInfo
    {
        public double[] Sem1 { get; set; }
        public double[] Sem2 { get; set; }
        public double[] Sem3 { get; set; }
        public double[] Sem4 { get; set; }

        public TheoryExamMarks(string registrationNumber,string name,string fatherName,long phone,DateTime dob,string gender,double[] sem1,double[] sem2,double[] sem3,double[] sem4):base(registrationNumber,name,fatherName,phone,dob,gender)
        {
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
    }
}