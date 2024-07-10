using System;
using System.Collections.Generic;
namespace Zadanie_novo
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
        private DateTime orderDate; //change
        public DateTime OrderDate
        {
            get { return orderDate; }
            set
            {
                if (value == default(DateTime))
                {
                    throw new ArgumentException("Order date cannot be the default date.");
                }
                else
                {
                    orderDate = value;
                }
            }
        }

        public List<Product> OrderItems { get; set; }

        private decimal totalAmount;
        public decimal TotalAmount
        {
            get { return totalAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
            }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set
            {
                if(value==" ")
                {
                    throw new Exception();
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
    }
}
