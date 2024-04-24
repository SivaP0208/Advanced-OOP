using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="MedicineDetails"/> 
    /// </summary>
    public class MedicineDetails
    {
        /// <summary>
        /// This static field is used to auto increment the Medicine ID of Instance <see cref="MedicineDetails"/> 
        /// </summary>
        private static int s_medicineID=100;

        /// <summary>
        /// This Property is used to hold Medicine ID of Instance <see cref="MedicineDetails"/> 
        /// </summary>
        public string MedicineID { get; }

        /// <summary>
        /// This Property is used to hold Medicine ID of Instance <see cref="MedicineDetails"/> 
        /// </summary>
        public string MedicineName { get; set; }

        /// <summary>
        /// This Property is used to hold Available Count of Instance <see cref="MedicineDetails"/> 
        /// </summary>
        public int AvailableCount { get; set; }

        /// <summary>
        /// This Property is used to hold Price of Instance <see cref="MedicineDetails"/> 
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// This Property is used to hold Date of Expiry of Instance <see cref="MedicineDetails"/> 
        /// </summary>
        public DateTime DateOfExpiry { get; set; }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="MedicineDetails"/> with Parameter Values. 
        /// </summary>
        /// <param name="medicineName">This Parameter is used to initialize its respective Property of <see cref="MedicineDetails"/></param>
        /// <param name="availableCount">This Parameter is used to initialize its respective Property of <see cref="MedicineDetails"/></param>
        /// <param name="price">This Parameter is used to initialize its respective Property of <see cref="MedicineDetails"/></param>
        /// <param name="dateOfExpiry">This Parameter is used to initialize its respective Property of <see cref="MedicineDetails"/></param>
        public MedicineDetails(string medicineName,int availableCount,double price,DateTime dateOfExpiry)
        {
            MedicineID="MD"+(++s_medicineID);
            MedicineName=medicineName;
            AvailableCount=availableCount;
            Price=price;
            DateOfExpiry=dateOfExpiry;
        }
        
        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="MedicineDetails"/> with Parameter Values. 
        /// </summary>
        /// <param name="medicine">This Parameter is used to initialize its respective Property of <see cref="MedicineDetails"/></param>
        public MedicineDetails(string medicine)
        {
            string [] properties=medicine.Split(',');
            MedicineID=properties[0];
            s_medicineID=int.Parse(properties[0].Remove(0,2));
            MedicineName=properties[1];
            AvailableCount=int.Parse(properties[2]);
            Price=double.Parse(properties[3]);
            DateOfExpiry=DateTime.ParseExact(properties[4],"dd/MM/yyyy",null);
        }
    }
}