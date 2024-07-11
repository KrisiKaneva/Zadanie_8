using System;
using System.Collections.Generic;
namespace Zadanie_8
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
                    throw new ArgumentException("Enter your ID");
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
                    throw new ArgumentException("Namespace can not be empty!");
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
                    throw new ArgumentException("Category can not be empty!");
                }
                else
                {
                    category = value;
                }
            }
        }
        private decimal price;
        public decimal Price 
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new NullReferenceException("Enter the price!");
                }
                else
                {
                    price = value;
                }
            }
        }
        private int stockQuantity;
        public int StockQuantity 
        {
            get { return stockQuantity; }
            set
            {
                if (value < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new ArgumentNullException("It must be a positive number!");
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
        public bool IsAvailable { get; set; } 
    }
}
