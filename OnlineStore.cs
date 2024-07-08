using System;
using System.Collections.Generic;

namespace Zadanie_8
{
	public class OnlineStore
	{
        public string Name { get; set; }
        public string Address { get; set; }
        public string Manager { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Payment> Payments { get; set; } = new List<Payment>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(string productID)
        {
            Product productToRemove = null;
            foreach (var product in Products)
            {
                if (product.ProductID == productID)
                {
                    productToRemove = product;
                    break;
                }
            }
            if (productToRemove != null)
            {
                Products.Remove(productToRemove);
            }
        }

        public List<Product> SearchProductByName(string name)
        {
            List<Product> result = new List<Product>();
            foreach (var product in Products)
            {
                if (product.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    result.Add(product);
                }
            }
            return result;
        }

        public List<Product> ListAllProducts()
        {
            return new List<Product>(Products);
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void RemoveCustomer(string customerID)
        {
            Customer customerToRemove = null;
            foreach (var customer in Customers)
            {
                if (customer.CustomerID == customerID)
                {
                    customerToRemove = customer;
                    break;
                }
            }
            if (customerToRemove != null)
            {
                Customers.Remove(customerToRemove);
            }
        }

        public List<Customer> SearchCustomerByName(string name)
        {
            List<Customer> result = new List<Customer>();
            foreach (var customer in Customers)
            {
                if (customer.FullName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    result.Add(customer);
                }
            }
            return result;
        }

        public List<Customer> ListAllCustomers()
        {
            return new List<Customer>(Customers);
        }

        public void PlaceOrder(Order order)
        {
            Orders.Add(order);
        }

        public void UpdateOrderStatus(string orderID, string status)
        {
            foreach (var order in Orders)
            {
                if (order.OrderID == orderID)
                {
                    order.Status = status;
                    break;
                }
            }
        }

        public void AddCategory(Category category)
        {
            Categories.Add(category);
        }

        public void RemoveCategory(string categoryID)
        {
            Category categoryToRemove = null;
            foreach (var category in Categories)
            {
                if (category.CategoryID == categoryID)
                {
                    categoryToRemove = category;
                    break;
                }
            }
            if (categoryToRemove != null)
            {
                Categories.Remove(categoryToRemove);
            }
        }

        public List<Category> ListAllCategories()
        {
            return new List<Category>(Categories);
        }

        public void ProcessPayment(Payment payment)
        {
            Payments.Add(payment);
        }

        public string GenerateSalesReport()
        {
            return "Sales Report Generated";
        }

        public string GenerateCustomerReport()
        {
            return "Customer Report Generated";
        }
    }
}
