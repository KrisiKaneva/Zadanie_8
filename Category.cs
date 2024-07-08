using System;
using System.Collections.Generic;

namespace Zadanie_8
{
	public class Category
	{
		private string categoryID;
		public string CategoryID
		{
			get { return categoryID; }
			set
			{
				if (value == " ")
				{
					throw new NullReferenceException();
				}
				else
				{
					categoryID = value;
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

        public List<Product> Products;


        public Category()
		{
		}
	}
}

