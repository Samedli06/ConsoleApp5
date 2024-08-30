using System;
using System.Collections;

ArrayList computers = new ArrayList
{
    new ArrayList { "1", "Acer", "Nitro5", "1000", "12" },
    new ArrayList { "2", "Asus", "Zephyrus", "1700", "8" },
    new ArrayList { "3", "Macbook", "pro14", "2000", "20" },
    new ArrayList { "4", "Lenovo", "Legion5", "1200", "5" }
};

ArrayList phones = new ArrayList
{
    new ArrayList { "1", "Iphone", "pro15", "1000", "30" },
    new ArrayList { "2", "Samsung", "S23", "800", "15" },
    new ArrayList { "3", "Xiomi", "note8", "400", "50" },
    new ArrayList { "4", "Oppo", "x8", "600", "20" }
};

double balance = 10000;

Menu:
Console.Clear();
Console.WriteLine("1. Show all products\n2. Show computers\n3. Show phones\n4. Add product\n5. Total company price\n6. Sell product\n7. Quit");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.Clear();
        foreach (ArrayList computer in computers)
        {
            Console.WriteLine($"ID: {computer[0]}");
            Console.WriteLine($"Brand: {computer[1]}");
            Console.WriteLine($"Model: {computer[2]}");
            Console.WriteLine($"Price: {computer[3]}");
            Console.WriteLine($"Quantity: {computer[4]}");
            Console.WriteLine("===============");
            Console.WriteLine();
        }
        foreach (ArrayList phone in phones)
        {
            Console.WriteLine($"ID: {phone[0]}");
            Console.WriteLine($"Brand: {phone[1]}");
            Console.WriteLine($"Model: {phone[2]}");
            Console.WriteLine($"Price: {phone[3]}");
            Console.WriteLine($"Quantity: {phone[4]}");
            Console.WriteLine("===============");
            Console.WriteLine();
        }
        Console.ReadKey();
        goto Menu;

    case "2":
        Console.Clear();
        foreach (ArrayList computer in computers)
        {
            Console.WriteLine($"ID: {computer[0]}");
            Console.WriteLine($"Brand: {computer[1]}");
            Console.WriteLine($"Model: {computer[2]}");
            Console.WriteLine($"Price: {computer[3]}");
            Console.WriteLine($"Quantity: {computer[4]}");
            Console.WriteLine("===============");
            Console.WriteLine();
        }
        Console.ReadKey();
        goto Menu;

    case "3":
        Console.Clear();
        foreach (ArrayList phone in phones)
        {
            Console.WriteLine($"ID: {phone[0]}");
            Console.WriteLine($"Brand: {phone[1]}");
            Console.WriteLine($"Model: {phone[2]}");
            Console.WriteLine($"Price: {phone[3]}");
            Console.WriteLine($"Quantity: {phone[4]}");
            Console.WriteLine("===============");
            Console.WriteLine();
        }
        Console.ReadKey();
        goto Menu;

    case "4":
        Console.Clear();
        Console.WriteLine("Enter what product do you want to add:\n1. Computer\n2. Phone");
        string productChoice = Console.ReadLine();
        if (productChoice == "1")
        {
            Console.Clear();
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter Model: ");
            string model = Console.ReadLine();

            Console.Write("Enter Price: ");
            string price = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            string quantity = Console.ReadLine();

            computers.Add(new ArrayList { id, brand, model, price, quantity });

            Console.WriteLine("Product added successfully!");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }
        else if (productChoice == "2")
        {
            Console.Clear();
            Console.Write("Enter ID: ");
            string pid = Console.ReadLine();

            Console.Write("Enter Brand: ");
            string pbrand = Console.ReadLine();

            Console.Write("Enter Model: ");
            string pmodel = Console.ReadLine();

            Console.Write("Enter Price: ");
            string pprice = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            string pquantity = Console.ReadLine();

            phones.Add(new ArrayList { pid, pbrand, pmodel, pprice, pquantity });

            Console.WriteLine("Product added successfully!");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }
        goto Menu;

    case "5":
        Console.Clear();
        double totalCompanyPrice = 0;
        foreach (ArrayList computer in computers)
        {
            totalCompanyPrice += Convert.ToDouble(computer[3]) * Convert.ToInt32(computer[4]);
        }
        foreach (ArrayList phone in phones)
        {
            totalCompanyPrice += Convert.ToDouble(phone[3]) * Convert.ToInt32(phone[4]);
        }
        Console.WriteLine($"Total company price: {totalCompanyPrice}");
        Console.ReadKey();
        goto Menu;

    case "6":
        Console.Clear();
        Console.WriteLine("Select category:");
        Console.WriteLine("1. Computers");
        Console.WriteLine("2. Phones");
        string categoryChoice = Console.ReadLine();

        ArrayList selectedCategory = null;

        if (categoryChoice == "1")
        {
            selectedCategory = computers;
        }
        else if (categoryChoice == "2")
        {
            selectedCategory = phones;
        }
        else
        {
            Console.WriteLine("Invalid category selected.");
            Console.ReadKey();
            goto Menu;
        }

        Console.Write("Enter the model name you want to sell: ");
        string sellModel = Console.ReadLine();

        int productIndex = -1;

        for (int i = 0; i < selectedCategory.Count; i++)
        {
            string[] product = (string[])selectedCategory[i];
            if (product[2].Equals(sellModel, StringComparison.OrdinalIgnoreCase))
            {
                productIndex = i;
                break;
            }
        }

        if (productIndex != -1)
        {
            string[] product = (string[])selectedCategory[productIndex];
            Console.Write($"Enter the quantity to sell (Available: {product[4]}): ");
            int quantityToSell = int.Parse(Console.ReadLine());

            int availableQuantity = int.Parse(product[4]);

            if (quantityToSell <= availableQuantity)
            {
                product[4] = (availableQuantity - quantityToSell).ToString();
                Console.WriteLine("Product sold successfully!");
            }
            else
            {
                Console.WriteLine("Insufficient stock.");
            }
        }
        else
        {
            Console.WriteLine("Model not found in the selected category.");
        }

        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
        goto Menu;
        break;
}