using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class IDInfo:PersonalInfo
    {
        public string VoterID { get; set; }
        public long AadharID { get; set; }
        public string PanNumber { get; set; }
        
        public IDInfo(string name,string gender,DateTime dob,long mobile,string voterID,long aadharID,string panNumber):base(name,gender,dob,mobile)
        {
            VoterID=voterID;
            AadharID=aadharID;
            PanNumber=panNumber;
        }
    }
}