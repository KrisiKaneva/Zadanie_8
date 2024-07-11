using System.Net;
using System.Xml.Linq;

namespace Zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineStore store = new OnlineStore();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Home menu:");
                Console.WriteLine("1. Enter the product");
                Console.WriteLine("2. Remove product");
                Console.WriteLine("3. Search product by name");
                Console.WriteLine("4. List of products");
                Console.WriteLine("5. Add customer");
                Console.WriteLine("6. Remove customer");
                Console.WriteLine("7. Search customer by name");
                Console.WriteLine("8. List of customers");
                Console.WriteLine("9. Place order");
                Console.WriteLine("10. Restore order status");
                Console.WriteLine("11. Add category");
                Console.WriteLine("12. Remove category");
                Console.WriteLine("13. Search category by name");
                Console.WriteLine("14. List of categories");
                Console.WriteLine("15. Payment processing");
                Console.WriteLine("16. Edit store details");
                Console.WriteLine("17. Generate sails report");
                Console.WriteLine("18. Generate customer report");
                Console.WriteLine("19. Generate store information");
                Console.WriteLine("20. Exit");

                Console.Write("Choose a command: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddProduct(store);
                        break;
                    case "2":
                        RemoveProduct(store);
                        break;
                    case "3":
                        SearchProductByName(store);
                        break;
                    case "4":
                        ListAllProducts(store);
                        break;
                    case "5":
                        AddCustomer(store);
                        break;
                    case "6":
                        RemoveCustomer(store);
                        break;
                    case "7":
                        SearchCustomerByName(store);
                        break;
                    case "8":
                        ListAllCustomers(store);
                        break;
                    case "9":
                        PlaceOrder(store);
                        break;
                    case "10":
                        UpdateOrderStatus(store);
                        break;
                    case "11":
                        AddCategory(store);
                        break;
                    case "12":
                        RemoveCategory(store);
                        break;
                    case "13":
                        SearchCategoryByName(store);
                        break;
                    case "14":
                        ListAllCategories(store);
                        break;
                    case "15":
                        ProcessPayment(store);
                        break;
                    case "16":
                        RenewStoreInformation(store);
                        break;
                    case "17":
                        GenerateSalesReport(store);
                        break;
                    case "18":
                        GenerateCustomerReport(store);
                        break;
                    case "19":
                        GenerateStoreInformation(store);
                        break;
                    case "20":
                        return;
                }
                Console.WriteLine();
            }
        }
        //1
        public static void AddProduct(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter product ID:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter product name:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter product category:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string category = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter product price:");
            Console.ForegroundColor = ConsoleColor.Blue;
            decimal price = decimal.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter product quantity:");
            Console.ForegroundColor = ConsoleColor.Blue;
            int quantity = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter product description:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string description = Console.ReadLine();

            Product product = new Product
            {
                ProductID = id,
                Name = name,
                Category = category,
                Price = price,
                StockQuantity = quantity,
                Description = description,
                IsAvailable = quantity > 0
            };

            store.AddProduct(product);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("The product has been successfully added.");
            Console.ResetColor();
        }
        //2
        public static void RemoveProduct(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter product ID to remove:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine();
            store.RemoveProduct(id);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("The product has been successfully removed.");
            Console.ResetColor();
        }
        //3
        public static void SearchProductByName(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter name to search product:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            var products = store.SearchProductByName(name);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductID}: {product.Name} - {product.Price:f2}лв - {product.Category}");
            }
            Console.ResetColor();
        }
        //4
        public static void ListAllProducts(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            var products = store.ListAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductID}: {product.Name} - {product.Price}лв - {product.Category}");
            }
            Console.ResetColor();
        }
        //5
        public static void AddCustomer(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter customer ID:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter customer name:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter customer e-mail:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string email = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter customer phone number:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string phone = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter the customer's delivery address:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string address = Console.ReadLine();

            Customer customer = new Customer
            {
                CustomerID = id,
                FullName = name,
                Email = email,
                PhoneNumber = phone,
                ShippingAddress = address
            };

            store.AddCustomer(customer);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("The customer has been successfully added.");
            Console.ResetColor();
        }
        //6
        public static void RemoveCustomer(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter customer ID to remove:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine();
            store.RemoveCustomer(id);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("The customer has been successfully removed.");
            Console.ResetColor();
        }
        //7
        public static void SearchCustomerByName(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter name to search customer:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            var customers = store.SearchCustomerByName(name);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.CustomerID}: {customer.FullName} - {customer.Email} - {customer.PhoneNumber}");
            }
            Console.ResetColor();
        }
        //8
        public static void ListAllCustomers(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            var customers = store.ListAllCustomers();
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.CustomerID}: {customer.FullName} - {customer.Email} - {customer.PhoneNumber}");
            }
            Console.ResetColor();
        }
        //9
        public static void PlaceOrder(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter order ID:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string orderId = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter customer ID:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string customerId = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter date of order (YYYY-MM-DD):");
            Console.ForegroundColor = ConsoleColor.Blue;
            DateTime orderDate = DateTime.Parse(Console.ReadLine());

            List<Product> orderItems = new List<Product>();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Enter product ID to add to the order (or 'end' to finalize order):");
                Console.ForegroundColor = ConsoleColor.Blue;
                string productId = Console.ReadLine();
                if (productId.ToLower() == "end") break;

                var product = store.Products.FirstOrDefault(p => p.ProductID == productId);
                if (product != null)
                {
                    orderItems.Add(product);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Product not found.");
                }
            }

            decimal totalAmount = orderItems.Sum(p => p.Price);

            Order order = new Order
            {
                OrderID = orderId,
                CustomerID = customerId,
                OrderDate = orderDate,
                OrderItems = orderItems,
                TotalAmount = totalAmount,
                Status = "in waiting"
            };

            store.PlaceOrder(order);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("The order has been successfully made.");
            Console.ResetColor();
        }
        //10
        public static void UpdateOrderStatus(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter order ID:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string orderId = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter new order status (in waiting, processed, sent, delivered):");
            string status = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            store.UpdateOrderStatus(orderId, status);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Order status has been updated.");
        }
        //11
        public static void AddCategory(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter category ID:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter category name:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter category description:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string description = Console.ReadLine();

            Category category = new Category
            {
                CategoryID = id,
                Name = name,
                Description = description,
                Products = new List<Product>()
            };

            store.AddCategory(category);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Category has been successfully added.");
        }
        //12
        public static void RemoveCategory(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter ID of the category to remove:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine();
            store.RemoveCategory(id);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Category has been successfully removed.");
        }
        //13 new
        public static void SearchCategoryByName(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter name to search category:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            var categories = store.SearchCategoryByName(name);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryID}: {category.Name} - {category.Description}");
            }
            Console.ResetColor();
        }
        //14
        public static void ListAllCategories(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            var categories = store.ListAllCategories();
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryID}: {category.Name} - {category.Description}");
            }
            Console.ResetColor();
        }
        //15
        public static void ProcessPayment(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter payment ID:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string paymentId = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter order ID:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string orderId = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter date of payment (YYYY-MM-DD):");
            Console.ForegroundColor = ConsoleColor.Blue;
            DateTime paymentDate = DateTime.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter payment sum:");
            Console.ForegroundColor = ConsoleColor.Blue;
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter payment method (Credit card, Debit card, PayPal, Bank transfer):");
            Console.ForegroundColor = ConsoleColor.Blue;
            string paymentMethod = Console.ReadLine();

            Payment payment = new Payment
            {
                PaymentID = paymentId,
                OrderID = orderId,
                PaymentDate = paymentDate,
                Amount = amount,
                PaymentMethod = paymentMethod
            };

            store.ProcessPayment(payment);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Payment has been successfully processed.");
            Console.ResetColor();
        }
        //16 new
        public static void RenewStoreInformation(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter store name:");
            Console.ForegroundColor = ConsoleColor.Blue;
            store.Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter store address:");
            Console.ForegroundColor = ConsoleColor.Blue;
            store.Address = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter name of the manager:");
            Console.ForegroundColor = ConsoleColor.Blue;
            store.Manager = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter store type:");
            Console.ForegroundColor = ConsoleColor.Blue;
            store.StoreType = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Store information has been successfully added.");
            Console.ResetColor();
        }
        //17
        public static void GenerateSalesReport(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            store.GenerateSalesReport();
            Console.ResetColor();
        }
        //18
        public static void GenerateCustomerReport(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            store.GenerateCustomerReport();
            Console.ResetColor();
        }
        //19 new
        public static void GenerateStoreInformation(OnlineStore info)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Our store {info.Name} is located on {info.Address}. " +
                $"The manager's name is {info.Manager} and the type of the store is {info.StoreType}.");
            Console.ResetColor();
        }
    }
}
