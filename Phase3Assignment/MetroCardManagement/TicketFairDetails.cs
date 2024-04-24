using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="TicketFairDetails"/> 
    /// </summary>
    public class TicketFairDetails
    {
        /// <summary>
        /// Static field used to auto increment the "Ticket ID" of Instatnce <see cref="TicketFairDetails"/> 
        /// </summary>
        private static int s_ticketID = 3000;

        /// <summary>
        /// This Property used to hold "Ticket ID" of the Instance <see cref="TicketFairDetails"/>  
        /// </summary>
        public string TicketID { get; }

        /// <summary>
        /// This Property used to hold From Location of the Instance <see cref="TicketFairDetails"/>  
        /// </summary>
        public string FromLocation { get; set; }

        /// <summary>
        /// This Property used to hold To Location of the Instance <see cref="TicketFairDetails"/>  
        /// </summary>
        public string ToLocation { get; set; }

        /// <summary>
        /// This Property used to hold Ticket Price of the Instance <see cref="TicketFairDetails"/>  
        /// </summary>
        public double TicketPrice { get; set; }

        /// <summary>
        /// This Constructor used to Create Instance of <see cref="TicketFairDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="fromLocation">This parameter used to initialize the respective property of <see cref="TicketFairDetails"/></param>
        /// <param name="toLocation">This parameter used to initialize the respective property of <see cref="TicketFairDetails"/></param>
        /// <param name="ticketPrice">This parameter used to initialize the respective property of <see cref="TicketFairDetails"/></param>
        public TicketFairDetails(string fromLocation, string toLocation, double ticketPrice)
        {
            TicketID = "MR" + (++s_ticketID);
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TicketPrice = ticketPrice;
        }

        /// <summary>
        /// This Constructor used to Create Instance of <see cref="TicketFairDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="ticket">This parameter used to initialize the respective properties of <see cref="TicketFairDetails"/> by splitting this.</param>
        public TicketFairDetails(string ticket)
        {
            string[] properties = ticket.Split(',');
            TicketID = properties[0];

            s_ticketID = int.Parse(properties[0].Remove(0, 2));

            FromLocation = properties[1];
            ToLocation = properties[2];
            TicketPrice = double.Parse(properties[3]);
        }
    }
}