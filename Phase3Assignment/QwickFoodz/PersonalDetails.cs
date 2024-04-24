using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    /// <summary>
    /// This enum is used to select the options among them.
    /// </summary>
    public enum Gender { Select, Male, Female, Transgender }

    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="PersonalDetails"/> 
    /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// This Property is used to hold Name of Instance <see cref="PersonalDetails"/> 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This Property is used to hold FatherName of Instance <see cref="PersonalDetails"/> 
        /// </summary>
        public string FatherName { get; set; }

        /// <summary>
        /// This Property is used to hold Gender of Instance <see cref="PersonalDetails"/> 
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// This Property is used to hold Mobile Number of Instance <see cref="PersonalDetails"/> 
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// This Property is used to hold Date Of Birth of Instance <see cref="PersonalDetails"/> 
        /// </summary>
        public DateTime DOB { get; set; }

        /// <summary>
        /// This Property is used to hold Mail ID of Instance <see cref="PersonalDetails"/> 
        /// </summary>
        public string MailID { get; set; }

        /// <summary>
        /// This Property is used to hold Location of Instance <see cref="PersonalDetails"/> 
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="PersonalDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="name">This Parameter is used to initialize its respective Property of <see cref="PersonalDetails"/></param>
        /// <param name="fatherName">This Parameter is used to initialize its respective Property of <see cref="PersonalDetails"/></param>
        /// <param name="gender">This Parameter is used to initialize its respective Property of <see cref="PersonalDetails"/></param>
        /// <param name="mobile">This Parameter is used to initialize its respective Property of <see cref="PersonalDetails"/></param>
        /// <param name="dob">This Parameter is used to initialize its respective Property of <see cref="PersonalDetails"/></param>
        /// <param name="mailID">This Parameter is used to initialize its respective Property of <see cref="PersonalDetails"/></param>
        /// <param name="location">This Parameter is used to initialize its respective Property of <see cref="PersonalDetails"/></param>
        public PersonalDetails(string name, string fatherName, Gender gender, string mobile, DateTime dob, string mailID, string location)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            DOB = dob;
            MailID = mailID;
            Location = location;
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="PersonalDetails"/> with Default Values.
        /// </summary>
        public PersonalDetails()
        {

        }
    }
}