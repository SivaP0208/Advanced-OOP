using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="TravelDetails"/> 
    /// </summary>
    public class TravelDetails
    {
        /// <summary>
        /// Static field used to auto increment the Travel ID of Instance <see cref="TravelDetails"/> 
        /// </summary>
        private static int s_travelID = 2000;

        /// <summary>
        /// This Property used to hold Travel ID of the Instance <see cref="TravelDetails"/>  
        /// </summary>
        public string TravelID { get; }

        /// <summary>
        /// This Property used to hold Card Number of the Instance <see cref="TravelDetails"/>  
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// This Property used to hold From Location of the Instance <see cref="TravelDetails"/>  
        /// </summary>
        public string FromLocation { get; set; }

        /// <summary>
        /// This Property used to hold To Location of the Instance <see cref="TravelDetails"/>  
        /// </summary>
        public string ToLocation { get; set; }

        /// <summary>
        /// This Property used to hold Date of the Instance <see cref="TravelDetails"/>  
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// This Property used to hold Travel Cost of the Instance <see cref="TravelDetails"/>  
        /// </summary>
        public double TravelCost { get; set; }

        /// <summary>
        /// This Constructor used to Create Instance of <see cref="TravelDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="cardNumber">This parameter used to initialize the respective property of <see cref="TravelDetails"/></param>
        /// <param name="fromLocation">This parameter used to initialize the respective property of <see cref="TravelDetails"/></param>
        /// <param name="toLocation">This parameter used to initialize the respective property of <see cref="TravelDetails"/></param>
        /// <param name="date">This parameter used to initialize the respective property of <see cref="TravelDetails"/></param>
        /// <param name="travelCost">This parameter used to initialize the respective property of <see cref="TravelDetails"/></param>
        public TravelDetails(string cardNumber, string fromLocation, string toLocation, DateTime date, double travelCost)
        {
            TravelID = "TID" + (++s_travelID);
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            Date = date;
            TravelCost = travelCost;
        }

        /// <summary>
        /// This Constructor used to Create Instance of <see cref="TravelDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="travel">This parameter used to initialize the respective properties of <see cref="TravelDetails"/> by splitting this.</param> 
        public TravelDetails(string travel)
        {
            string[] properties = travel.Split(',');
            TravelID = properties[0];

            s_travelID = int.Parse(properties[0].Remove(0, 3));

            CardNumber = properties[1];
            FromLocation = properties[2];
            ToLocation = properties[3];
            Date = DateTime.ParseExact(properties[4], "dd/MM/yyyy", null);
            TravelCost = double.Parse(properties[5]);
        }
    }
}