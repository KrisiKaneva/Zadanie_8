using System;
using System.Collections.Generic;
namespace Zadanie_novo
{
	public class Category
	{
        private string categoryID; //change
        public string CategoryID
        {
            get { return categoryID; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("CategoryID cannot be null or whitespace.");
                }
                else
                {
                    categoryID = value;
                }
            }
        }

        private string name; //change
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be null or whitespace.");
                }
                else
                {
                    name = value;
                }
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Description cannot be null or whitespace.");
                }
                else
                {
                    description = value;
                }
            }
        }

        public List<Product> Products { get; set; } //change
    }
}

