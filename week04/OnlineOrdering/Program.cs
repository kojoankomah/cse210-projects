using System;


class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop Stand", "P1001", 34.50m, 13);
        Product product2 = new Product("Mechanical Keyboard", "P1002", 79.99m, 10);
        Product product3 = new Product("Monitor", "P1003", 149.99m, 5);
        Product product4 = new Product("Gaming Chair", "P1004", 249.99m, 20);
        Product product5 = new Product("External Hard Drive", "P1005", 99.99m, 12);
        Product product6 = new Product("Adjustable Desk Lamp", "P1006", 27.99m, 8);
        Product product7 = new Product("USB Flash Drive (64GB)", "P1007", 19.99m, 10);
        Product product8 = new Product("Graphic Tablet", "P1008", 129.99m, 6);
        Product product9 = new Product("DSLR Camera", "P1009", 599.99m, 27);
        Product product10 = new Product("Tripod Stand", "P10010", 49.99m, 9);
        Product product11 = new Product("Smartwatch", "P10011", 199.99m, 13);
        Product product12 = new Product("Wireless Charging Pad", "P10012", 39.99m, 25);
        Product product13 = new Product("Fitness Tracker", "P10013", 129.99m, 20);
        Product product14 = new Product("Smart Thermostat", "P10014", 199.99m, 10);
        Product product15 = new Product("Home Security Camera", "P10015", 149.99m, 17);
        Product product16 = new Product("Streaming Webcam", "P10016", 79.99m, 30);
        Product product17 = new Product("Laptop Cooling Pad", "P10017", 35.99m, 29);
        Product product18 = new Product("Noise-Isolating Earphones", "P10018", 49.99m, 5);
        Product product19 = new Product("External SSD (1TB)", "P10019", 129.99m, 23);
        Product product20 = new Product("Mechanical Pencil Set", "P10020", 9.99m, 6);
        Product product21 = new Product("Office Chair Cushion", "P10021", 29.99m, 12);


        Address address1 = new Address ("123 Maple Street", "Los Angeles", "CA", "USA");
        Address address2 = new Address("369 Willow Way", "Atlanta", "GA", "USA");
        Address address3 = new Address("67 George Street", "Sydney", "New South Wales", "Australia");
        Address address4 = new Address("34 Rue de Rivoli", "Paris", "Île-de-France", "France");
        Address address5 = new Address("456 Oak Avenue", "Chicago", "IL", "USA");
        Address address6 = new Address("102 Yonge Street", "Vancouver", "British Columbia", "Canada");
        Address address7 = new Address("159 Chestnut Place", "Dallas", "TX", "USA");
        Address address8 = new Address("12 Baker Street", "London", "England", "UK");
        Address address9 = new Address("987 Walnut Blvd", "Seattle", "WA", "USA");
        Address address10 = new Address("23 Queen Street", "Toronto", "Ontario", "Canada");
        Address address11 = new Address("478 Elm Road", "Nashville", "TN", "USA");


        // Create customers
        Customer customer1 = new Customer("Samuel Pyne", address1);
        Customer customer2 = new Customer("Nathan Jones", address2);
        Customer customer3 = new Customer("Michael Angelo", address3);
        Customer customer4 = new Customer("Sean Jacobson", address4);
        Customer customer5 = new Customer("Ashley Green", address6);
        Customer customer6 = new Customer("Nathan Jones", address7);
        Customer customer7 = new Customer("Michael Angelo", address10);
        Customer customer8 = new Customer("Sean Jacobson", address9);
        Customer customer9 = new Customer("Ashley Green", address11);

        Order order1 = new Order(customer1);
        order1.AddProduct(product2);
        order1.AddProduct(product4);
        order1.AddProduct(product6);
        order1.AddProduct(product8);
        order1.AddProduct(product10);
        order1.AddProduct(product12);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product9);
        order2.AddProduct(product6);
        order2.AddProduct(product12);
        order2.AddProduct(product15); 
        order2.AddProduct(product18);
        order2.AddProduct(product21);

        Order order3 = new Order(customer3);
        order3.AddProduct(product4);
        order3.AddProduct(product8);
        order3.AddProduct(product12);
        order3.AddProduct(product16);
        order3.AddProduct(product20);
        order3.AddProduct(product1);

        Order order4 = new Order(customer4);
        order4.AddProduct(product5);
        order4.AddProduct(product3);
        order4.AddProduct(product9);
        order4.AddProduct(product11);

        Order order5 = new Order(customer5);
        order5.AddProduct(product10);
        order5.AddProduct(product20);
        order5.AddProduct(product17);

        Order order6 = new Order(customer6);
        order6.AddProduct(product15);
        order6.AddProduct(product3);
        order6.AddProduct(product19);
        order6.AddProduct(product1);
        order6.AddProduct(product4);
        order6.AddProduct(product8);

        Order order7 = new Order(customer7);
        order7.AddProduct(product10);
        order7.AddProduct(product2);
        order7.AddProduct(product7);
        order7.AddProduct(product5);
        order7.AddProduct(product3);
        order7.AddProduct(product15);
        order7.AddProduct(product17);

        Order order8 = new Order(customer8);
        order8.AddProduct(product10);
        order8.AddProduct(product8);
        order8.AddProduct(product3);
        order8.AddProduct(product19);
        order8.AddProduct(product6);

        Order order9 = new Order(customer9);
        order9.AddProduct(product10);
        order9.AddProduct(product5);
        order9.AddProduct(product2);
        order9.AddProduct(product11);
        order9.AddProduct(product17); 
        order9.AddProduct(product9);
        order9.AddProduct(product3);
        order9.AddProduct(product14);

        // store orders in a list

        List<Order> orders = new List<Order>{order1,order2,order3,order4,order5,order6,order7,order8,order9};

        // display details of each order

        int orderNumb = 1;
        
        foreach(Order order in orders)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine($"Detail for {orderNumb} Orders:  \n");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost : ${order.CalculateTotalCost():F2}\n");
            orderNumb++;
            Console.WriteLine("**************************************************");

        }
    }

}