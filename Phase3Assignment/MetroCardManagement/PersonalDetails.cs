using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This Class is used as a blueprint to create Instance for Personal Details <see cref="PersonalDetails"/> 
    /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// This property used to hold User Name of Instance <see cref="PersonalDetails"/> 
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// This property used to hold Phone Number of Instance <see cref="PersonalDetails"/> 
        /// </summary>
        public long PhoneNumber { get; set; }

        /// <summary>
        /// This Constructor used to Create Instance of <see cref="PersonalDetails"/> with parameter values. 
        /// </summary>
        /// <param name="userName">This parameter used to initialize the respective property of <see cref="PersonalDetails"/> .</param>
        /// <param name="phoneNumber">This parameter used to initialize the respective property of <see cref="PersonalDetails"/>.</param>
        public PersonalDetails(string userName, long phoneNumber)
        {
            UserName = userName;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// This Constructor used to create instance of <see cref="PersonalDetails" with default values/> 
        /// </summary>
        public PersonalDetails()
        {

        }
    }
}