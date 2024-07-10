using System;
using System.Collections.Generic;
namespace Zadanie_novo
{
	public class Product
	{
        private string productID;
        public string ProductID
        {
            get { return productID; }
            set
            {
                if (value == " ")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new ArgumentException("Enter the correct ID");
                }
                else
                {
                    productID = value;
                }
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new ArgumentException("Name cannot be empty or null!");
                }
                else
                {
                    name = value;
                }
            }
        }

        private string category;
        public string Category
        {
            get { return category; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new ArgumentException("Category cannot be empty or null!");
                }
                else
                {
                    category = value;
                }
            }
        }
        private decimal price;
        public decimal Price //change
        {
            get { return price; }
            set
            {
                if (value <0)
                {
                    throw new NullReferenceException("Enter correct price!");
                }
                else
                {
                    price = value;
                }
            }
        }
        private int stockQuantity;
        public int StockQuantity //change
        {
            get { return stockQuantity; }
            set
            {
                if (value <0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new ArgumentNullException("Must be above or 0!");
                }
                else
                {
                    stockQuantity = value;
                }
            }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new NullReferenceException("Enter valid description!");
                }
                else
                {
                    description = value;
                }
            }
        }
        private bool isAvailable;
        public bool IsAvailable { get; set; } //change
    }
}
