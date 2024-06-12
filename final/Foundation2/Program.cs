using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressOne = new Address("Suite 576 Florencio River", "Port Antonina", "FL", "USA", 41475);
        Customer customerOne = new Customer("Bill Clarence", addressOne);
        List<Product> productsOne = new List<Product>
        {
            new Product("Wingdinger", 0, 10.99, 5),
            new Product("Scramdoodle", 1, 20.35, 3),
            new Product("Whatshehoozit", 2, 199.89, 1)
        };

        Order orderOne = new Order(customerOne, productsOne);

        orderOne.GetPackingLabel();
        orderOne.GetShippingLabel();
        double totalCostOne = orderOne.GetTotalCost();
        Console.WriteLine($"Total Cost: ${totalCostOne}");

        Address addressTwo = new Address("Apt. 125 9420 Giuseppe Burg", "West Ashlyn", "MN", "Canada", 70833-9024);
        Customer customerTwo = new Customer("Car Car Man Man", addressTwo);
        List<Product> productsTwo = new List<Product>
        {
            new Product("Danferter", 3, 50, 3),
            new Product("Plentiful Packets", 4, 4.50, 10),
            new Product("Pluto, the planet", 5, 599.99, 1)
        };

        Order orderTwo = new Order(customerTwo, productsTwo);

        orderTwo.GetPackingLabel();
        orderTwo.GetShippingLabel();
        double totalCostTwo = orderTwo.GetTotalCost();
        Console.WriteLine($"Total Cost: ${totalCostTwo}");
    }
}