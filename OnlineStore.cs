using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingIvo
{
    internal class OnlineStore
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Manager { get; set; }
        public string StoreType { get; set; }

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
                else
                {
                    Console.WriteLine("The searched product was not found.");
                }
            }
            return result;
        }

        public List<Product> ListAllProducts() // changed
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
                else
                {
                    Console.WriteLine("The searched customer was not found.");
                }
            }
            return result;
        }

        public List<Customer> ListAllCustomers() // changed
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
        public List<Category> SearchCategoryByName(string name)
        {
            List<Category> result = new List<Category>();
            foreach (var category in Categories)
            {
                if (category.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    result.Add(category);
                }
                else
                {
                    Console.WriteLine("The searched category was not found.");
                }
            }
            return result;
        }

        public List<Category> ListAllCategories() // changed
        {
            return new List<Category>(Categories);
        }

        public void ProcessPayment(Payment payment)
        {
            Payments.Add(payment);
        }

        public void GenerateSalesReport() // changed
        {
            Console.WriteLine($"A total of {Products.Count} products have been sold.");
            Console.WriteLine($"Products from {Categories.Count} categories have been sold - {ListAllCategories()}.");
            Console.WriteLine($"There is a total of {Orders.Count} orders and a total of {Payments.Count} payments.");
            Console.WriteLine("Sales Report Generated");
        }

        public void GenerateCustomerReport() // changed
        {
            Console.WriteLine($"There have been {Customers.Count} customers so far - {ListAllCustomers()}");
            Console.WriteLine("Customers Report Generated");
        }
    }
}
