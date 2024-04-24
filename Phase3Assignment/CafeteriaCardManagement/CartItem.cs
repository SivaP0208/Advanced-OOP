using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    /// <summary>
    ///  This Class is used as a blueprint to create Instance for <see cref="CartItem"/> 
    /// </summary>
    public class CartItem
    {
        /// <summary>
        /// This static field is used to auto increment the Item ID of Instance <see cref="CartItem"/> 
        /// </summary>
        private static int s_itemID = 100;

        /// <summary>
        /// This Property is used to hold Item ID of Instance <see cref="CartItem"/>
        /// </summary>
        public string ItemID { get; }

        /// <summary>
        /// This Property is used to hold Order ID of Instance <see cref="CartItem"/>
        /// </summary>
        public string OrderID { get; set; }

        /// <summary>
        /// This Property is used to hold Food ID of Instance <see cref="CartItem"/>
        /// </summary>
        public string FoodID { get; set; }

         /// <summary>
        /// This Property is used to hold Order Price of Instance <see cref="CartItem"/>
        /// </summary>
        public double OrderPrice { get; set; }

        /// <summary>
        /// This Property is used to hold Order Quantity of Instance <see cref="CartItem"/>
        /// </summary>
        public int OrderQuantity { get; set; }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="CartItem"/> with Parameter Values. 
        /// </summary>
        /// <param name="orderID">This Parameter is used to initialize its respective Property of <see cref="CartItem"/></param>
        /// <param name="foodID">This Parameter is used to initialize its respective Property of <see cref="CartItem"/></param>
        /// <param name="orderPrice">This Parameter is used to initialize its respective Property of <see cref="CartItem"/></param>
        /// <param name="orderQuantity">This Parameter is used to initialize its respective Property of <see cref="CartItem"/></param>
        public CartItem(string orderID, string foodID, double orderPrice, int orderQuantity)
        {
            ItemID = "ITID" + (++s_itemID);
            OrderID = orderID;
            FoodID = foodID;
            OrderPrice = orderPrice;
            OrderQuantity = orderQuantity;
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="CartItem"/> with Parameter Values.
        /// </summary>
        /// <param name="cartItem">This Parameter is used to initialize its respective Property of <see cref="CarteItem"/> by splitting it.</param>
        public CartItem(string cartItem)
        {
            string[] properties = cartItem.Split(',');
            ItemID = properties[0];

            s_itemID = int.Parse(properties[0].Remove(0, 4));

            OrderID = properties[1];
            FoodID = properties[2];
            OrderPrice = double.Parse(properties[3]);
            OrderQuantity = int.Parse(properties[4]);
        }
    }
}