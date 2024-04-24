using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public partial class EmployeeInfo
    {
        public EmployeeInfo()
        {
            EmployeeID="EID"+(++s_employeeID);
        }

        public EmployeeInfo(string name,string gender,DateTime dob,long mobile)
        {
            EmployeeID="EID"+(++s_employeeID);
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
        }
    }
}