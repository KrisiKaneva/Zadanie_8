using System.Net;
using System.Xml.Linq;

namespace testingIvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineStore store = new OnlineStore();
            while (true)
            {
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
            Console.WriteLine("Въведете ID на продукта:");
            string id = Console.ReadLine();
            Console.WriteLine("Въведете име на продукта:");
            string name = Console.ReadLine();
            Console.WriteLine("Въведете категория на продукта:");
            string category = Console.ReadLine();
            Console.WriteLine("Въведете цена на продукта:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Въведете количество на продукта:");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете описание на продукта:");
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
            Console.WriteLine("Продуктът е добавен успешно.");
        }
        //2
        public static void RemoveProduct(OnlineStore store)
        {
            Console.WriteLine("Въведете ID на продукта за премахване:");
            string id = Console.ReadLine();
            store.RemoveProduct(id);
            Console.WriteLine("Продуктът е премахнат успешно.");
        }
        //3
        public static void SearchProductByName(OnlineStore store)
        {
            Console.WriteLine("Въведете име на продукта за търсене:");
            string name = Console.ReadLine();
            var products = store.SearchProductByName(name);
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductID}: {product.Name} - {product.Price:f2}лв - {product.Category}");
            }
        }
        //4
        public static void ListAllProducts(OnlineStore store)
        {
            var products = store.ListAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductID}: {product.Name} - {product.Price}лв - {product.Category}");
            }
        }
        //5
        public static void AddCustomer(OnlineStore store)
        {
            Console.WriteLine("Въведете ID на клиента:");
            string id = Console.ReadLine();
            Console.WriteLine("Въведете име на клиента:");
            string name = Console.ReadLine();
            Console.WriteLine("Въведете имейл на клиента:");
            string email = Console.ReadLine();
            Console.WriteLine("Въведете телефонен номер на клиента:");
            string phone = Console.ReadLine();
            Console.WriteLine("Въведете адрес за доставка на клиента:");
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
            Console.WriteLine("Клиентът е добавен успешно.");
        }
        //6
        public static void RemoveCustomer(OnlineStore store)
        {
            Console.WriteLine("Въведете ID на клиента за премахване:");
            string id = Console.ReadLine();
            store.RemoveCustomer(id);
            Console.WriteLine("Клиентът е премахнат успешно.");
        }
        //7
        public static void SearchCustomerByName(OnlineStore store)
        {
            Console.WriteLine("Въведете име на клиента за търсене:");
            string name = Console.ReadLine();
            var customers = store.SearchCustomerByName(name);
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.CustomerID}: {customer.FullName} - {customer.Email} - {customer.PhoneNumber}");
            }
        }
        //8
        public static void ListAllCustomers(OnlineStore store)
        {
            var customers = store.ListAllCustomers();
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.CustomerID}: {customer.FullName} - {customer.Email} - {customer.PhoneNumber}");
            }
        }
        //9
        public static void PlaceOrder(OnlineStore store)
        {
            Console.WriteLine("Въведете ID на поръчката:");
            string orderId = Console.ReadLine();
            Console.WriteLine("Въведете ID на клиента:");
            string customerId = Console.ReadLine();
            Console.WriteLine("Въведете дата на поръчката (YYYY-MM-DD):");
            DateTime orderDate = DateTime.Parse(Console.ReadLine());

            List<Product> orderItems = new List<Product>();
            while (true)
            {
                Console.WriteLine("Въведете ID на продукта за добавяне към поръчката (или 'край' за завършване):");
                string productId = Console.ReadLine();
                if (productId.ToLower() == "край") break;

                var product = store.Products.FirstOrDefault(p => p.ProductID == productId);
                if (product != null)
                {
                    orderItems.Add(product);
                }
                else
                {
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
            Console.WriteLine("Успешно направеня поръчка.");
        }
        //10
        public static void UpdateOrderStatus(OnlineStore store)
        {
            Console.WriteLine("Въведете ID на поръчката:");
            string orderId = Console.ReadLine();
            Console.WriteLine("Въведете нов статус на поръчката (чакаща, обработена, изпратена, завършена):");
            string status = Console.ReadLine();
            store.UpdateOrderStatus(orderId, status);
            Console.WriteLine("Статусът на поръчката е обновен успешно.");
        }
        //11
        public static void AddCategory(OnlineStore store)
        {
            Console.WriteLine("Въведете ID на категорията:");
            string id = Console.ReadLine();
            Console.WriteLine("Въведете име на категорията:");
            string name = Console.ReadLine();
            Console.WriteLine("Въведете описание на категорията:");
            string description = Console.ReadLine();

            Category category = new Category
            {
                CategoryID = id,
                Name = name,
                Description = description,
                Products = new List<Product>()
            };

            store.AddCategory(category);
            Console.WriteLine("Категорията е добавена успешно.");
        }
        //12
        public static void RemoveCategory(OnlineStore store)
        {
            Console.WriteLine("Въведете ID на категорията за премахване:");
            string id = Console.ReadLine();
            store.RemoveCategory(id);
            Console.WriteLine("Категорията е премахната успешно.");
        }
        //13 new
        public static void SearchCategoryByName(OnlineStore store)
        {
            Console.WriteLine("Въведете име на категорията за търсене:");
            string name = Console.ReadLine();
            var categories = store.SearchCategoryByName(name);
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryID}: {category.Name} - {category.Description}");
            }
        }
        //14
        public static void ListAllCategories(OnlineStore store)
        {
            var categories = store.ListAllCategories();
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryID}: {category.Name} - {category.Description}");
            }
        }
        //15
        public static void ProcessPayment(OnlineStore store)
        {
            Console.WriteLine("Въведете ID на плащането:");
            string paymentId = Console.ReadLine();
            Console.WriteLine("Въведете ID на поръчката:");
            string orderId = Console.ReadLine();
            Console.WriteLine("Въведете дата на плащането (YYYY-MM-DD):");
            DateTime paymentDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Въведете сума на плащането:");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Въведете метод на плащане (кредитна карта, PayPal, банков превод):");
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
            Console.WriteLine("Плащането е обработено успешно.");
        }
        //16 new
        public static void RenewStoreInformation(OnlineStore store)
        {
            Console.WriteLine("Въведете името на магазина:");
            store.Name = Console.ReadLine();
            Console.WriteLine("Въведете адреса на магазина:");
            store.Address = Console.ReadLine();
            Console.WriteLine("Въведете името на мениджъра:");
            store.Manager = Console.ReadLine();
            Console.WriteLine("Въведете вида на магазина:");
            store.StoreType = Console.ReadLine();

            Console.WriteLine("Информацията за магазина е обновена успешно.");
        }
        //17
        public static void GenerateSalesReport(OnlineStore store)
        {
            store.GenerateSalesReport();
        }
        //18
        public static void GenerateCustomerReport(OnlineStore store)
        {
            store.GenerateCustomerReport();
        }
        //19 new
        public static void GenerateStoreInformation(OnlineStore info)
        {
            Console.WriteLine($"Our store {info.Name} is located on {info.Address}. " +
                $"The manager's name is {info.Manager} and the type of the store is {info.StoreType}.");
        }
    }
}
