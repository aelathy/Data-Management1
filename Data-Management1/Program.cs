// Data Management Project
#nullable disable
using static System.IComparable;
Console.Clear();

// List<User> users = new List<User>();
// users.Add(new User(---------, —-------));

List<User> users = new List<User>();
users.Add(new User("aly", "hi"));
List<Product> products = new List<Product>();
products.Add(new Product("Laptop", "Acer", 800));
products.Add(new Product("Phone", "Samsung", 1000));
products.Add(new Product("Phone", "Apple", 1000));
products.Add(new Product("Monitor", "Asus", 300));


bool loop = true;
while (loop)
{
    // Console.WriteLine("Please log in with your password and username");
    // Console.Write("Username: ");
    // string name = Console.ReadLine();
    // Console.Write("Password");
    // string password = Console.ReadLine();
    // if (name & password equal a user.Username & user.Password) {
    //  In
    // } else {
    //  Not In
    // }
    // Main Menu Loop
    Console.WriteLine("\n Main Menu");
    Console.WriteLine("1. Display All Products");
    Console.WriteLine("2. Look for Product");
    Console.WriteLine("3. Sort & Show Lowest to Highest");
    Console.WriteLine("4. Add Product to Shopping Cart");
    Console.WriteLine("5. Remove Product from Shopping Cart");
    Console.WriteLine("6. Display Shopping Cart");
    Console.WriteLine("7. Exit");
    string menuOption = Console.ReadLine().ToLower();
    Console.WriteLine();

    int selectionSort(List<int> aList)
    {
        for (int i = 0; i < aList.Count - 1; i++)
        {
            int min_pos = i;
            for (int j = i + 1; j < aList.Count; j++)
            {
                if (aList[min_pos] > aList[j])
                {
                    min_pos = j;
                }
            }
            int el = aList[min_pos];
            aList[min_pos] = aList[i];
            aList[i] = el;
        }
        return -1;
    }

    if (menuOption == "1")
    {
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{products[i].Type} {products[i].Brand} ${products[i].Price}");
        }
    }
    else if (menuOption == "2")
    {
        // Implement Search Program
        Console.Write("Search by Brand: ");
        string brandSearch = Console.ReadLine();
        // First letters of the product brand match the letters type (left to right)
        for (int i = 0; i < products.Count; i++)
        {
            if (brandSearch == products[i].Brand)
            {
                Console.WriteLine($"{products[i].Type} {products[i].Brand} ${products[i].Price}");
            }
        }
    }
    else if (menuOption == "3")
    {
        // Do Some Type of Sort to Organize Products by Lowest to Highest Price
    }
    else if (menuOption == "4")
    {
        // Add Product to Shopping List
        Console.WriteLine("Enter the type & brand of the product you want to ADD:");
        Console.Write("Type: ");
        string addType = Console.ReadLine();
        Console.Write("Brand: ");
        string addBrand = Console.ReadLine();
        for (int i = 0; i < products.Count; i++)
        {
            if (addType == products[i].Type && addBrand == products[i].Brand)
            {
            }
        }
    }
    else if (menuOption == "5")
    {
        // Remove Product from Shopping List
        Console.WriteLine("Enter the type & brand of the product you want to REMOVE:");
        Console.Write("Type: ");
        string addType = Console.ReadLine();
        Console.Write("Brand: ");
        string addBrand = Console.ReadLine();
        for (int i = 0; i < products.Count; i++)
        {
            if (addType == products[i].Type && addBrand == products[i].Brand)
            {
            }
        }
    }
    else if (menuOption == "6")
    {
        // Display Shopping Cart
    }
    else if (menuOption == "7")
    {
        break;
    }
}


class Product
{
    public string Type { get; set; }
    public string Brand { get; set; }
    public int Price { get; set; }

    public Product(string type, string brand, int price)
    {
        this.Type = type;
        this.Brand = brand;
        this.Price = price;
    }
}

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public List<Product> ShopItem { get; set; }

    public User(string username, string password)
    {
        this.Username = username;
        this.Password = password;
        this.ShopItem = new List<Product>();
    }
}