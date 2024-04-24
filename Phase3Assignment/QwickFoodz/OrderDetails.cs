using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    /// <summary>
    /// This enum is used to select the options among them.
    /// </summary>
    public enum OrderStatus { Default, Initiated, Ordered, Cancelled }

    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="OrderDetails"/> 
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// This static field is used to auto increment the Order ID of Instance <see cref="OrderDetails"/> 
        /// </summary>
        private static int s_orderID = 3000;

        /// <summary>
        /// This Property is used to hold Order ID of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public string OrderID { get; }

        /// <summary>
        ///  This Property is used to hold Customer ID of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public string CustomerID { get; set; }

        /// <summary>
        ///  This Property is used to hold Total Price of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public double TotalPrice { get; set; }

        /// <summary>
        ///  This Property is used to hold Date of Order of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public DateTime DateOfOrder { get; set; }

        /// <summary>
        ///  This Property is used to hold Order Status of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="OrderDetails"/> with Parameter Values. 
        /// </summary>
        /// <param name="customerID">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        /// <param name="totalPrice">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        /// <param name="dateOFOrder">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        /// <param name="orderStatus">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        public OrderDetails(string customerID, double totalPrice, DateTime dateOFOrder, OrderStatus orderStatus)
        {
            OrderID = "OID" + (++s_orderID);
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfOrder = dateOFOrder;
            OrderStatus = orderStatus;
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="OrderDetails"/> with Parameter Values. 
        /// </summary>
        /// <param name="order">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/> by splitting it.</param>
        public OrderDetails(string order)
        {
            string[] properties = order.Split(',');
            OrderID = properties[0];
            s_orderID = int.Parse(properties[0].Remove(0, 3));
            CustomerID = properties[1];
            TotalPrice = double.Parse(properties[2]);
            DateOfOrder = DateTime.ParseExact(properties[3], "dd/MM/yyyy", null);
            OrderStatus = Enum.Parse<OrderStatus>(properties[4], true);
        }
    }
}