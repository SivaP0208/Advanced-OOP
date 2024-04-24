using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public partial class StudentInfo
    {
        public StudentInfo()
        {
            StudentID="SID"+(++s_studentID);
        }
        public StudentInfo(string name,string gender,DateTime dob,long mobile,int physicsMark,int chemistryMark,int mathsMark)
        {
            StudentID="SID"+(++s_studentID);
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
            PhysicsMark=physicsMark;
            ChemistryMark=chemistryMark;
            MathsMark=mathsMark;
        }
    }
}