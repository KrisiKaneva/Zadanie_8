using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingIvo
{
    internal class Customer
    {
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

        private string fullName;
        public string FullName
        {
            get { return fullName; }
            set
            {
                if (value == " ")
                {
                    throw new NullReferenceException();
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
                    throw new NullReferenceException();
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
                if (value == " ")
                {
                    throw new NullReferenceException();
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
                if (value == " ")
                {
                    throw new NullReferenceException();
                }
                else
                {
                    shippingAddress = value;
                }
            }
        }
    }
}
