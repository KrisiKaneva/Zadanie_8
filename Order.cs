using System;
using System.Collections.Generic;
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
                if (string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new Exception("Enter valid order ID!");
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
                if (string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new ArgumentException("Enter valid customer ID");
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
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new ArgumentException("Order date can not be the default date.");
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
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new ArgumentException("Enter valid total amount!");
                }
            }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new Exception("Enter valid status!");
                }
            }
        }

        private string location;
        public string Location
        {
            get { return location; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
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
