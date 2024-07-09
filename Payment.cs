using System;
using System.Collections.Generic;
namespace Zadanie_novo
{
	public class Payment
	{
        private string paymentID;
        public string PaymentID
        {
            get { return paymentID; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be null or empty!");
                }
                else
                {
                    paymentID = value;
                }
            }
        }
        private string orderID;
        public string OrderID
        {
            get { return orderID; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be null or empty!");
                }
                else
                {
                    orderID = value;
                }
            }
        }
        private DateTime paymentDate;
        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set
            {
                if (value == default(DateTime))
                {
                    throw new ArgumentException("Payment date cannot be the default date.", nameof(value));
                }
                else
                {
                    paymentDate = value;
                }

            }
        }
        private string paymentMethod;
        public string PaymentMethod
        {
            get { return paymentMethod; }
            set
            {
                if (value != "Credit card" || value != "Debit card" || value != "PayPal" || value != "Bank transfer")
                {
                    throw new ArgumentException("Invalid payment method. Valid options are: Credit card, Debit card, PayPal, Bank transfer.", nameof(value));
                }
                else
                {
                    paymentMethod = value;
                }
            }
        }
    }
}

