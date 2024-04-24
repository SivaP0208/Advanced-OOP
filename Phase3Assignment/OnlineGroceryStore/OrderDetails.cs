using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="OrderDetails"/> 
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// This static field is used to auto increment the Order ID of Instance <see cref="OrderDetails"/> 
        /// </summary>
        private static int s_orderID=4000;

        /// <summary>
        /// This Property is used to hold Order ID of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public string OrderID { get; }

        /// <summary>
        /// This Property is used to hold Booking ID of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public string BookingID { get; set; }

        /// <summary>
        /// This Property is used to hold Product ID of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public string ProductID { get; set; }

        /// <summary>
        /// This Property is used to hold Purchase Count of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public int PurchaseCount { get; set; }

        /// <summary>
        /// This Property is used to hold Price Of Order of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public double PriceOfOrder { get; set; }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="OrderDetails"/> with default Values.
        /// </summary>
        public OrderDetails()
        {
            OrderID="OID"+(++s_orderID);
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="OrderDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="bookingID">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        /// <param name="productID">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        /// <param name="purchaseCount">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        /// <param name="priceOfOrder">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        public OrderDetails(string bookingID,string productID,int purchaseCount,double priceOfOrder)
        {
            OrderID="OID"+(++s_orderID);
            BookingID=bookingID;
            ProductID=productID;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="OrderDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="order">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/> by splitting it.</param>
        public OrderDetails(string order)
        {
            string[] properties=order.Split(',');
            OrderID=properties[0];
            s_orderID=int.Parse(properties[0].Remove(0,3));
            BookingID=properties[1];
            ProductID=properties[2];
            PurchaseCount=int.Parse(properties[3]);
            PriceOfOrder=double.Parse(properties[4]);
        }
    }
}