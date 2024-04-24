using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    /// <summary>
    /// This enum is used to select the options among them.
    /// </summary>
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}

    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="BookingDetails"/> 
    /// </summary>
    public class BookingDetails
    {
        /// <summary>
        /// This static field is used to auto increment the Booking ID of Instance <see cref="BookingDetails"/> 
        /// </summary>
        private static int s_bookingID=3000;

        /// <summary>
        /// This Property is used to hold Booking ID of Instance <see cref="BookingDetails"/> 
        /// </summary>
        public string BookingID { get; }

        /// <summary>
        /// This Property is used to hold Customer ID of Instance <see cref="BookingDetails"/> 
        /// </summary>
        public string CustomerID { get; set; }

        /// <summary>
        /// This Property is used to hold Total Price of Instance <see cref="BookingDetails"/> 
        /// </summary>
        public double TotalPrice { get; set; }

        /// <summary>
        /// This Property is used to hold Date of Booking of Instance <see cref="BookingDetails"/> 
        /// </summary>
        public DateTime DateOfBooking { get; set; }

        /// <summary>
        /// This Property is used to hold Booking Status of Instance <see cref="BookingDetails"/> 
        /// </summary>
        public BookingStatus BookingStatus { get; set; }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="BookingDetails"/> with Default Values.
        /// </summary>
        public BookingDetails()
        {
            BookingID="BID"+(++s_bookingID);
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="BookingDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="customerID">This Parameter is used to initialize its respective Property of <see cref="BookingDetails"/></param>
        /// <param name="totalPrice">This Parameter is used to initialize its respective Property of <see cref="BookingDetails"/></param>
        /// <param name="dateOfBooking">This Parameter is used to initialize its respective Property of <see cref="BookingDetails"/></param>
        /// <param name="bookingStatus">This Parameter is used to initialize its respective Property of <see cref="BookingDetails"/></param>
        public BookingDetails(string customerID,double totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            BookingID="BID"+(++s_bookingID);
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus=bookingStatus;
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="BookingDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="booking">This Parameter is used to initialize its respective Property of <see cref="BookingDetails"/> by splitting it.</param>
        public BookingDetails(string booking)
        {
            string[] properties=booking.Split(',');
            BookingID=properties[0];
            s_bookingID=int.Parse(properties[0].Remove(0,3));
            CustomerID=properties[1];
            TotalPrice=double.Parse(properties[2]);
            DateOfBooking=DateTime.ParseExact(properties[3],"dd/MM/yyyy",null);
            BookingStatus=Enum.Parse<BookingStatus>(properties[4]);
        }

        /// <summary>
        /// This method is used to show Booking Details
        /// </summary>
        public void ShowBookingDetails()
        {
            Console.WriteLine("\n\tBooking Details\n");
            Console.WriteLine($"Booking ID : {BookingID}");
            Console.WriteLine($"Customer ID : {CustomerID}");
            Console.WriteLine($"Total Price : {TotalPrice}");
            Console.WriteLine($"Date of Booking : {DateOfBooking.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Booking Status : {BookingStatus}");
        }
    }
}