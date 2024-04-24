using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    /// <summary>
    /// This Class is used as a blueprint to create Instance for <see cref="ProductDetails"/> 
    /// </summary>
    public class ProductDetails
    {
        /// <summary>
        /// This static field is used to auto increment the Product ID of Instance <see cref="ProductDetails"/> 
        /// </summary>
        private static int s_productID=2000;

        /// <summary>
        /// This Property is used to hold Product ID of Instance <see cref="ProductDetails"/> 
        /// </summary>
        public string ProductID { get; }

        /// <summary>
        /// This Property is used to hold Product Name of Instance <see cref="ProductDetails"/> 
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// This Property is used to hold Quantity Available of Instance <see cref="ProductDetails"/> 
        /// </summary>
        public int QuantityAvailable { get; set; }

        /// <summary>
        /// This Property is used to hold Price Per Quantity of Instance <see cref="ProductDetails"/> 
        /// </summary>
        public double PricePerQuantity { get; set; }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="ProductDetails"/> with Default Values. 
        /// </summary>
        public ProductDetails()
        {
            ProductID="PID"+(++s_productID);
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="ProductDetails"/> with Parameter Values. 
        /// </summary>
        /// <param name="productName">This Parameter is used to initialize its respective Property of <see cref="ProductDetails"/></param>
        /// <param name="quantityAvailable">This Parameter is used to initialize its respective Property of <see cref="ProductDetails"/></param>
        /// <param name="pricePerQuantity">This Parameter is used to initialize its respective Property of <see cref="ProductDetails"/></param>
        public ProductDetails(string productName,int quantityAvailable,double pricePerQuantity)
        {
            ProductID="PID"+(++s_productID);
            ProductName=productName;
            QuantityAvailable=quantityAvailable;
            PricePerQuantity=pricePerQuantity;
        }

        /// <summary>
        /// This Constructor is used to Create Instance for <see cref="ProductDetails"/> with Parameter Values. 
        /// </summary>
        /// <param name="product">This Parameter is used to initialize its respective Property of <see cref="ProductDetails"/> by splitting it.</param>
        public ProductDetails(string product)
        {
            string[] properties=product.Split(',');
            ProductID=properties[0];
            s_productID=int.Parse(properties[0].Remove(0,3));
            ProductName=properties[1];
            QuantityAvailable=int.Parse(properties[2]);
            PricePerQuantity=double.Parse(properties[3]);
        }

        /// <summary>
        /// This method is used to show Product Details
        /// </summary>
        public void ShowProductDetails()
        {
            Console.WriteLine("\n\tProduct Details\n");
            Console.WriteLine($"Product ID         : {ProductID}");
            Console.WriteLine($"Product Name       : {ProductName}");
            Console.WriteLine($"Quantity Available : {QuantityAvailable}");
            Console.WriteLine($"Price Per Quantity : {PricePerQuantity}");
        }
    }
}