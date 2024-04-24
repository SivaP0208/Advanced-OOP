using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="FoodDetails"/> 
    /// </summary>
    public class FoodDetails
    {
        /// <summary>
        /// This static field is used to auto increment the Food ID of Instance <see cref="FoodDetails"/> 
        /// </summary>
        private static int s_foodID = 100;

        /// <summary>
        /// This Property is used to hold Food ID of Instance <see cref="FoodDetails"/> 
        /// </summary>
        public string FoodID { get; }

        /// <summary>
        /// This Property is used to hold Food Name of Instance <see cref="FoodDetails"/> 
        /// </summary>
        public string FoodName { get; set; }

        /// <summary>
        /// This Property is used to hold Price of Instance <see cref="FoodDetails"/> 
        /// </summary>
        public double FoodPrice { get; set; }

        /// <summary>
        /// This Property is used to hold Quantity Available of Instance <see cref="FoodDetails"/> 
        /// </summary>
        public int AvailableQuantity { get; set; }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="FoodDetails"/> with Parameter Values. 
        /// </summary>
        /// <param name="foodName">This Parameter is used to initialize its respective Property of <see cref="FoodDetails"/></param>
        /// <param name="foodPrice">This Parameter is used to initialize its respective Property of <see cref="FoodDetails"/></param>
        /// <param name="availableQuantity">This Parameter is used to initialize its respective Property of <see cref="FoodDetails"/></param>
        public FoodDetails(string foodName, double foodPrice, int availableQuantity)
        {
            FoodID = "FID" + (++s_foodID);
            FoodName = foodName;
            FoodPrice = foodPrice;
            AvailableQuantity = availableQuantity;
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="FoodDetails"/> with Parameter Values.
        /// </summary>
        /// <param name="food">This Parameter is used to initialize its respective Property of <see cref="FoodDetails"/> by splitting it.</param>
        public FoodDetails(string food)
        {
            string[] properties = food.Split(',');
            FoodID = properties[0];

            s_foodID = int.Parse(properties[0].Remove(0, 3));

            FoodName = properties[1];
            FoodPrice = double.Parse(properties[2]);
            AvailableQuantity = int.Parse(properties[3]);
        }
    }
}