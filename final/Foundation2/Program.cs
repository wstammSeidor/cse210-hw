using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Make sure that all member variables are private and getters, setters, and constructors are created as needed.

Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.
        */

        Address address1 = new Address("123 Main St", "Provo", "UT", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Product product1 = new Product("TV", "12345", 1.99, 10);
        Product product2 = new Product("Ipad", "67890", 2.99, 5);
        Product product3 = new Product("Samsung S23", "13579", 3.99, 15);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);



        Address address2 = new Address("Jose Marmol 423", "Tigre", "Buenos Aires", "Argentina");
        Customer customer2 = new Customer("Walter Stamm", address2);
        Product product4 = new Product("Guitar", "12345", 66.99, 10);
        Product product5 = new Product("Violin", "67890", 78.99, 5);
        Product product6 = new Product("Piano", "13579", 46.99, 15);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);




        Console.WriteLine(order1.getShippingLabel());
        Console.WriteLine("Shipping cost: "+ order1.getCostShipping());
        Console.WriteLine("Total cost: "+ order1.calculateTotalCost());

        Console.WriteLine("\n\n");        
        Console.WriteLine(order2.getShippingLabel());
        Console.WriteLine("Shipping cost: "+ order2.getCostShipping());
        Console.WriteLine("Total cost: "+ order2.calculateTotalCost());



        
    }
}