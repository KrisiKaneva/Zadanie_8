using System;
namespace Zadanie_8
{
	public class Payment
	{
		private string paymentID;
        public string PaymentID
        {
            get { return paymentID; }
            set
            {
                if (value == " ")
                {
                    throw new NullReferenceException();
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
        private DateTime paymentDate;
        public string PaymentDate
        {
            get { return paymentDate; }
            set
            {
                if (value == " ")
                {
                    throw new NullReferenceException();
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
                    throw new NullReferenceException();
                }
                else
                {
                    paymentMethod = value;
                }
            }
        }

        public Payment()
		{
		}
	}
}

