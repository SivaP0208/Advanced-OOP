using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="FoodDetails"/> 
    /// </summary> 
    public class FoodDetails
    {
        /// <summary>
        /// This static field is used to auto increment the Food ID of Instance <see cref="FoodDetails"/> 
        /// </summary>
        private static int s_foodID = 2000;

        /// <summary>
        /// This Property is used to hold Food ID of Instance <see cref="FoodDetails"/> 
        /// </summary>
        public string FoodID { get; }

        /// <summary>
        /// This Property is used to hold Food Name of Instance <see cref="FoodDetails"/> 
        /// </summary>
        public string FoodName { get; set; }

        /// <summary>
        /// This Property is used to hold Price Per Quantity of Instance <see cref="FoodDetails"/> 
        /// </summary>
        public double PricePerQuantity { get; set; }

        /// <summary>
        /// This Property is used to hold Quantity Available of Instance <see cref="FoodDetails"/> 
        /// </summary>
        public int QuantityAvailable { get; set; }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="FoodDetails"/> with Parameter Values. 
        /// </summary>
        /// <param name="foodName">This Parameter is used to initialize its respective Property of <see cref="FoodDetails"/></param>
        /// <param name="pricePerQuantity">This Parameter is used to initialize its respective Property of <see cref="FoodDetails"/></param>
        /// <param name="quantityAvailable">This Parameter is used to initialize its respective Property of <see cref="FoodDetails"/></param>
        public FoodDetails(string foodName, double pricePerQuantity, int quantityAvailable)
        {
            FoodID = "FID" + (++s_foodID);
            FoodName = foodName;
            PricePerQuantity = pricePerQuantity;
            QuantityAvailable = quantityAvailable;
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
            PricePerQuantity = int.Parse(properties[2]);
            QuantityAvailable = int.Parse(properties[3]);
        }
    }
}