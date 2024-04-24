using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
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
        /// This Property is used to hold Age of Instance <see cref="PersonalDetails"/>
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// This Property is used to hold City of Instance <see cref="PersonalDetails"/>
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// This Property is used to hold Phone Number of Instance <see cref="PersonalDetails"/>
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="PersonalDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="name">This Parameter is used to initialize its respective Property of <see cref="PersonalDetails"/></param>
        /// <param name="age">This Parameter is used to initialize its respective Property of <see cref="PersonalDetails"/></param>
        /// <param name="city">This Parameter is used to initialize its respective Property of <see cref="PersonalDetails"/></param>
        /// <param name="phoneNumber">This Parameter is used to initialize its respective Property of <see cref="PersonalDetails"/></param>
        public PersonalDetails(string name,int age,string city,string phoneNumber)
        {
            Name=name;
            Age=age;
            City=city;
            PhoneNumber=phoneNumber;
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="PersonalDetails"/> with default Values.
        /// </summary>
        public PersonalDetails()
        {

        }
    }
}