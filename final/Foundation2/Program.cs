using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address allisonAddress = new Address("5643 Evergreen Avenue", "Springfield", "IL", "United States", true);
        Customer allisonWright = new Customer("Allison Wright", allisonAddress);
        Product keyboard = new Product("Wireless Keyboard", 234298, 49.99, 1);
        Product cable = new Product("USB-C Cable", 473448, 9.99, 3);
        Product stand = new Product("Laptop Stand", 357463, 32.50, 1);
        List<Product> allisonItems = new List<Product>() { keyboard, cable, stand };
        Order allisonOrder = new Order(allisonWright.GetCustomerName());
        allisonOrder.SetProducts(allisonItems);
        allisonOrder.SetPackingLabel(allisonItems);
        allisonOrder.SetShippingLabel(allisonWright, allisonAddress);
        allisonOrder.CalcTotalPrice(allisonAddress);
        orders.Add(allisonOrder);

        Address lucasAddress = new Address("Calle Salvador Rueda 741", "Seville", "", "Spain", false);
        Customer lucasMartin = new Customer("Lucas Martín", lucasAddress);
        Product speaker = new Product("Bluetooth Speaker", 346869, 29.99, 2);
        Product notebook = new Product("Notebook Set", 894673, 14.25, 1);
        Product lamp = new Product("LED Desk Lamp", 946825, 22.80, 1);
        List<Product> lucasItems = new List<Product>() { speaker, notebook, lamp };
        Order lucasOrder = new Order(lucasMartin.GetCustomerName());
        lucasOrder.SetProducts(lucasItems);
        lucasOrder.SetPackingLabel(lucasItems);
        lucasOrder.SetShippingLabel(lucasMartin, lucasAddress);
        lucasOrder.CalcTotalPrice(lucasAddress);
        orders.Add(lucasOrder);

        Address sakuraAddress = new Address("3-14-22 Shinjuku", "Tokyo", "", "Japan", false);
        Customer sakuraTanaka = new Customer("Lucas Martín", sakuraAddress);
        Product pencil = new Product("Mechanical Pencil", 764286, 5.40, 4);
        Product charger = new Product("Portable Charger", 312645, 38.90, 1);
        Product headphones = new Product("Noise-Canceling Headphones", 437654, 129.99, 1);
        List<Product> sakuraItems = new List<Product>() { pencil, charger, headphones };
        Order sakuraOrder = new Order(sakuraTanaka.GetCustomerName());
        sakuraOrder.SetProducts(sakuraItems);
        sakuraOrder.SetPackingLabel(sakuraItems);
        sakuraOrder.SetShippingLabel(sakuraTanaka, sakuraAddress);
        sakuraOrder.CalcTotalPrice(sakuraAddress);
        orders.Add(sakuraOrder);

        int orderCount = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Order #{orderCount}");
            order.DisplayOrder(order);
            orderCount++;
        }
    }
}