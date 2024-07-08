using System;
namespace Zadanie_8
{
	public class Order
	{
		private string orderID;
        public string OrderID
        {
            get { return orderID; }
            set
            {
                if (value == " ")
                {
                    throw new NullReferenceException();
                }
                else
                {
                    orderID = value;
                }
            }
        }

        private string customerID;
        public string CustomerID
        {
            get { return customerID; }
            set
            {
                if (value == " ")
                {
                    throw new NullReferenceException();
                }
                else
                {
                    customerID = value;
                }
            }
        }
        private DateTime orderDate;
        public string OrderDate
        {
            get { return orderID; }
            set
            {
                if (value == " ")
                {
                    throw new NullReferenceException();
                }
                else
                {
                    orderID = value;
                }
            }
        }
        private string location;
        public string Location
        {
            get { return location; }
            set
            {
                if (value == " ")
                {
                    throw new NullReferenceException();
                }
                else
                {
                    location = value;
                }
            }
        }


        public Order()
		{
		}
	}
}
