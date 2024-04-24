using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="ItemDetails"/> 
    /// </summary>
    public class ItemDetails
    {
        /// <summary>
        /// This static field is used to auto increment the Item ID of Instance <see cref="ItemDetails"/> 
        /// </summary>
        private static int s_itemID = 4000;

        /// <summary>
        /// This Property is used to hold Item ID of Instance <see cref="ItemDetails"/> 
        /// </summary>
        public string ItemID { get; }

        /// <summary>
        /// This Property is used to hold Order ID of Instance <see cref="ItemDetails"/> 
        /// </summary>
        public string OrderID { get; set; }

        /// <summary>
        /// This Property is used to hold Food ID of Instance <see cref="ItemDetails"/> 
        /// </summary>
        public string FoodID { get; set; }

        /// <summary>
        /// This Property is used to hold Purchase Count of Instance <see cref="ItemDetails"/> 
        /// </summary>
        public int PurchaseCount { get; set; }

        /// <summary>
        /// This Property is used to hold Price of Order of Instance <see cref="ItemDetails"/> 
        /// </summary>
        public double PriceOfOrder { get; set; }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="ItemDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="orderID">This Parameter is used to initialize its respective Property of <see cref="ItemDetails"/></param>
        /// <param name="foodID">This Parameter is used to initialize its respective Property of <see cref="ItemDetails"/></param>
        /// <param name="purchaseCount">This Parameter is used to initialize its respective Property of <see cref="ItemDetails"/></param>
        /// <param name="priceOfOrder">This Parameter is used to initialize its respective Property of <see cref="ItemDetails"/></param>
        public ItemDetails(string orderID, string foodID, int purchaseCount, double priceOfOrder)
        {
            ItemID = "ITID" + (++s_itemID);
            OrderID = orderID;
            FoodID = foodID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="ItemDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="item">This Parameter is used to initialize its respective Property of <see cref="ItemDetails"/> by splitting it.</param>
        public ItemDetails(string item)
        {
            string[] properties = item.Split(',');
            ItemID = properties[0];
            s_itemID = int.Parse(properties[0].Remove(0, 4));
            OrderID = properties[1];
            FoodID = properties[2];
            PurchaseCount = int.Parse(properties[3]);
            PriceOfOrder = double.Parse(properties[4]);
        }
    }
}