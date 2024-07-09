using System.Runtime.InteropServices;
using System.Collections.Generic;
namespace Zadanie_8;

class Program
{
    static void Main(string[] args)
    {
        OnlineStore store = new OnlineStore();
        while(true)
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
            Console.WriteLine("13. Списък с всички категории");
            Console.WriteLine("14. Обработка на плащане");
            Console.WriteLine("15. Генериране на отчет за продажбите");
            Console.WriteLine("16. Генериране на отчет за клиентите");
            Console.WriteLine("17. Изход");

            string choice = Console.ReadLine();

            switch(choice)
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
                    ListAllCategories(store);
                    break;
                case "14":
                    ProcessPayment(store);
                    break;
                case "15":
                    GenerateSalesReport(store);
                    break;
                case "16":
                    GenerateCustomerReport(store);
                    break;
                case "17":
                    return;

            }
        }
    }
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
    public static void RemoveProduct(OnlineStore store)
    {
        Console.WriteLine("Въведете ID на продукта за премахване:");
        string id = Console.ReadLine();
        store.RemoveProduct(id);
        Console.WriteLine("Продуктът е премахнат успешно.");
    }
    public static void SearchProductByName(OnlineStore store)
    {
        Console.WriteLine("Въведете име на продукта за търсене:");
        string name = Console.ReadLine();
        var products = store.SearchProductByName(name);
        foreach (var product in products)
        {
            Console.WriteLine($"{product.ProductID}: {product.Name} - {product.Price}лв - {product.Category}");
        }
    }
    public static void ListAllProducts(OnlineStore store)
    {
        store.ListAllProducts();
    }
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
    public static void RemoveCustomer(OnlineStore store)
    {
        Console.WriteLine("Въведете ID на клиента за премахване:");
        string id = Console.ReadLine();
        store.RemoveCustomer(id);
        Console.WriteLine("Клиентът е премахнат успешно.");
    }
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
    public static void ListAllCustomers(OnlineStore store)
    {
        store.ListAllCustomers();
    }
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
    public static void UpdateOrderStatus(OnlineStore store)
    {
        Console.WriteLine("Въведете ID на поръчката:");
        string orderId = Console.ReadLine();
        Console.WriteLine("Въведете нов статус на поръчката (чакаща, обработена, изпратена, завършена):");
        string status = Console.ReadLine();
        store.UpdateOrderStatus(orderId, status);
        Console.WriteLine("Статусът на поръчката е обновен успешно.");
    }
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
    public static void RemoveCategory(OnlineStore store)
    {
        Console.WriteLine("Въведете ID на категорията за премахване:");
        string id = Console.ReadLine();
        store.RemoveCategory(id);
        Console.WriteLine("Категорията е премахната успешно.");
    }
    public static void ListAllCategories(OnlineStore store)
    {
        store.ListAllCategories();
    }
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
    public static void GenerateSalesReport(OnlineStore store)
    {
        
    }
    public static void GenerateCustomerReport(OnlineStore store)
    {
        
    }
}
