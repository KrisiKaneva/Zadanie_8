
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8
{
    internal class Customer
    {
        private string customerID;
        public string CustomerID
        {
            get { return customerID; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new ArgumentException();
                }
                else
                {
                    customerID = value;
                }
            }
        }

        private string fullName;
        public string FullName
        {
            get { return fullName; }
            set
            {
                if (value == " ")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new Exception("Enter valid name!");
                }
                else
                {
                    fullName = value;
                }
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (value == " ")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new ArgumentNullException("Enter valid email!");
                }
                else
                {
                    email = value;
                }
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new NullReferenceException("Enter valid phone number!");
                }
                else
                {
                    phoneNumber = value;
                }
            }
        }

        private string shippingAddress;
        public string ShippingAddress
        {
            get { return shippingAddress; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    throw new Exception("Enter valid order address!");
                }
                else
                {
                    shippingAddress = value;
                }
            }
        }
    }
}

