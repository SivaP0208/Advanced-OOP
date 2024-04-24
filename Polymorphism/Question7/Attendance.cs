using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question7
{
    public class Attendance
    {
        public int TotalWorkingDaysInMonth { get; set; }
        public int NumberOfLeavesTaken { get; set; }
        public int NumberOfPermissionsTaken { get; set; }

        public Attendance(int totalWorkingDaysInMonth,int numberOfLeavesTaken,int numberOfPermissionsTaken)
        {
            TotalWorkingDaysInMonth=totalWorkingDaysInMonth;
            NumberOfLeavesTaken=numberOfLeavesTaken;
            NumberOfPermissionsTaken=numberOfPermissionsTaken;
        }

        public static Attendance operator + (Attendance month1,Attendance month2)
        {
            Attendance attendance=new Attendance(0,0,0);
            attendance.TotalWorkingDaysInMonth=month1.TotalWorkingDaysInMonth+month2.TotalWorkingDaysInMonth;
            attendance.NumberOfLeavesTaken=month1.NumberOfLeavesTaken+month2.NumberOfLeavesTaken;
            attendance.NumberOfPermissionsTaken=month1.NumberOfPermissionsTaken+month2.NumberOfPermissionsTaken;
            return attendance;
        } 
    }
}