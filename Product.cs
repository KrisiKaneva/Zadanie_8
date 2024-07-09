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
                    throw new NullReferenceException();
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
                if (value == " ")
                {
                    throw new NullReferenceException();
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
                if (value == " ")
                {
                    throw new NullReferenceException();
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
                    throw new NullReferenceException();
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
                    throw new NullReferenceException();
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
                if (value == " ")
                {
                    throw new NullReferenceException();
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
