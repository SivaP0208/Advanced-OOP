using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class DepartmentDetails
    {
        private static int s_departmentID=1000;
        public string DepartmentID { get; }
        public string DepartmentName { get; set; }
        public string Degree { get; set; }

        public DepartmentDetails(string departmentName,string degree)
        {
            DepartmentID="DID"+(++s_departmentID);
            DepartmentName=departmentName;
            Degree=degree;
        }

        public DepartmentDetails(string departmentID,string departmentName,string degree)
        {
            DepartmentID=departmentID;
            DepartmentName=departmentName;
            Degree=degree;
        }
    }
}