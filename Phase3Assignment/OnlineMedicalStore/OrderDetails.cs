using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// This enum is used to select the options among them.
    /// </summary>
    public enum OrderStatus{Purchased,Cancelled}

    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="OrderDetails"/> 
    /// </summary>
    public class OrderDetails
    {
         /// <summary>
        /// This static field is used to auto increment the Order ID of Instance <see cref="OrderDetails"/> 
        /// </summary>
        private static int s_orderID=2000;

        /// <summary>
        /// This Property is used to hold Order ID of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public string OrderID { get; }

        /// <summary>
        /// This Property is used to hold User ID of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// This Property is used to hold Medicine ID of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public string MedicineID { get; set; }

        /// <summary>
        /// This Property is used to hold Medicine Count of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public int MedicineCount { get; set; }

         /// <summary>
        ///  This Property is used to hold Total Price of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public double TotalPrice { get; set; }

        /// <summary>
        /// This Property is used to hold OrderDate of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        ///  This Property is used to hold Order Status of Instance <see cref="OrderDetails"/> 
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="OrderDetails"/> with Parameter Values. 
        /// </summary>
        /// <param name="userID">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        /// <param name="medicineID">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        /// <param name="medicineCount">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        /// <param name="totalPrice">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        /// <param name="orderDate">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        /// <param name="orderStatus">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/></param>
        public OrderDetails(string userID,string medicineID,int medicineCount,double totalPrice,DateTime orderDate,OrderStatus orderStatus)
        {
            OrderID="OID"+(++s_orderID);
            UserID=userID;
            MedicineID=medicineID;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            OrderStatus=orderStatus;
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="OrderDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="order">This Parameter is used to initialize its respective Property of <see cref="OrderDetails"/> by splitting it.</param>
        public OrderDetails(string order)
        {
            string [] properties=order.Split(',');
            OrderID=properties[0];
            s_orderID=int.Parse(properties[0].Remove(0,3));
            UserID=properties[1];
            MedicineID=properties[2];
            MedicineCount=int.Parse(properties[3]);
            TotalPrice=double.Parse(properties[4]);
            OrderDate=DateTime.ParseExact(properties[5],"dd/MM/yyyy",null);
            OrderStatus=Enum.Parse<OrderStatus>(properties[6]);
        }
    }
}