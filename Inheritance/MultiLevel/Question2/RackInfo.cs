using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class RackInfo:DepartmentDetails
    {
        public int RackNumber { get; set; }
        public int ColumnNumber { get; set; }

        public RackInfo(string departmentID,string departmentName,string degree,int rackNumber,int columnNumber):base(departmentID,departmentName,degree)
        {
            RackNumber=rackNumber;
            ColumnNumber=columnNumber;
        }
    }
}