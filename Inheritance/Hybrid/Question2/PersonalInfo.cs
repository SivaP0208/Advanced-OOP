using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public long Mobile { get; set; }

        public PersonalInfo(string name,string gender,DateTime dob,long mobile)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
        }
    }
}