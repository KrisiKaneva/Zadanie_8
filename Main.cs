using System.Net;
using System.Xml.Linq;
using Zadanie_novo;

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
                Console.WriteLine("Главно меню:");
                Console.WriteLine("1. Добавяне на продукт");
                Console.WriteLine("2. Премахване на продукт");
                Console.WriteLine("3. Търсене на продукт по име");
                Console.WriteLine("4. Списък с всички продукти");
                Console.WriteLine("5. Добавяне на клиент");
                Console.WriteLine("6. Премахване на клиент");
                Console.WriteLine("7. Търсене на клиент по име");
                Console.WriteLine("8. Списък с всички клиенти");
                Console.WriteLine("9. Поставяне на поръчка");
                Console.WriteLine("10. Обновяване на статус на поръчка");
                Console.WriteLine("11. Добавяне на категория");
                Console.WriteLine("12. Премахване на категория");
                Console.WriteLine("13. Търсене на категория по име");
                Console.WriteLine("14. Списък с всички категории");
                Console.WriteLine("15. Обработка на плащане");
                Console.WriteLine("16. Обновяване на данните за магазина");
                Console.WriteLine("17. Генериране на отчет за продажбите");
                Console.WriteLine("18. Генериране на отчет за клиентите");
                Console.WriteLine("19. Генериране на информация за магазина");
                Console.WriteLine("20. Изход");

                Console.Write("Изберете команда: ");
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
            Console.WriteLine("Въведете ID на продукта:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете име на продукта:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете категория на продукта:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string category = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете цена на продукта:");
            Console.ForegroundColor = ConsoleColor.Blue;
            decimal price = decimal.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете количество на продукта:");
            Console.ForegroundColor = ConsoleColor.Blue;
            int quantity = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете описание на продукта:");
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
            Console.WriteLine("Продуктът е добавен успешно.");
            Console.ResetColor();
        }
        //2
        public static void RemoveProduct(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете ID на продукта за премахване:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine();
            store.RemoveProduct(id);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Продуктът е премахнат успешно.");
            Console.ResetColor();
        }
        //3
        public static void SearchProductByName(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете име на продукта за търсене:");
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
            Console.WriteLine("Въведете ID на клиента:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете име на клиента:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете имейл на клиента:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string email = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете телефонен номер на клиента:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string phone = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете адрес за доставка на клиента:");
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
            Console.WriteLine("Клиентът е добавен успешно.");
            Console.ResetColor();
        }
        //6
        public static void RemoveCustomer(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете ID на клиента за премахване:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine();
            store.RemoveCustomer(id);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Клиентът е премахнат успешно.");
            Console.ResetColor();
        }
        //7
        public static void SearchCustomerByName(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете име на клиента за търсене:");
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
            Console.WriteLine("Въведете ID на поръчката:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string orderId = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете ID на клиента:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string customerId = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете дата на поръчката (YYYY-MM-DD):");
            Console.ForegroundColor = ConsoleColor.Blue;
            DateTime orderDate = DateTime.Parse(Console.ReadLine());

            List<Product> orderItems = new List<Product>();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Въведете ID на продукта за добавяне към поръчката (или 'край' за завършване):");
                Console.ForegroundColor = ConsoleColor.Blue;
                string productId = Console.ReadLine();
                if (productId.ToLower() == "край") break;

                var product = store.Products.FirstOrDefault(p => p.ProductID == productId);
                if (product != null)
                {
                    orderItems.Add(product);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Продуктът не е намерен.");
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
                Status = "чакаща"
            };

            store.PlaceOrder(order);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Успешно направеня поръчка.");
            Console.ResetColor();
        }
        //10
        public static void UpdateOrderStatus(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете ID на поръчката:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string orderId = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете нов статус на поръчката (чакаща, обработена, изпратена, завършена):");
            string status = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            store.UpdateOrderStatus(orderId, status);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Статусът на поръчката е обновен успешно.");
        }
        //11
        public static void AddCategory(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете ID на категорията:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете име на категорията:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете описание на категорията:");
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
            Console.WriteLine("Категорията е добавена успешно.");
        }
        //12
        public static void RemoveCategory(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете ID на категорията за премахване:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string id = Console.ReadLine();
            store.RemoveCategory(id);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Категорията е премахната успешно.");
        }
        //13 new
        public static void SearchCategoryByName(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете име на категорията за търсене:");
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
            Console.WriteLine("Въведете ID на плащането:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string paymentId = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете ID на поръчката:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string orderId = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете дата на плащането (YYYY-MM-DD):");
            Console.ForegroundColor = ConsoleColor.Blue;
            DateTime paymentDate = DateTime.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете сума на плащането:");
            Console.ForegroundColor = ConsoleColor.Blue;
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете метод на плащане (кредитна карта, PayPal, банков превод):");
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
            Console.WriteLine("Плащането е обработено успешно.");
            Console.ResetColor();
        }
        //16 new
        public static void RenewStoreInformation(OnlineStore store)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете името на магазина:");
            Console.ForegroundColor = ConsoleColor.Blue;
            store.Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете адреса на магазина:");
            Console.ForegroundColor = ConsoleColor.Blue;
            store.Address = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете името на мениджъра:");
            Console.ForegroundColor = ConsoleColor.Blue;
            store.Manager = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Въведете вида на магазина:");
            Console.ForegroundColor = ConsoleColor.Blue;
            store.StoreType = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Информацията за магазина е обновена успешно.");
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
